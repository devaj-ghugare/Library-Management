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
    public partial class Dashboard1 : Form
    {
        public Dashboard1()
        {
            InitializeComponent();
            costamizeDesiing();
        }
        private void costamizeDesiing()
        {
            panelsubbookmenu.Visible = false;
            panelsubmembermenu.Visible = false;
            panelsubbookdetailmenu.Visible = false;
        }
        private void hidesubmenu()
        {
            if (panelsubbookmenu.Visible == true)
            {
                panelsubbookmenu.Visible = false;
            }
            if (panelsubmembermenu.Visible == true)
            {
                panelsubmembermenu.Visible = false;
            }
            if (panelsubbookdetailmenu.Visible == true)
            {
                panelsubbookdetailmenu.Visible = false;
            }
        }
       
            private void showSubMenu(Panel subMenu)
            {
                if (subMenu.Visible == false)
                {
                    hidesubmenu();
                    subMenu.Visible = true;
                }
                else
                    subMenu.Visible = false;
            }

        private void btnBook_Click(object sender, EventArgs e)
        {
            showSubMenu(panelsubbookmenu);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openpanelmain(new Add_Book());
            hidesubmenu();
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

        private void button3_Click(object sender, EventArgs e)
        {
           // openpanelmain(new Add_Book());
            hidesubmenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            showSubMenu(panelsubmembermenu);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // openpanelmain(new Add_Book());
            hidesubmenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // openpanelmain(new Add_Book());
            hidesubmenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            showSubMenu(panelsubbookdetailmenu);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // openpanelmain(new Add_Book());
            hidesubmenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // openpanelmain(new Add_Book());
            hidesubmenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // openpanelmain(new Add_Book());
            hidesubmenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // openpanelmain(new Add_Book());
            hidesubmenu();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // openpanelmain(new Add_Book());
            hidesubmenu();
        }
    }
}
