using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        private void Dashboard_Load(object sender, EventArgs e, Panel mainpanel)
        {
            Dashboard_Load(sender, e, mainpanel);
        }

        private Form activeForm = null;
        private void openpanelmain(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelmain.Controls.Add(childForm);
            panelmain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private static void addToolStripMenuItem_Click(object sender, EventArgs e, Form dashboard)
        {
           /* Add_Book abs = new Add_Book();          
            abs.Show();*/

            openmailpanel(new Add_Book());
        }

        private static void openmailpanel(Add_Book add_Book)
        {
            throw new NotImplementedException();
        }

        private static void Dashboard_Load(Dashboard dashboard)
        {
            throw new NotImplementedException();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            openpanelmain(new Add_Book());
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            openpanelmain(new Add_Member());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            openpanelmain(new B_Update());
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            openpanelmain(new M_Update());
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            openpanelmain(new Borrow_Book());
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            openpanelmain(new Return_Book());
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Login lg = new Login();
            lg.Show();
            //this.Close();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            openpanelmain(new BB_Details());
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            openpanelmain(new RB_details());
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openpanelmain(new View_Book());
        }

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openpanelmain(new View_Member());
        }
    }
}
