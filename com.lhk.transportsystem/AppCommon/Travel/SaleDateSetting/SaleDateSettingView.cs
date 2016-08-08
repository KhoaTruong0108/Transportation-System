using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using AppCommon.Business;
using AppCommon.CommonView;
using AppCommon.Constant;
using AppCommon.Util;
using DBManagement;

namespace AppCommon.Travel.SaleDateSetting
{
    public partial class SaleDateSettingView : GenericDialog
    {
        #region Constant
        private string DATE_INVALID_MSG = "Ngày tháng không hợp lệ";
        private string MISSING_BEFORE_DATE = "Nhập ngày cho đặt vé trước";
        private string BEFORE_DATE_NUMBER_ERROR = "Ngày cho đặt vé trước phải là số";

        private string Id_Column = "colId";
        private string Ticket_Sale_Day_Column = "ticket_sale_day";
        private string Ticket_Sale_Month_Column = "ticket_sale_month";
        private string Ticket_Sale_Year_Column = "ticket_sale_year";
        private string Before_Days_Column = "before_days";

        private string Id_Column_Header = "Mã Số";
        private string Ticket_Sale_Day_Column_Header = "Ngày";
        private string Ticket_Sale_Month_Column_Header = "Tháng";
        private string Ticket_Sale_Year_Column_Header = "Năm";
        private string Before_Days_Column_Header = "Trước ngày";
        #endregion

        #region Variables
        protected TicketSaleDateBusiness _business = new TicketSaleDateBusiness();
        #endregion

        #region Constructor
        public SaleDateSettingView()
        {
            InitializeComponent();
            BindValueToDate();
            InitializeData();
        }
        #endregion

        #region Methods
        private void InitializeData()
        {
            _business = new TicketSaleDateBusiness();

            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            dgvItemsList.SelectionChanged += new EventHandler(dgvItemsList_SelectionChanged);
            DataBind();
        }
        private void DataBind()
        {
            dgvItemsList.DataSource = _business.GetAll().ToList();
            //ChangeColumnHeader();
            ChangeViewStatus(false);
        }
        private void ChangeColumnHeader()
        {
            if (dgvItemsList.Columns.Count > 0)
            {
                if (dgvItemsList.Columns.Contains(Id_Column))
                {
                    dgvItemsList.Columns[Id_Column].HeaderText = Id_Column_Header;
                }
                if (dgvItemsList.Columns.Contains(Ticket_Sale_Day_Column))
                {
                    dgvItemsList.Columns[Ticket_Sale_Day_Column].HeaderText = Ticket_Sale_Day_Column_Header;
                }
                if (dgvItemsList.Columns.Contains(Ticket_Sale_Month_Column))
                {
                    dgvItemsList.Columns[Ticket_Sale_Month_Column].HeaderText = Ticket_Sale_Month_Column_Header;
                }
                if (dgvItemsList.Columns.Contains(Ticket_Sale_Year_Column))
                {
                    dgvItemsList.Columns[Ticket_Sale_Year_Column].HeaderText = Ticket_Sale_Year_Column_Header;
                }
                if (dgvItemsList.Columns.Contains(Before_Days_Column))
                {
                    dgvItemsList.Columns[Before_Days_Column].HeaderText = Before_Days_Column_Header;
                }
            }
        }
        private void BindValueToDate()
        {
            var listDay = new List<string>();
            listDay.Add(string.Empty);
            for (int d = 1; d <= 31; d++)
            {
                listDay.Add(d.ToString(CultureInfo.InvariantCulture));
            }
            cbSaleDay.DataSource = listDay;

            var listMonth = new List<string>();
            listMonth.Add(string.Empty);
            for (int m = 1; m <= 12; m++)
            {
                listMonth.Add(m.ToString(CultureInfo.InvariantCulture));
            }
            cbSaleMonth.DataSource = listMonth;

            var listYear = new List<string>();
            listYear.Add(string.Empty);
            for (int y = DateTime.Now.Year; y <= DateTime.Now.Year + 10; y++)
            {
                listYear.Add(y.ToString(CultureInfo.InvariantCulture));
            }
            cbSaleYear.DataSource = listYear;
        }

