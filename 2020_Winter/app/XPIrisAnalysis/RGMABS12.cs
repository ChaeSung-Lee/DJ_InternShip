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
    public partial class RGMABS12 : Form
    {
        public RGMABS12()
        {
            InitializeComponent();
        }

        private void btnRegisteUser_Click(object sender, EventArgs e)
        {

            RGMABS14 showForm = new RGMABS14();
            MainForm parent = (MainForm)this.MdiParent;
            parent.OpenForm(this, showForm);
        }
    }
}
