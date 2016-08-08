using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppCommon.Report
{
    public partial class ReportReviewer : Form
    {
        public object ReportSource
        {
            set { crystalReportViewer1.ReportSource = value; }
        }

        public ReportReviewer()
        {
            InitializeComponent();
        }

        private void ReportReviewer_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.RefreshReport();
        }

    }
}
