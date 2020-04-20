using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tazkarti
{
    public partial class AdminForm : Form
    {
        int PW; //Side bar Width
        bool hided; //Side bar status
        //string username;
        Person person;
        public AdminForm(Person person)
        {
            InitializeComponent();
            PW = pnl_adminSidebar.Width;
            hided = true;
            pnl_adminSidebar.Width = 0;
            //this.username = username;
            this.person = person;
        }
        private void AdminForm_Load(object sender, EventArgs e)
        {
            //Make there background transparent
            pnl_adminSidebar.BackColor = Color.FromArgb(20, 0, 0, 0);
            pnl_adminMenu.BackColor = Color.FromArgb(0, 0, 0, 0);
            buttonChangeAll();
        }
        private void buttonChange(Label lbl)
        {
            buttonChangeAll();
            lbl.BackColor = Color.FromArgb(20, 0, 0, 0);
        }

        private void buttonChangeAll()
        {
            lbl_adminTickets.BackColor = Color.FromArgb(0, 0, 0, 0);
            lbl_adminAirplanes.BackColor = Color.FromArgb(0, 0, 0, 0);
            lbl_adminPassengers.BackColor = Color.FromArgb(0, 0, 0, 0);
            lbl_adminLogout.BackColor = Color.FromArgb(0, 0, 0, 0);
            lbl_adminProfile.BackColor = Color.FromArgb(0, 0, 0, 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Side bar Animation
            if (hided)
            {
                pnl_adminSidebar.Width += 50;
                if (pnl_adminSidebar.Width >= PW)
                {
                    timer1.Stop();
                    hided = false;
                    this.Refresh();
                }
            }
            else
            {
                pnl_adminSidebar.Width -= 50;
                if (pnl_adminSidebar.Width <= 0)
                {
                    timer1.Stop();
                    hided = true;
                    this.Refresh();
                }
            }
        }

        private void btn_adminMenu_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void lbl_adminTickets_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminTicket ticketReportForm = new AdminTicket(person);
            ticketReportForm.ShowDialog();
            this.Close();
        }
        private void lbl_adminAirplanes_Click(object sender, EventArgs e)
        {
            this.Hide();
            FlightsForm ff = new FlightsForm(person);
            ff.ShowDialog();
            this.Close();
        }
        private void lbl_adminPassengers_Click(object sender, EventArgs e)
        {
            this.Hide();
            PassengersForm passengersForm = new PassengersForm( person);
            passengersForm.ShowDialog();
            this.Close();
        }
        private void lbl_adminProfile_Click(object sender, EventArgs e)
        {
            ChangePassword cp = new ChangePassword(person);
            cp.ShowDialog();
        }

        private void lbl_adminLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.ShowDialog();
            this.Close();
        }

        private void lbl_MouseHover(object sender, EventArgs e)
        {
            buttonChangeAll();
            buttonChange((Label)sender);
        }
    }
}
