using System;
using System.Windows.Forms;
using AppCommon.Util;

namespace AppCommon.CommonView
{
    public partial class GenericDialog : Form
    {
        protected bool _isUpdating = false;

        protected bool IsUpdating
        {
            get { return _isUpdating; }
            set { _isUpdating = value; }
        }

        public GenericDialog()
        {
            InitializeComponent();
        }

        protected virtual void btnAddNew_Click(object sender, EventArgs e)
        {
            _isUpdating = false;
            ClearAll();
            ChangeViewStatus(true);
        }

        protected virtual void btnCancel_Click(object sender, EventArgs e)
        {
            ChangeViewStatus(false);
            ClearAll();
        }

        protected virtual void btnDelete_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected virtual void btnUpdate_Click(object sender, EventArgs e)
        {
            _isUpdating = true;
            ChangeViewStatus(true);
        }

        protected virtual void btnSave_Click(object sender, EventArgs e)
        {

        }

        protected virtual void ClearAll()
        {

        }

        protected virtual void ChangeViewStatus(bool isEditing)
        {
            btnCancel.Visible = isEditing;
            btnSave.Visible = isEditing;
            btnAddNew.Visible = !isEditing;
            btnDelete.Visible = !isEditing;
            btnUpdate.Visible = !isEditing;
        }

        protected virtual void SetControlError(Control control, string error)
        {
            this.errorProvider.SetIconAlignment(control, ErrorIconAlignment.MiddleRight);
            this.errorProvider.SetIconPadding(control, 2);
            this.errorProvider.SetError(control, error);
        }

        protected virtual void ClearControlError(Control control)
        {
            this.errorProvider.SetError(control, string.Empty);
        }

        protected virtual void NumberOnlyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        protected virtual void FloatNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar.Equals('.'))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        protected virtual void CurrencyTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox currencyTextBox = (TextBox)sender;
            decimal value = 0;
            int pos = 0;

            if (string.IsNullOrWhiteSpace(currencyTextBox.Text))
            {
                currencyTextBox.Text = "0";
            }
            else if (decimal.TryParse(currencyTextBox.Text, out value))
            {
                pos = currencyTextBox.SelectionStart;
                currencyTextBox.Text = CurrencyUtil.ToString(value);
                currencyTextBox.SelectionStart = pos;
            }
            else
            {
                SetControlError(currencyTextBox, "Giá trị không hợp lệ");
            }
        }

        protected virtual void OnEnter(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                ((TextBox)sender).SelectAll();
            }
        }
    }
}
