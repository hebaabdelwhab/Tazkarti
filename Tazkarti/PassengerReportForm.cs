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
    public partial class PassengerReportForm : Form
    {
        PassengersReport CR;
        Person person;

        public PassengerReportForm(Person person)
        {
            InitializeComponent();
            this.person = person;
        }

        private void PassengerReportForm_Load(object sender, EventArgs e)
        {
            CR = new PassengersReport();
            crystalReportViewer1.ReportSource = CR;
        }

        private void lbl_passenegerBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            PassengersForm pf = new PassengersForm(person);
            pf.ShowDialog();
            this.Close();
        }
    }
}
