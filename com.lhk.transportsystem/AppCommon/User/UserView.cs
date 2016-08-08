using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using AppCommon.Business;
using AppCommon.CommonView;
using AppCommon.Constant;
using AppCommon.Util;
using DBManagement;
using Utility.Password;

namespace AppCommon.UserManagement
{
    public partial class UserView : GenericView
    {
        #region Variables
        private UserBusiness _business;
        #endregion

        #region Properties
        private string SelectedUserID
        {
            get
            {
                return dgvUsersList.SelectedRows.Count > 0 ? dgvUsersList.SelectedRows[0].Cells["IDColumn"].Value.ToString() : string.Empty;
            }
        }
        #endregion

        #region Constructors
        public UserView()
        {
            InitializeComponent();
            dgvUsersList.AutoGenerateColumns = false;
            InitializeData();
        }
        #endregion

        #region Private Methods
        private void InitializeData()
        {
            _business = new UserBusiness(SystemParam.CurrentUser);

            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            var roles = typeof(Constant.Constants.UserRole).ToList<string>();
            cboRole.DisplayMember = "Value";
            cboRole.ValueMember = "Key";
            cboRole.DataSource = roles;

            DataBind();
        }

        private void DataBind()
        {
            BindingSource bindingSource = new BindingSource();
            List<User> users = _business.GetAll();
            BindingList<User> bindingList = new BindingList<User>(users);
            bindingSource.DataSource = bindingList;
            dgvUsersList.DataSource = bindingSource;
            dgvUsersList.ClearSelection();
            ClearUserInfo();
        }

        private bool ValidateInput(bool isUpdating)
        {
            bool result = true;
            if (string.IsNullOrEmpty(tbUserName.Text))
            {
                MessageBox.Show("Tên người dùng không được trống.", "Tên người dùng trống", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                result = false;
            }
            else if (tbUserName.Text.Length < 3)
            {
                MessageBox.Show("Tên người dùng phải dài ít nhất 3 kí tự.", "Tên người dùng quá ngắn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                result = false;
            }
            else if (!Regex.IsMatch(tbUserName.Text, @"[a-zA-Z0-9]"))
            {
                MessageBox.Show("Tên người dùng chứa ký tự không hợp lệ.\nKý tự được cho phép: a - z, A - Z, 0 - 9.", "Tên người dùng không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                result = false;
            }
            else if (tbUserName.Text.Equals("SYSTEM", StringComparison.InvariantCultureIgnoreCase))
            {
                MessageBox.Show("Vui lòng chọn tên khác.", "Tên người dùng không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                result = false;
            }
            else if (isUpdating && string.IsNullOrEmpty(tbCurrentPassword.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu hiện tại để tiếp tục.", "Mật khẩu trống", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                result = false;
            }
            else if (!isUpdating && string.IsNullOrEmpty(tbNewPassword.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu.", "Mật khẩu trống", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                result = false;
            }
            else if (!tbNewPassword.Text.Equals(tbConfirmPassword.Text))
            {
                MessageBox.Show("Mật khẩu không trùng khớp.", "Sai mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                result = false;
            }
            else if (!string.IsNullOrEmpty(tbNewPassword.Text) && tbNewPassword.Text.Length < 3)
            {
                MessageBox.Show("Mật khẩu phải dài tối thiểu 3 ký tự.", "Mật khẩu quá ngắn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                result = false;
            }
            return result;
        }

        private User GetUserInfo(bool isUpdating)
        {
            User user;
            if (isUpdating)
            {
                user = _business.Get(SelectedUserID);
            }
            else
            {
                user = new User();
                user.id = IDGenerator.NewId<User>(true);
                user.user_name = tbUserName.Text.ToLowerInvariant();
                user.created_date = DateTime.Now;
                user.created_by = SystemParam.CurrentUser.id;
                user.deleted = false;
            }
            var password = string.IsNullOrEmpty(tbNewPassword.Text) ? tbCurrentPassword.Text : tbNewPassword.Text;
            password = PasswordServiceProvider.Encrypt(user.user_name, password);
            user.password = password;
            user.role = cboRole.SelectedValue.ToString();
            user.staff_id = tbStaffID.Text;
            user.active_status = chkActive.Checked;
            return user;
        }

        private void LoadUserInfo(User user)
        {
            tbConfirmPassword.Clear();
            if (user != null)
            {
                tbUserName.Text = user.user_name;
                cboRole.SelectedValue = user.role;
                tbStaffID.Text = user.staff_id;
                chkActive.Checked = user.active_status;
            }
        }

        private void ClearUserInfo()
        {
            tbUserName.Text = string.Empty;
            cboRole.Text = string.Empty;
            tbStaffID.Text = string.Empty;
            chkActive.Checked = false;
            tbCurrentPassword.Text = string.Empty;
            tbNewPassword.Text = string.Empty;
            tbConfirmPassword.Text = string.Empty;
        }
        #endregion

        #region Event Handlers
        private void OnEnter(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateInput(false))
            {
                User user = GetUserInfo(false);
                string result = _business.Insert(user);
                if (string.IsNullOrEmpty(result))
                {
                    DataBind();
                }
                else
                {
                    MessageBox.Show(result, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateInput(true))
            {
                User newUserInfo = GetUserInfo(true);
                User oldUserInfo = _business.Get(newUserInfo.id);
                if (oldUserInfo.user_name.Equals(newUserInfo.user_name, StringComparison.InvariantCultureIgnoreCase))
                {
                    if (PasswordServiceProvider.Match(oldUserInfo.user_name, tbCurrentPassword.Text, oldUserInfo.password))
                    {
                        string result = _business.Update(newUserInfo);
                        if (string.IsNullOrEmpty(result))
                        {
                            DataBind();
                        }
                        else
                        {
                            MessageBox.Show(result, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu không chính xác, vui lòng thử lại.", "Sai mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Tên người dùng không được phép thay đổi.", "Không thể cập nhật tên người dùng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Xóa người dùng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == System.Windows.Forms.DialogResult.Yes)
            {
                string result = _business.Delete(SelectedUserID);
                if (string.IsNullOrEmpty(result))
                {
                    DataBind();
                }
                else
                {
                    MessageBox.Show(result, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataBind();
        }

        private void dgvUsersList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                Constants.UserRole role;
                if (Enum.TryParse(e.Value.ToString(), out role))
                {
                    e.Value = role.GetDescription();
                }
            }
            if (e.ColumnIndex == 6)
            {
                e.Value = bool.Parse(e.Value.ToString()) ? "Đang hoạt động" : "Ngưng hoạt động";
            }
        }

        private void dgvUsersList_SelectionChanged(object sender, EventArgs e)
        {
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            User user = _business.Get(SelectedUserID);
            LoadUserInfo(user);
        }
        #endregion
    }
}
