using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DBManagement;
using AppCommon.Util;
using AppCommon.Constant;

namespace AppCommon.Travel.SaleTicket
{
    public partial class SeatMap : UserControl
    {
        private TableLayoutPanel _panelLayout;

        private int MAX_COLUMNS_COUNT = 5;
        private int MAX_ROWS_COUNT = 6;
        private int MAX_NORMAL_SEAT_COUNT = 20;
        private int MAX_FLOOR_SEAT_COUNT = 10;

        private Color EMPTY_SEAT_COLOR = Color.LightGray;
        private Color SELECTED_SEAT_COLOR = Color.Aqua;
        private Color OWN_SEAT_COLOR = Color.GreenYellow;
        private Color FORBID_SEAT_COLOR = Color.Red;

        private List<Button> _seatMap;
        private Constants.SeatClass _seatClass;

        public SeatMap()
        {
            InitializeComponent();
        }

        protected void InitLayoutContainer()
        {
            _panelLayout = new TableLayoutPanel();
            _seatMap = new List<Button>();
            this.Controls.Clear();

            // Columns
            _panelLayout.ColumnCount = MAX_COLUMNS_COUNT;
            for (int i = 0; i < MAX_COLUMNS_COUNT; i++)
            {
                _panelLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            }

            // Rows
            _panelLayout.RowCount = MAX_ROWS_COUNT;
            for (int i = 0; i < MAX_ROWS_COUNT; i++)
            {
                _panelLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            }

            _panelLayout.Dock = DockStyle.Fill;

            this.Controls.Add(_panelLayout);
        }

        public void InitSeatMap(Constants.SeatClass seatClass)
        {
            InitLayoutContainer();

            _seatMap = new List<Button>();
            _seatClass = seatClass;

            bool isSeat = false;
            int seatIndex = 1;
            int gridIndex = 0;
            int maxSeat = seatClass == Constants.SeatClass.S ? MAX_FLOOR_SEAT_COUNT : MAX_NORMAL_SEAT_COUNT;
            for (int rowIndex = 0; rowIndex < MAX_ROWS_COUNT; rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < MAX_COLUMNS_COUNT; columnIndex++)
                {
                    isSeat = seatClass != Constants.SeatClass.S
                        ? (gridIndex + rowIndex % 2) % 2 == 0 || seatIndex > maxSeat - 5
                        : (gridIndex + rowIndex % 2) % 2 == 1;

                    int tempColumnIndex = columnIndex;
                    if (rowIndex % 2 != 0)
                    {
                        tempColumnIndex = MAX_COLUMNS_COUNT - columnIndex - 1;
                    }

                    if (isSeat == false)
                    {
                        gridIndex++;
                        continue;
                    }

                    Button seat = new Button();
                    seat.BackColor = EMPTY_SEAT_COLOR;
                    seat.Dock = DockStyle.Fill;
                    seat.Text = seatClass.ToString() + seatIndex.ToString();
                    seat.Name = seatIndex.ToString();
                    seat.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    seat.Click += new EventHandler(btnSeat_Click);

                    _seatMap.Add(seat);
                    _panelLayout.Controls.Add(seat, tempColumnIndex, rowIndex);

                    seatIndex++;
                    gridIndex++;
                }

            }
        }

        public string LoadTicket(List<Ticket> tickets)
        {
            StringBuilder errorMessage = new StringBuilder();

            foreach (Ticket ticket in tickets)
            {
                errorMessage.Append(SetSeatBusy(ticket));
            }

            return errorMessage.ToString();
        }

        public string SetSeatBusy(Ticket ticket)
        {
            Button seat = _seatMap.SingleOrDefault(i => i.Name == ticket.seat_number.ToString());
            if (seat == null)
            {
                return "Không tồn tại số ghế này - SeatNumber:" + ticket.seat_number;
            }

            seat.BackColor = SystemParam.CurrentUser.id.Equals(ticket.user_id)
                || SystemParam.CurrentUser.role.Equals(Constants.UserRole.Supervisor.ToString())
                || SystemParam.CurrentUser.role.Equals(Constants.UserRole.Owner.ToString())
                ? OWN_SEAT_COLOR : FORBID_SEAT_COLOR;
            seat.Tag = ticket;

            return string.Empty;
        }

        public void SetEmpty(int seatNumber)
        {
            Button seat = _seatMap.SingleOrDefault(i => i.Name == seatNumber.ToString());
            seat.BackColor = EMPTY_SEAT_COLOR;
            seat.Tag = null;
        }

        public void SetSelected(int seatNumber)
        {
            Button seat = _seatMap.SingleOrDefault(i => i.Name == seatNumber.ToString());
            seat.BackColor = SELECTED_SEAT_COLOR;
            seat.Tag = null;
        }

        private void btnSeat_Click(object sender, EventArgs e)
        {
            try
            {
                Ticket ticket = ((Button)sender).Tag != null ? ((Button)sender).Tag as Ticket : null;

                LoadSeatInfo(((Button)sender).Name,_seatClass, ticket);
            }
            catch (Exception exc)
            {
                AppLogger.logError("btnSeat_Click", exc);
            }
        }


        #region delegate
        public delegate void LoadSeatInfoDelegate(string seatNumber, Constants.SeatClass seatClass, Ticket ticket);
        public LoadSeatInfoDelegate LoadSeatInfo;
        #endregion
    }
}
