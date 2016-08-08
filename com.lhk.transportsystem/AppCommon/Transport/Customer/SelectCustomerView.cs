using System;
using System.Collections.ObjectModel;
using System.Windows.Forms;
using AppCommon.Business;
using DBManagement;

namespace AppCommon.Transport.TransportCustomer
{
    public partial class SelectCustomerView : Form
    {
        #region Variables
        private CustomerBusiness _business = null;
        #endregion

        #region Properties
        private string SearchCriteria
        {
            get
            {
                // Gets search criteria and generates filter query
                Collection<string> criteriaList = new Collection<string>();
                if (!string.IsNullOrWhiteSpace(tbName.Text))
                {
                    criteriaList.Add(string.Format(@"(it.name LIKE '%{0}%')", tbName.Text));
                }
                if (!string.IsNullOrWhiteSpace(tbPhoneNumber.Text))
                {
                    criteriaList.Add(string.Format(@"(it.mobile LIKE '%{0}%')", tbName.Text));
                }
                if (!string.IsNullOrWhiteSpace(tbIDCardNumber.Text))
                {
                    criteriaList.Add(string.Format(@"(it.id_card_number LIKE '%{0}%')", tbName.Text));
                }
                return string.Join(" AND ", criteriaList);
            }
        }

        private string SelectedCustomerID
        {
            get
            {
                return dgvCustomersList.CurrentRow != null ? dgvCustomersList.CurrentRow.Cells["IDColumn"].Value.ToString() : string.Empty;
            }
        }

        public Customer ReturnValue { get; set; }
        #endregion

        #region Constructors
        public SelectCustomerView()
        {
            InitializeComponent();
            dgvCustomersList.AutoGenerateColumns = false;
            _business = new CustomerBusiness();
        }
        #endregion

        #region Event Handlers
        private void btnSearch_Click(object sender, EventArgs e)
        {
            var customers = _business.Search(SearchCriteria);
            dgvCustomersList.DataSource = customers;
            dgvCustomersList.ClearSelection();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var customer = _business.Get(SelectedCustomerID);
            if (customer != null)
            {
                this.ReturnValue = customer;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Không tìm được thông tin khách hàng.", "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
