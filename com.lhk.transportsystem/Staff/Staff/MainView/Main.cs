using System;
using System.Linq;
using System.Windows.Forms;
using AppCommon.CommonView;
using AppCommon.Constant;
using AppCommon.Setting;
using AppCommon.Transport.TransportOrder;
using AppCommon.Travel.SaleTicket;
using AppCommon.UserManagement;
using AppCommon.Util;
using Staff.View;
using TransportService;

namespace Staff
{
    public partial class Main : Form
    {
        #region -Private properties
        private GenericView CurrentView { get; set; }
        //public MainModel _model = MainModel.getInstance();

        private bool m_isLoggedIn;
        public bool IsLoggedIn
        {
            get { return m_isLoggedIn; }
            set { m_isLoggedIn = value; SetMainFormLogin(m_isLoggedIn); }
        }

        private bool m_isEditing;
        public bool IsEditing
        {
            get { return m_isEditing; }
            set { m_isEditing = value; SetMainFormEditing(m_isEditing); }
        }

        #endregion

        #region View menthods
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                AppLogger.logInfo(this.Name, ":: Main_Manager_Load");

                //m_menuStrip.DataBindings.Add("Enabled", _model, "IsLoggedIn");
                //m_tsbAddNew.DataBindings.Add("Enabled", _model, "IsLoggedIn");
                //m_tsbCancelTask.DataBindings.Add("Enabled", _model, "IsLoggedIn");
                //m_tsbDelete.DataBindings.Add("Enabled", _model, "IsLoggedIn");
                //m_tsbEdit.DataBindings.Add("Enabled", _model, "IsLoggedIn");
                //m_tsbSaveTask.DataBindings.Add("Enabled", _model, "IsLoggedIn");
                //m_tsbSyncData.DataBindings.Add("Enabled", _model, "IsLoggedIn");
                ////m_tsbExport.DataBindings.Add("Enabled", _model, "IsLoggedIn");
                ////m_tsbPrint.DataBindings.Add("Enabled", _model, "IsLoggedIn");
                ////m_tsbSearch.DataBindings.Add("Enabled", _model, "IsLoggedIn");

                //m_tsbAddNew.DataBindings.Add("Visible", _model, "IsNotEditing");
                //m_tsbDelete.DataBindings.Add("Visible", _model, "IsNotEditing");
                //m_tsbEdit.DataBindings.Add("Visible", _model, "IsNotEditing");
                ////m_tsbExport.DataBindings.Add("Visible", _model, "IsNotEditing");
                ////m_tsbPrint.DataBindings.Add("Visible", _model, "IsNotEditing");
                ////m_tsbSearch.DataBindings.Add("Visible", _model, "IsNotEditing");
                //m_tsbCancelTask.DataBindings.Add("Visible", _model, "IsEditing");
                //m_tsbSaveTask.DataBindings.Add("Visible", _model, "IsEditing");

                IsEditing = false;
                IsLoggedIn = SystemParam.IsLogged;

