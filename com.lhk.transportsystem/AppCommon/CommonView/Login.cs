using System;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Forms;
using AppCommon.Business;
using AppCommon.Constant;
using AppCommon.Util;
using DBManagement;

namespace AppCommon.CommonView
{
    public partial class Login : Form
    {
        public delegate void LoginSucessCallBack();
        public LoginSucessCallBack _loginCallBack;

        private string _currentRole;
        #region Constructors
        public Login()
        {
            InitializeComponent();
            lblErrorMessage.Text = string.Empty;
        }

        public Login(Constants.UserRole currentRole)
        {
            InitializeComponent();
            lblErrorMessage.Text = string.Empty;
            _currentRole = currentRole.ToString();
        }
        #endregion

        #region Private Methods
        private bool ValidateInput()
        {
            bool result = true;
            lblErrorMessage.Text = string.Empty;
            if (!string.IsNullOrEmpty(_currentRole))
            {
                Collection<string> errorMessages = new Collection<string>();
                if (string.IsNullOrEmpty(tbUsername.Text))
                {
                    errorMessages.Add(Constants.Messages.BLANK_USERNAME_ALERT);
                }
                if (string.IsNullOrEmpty(tbPassword.Text))
                {
                    errorMessages.Add(Constants.Messages.BLANK_PASSWORD_ALERT);
                }
                if (errorMessages.Count > 0)
                {
                    StringBuilder message = new StringBuilder();
                    message.AppendLine("Lỗi:");
                    foreach (string errMessage in errorMessages)
                    {
                        message.AppendLine(string.Format(" - {0}", errMessage));
                    }
                    MessageBox.Show(message.ToString(), Constants.Messages.ERROR_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    result = false;
                }
            }
            else
            {
                MessageBox.Show(Constants.Messages.INVALID_USER_ROLE, Constants.Messages.ERROR_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return result;
        }
        #endregion

        #region Event Handlers
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                User validatedUser = ExcuteLogin(tbUsername.Text, tbPassword.Text, _currentRole);
                if (validatedUser != null)
                {
                    SystemParam.IsLogged = true;
                    SystemParam.CurrentUser = validatedUser;

                    if (_loginCallBack != null)
                    {
                        _loginCallBack();
                    }

                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }
                else
                {
                    this.lblErrorMessage.Text = Constants.Messages.INVALID_USERNAME_OR_PASSWORD;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }


        #endregion

        #region client implement
        protected virtual void Login_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// will be implemented in client
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        protected virtual User ExcuteLogin(string userName, string password, string role)
        {
            User validatedUser = null;
            try
            {
                validatedUser = (new UserBusiness()).ValidateUser(userName, password, role);
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), ex);
            }
            return validatedUser;
        }

        #endregion

        private void OnEnter(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                ((TextBox)sender).SelectAll();
            }
        }
    }
}
