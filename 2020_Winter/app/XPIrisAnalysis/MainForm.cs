using Microsoft.Build.BuildEngine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XPIrisAnalysis
{
    public partial class MainForm : Form
    {
        //Start Form
        public Form mainFrom = new ASMABS11();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //private ASMABS10 asmabs10 = null;
            //private ASMABS20 asmabs20 = null;
        }

        private bool fomIsExist(Type tp)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.GetType() == tp)
                {
                    form.Activate();
                    form.BringToFront();
                    return true;
                }
            }

            return false;
        }

        private void IFMABS10_Click(object sender, EventArgs e)
        {
            //this.Visible = false;             // 추가
            IFMABS11 regForm = new IFMABS11();
            if (fomIsExist(regForm.GetType()))
            {
                regForm.Dispose();
            }
            else
            {
                regForm.MdiParent = this;
                regForm.WindowState = FormWindowState.Maximized;
                regForm.Show();
            }
        }

        private void IFMABS20_Click(object sender, EventArgs e)
        {
            //this.Visible = false;             // 추가
            IFMABS21 regForm = new IFMABS21();
            if (fomIsExist(regForm.GetType()))
            {
                regForm.Dispose();
            }
            else
            {
                regForm.MdiParent = this;
                regForm.WindowState = FormWindowState.Maximized;
                regForm.Show();
            }
        }

        private void RGMABS10_Click(object sender, EventArgs e)
        {
            //this.Visible = false;             // 추가
            RGMABS11 regForm = new RGMABS11();
            if (fomIsExist(regForm.GetType()))
            {
                regForm.Dispose();
            }
            else
            {
                regForm.MdiParent = this;
                regForm.WindowState = FormWindowState.Maximized;
                regForm.Show();
            }
        }

        private void RGMABS20_Click(object sender, EventArgs e)
        {
            //this.Visible = false;             // 추가
            RGMABS21 regForm = new RGMABS21();
            if (fomIsExist(regForm.GetType()))
            {
                regForm.Dispose();
            }
            else
            {
                regForm.MdiParent = this;
                regForm.WindowState = FormWindowState.Maximized;
                regForm.Show();
            }
        }

        private void FLMABS20_Click(object sender, EventArgs e)
        {
            //this.Visible = false;             // 추가
            FLMABS21 regForm = new FLMABS21();
            if (fomIsExist(regForm.GetType()))
            {
                regForm.Dispose();
            }
            else
            {
                regForm.MdiParent = this;
                regForm.WindowState = FormWindowState.Maximized;
                regForm.Show();
            }
        }

        private void FLMABS10_Click(object sender, EventArgs e)
        {
            //this.Visible = false;             // 추가
            FLMABS11 regForm = new FLMABS11();
            if (fomIsExist(regForm.GetType()))
            {
                regForm.Dispose();
            }
            else
            {
                regForm.MdiParent = this;
                regForm.WindowState = FormWindowState.Maximized;
                regForm.Show();
            }
        }

        private void FLMABS40_Click(object sender, EventArgs e)
        {
            //this.Visible = false;             // 추가
            FLMABS41 regForm = new FLMABS41();
            if (fomIsExist(regForm.GetType()))
            {
                regForm.Dispose();
            }
            else
            {
                regForm.MdiParent = this;
                regForm.WindowState = FormWindowState.Maximized;
                regForm.Show();
            }
        }

        private void ASMABS10_Click(object sender, EventArgs e)
        {
            //this.Visible = false;             // 추가
            ASMABS11 regForm = new ASMABS11();
            if (fomIsExist(regForm.GetType()))
            {
                regForm.Dispose();
            }
            else
            {
                regForm.MdiParent = this;
                regForm.WindowState = FormWindowState.Maximized;
                regForm.Show();
            }
        }

        private void ASMABS20_Click(object sender, EventArgs e)
        {
            //this.Visible = false;             // 추가
            ASMABS21 regForm = new ASMABS21();
            if (fomIsExist(regForm.GetType()))
            {
                regForm.Dispose();
            }
            else
            {
                regForm.MdiParent = this;
                regForm.WindowState = FormWindowState.Maximized;
                regForm.Show();
            }
        }

        private void ASMABS30_Click(object sender, EventArgs e)
        {
            //this.Visible = false;             // 추가
            ASMABS31 regForm = new ASMABS31();
            if (fomIsExist(regForm.GetType()))
            {
                regForm.Dispose();
            }
            else
            {
                regForm.MdiParent = this;
                regForm.WindowState = FormWindowState.Maximized;
                regForm.Show();
            }
        }

        private void ASMABS40_Click(object sender, EventArgs e)
        {
            ASMABS41 regForm = new ASMABS41();
            if (fomIsExist(regForm.GetType()))
            {
                regForm.Dispose();
            }
            else
            {
                regForm.MdiParent = this;
                regForm.WindowState = FormWindowState.Maximized;
                regForm.Show();
            }
        }


        public void OpenForm(Form preform, Form nextForm)
        {
            preform.Close();
            if (fomIsExist(nextForm.GetType()))
            {
                nextForm.Dispose();
            }
            else
            {
                nextForm.MdiParent = this;
                nextForm.WindowState = FormWindowState.Maximized;
                nextForm.Show();
            }

        }


        //상단 메인 메뉴 선택 시
        private void RGMABS00_Click(object sender, EventArgs e)
        {

        }

        private void moveSecendMenuForm()
        {
            return;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //testcode : Open python file (Debug/test.py)
            runPython();
        }

        private void runPython()
        {
            var engine = IronPython.Hosting.Python.CreateEngine();
            var scope = engine.CreateScope();

            try
            {
                var source = engine.CreateScriptSourceFromFile(@"test.py");
                source.Execute(scope);

                var getPythonFuncResult = scope.GetVariable<Func<string>>("getPhthonFunc");
                Console.WriteLine("def runtest : " + getPythonFuncResult());

                var sum = scope.GetVariable<Func<int, int, int>>("sum");
                Console.WriteLine("sum : " + sum(2, 1));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}