using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AppCommon.CommonView;

namespace Staff
{
    public partial class ConfigView : GenericView
    {
        private ConfigUtil.ConfigObject _currentConfig = null;

        public ConfigView()
        {
            InitializeComponent();
        }

        private void SystemConfigView_Load(object sender, EventArgs e)
        {
            ChangeStatusView(false);

            dgvConfig.DataSource = ConfigUtil.GetConfig();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void ChangeStatusView(bool isEditing)
        {
            btnCancel.Visible = isEditing;
            btnSave.Visible = isEditing;
            btnUpdate.Visible = !isEditing;

            tbValue.ReadOnly = !isEditing;
            dgvConfig.ReadOnly = !isEditing;
            dgvConfig.Enabled = !isEditing;
        }

        private void ClearView()
        {
            tbName.Text = "";
            tbValue.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ChangeStatusView(true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ConfigUtil.SaveConfig(_currentConfig.Id, tbName.Text, tbValue.Text);
            ChangeStatusView(false);

            dgvConfig.DataSource = ConfigUtil.GetConfig();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ChangeStatusView(false);

            ClearView();
        }

        private void dgvConfig_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvConfig.SelectedRows.Count > 0)
            {
                _currentConfig = (dgvConfig.SelectedRows[0].DataBoundItem as ConfigUtil.ConfigObject);
                tbName.Text = _currentConfig.Name;
                tbValue.Text = _currentConfig.Value;
            }
        }

    }
}