                ServerConnector.GetInstance().DisconnectCallBack = HandleServerDisconnect;
            }
            catch (Exception exc)
            {
                AppLogger.logError(this.Name, exc);
            }
        }

        protected void SetMainFormLogin(bool isLogin)
        {
            SetEnableControl(m_menuStrip, isLogin);
            SetEnableToolStripButton(m_tsbAddNew, isLogin);
            SetEnableToolStripButton(m_tsbCancelTask, isLogin);
            SetEnableToolStripButton(m_tsbDelete, isLogin);
            SetEnableToolStripButton(m_tsbEdit, isLogin);
            SetEnableToolStripButton(m_tsbSaveTask, isLogin);
            SetEnableToolStripButton(m_tsbSyncData, isLogin);
            SetEnableToolStripButton(m_tsbPrint, isLogin);

        }

        protected void SetMainFormEditing(bool isEditting)
        {
            SetVisibleToolStripButton(m_tsbAddNew, !IsEditing);
            SetVisibleToolStripButton(m_tsbDelete, !IsEditing);
            SetVisibleToolStripButton(m_tsbEdit, !IsEditing);
            SetVisibleToolStripButton(m_tsbPrint, !IsEditing);
            SetVisibleToolStripButton(m_tsbCancelTask, IsEditing);
            SetVisibleToolStripButton(m_tsbSaveTask, IsEditing);
        }

        protected void HandleLoginSucess()
        {
            try
            {
                m_tssUserName.Text = string.Format("Name: {0}", SystemParam.CurrentUser.user_name);
                m_tssUserRole.Text = string.Format("Role: {0}", EnumHelper.Parse<Constants.UserRole>(SystemParam.CurrentUser.role).GetDescription());

                IsLoggedIn = true;

                //UserId = SystemParam.CurrentUser.id;
                //UserName = SystemParam.CurrentUser.user_name;
                //UserRole = SystemParam.CurrentUser.role;

                //init Data
                MainBusiness business = new MainBusiness();

                string errorMessage = business.InitData();
                if (string.IsNullOrEmpty(errorMessage) == false)
                {
                    MessageBox.Show(errorMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                AutoSync.GetInstance().Start();
                AutoSendMail.GetInstance().Start();
            }
            catch (Exception exc)
            {
                AppLogger.logError(this.ToString(), exc);
            }

        }


        delegate void SetEnableControlCallBack(Control control, bool isEnable);
        private void SetEnableControl(Control control, bool isEnable)
        {
            if (control.InvokeRequired)
            {
                SetEnableControlCallBack d = new SetEnableControlCallBack(SetEnableControl);
                this.Invoke(d, new object[] {control,  isEnable });
            }
            else
            {
                control.Enabled = isEnable;
            }
        }

        delegate void SetEnableToolStripButtonCallBack(ToolStripButton control, bool isEnable);
        private void SetEnableToolStripButton(ToolStripButton component, bool isEnable)
        {
            if (this.InvokeRequired)
            {
                SetEnableToolStripButtonCallBack d = new SetEnableToolStripButtonCallBack(SetEnableToolStripButton);
                this.Invoke(d, new object[] { component, isEnable });
            }
            else
            {
                component.Enabled = isEnable;
            }
        }

        delegate void SetVisibleToolStripButtonCallBack(ToolStripButton control, bool isVisible);
        private void SetVisibleToolStripButton(ToolStripButton component, bool isVisible)
        {
            if (this.InvokeRequired)
            {
                SetVisibleToolStripButtonCallBack d = new SetVisibleToolStripButtonCallBack(SetVisibleToolStripButton);
                this.Invoke(d, new object[] { component, isVisible });
            }
            else
            {
                component.Visible = isVisible;
            }
        }
        
        protected void HandleServerDisconnect()
        {
            try
            {
                if (IsLoggedIn == false)
                    return;

                m_tssUserName.Text = string.Empty;
                m_tssUserRole.Text = string.Empty;

                //UserId = UserName = UserRole = string.Empty;
                SystemParam.CurrentUser = null;

                AutoSync.GetInstance().Stop();
                AutoSendMail.GetInstance().Stop();

                CloseAllView(this);

                MessageBox.Show("Không thể kết nối tới máy chủ!", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);

                IsLoggedIn = false;
                IsEditing = false;
            }
            catch (Exception exc)
            {
                AppLogger.logError(this.ToString(), exc);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        protected void logout()
        {
            string userName = SystemParam.CurrentUser.user_name;

            CloseAllView(this);
            SystemParam.IsLogged = false;
            SystemParam.CurrentUser = null;
            IsLoggedIn = false;

            ServerConnector.GetInstance().LogOut(userName, ClientRepository.GetInstance()._clientIp, ClientRepository.GetInstance()._clientPort);

            AutoSync.GetInstance().Stop();
        }
        #endregion

        #region -Menu event
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsiSaleTicket_Click(object sender, EventArgs e)
        {
            this.ShowView(this, new SaleTicketViewClient(), typeof(SaleTicketViewClient));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsiRegluarOrder_Click(object sender, EventArgs e)
        {
            this.ShowView(this, new RegularOrderViewClient(), typeof(RegularOrderViewClient));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsiIrregluarOrder_Click(object sender, EventArgs e)
        {
            m_tsbSearch.Visible = false;
            this.ShowView(this, new IrregularOrderViewClient(), typeof(IrregularOrderViewClient));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsiUser_Click(object sender, EventArgs e)
        {
            UserView formDialog = new UserView();
            formDialog.ShowDialog();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsiSetupSystem_Click(object sender, EventArgs e)
        {
            SystemConfigView formDialog = new SystemConfigView();
            formDialog.ShowDialog();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsiTicketPrice_Click(object sender, EventArgs e)
        {
            TicketPriceView formDialog = new TicketPriceView();
            formDialog.ShowDialog();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsiTransportPrice_Click(object sender, EventArgs e)
        {
            TransportPriceView formDialog = new TransportPriceView();
            formDialog.ShowDialog();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsiSetting_Click(object sender, EventArgs e)
        {
            ConfigView dialog = new ConfigView();
            dialog.ShowDialog();
        }
        #endregion

        #region -Common button event
        private void m_tsbLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (SystemParam.IsLogged)
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn có muốn Đăng Xuất không?", "Đăng Xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogResult == System.Windows.Forms.DialogResult.Yes)
                    {
                        logout();
                    }
                }
                else
                {
                    //Login newForm = new Login();

                    //newForm.ShowDialog();

                    //this.HandleActiveView(newForm);

                    //IsLoggedIn = newForm.IsLoginSucess;

                    Staff.View.LoginClient login = new View.LoginClient(Constants.UserRole.Staff);
                    login._loginCallBack = HandleLoginSucess;
                    IsLoggedIn = login.ShowDialog() == System.Windows.Forms.DialogResult.OK;
                }
            }
            catch (Exception exc)
            {
                AppLogger.logError(this.ToString(), exc);
            }
        }

        private void m_tsbAddNew_Click(object sender, EventArgs e)
        {
            AppLogger.logInfo(this.Name, "handle tsbAddNew");
            this.HandleCreateNew();
        }
        
        private void m_tsbSave_Click(object sender, EventArgs e)
        {
            AppLogger.logInfo(this.Name, "handle tsbSave");
            this.HandleSaveTask();
        }

        private void m_tsbCancelTask_Click(object sender, EventArgs e)
        {
            AppLogger.logInfo(this.Name, "handle tsbCancel");
            this.HandleCancelTask();
        }

        private void m_tsbEdit_Click(object sender, EventArgs e)
        {
            AppLogger.logInfo(this.Name, "handle tsbEdit");
            this.HandleEdit();
        }

        private void m_tsbDelete_Click(object sender, EventArgs e)
        {
            AppLogger.logInfo(this.Name, "handle tsbDelete");
            this.HandleDelete();
        }

        private void m_tsbSearch_Click(object sender, EventArgs e)
        {
            AppLogger.logInfo(this.Name, "handle tsbSearch");
            this.HandleSearch();
        }

        private void m_tsbPrint_Click(object sender, EventArgs e)
        {
            AppLogger.logInfo(this.Name, "handle tsbPrint");
            this.HandlePrint();
        }

        private void m_tsbExport_Click(object sender, EventArgs e)
        {
            AppLogger.logInfo(this.Name, "handle tsbExport");
            this.HandleExport();
        }
        #endregion

        #region -Private Method
        public void CloseAllView(Form mainForm)
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mainForm"></param>
        /// <param name="newForm"></param>
        /// <param name="type"></param>
        public void ShowView(Form mainForm, GenericView newForm, Type type)
        {
            foreach (Form f in mainForm.MdiChildren)
            {
                if (f.GetType() == type)
                {
                    f.Activate();
                    HandleActiveView(f as GenericView);

                    return;
                }
            }
            newForm.MdiParent = mainForm;
            newForm.WindowState = FormWindowState.Maximized;
            newForm.ShowIcon = false;
            newForm.Show();

            HandleActiveView(newForm);

            newForm._closeViewCallBack = CloseView;
        }

        public void CloseView(GenericView view)
        {
            Form f = this.MdiChildren.FirstOrDefault(v => v.GetType() != view.GetType());
            if (f != null)
            {
                f.Activate();
                HandleActiveView(f as GenericView);

                return;
            }

            HandleActiveView(null);
        }

        public void HandleActiveView(GenericView view)
        {
            this.CurrentView = view;
        }

        public void HandleBarcodeHit(string barcode)
        {
            if (this.CurrentView != null)
            {
                this.CurrentView.HandleBarcodeHit(barcode);
            }
        }

        public void HandleCreateNew()
        {
            if (this.CurrentView != null)
            {
                IsEditing = this.CurrentView.HandleCreateNew();
            }
        }

        public void HandleEdit()
        {
            if (this.CurrentView != null)
            {
                IsEditing = this.CurrentView.HandleEdit();
            }
        }

        public void HandleDelete()
        {
            if (this.CurrentView != null)
            {
                this.CurrentView.HandleDelete();
            }
        }

        public void HandleSaveTask()
        {
            if (this.CurrentView != null)
            {
                IsEditing = !this.CurrentView.HandleSaveTask();
            }
        }

        public void HandleCancelTask()
        {
            if (this.CurrentView != null)
            {
                this.CurrentView.HandleCancelTask();
                IsEditing = false;
            }
        }

        public void HandlePrint()
        {
            if (this.CurrentView != null)
            {
                this.CurrentView.HandlePrint();
            }
        }

        public void HandleExport()
        {
            if (this.CurrentView != null)
            {
                this.CurrentView.HandleExport();
            }
        }

        public void HandleSearch()
        {
            if (this.CurrentView != null)
            {
                this.CurrentView.HandleSearch();
            }
        }

        public void HandleHelp()
        {
            if (this.CurrentView != null)
            {
                this.CurrentView.HandleHelp();
            }
        }
        #endregion

        private void m_tsbConfig_Click(object sender, EventArgs e)
        {
            ConfigView dialog = new ConfigView();
            dialog.ShowDialog();
        }

        private void m_tsbSyncData_Click(object sender, EventArgs e)
        {
            MainBusiness business = new MainBusiness();

            string errorMessage = business.InitData();
            //string errorMessage = business.SyncCommonData();
            if (string.IsNullOrEmpty(errorMessage) == false)
            {
                MessageBox.Show(errorMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            AutoSendMail.GetInstance().SendMail("STAFF");
        }
    }
}
