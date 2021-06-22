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
    public partial class RGMABS11 : Form
    {
        public RGMABS11()
        {
            InitializeComponent();
        }

        private void cbAgreement_CheckedChanged(object sender, EventArgs e)
        {
            RGMABS12 showForm = new RGMABS12();
            MainForm parent = (MainForm)this.MdiParent;
            parent.OpenForm(this, showForm);
        }
    }
}