        private string ValidateInput()
        {
            string errorMsg = string.Empty;
            if (string.IsNullOrEmpty(tbBeforeDay.Text))
            {
                errorMsg = MISSING_BEFORE_DATE;
            }
            else if (!IsNumber(tbBeforeDay.Text))
            {
                errorMsg = BEFORE_DATE_NUMBER_ERROR;
            }
            else if (!string.IsNullOrEmpty(cbSaleDay.SelectedValue.ToString())
                    && !string.IsNullOrEmpty(cbSaleMonth.SelectedValue.ToString())
                    && !string.IsNullOrEmpty(cbSaleYear.SelectedValue.ToString()))
            {
                DateTime date;
                string datetime = cbSaleDay.SelectedValue.ToString() + "/"
                                 + cbSaleMonth.SelectedValue.ToString() + "/"
                                 + cbSaleYear.SelectedValue.ToString();
                if (DateTime.TryParse(datetime, out date) == false)
                {
                    errorMsg = DATE_INVALID_MSG;
                }
            }
            else if (!string.IsNullOrEmpty(cbSaleDay.SelectedValue.ToString())
                    && !string.IsNullOrEmpty(cbSaleMonth.SelectedValue.ToString()))
            {
                DateTime date;
                string datetime = DateTime.Now.Year + "/"
                                 + cbSaleMonth.SelectedValue.ToString() + "/"
                                 + cbSaleDay.SelectedValue.ToString();
                if (DateTime.TryParse(datetime, out date) == false)
                {
                    errorMsg = DATE_INVALID_MSG;
                }
            }

            return errorMsg;
        }
        private TicketSaleDate CreateNewTicketSaleDate()
        {
            var date = CreateTicketSaleDateWithoutId();
            date.id = IDGenerator.SaleTicketDateId();

            return date;
        }

        private TicketSaleDate CreateUpdateTicketSaleDate()
        {
            var date = CreateTicketSaleDateWithoutId();
            date.id = tbSaleDateId.Text;

            return date;
        }

        private TicketSaleDate CreateTicketSaleDateWithoutId()
        {
            var date = new TicketSaleDate();
            date.before_days = int.Parse(tbBeforeDay.Text);

            if (!string.IsNullOrEmpty(cbSaleDay.SelectedValue.ToString()))
            {
                date.ticket_sale_day = int.Parse(cbSaleDay.SelectedValue.ToString());
            }
            if (!string.IsNullOrEmpty(cbSaleMonth.SelectedValue.ToString()))
            {
                date.ticket_sale_month = int.Parse(cbSaleMonth.SelectedValue.ToString());
            }
            if (!string.IsNullOrEmpty(cbSaleYear.SelectedValue.ToString()))
            {
                date.ticket_sale_year = int.Parse(cbSaleYear.SelectedValue.ToString());
            }
            return date;
        }
        private bool IsNumber(string number)
        {
            int value;
            return int.TryParse(number, out value);
        }
        #endregion

        #region Event Handler
        void dgvItemsList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvItemsList.SelectedRows.Count > 0 && dgvItemsList.Columns.Count > 1)
            {
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;

                var ticketSaleDate = dgvItemsList.SelectedRows[0].DataBoundItem as TicketSaleDate;

                tbSaleDateId.Text = ticketSaleDate.id;
                tbBeforeDay.Text = ticketSaleDate.before_days.ToString();
                cbSaleDay.SelectedItem = ticketSaleDate.ticket_sale_day > 0 ? ticketSaleDate.ticket_sale_day.ToString() : string.Empty;
                cbSaleMonth.SelectedItem = ticketSaleDate.ticket_sale_month > 0 ? ticketSaleDate.ticket_sale_month.ToString() : string.Empty;
                cbSaleYear.SelectedItem = ticketSaleDate.ticket_sale_year > 0 ? ticketSaleDate.ticket_sale_year.ToString() : string.Empty;
            }
            else
            {
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
        }
        #endregion

        #region Override Methods
        protected override void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvItemsList.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Bạn có chắc rằng muốn xóa thiết lập này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                {
                    var id = dgvItemsList.SelectedRows[0].Cells[Id_Column].Value.ToString();
                    string result = _business.Delete(id);
                    if (string.IsNullOrEmpty(result))
                    {
                        ClearAll();
                        DataBind();
                    }
                    else
                    {
                        MessageBox.Show(result, Constants.Messages.ERROR_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        protected override void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ValidateInput()))
            {
                string result = string.Empty;

                if (_isUpdating)
                {
                    var date = CreateUpdateTicketSaleDate();
                    result = _business.Update(date);
                }
                else
                {
                    var date = CreateNewTicketSaleDate();
                    result = _business.Insert(date);
                }
                if (string.IsNullOrEmpty(result))
                {
                    ChangeViewStatus(false);
                    DataBind();
                }
                else
                {
                    MessageBox.Show(result, Constants.Messages.ERROR_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(ValidateInput(), Constants.Messages.ERROR_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void btnCancel_Click(object sender, EventArgs e)
        {
            base.btnCancel_Click(sender, e);
        }

        protected override void ClearAll()
        {
            tbSaleDateId.Text = string.Empty;
            tbBeforeDay.Text = string.Empty;
            cbSaleDay.SelectedIndex = 0;
            cbSaleMonth.SelectedIndex = 0;
            cbSaleYear.SelectedIndex = 0;
        }

        protected override void ChangeViewStatus(bool isEditing)
        {
            base.ChangeViewStatus(isEditing);
            tbBeforeDay.Enabled = isEditing;
            cbSaleYear.Enabled = isEditing;
            cbSaleMonth.Enabled = isEditing;
            cbSaleDay.Enabled = isEditing;
            dgvItemsList.Enabled = !isEditing;
        }
        #endregion
    }
}
