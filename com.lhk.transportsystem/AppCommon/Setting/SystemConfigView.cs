using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AppCommon.Util;
using AppCommon.CommonView;
using DBManagement;

namespace AppCommon.Setting
{
    public partial class SystemConfigView : GenericDialog
    {
        public SystemConfigView()
        {
            InitializeComponent();
        }

        private void SystemConfigView_Load(object sender, EventArgs e)
        {
            try
            {
                LoadConfiguration();
                ChangeViewStatus(false);
            }
            catch (Exception exc)
            {
                AppLogger.logError("SystemConfigView_Load", exc);
            }
        }

        protected override void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                base.btnSave_Click(sender, e);

                using (ThanhVanTranSysEntities context = new ThanhVanTranSysEntities())
                {
                    var config = context.Configurations.SingleOrDefault(i => i.id == tbID.Text.Trim());

                    if (config == null) return;

                    config.name = tbName.Text.Trim();
                    config.value = tbValue.Text.Trim();
                    config.description = tbRemark.Text.Trim();

                    context.SaveChanges();
                }

                ChangeViewStatus(false);

                LoadConfiguration();
            }
            catch (Exception exc)
            {
                AppLogger.logError("btnSave_Click", exc);
            }
        }

        private void dgvItemsList_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvItemsList.SelectedRows.Count <= 0) return;

                var seletedItem = dgvItemsList.SelectedRows[0].DataBoundItem as Configuration;

                tbID.Text = seletedItem.id;
                tbName.Text = seletedItem.name;
                tbValue.Text = seletedItem.value;
                tbRemark.Text = seletedItem.description;
            }
            catch (Exception exc)
            {
                AppLogger.logError("dgvItemsList_SelectionChanged", exc);
            }
        }

        protected void LoadConfiguration()
        {
            using (ThanhVanTranSysEntities context = new ThanhVanTranSysEntities())
            {
                dgvItemsList.DataSource = context.Configurations;
            }
        }

        protected override void ChangeViewStatus(bool isEditing)
        {
            base.ChangeViewStatus(isEditing);
            btnAddNew.Visible = false;
            btnDelete.Visible = false;

            tbName.Enabled = isEditing;
            tbValue.Enabled = isEditing;
            tbRemark.Enabled = isEditing;
        }


    }
}
