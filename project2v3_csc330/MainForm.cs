using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project2v3_csc330
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void agentLogInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login1 a1 = new Login1(); 
            a1.MdiParent = this;
            a1.Show(); 
        }

        private void customerLogInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login a1 = new Login(); 
            a1.MdiParent = this;
            a1.Show(); 
        }

        private void newCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateAccount a1 = new CreateAccount();
            a1.MdiParent = this;
            a1.Show(); 
        }
    }
}
