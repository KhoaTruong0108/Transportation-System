using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DBManagement;
using AppCommon.Util;

namespace AppCommon.Entity
{
    public class TicketReportEntity
    {
        private string _seatClass;

        public string SeatClass
        {
            get { return _seatClass; }
            set { _seatClass = value; }
        }
        private string _seatNumber;

        public string SeatNumber
        {
            get { return _seatNumber; }
            set { _seatNumber = value; }
        }
        private string _passengerName;

        public string PassengerName
        {
            get { return _passengerName; }
            set { _passengerName = value; }
        }
        private string _passengerIdNo;

        public string PassengerIdNo
        {
            get { return _passengerIdNo; }
            set { _passengerIdNo = value; }
        }
        private string _phone;

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        private string _busName;

        public string BusName
        {
            get { return _busName; }
            set { _busName = value; }
        }
        private string _tourName;

        public string TourName
        {
            get { return _tourName; }
            set { _tourName = value; }
        }
        private string _departTime;

        public string DepartTime
        {
            get { return _departTime; }
            set { _departTime = value; }
        }

        private string _costString;
        public string CostString
        {
            get { return _costString; }
            set { _costString = value; }
        }

        private decimal _cost;

        public decimal Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }

        public static List<TicketReportEntity> ConvertFromReportEntityList(IEnumerable<Ticket> tickets, Bus bus, Tour tour)
        {
            return (from t in tickets select ConvertFromReportEntity(t,bus,tour)).ToList();
        }

        public static TicketReportEntity ConvertFromReportEntity(Ticket tickets, Bus bus, Tour tour)
        {
            return new TicketReportEntity()
                   {
                       BusName = bus.name,
                       DepartTime = tickets.departure_time.ToString("dd-MM-yyyy"),
                       PassengerIdNo = tickets.passenger_id_card_no,
                       PassengerName = tickets.passenger_name,
                       Phone = tickets.phone,
                       SeatClass = tickets.seat_class,
                       SeatNumber = tickets.seat_number.ToString(),
                       Cost = tickets.cost,
                       CostString = CurrencyUtil.ToString(tickets.cost),
                       TourName = string.Format("{0} -> {1}", tour.start, tour.destination)
                   };
        }
    }
}
