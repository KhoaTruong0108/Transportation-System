using System;
using System.Linq;
using System.Windows.Forms;
using AppCommon.CommonView;
using AppCommon.Constant;
using AppCommon.Setting;
using AppCommon.Transport.TransportCustomer;
using AppCommon.Transport.TransportOrder;
using AppCommon.Travel;
using AppCommon.Travel.SaleTicket;
using AppCommon.UserManagement;
using AppCommon.Util;
using com.lhk.transportsystem.Owner.Financial;
using AppCommon.Travel.SaleDateSetting;

namespace Owner.Main
{
    public partial class Main : Form
    {
        #region -Private properties
        private GenericView CurrentView { get; set; }
        public MainModel _model = MainModel.getInstance();
        #endregion

        #region View methods
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                AppLogger.logInfo(this.Name, ":: Main_Manager_Load");

                m_menuStrip.DataBindings.Add("Enabled", _model, "IsLoggedIn");
                m_tsbAddNew.DataBindings.Add("Enabled", _model, "IsLoggedIn");
                m_tsbCancelTask.DataBindings.Add("Enabled", _model, "IsLoggedIn");
                m_tsbDelete.DataBindings.Add("Enabled", _model, "IsLoggedIn");
                m_tsbEdit.DataBindings.Add("Enabled", _model, "IsLoggedIn");
                m_tsbExport.DataBindings.Add("Enabled", _model, "IsLoggedIn");
                m_tsbSaveTask.DataBindings.Add("Enabled", _model, "IsLoggedIn");
                m_tsbPrint.DataBindings.Add("Enabled", _model, "IsLoggedIn");
                m_tsbSearch.DataBindings.Add("Enabled", _model, "IsLoggedIn");

                m_tsbAddNew.DataBindings.Add("Visible", _model, "IsNotEditing");
                m_tsbDelete.DataBindings.Add("Visible", _model, "IsNotEditing");
                m_tsbEdit.DataBindings.Add("Visible", _model, "IsNotEditing");
                m_tsbExport.DataBindings.Add("Visible", _model, "IsNotEditing");
                m_tsbPrint.DataBindings.Add("Visible", _model, "IsNotEditing");
                m_tsbSearch.DataBindings.Add("Visible", _model, "IsNotEditing");
                m_tsbCancelTask.DataBindings.Add("Visible", _model, "IsEditing");
                m_tsbSaveTask.DataBindings.Add("Visible", _model, "IsEditing");

                m_tssUserName.Text = string.Format("Name: {0}", SystemParam.CurrentUser.user_name);
                m_tssUserRole.Text = string.Format("Role: {0}", EnumHelper.Parse<Constants.UserRole>(SystemParam.CurrentUser.role).GetDescription());

                _model.IsLoggedIn = true;
                _model.IsEditing = false;
                _model.UserId = SystemParam.CurrentUser.id;
                _model.UserName = SystemParam.CurrentUser.user_name;
                _model.UserRole = SystemParam.CurrentUser.role;

                AutoSendMail.GetInstance().Start();
            }
            catch (Exception exc)
            {
                AppLogger.logError(this.Name, exc);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        protected void logout()
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }
            SystemParam.IsLogged = false;
            SystemParam.CurrentUser = null;

            _model.IsLoggedIn = false;
        }
        #endregion

        #region -Menu event

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsiRegluarOrder_Click(object sender, EventArgs e)
        {
            this.ShowView(this, new RegularOrderView(), typeof(RegularOrderView));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsiIrregluarOrder_Click(object sender, EventArgs e)
        {
            m_tsbSearch.Visible = false;
            this.ShowView(this, new IrregularOrderView(), typeof(IrregularOrderView));
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

        private void tsGuaranteeFee_Click(object sender, EventArgs e)
        {
            GuaranteeFeeView formDialog = new GuaranteeFeeView();
            formDialog.ShowDialog();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsiCustomer_Click(object sender, EventArgs e)
        {
            this.ShowView(this, new CustomerView(), typeof(CustomerView));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsiFinancial_Click(object sender, EventArgs e)
        {
            this.ShowView(this, new FinancialView(), typeof(FinancialView));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsiTicketReturnFee_Click(object sender, EventArgs e)
        {
            TicketReturnFeeView formDialog = new TicketReturnFeeView();
            formDialog.ShowDialog();
        }

        private void tsiCompleteTicket_Click(object sender, EventArgs e)
        {
            CompleteTicketView formDialog = new CompleteTicketView();
            formDialog.ShowDialog();
        }

        private void tsiSellTikect_Click(object sender, EventArgs e)
        {
            this.ShowView(this, new SaleTicketView(), typeof(SaleTicketView));
        }

        private void tsiCompleteIrregularOrder_Click(object sender, EventArgs e)
        {
            CompleteIrregularOrder formDialog = new CompleteIrregularOrder();
            formDialog.ShowDialog();
        }
        #endregion

        #region -Common button event
        private void m_tsbLogin_Click(object sender, EventArgs e)
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

                //_model.IsLoggedIn = newForm.IsLoginSucess;
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

        #region -Private Methods
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

        public void HandleActiveView(GenericView view)
        {
            this.CurrentView = view;
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
                _model.IsEditing = this.CurrentView.HandleCreateNew();
            }
        }

        public void HandleEdit()
        {
            if (this.CurrentView != null)
            {
                _model.IsEditing = this.CurrentView.HandleEdit();
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
                bool result = this.CurrentView.HandleSaveTask();
                _model.IsEditing = !result;
            }
        }

        public void HandleCancelTask()
        {
            if (this.CurrentView != null)
            {
                this.CurrentView.HandleCancelTask();
                _model.IsEditing = false;
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


        private void tsiSaleDate_Click(object sender, EventArgs e)
        {
            SaleDateSettingView frm = new SaleDateSettingView();
            frm.ShowDialog();
        }

        private void tsTicketReturnFee_Click(object sender, EventArgs e)
        {
            TicketReturnFeeView frm = new TicketReturnFeeView();
            frm.ShowDialog();
        }

        #endregion

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            AutoSendMail.GetInstance().SendMail("Owner");
        }

    }
}
