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
    
    public partial class PassengersForm : Form
    {
        OracleConnection conn;
        string ordb = "Data Source = orcl; User ID = hr; Password = hr;";
        Person person;

        public PassengersForm(Person person)
        {
            InitializeComponent();
            this.person = person;
            conn = new OracleConnection(ordb);
        }

        private void lbl_passengersBack_Click(object sender, EventArgs e)
        {
            gotoAdminForm();
        }

        private void gotoAdminForm()
        {
            this.Hide();
            AdminForm adminForm = new AdminForm(person);
            adminForm.ShowDialog();
            this.Close();
        }

        private void txt_passengerSearch_TextChanged(object sender, EventArgs e)
        {
            //--------- A.2. Select using where ----------\\
            string cmdstr = "SELECT p.Username, p.FirstName, p.LastName, p.Email, p.CreditCardNumber," +
                "p.SSN, m.PMobile_Number FROM Passengers p, Passenger_Mobile_Number m " +
                "WHERE p.Username = m.PUsername AND p.Username LIKE '%" + txt_passengerSearch.Text + "%'";
            OracleCommand cmd = new OracleCommand(cmdstr, conn);
            DataTable dt = new DataTable();
            conn.Open();
            dt.Load(cmd.ExecuteReader());
            conn.Close();
            dataGridView1.DataSource = dt;
        }

        private void PassengersForm_Load(object sender, EventArgs e)
        {
            //--------- A.1. Select without where ----------\\
            string cmdstr = "SELECT p.Username, p.FirstName, p.LastName, p.Email, p.CreditCardNumber," +
                "p.SSN, m.PMobile_Number FROM Passengers p, Passenger_Mobile_Number m " +
                "WHERE p.Username = m.PUsername";
            OracleCommand cmd = new OracleCommand(cmdstr, conn);
            DataTable dt = new DataTable();
            conn.Open();
            dt.Load(cmd.ExecuteReader());
            conn.Close();
            dataGridView1.DataSource = dt;
        }
        private void Btn_ShowPassReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            PassengerReportForm ThePassengerReportForm = new PassengerReportForm(person);
            ThePassengerReportForm.ShowDialog();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
