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
    public partial class RGMABS14 : Form
    {
        public RGMABS14()
        {
            InitializeComponent();
        }

        private void btnStartProgram_Click(object sender, EventArgs e)
        {
            MainForm parent = (MainForm)this.MdiParent;
            parent.OpenForm(this, parent.mainFrom);
        }
    }
}
