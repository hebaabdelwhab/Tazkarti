using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
namespace Tazkarti
{
    public partial class UserTicketReportForm : Form
    {
        Person person;
        UserTicketReport TheUserTicketReport;
        public UserTicketReportForm(Person person)
        {
            InitializeComponent();
            this.person = person;
        }

        private void UserTicketReportForm_Load(object sender, EventArgs e)
        {
            TheUserTicketReport = new UserTicketReport();
            TheUserTicketReport.SetParameterValue(0,person.username);
            crystalReportViewer1.ReportSource=TheUserTicketReport;
        }

        private void lbl_passenegerBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserTicket ut = new UserTicket(person);
            ut.ShowDialog();
            this.Close();
        }
    }
}
