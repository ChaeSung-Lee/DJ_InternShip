using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XPIrisAnalysis
{
    public partial class RGMABS21 : Form
    {
        public RGMABS21()
        {
            InitializeComponent();
        }

        private void chkAgreement_CheckedChanged(object sender, EventArgs e)
        {
            RGMABS22 showForm = new RGMABS22();
            MainForm parent = (MainForm)this.MdiParent;
            parent.OpenForm(this, showForm);
        }
    }
}
