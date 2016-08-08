using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using AppCommon.CommonBusiness;
using AppCommon.CommonRepository;
using AppCommon.Constant;
using AppCommon.Util;
using DBManagement;

namespace AppCommon.Business
{
    public class TicketBusiness : GenericBusiness<Ticket>
    {
        private GenericRepository<TicketHistory> _ticketHistoryRepository;

        public TicketBusiness(User currentUser = null)
            : base(currentUser)
        {
            UseAuditTrail = true;
        }

        public IEnumerable<Ticket> GetAll(string busId, string tourId, Constants.TicketStatus status, DateTime departureTime)
        {
            IEnumerable<Ticket> tickets = new Collection<Ticket>();
            try
            {
                var ticketStatus = status.ToString();
                AppLogger.logInfo(this.ToString(), string.Format("Condition: [bus_id = {0}, tour_id = {1}, status = {2}, departure_time = {3}.", busId, tourId, ticketStatus, departureTime));
                tickets = Repository.EntitiesSet.Where(t => t.bus_id.Equals(busId) &&
                                                            t.tour_id.Equals(tourId) &&
                                                            t.status.Equals(ticketStatus) &&
                                                            t.departure_time.Year == departureTime.Year &&
                                                            t.departure_time.Month == departureTime.Month &&
                                                            t.departure_time.Day == departureTime.Day).OrderBy(i => i.seat_class).ThenBy(i => i.seat_number);
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), ex);
            }
            return tickets;
        }

        public IEnumerable<Ticket> GetAll(string busId, string tourId, string seatClass, DateTime departureTime)
        {
            IEnumerable<Ticket> tickets = new Collection<Ticket>();
            try
            {
                var status = Constants.TicketStatus.Cancel.ToString();
                AppLogger.logInfo(this.ToString(), string.Format("Condition: [bus_id = {0}, tour_id = {1}, seat_class = {2}, departure_time = {3}.", busId, tourId, seatClass, departureTime));
                tickets = Repository.EntitiesSet.Where(t => t.bus_id.Equals(busId) &&
                                                            t.tour_id.Equals(tourId) &&
                                                            t.seat_class.Equals(seatClass) &&
                                                            t.departure_time.Year == departureTime.Year &&
                                                            t.departure_time.Month == departureTime.Month &&
                                                            t.departure_time.Day == departureTime.Day &&
                                                            !t.status.Equals(status));
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), ex);
            }
            return tickets;
        }

        public override string Insert(Ticket ticket)
        {
            string result = string.Empty;
            try
            {
                var status = Constants.TicketStatus.Cancel.ToString();
                var bookedTicket = Repository.EntitiesSet.FirstOrDefault(t => t.tour_id.Equals(ticket.tour_id) &&
                                                                              t.bus_id.Equals(ticket.bus_id) &&
                                                                              t.seat_class.Equals(ticket.seat_class) &&
                                                                              t.seat_number.Equals(ticket.seat_number) &&
                                                                              t.departure_time == ticket.departure_time &&
                                                                              !t.status.Equals(status));
                if (bookedTicket == null)
                { 
                    Repository.Insert(ticket);
                    if (UseAuditTrail)
                    {
                        LogAuditTrail(ticket, Constants.INSERT_ACTION);
                    }
                    Repository.Commit();
                }
                else
                {
                    result = Constants.Messages.MSG_TICKET_SEAT_NOT_AVAILABLE;
                }
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), ex);
                Repository.Rollback();
                result = Constants.Messages.ERROR_OPERATION_NOT_PERFORMED;
            }
            return result;
        }

        public override string Update(Ticket ticket)
        {
            string result = string.Empty;
            try
            {
                var status = Constants.TicketStatus.Cancel.ToString();
                var bookedTicket = Repository.EntitiesSet.FirstOrDefault(t => !t.id.Equals(ticket.id) &&
                                                                              t.tour_id.Equals(ticket.tour_id) &&
                                                                              t.bus_id.Equals(ticket.bus_id) &&
                                                                              t.seat_class.Equals(ticket.seat_class) &&
                                                                              t.seat_number.Equals(ticket.seat_number) &&
                                                                              t.departure_time == ticket.departure_time &&
                                                                              !t.status.Equals(status));
                if (bookedTicket == null)
                {
                    Repository.Update(ticket);
                    if (UseAuditTrail)
                    {
                        LogAuditTrail(ticket, Constants.UPDATE_ACTION);
                    }
                    Repository.Commit();
                }
                else
                {
                    result = Constants.Messages.MSG_TICKET_SEAT_NOT_AVAILABLE;
                }
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), ex);
                Repository.Rollback();
                result = Constants.Messages.ERROR_OPERATION_NOT_PERFORMED;
            }
            return result;
        }

        public virtual string Cancel(Ticket ticket, decimal returnFee)
        {
            string result = string.Empty;
            try
            {
                ticket.cost = returnFee;
                ticket.status = Constants.TicketStatus.Cancel.ToString();
                result = Update(ticket);
                AppLogger.logInfo(this.ToString(), "Ticket canceled successfully.");
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), ex);
                result = Constants.Messages.ERROR_OPERATION_NOT_PERFORMED;
            }
            return result;
        }

        protected override void LogAuditTrail(Ticket ticket, string action)
        {
            if (CurrentUser != null)
            {
                action = action.ToUpperInvariant();
                if (_ticketHistoryRepository == null)
                {
                    _ticketHistoryRepository = new GenericRepository<TicketHistory>(Repository.Context);
                }

                // Logs audit trail
                var ticketHistory = new TicketHistory();
                ticketHistory.action = action;
                ticketHistory.changed_by = CurrentUser.id; // This should be the logged-in user in the system, not the ticket creator.
                ticketHistory.id = IDGenerator.TicketHistoryId();
                ticketHistory.ticket_id = ticket.id;
                ticketHistory.changed_date = DateTime.Now;
                _ticketHistoryRepository.Insert(ticketHistory);
            }
        }

        public DateTime GetDepartureDateTime(DateTime departureDate)
        {
            int departureHour;
            int departureMinute;
            if (int.TryParse(ConfigurationUtil.GetConfig(Constants.FIELD_CONFIGURATION_DEPARTURE_HOUR), out departureHour) == false)
            {
                departureHour = Constants.DEFAULT_VALUE_DEPARTURE_HOUR;
            }
            if (int.TryParse(ConfigurationUtil.GetConfig(Constants.FIELD_CONFIGURATION_DEPARTURE_MINUTE), out departureMinute) == false)
            {
                departureMinute = Constants.DEFAULT_VALUE_DEPARTURE_MINUTE;
            }
            return new DateTime(departureDate.Year, departureDate.Month, departureDate.Day, departureHour, departureMinute, 0); ;
        }

        public string CompleteTicket(string id)
        {
            string result = string.Empty;
            var ticket = this.Get(id);
            ticket.status = Constants.TicketStatus.Closed.ToString();

            return base.Update(ticket);
        }
    }
}
