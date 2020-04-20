using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Tazkarti
{
    public partial class UserForm : Form
    {
        string ordb = "Data source=orcl;User Id=hr; Password=hr;";
        OracleConnection conn;

        int PW;
        bool hided;
        Person person;

        public UserForm(Person person)
        {
            InitializeComponent();
            PW = pnl_userSidebar.Width;
            hided = true;
            pnl_userSidebar.Width = 0;
            this.person = person;
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            pnl_userSidebar.BackColor = Color.FromArgb(20, 0, 0, 0);
            pnl_userMenu.BackColor = Color.FromArgb(0, 0, 0, 0);
            buttonChangeAll();

            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void buttonChange(Label lbl)
        {
            buttonChangeAll();
            lbl.BackColor = Color.FromArgb(20, 0, 0, 0);
        }

        private void buttonChangeAll()
        {
            lbl_userLogout.BackColor = Color.FromArgb(0, 0, 0, 0);
            lbl_userReserve.BackColor = Color.FromArgb(0, 0, 0, 0);
            lbl_userProfile.BackColor = Color.FromArgb(0, 0, 0, 0);
            lbl_userTickets.BackColor = Color.FromArgb(0, 0, 0, 0);
        }

        private void UserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (hided)
            {
                pnl_userSidebar.Width += 20;
                if (pnl_userSidebar.Width >= PW)
                {
                    timer1.Stop();
                    hided = false;
                    this.Refresh();
                }
            }
            else
            {
                pnl_userSidebar.Width -= 20;
                if (pnl_userSidebar.Width <= 0)
                {
                    timer1.Stop();
                    hided = true;
                    this.Refresh();
                }
            }
        }

        private void btn_userMenu_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void lbl_userReserve_Click(object sender, EventArgs e)
        {
            this.Hide();
            TicketsForm ticketsForm = new TicketsForm(person);
            ticketsForm.ShowDialog();
            this.Close();
        }

        private void lbl_userProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProfileForm profileForm = new ProfileForm(person);
            profileForm.ShowDialog();
            this.Close();
        }

        private void lbl_userTickets_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserTicket userTicket = new UserTicket(person);
            userTicket.ShowDialog();
            this.Close();
        }

        private void lbl_MouseHover(object sender, EventArgs e)
        {
            buttonChangeAll();
            buttonChange((Label)sender);
        }

        private void lbl_userLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Close();
        }
    }
}
