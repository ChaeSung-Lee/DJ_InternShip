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
    public partial class RGMABS22 : Form
    {
        public RGMABS22()
        {
            InitializeComponent();
        }

        private void btnRegistPatient_Click(object sender, EventArgs e)
        {
            RGMABS24 showForm = new RGMABS24();
            MainForm parent = (MainForm)this.MdiParent;
            parent.OpenForm(this, showForm);
        }
    }
}
