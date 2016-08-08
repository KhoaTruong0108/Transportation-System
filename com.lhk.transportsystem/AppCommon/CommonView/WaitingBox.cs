using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppCommon.CommonView
{
    public partial class WaitingBox : Form
    {
        public delegate string WaitingBoxAction();
        public WaitingBoxAction Process;

        private string _errorMessage;

        public string ErrorMessage
        {
            get { return _errorMessage; }
            set { _errorMessage = value; }
        }

        public WaitingBox()
        {
            InitializeComponent();
        }


    }
}
