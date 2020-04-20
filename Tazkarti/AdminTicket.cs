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
using Microsoft.VisualBasic;

namespace Tazkarti
{
    public partial class AdminTicket : Form
    {
        string constr = "Data Source=orcl;User Id = hr;Password = hr;";
        OracleDataAdapter adapter;
        DataSet ds;
        OracleCommandBuilder builder;
        Person person;
        public AdminTicket(Person person)
        {
            InitializeComponent();
            this.person = person;
        }
        private void AdminTicket_Load(object sender, EventArgs e)
        {
            string cmdstr = "SELECT * FROM Tickets";
            adapter = new OracleDataAdapter(cmdstr, constr);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void lbl_searchTicket_Click(object sender, EventArgs e)
        {
            string cmdstr = "SELECT * FROM Tickets WHERE PUsername = :uname";
            adapter = new OracleDataAdapter(cmdstr, constr);
            adapter.SelectCommand.Parameters.Add("uname", txt_ticketUsername.Text);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btn_saveTicket_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
            MessageBox.Show("Your changes have been saved successfully! :)", "Tickets Change");
        }

        private void lbl_ticketBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm af = new AdminForm(person);
            af.ShowDialog();
            this.Close();
        }
    }
}
