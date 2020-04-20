using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Types;
using Oracle.DataAccess.Client;

namespace Tazkarti
{
    public partial class UserTicket : Form
    {
        string constr = "Data Source=orcl; User Id=hr; Password=hr;";
        Person person;
        OracleConnection Myconnection;

        public UserTicket(Person person)
        {
            InitializeComponent();
            this.person = person;
            Myconnection = new OracleConnection(constr);
            Myconnection.Open();
        }

        private void lbl_ticketEdit_Click(object sender, EventArgs e)
        {
            if (txt_ticketID.Text != "")
                showUpdates(txt_ticketID.Text);
            else
                MessageBox.Show("Please, Enter the ticket ID you want to update!", "Ticket ID Update ERROR");
        }

        int isVIP = 0;
        private void showUpdates(string ticketID)
        {
            int tID = Convert.ToInt32(ticketID);
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = Myconnection;
            cmd.CommandText = "select ticket_type from tickets where ticketid = :ticketid1 and pusername = :uname";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("ticketid1", tID);
            cmd.Parameters.Add("ticketid1", person.username);
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                isVIP = Convert.ToInt32(dr[0].ToString());
                pnl_updateTicket.Show();

                if (isVIP == 1)
                {
                    chk_vip.Hide();
                    chk_regular.Show();
                }
                else
                {
                    chk_regular.Hide();
                    chk_vip.Show();
                }
            }
            else
                MessageBox.Show("Wrong Ticket ID!", "Ticket ID ERROR");

            dr.Close();
        }

        private void UserTicket_Load(object sender, EventArgs e)
        {
            insertDataGridView();
        }

        private void insertDataGridView()
        {
            string cmdstr = "select * from tickets where pusername = :uname ";
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = Myconnection;
            cmd.CommandText = cmdstr;
            cmd.Parameters.Add("uname", person.username);
            OracleDataReader rd = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(rd);
            dataGridView1.DataSource = dt;
            rd.Close();
            pnl_updateTicket.Hide();
        }
        private void btn_updateTicket_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = Myconnection;
            
            string Update_Flight = "Update tickets set ticket_type = :ttype where ticketid = :ticket_id";
            cmd.CommandText = Update_Flight;
            cmd.CommandType = CommandType.Text;

            int zero = 0;

            if (chk_vip.Checked==true)
                cmd.Parameters.Add("ttype", 1);
            else if (chk_regular.Checked==true)
                cmd.Parameters.Add("ttype", Convert.ToInt32(zero));
            else
                cmd.Parameters.Add("ttype", isVIP);

            cmd.Parameters.Add("ticket_id", Convert.ToInt32(txt_ticketID.Text));
            cmd.ExecuteNonQuery();

            MessageBox.Show("Flight updated successfully! :)", "Flight Update");
            insertDataGridView();
            chk_vip.Checked = false;
            chk_regular.Checked = false;
            pnl_updateTicket.Hide();
        }

        private void lbl_ticketDelete_Click(object sender, EventArgs e)
        {
            int TicketId = Convert.ToInt32(txt_ticketID.Text);
            int flightID = getFlightID(TicketId);

            if (txt_ticketID.Text != "")
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = Myconnection;
                cmd.CommandText = "delete_ticket";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("my_ticket", TicketId);
                int r = cmd.ExecuteNonQuery();
                if (r != -1)
                    MessageBox.Show("Please, Enter the ticket ID you want to delete!", "Ticket ID Delete ERROR");
                else
                { 
                    cmd = new OracleCommand();
                    cmd.Connection = Myconnection;
                    cmd.CommandText = "increment_Flight_seats";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("my_flight", flightID);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ticket deleted successfully! :)", "Ticket Delete");
                    insertDataGridView();
                }
            }
            else
                MessageBox.Show("Please, Enter the ticket you want to delete!", "Ticket ID Delete ERROR");        
        }
        private int getFlightID(int ticketID)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = Myconnection;
            cmd.CommandText = "select flight_id from tickets where ticketid= :tid";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("tid", ticketID);
            MessageBox.Show("ticket id: " + ticketID);
            OracleDataReader dr = cmd.ExecuteReader();
            int fID = 0;
            if (dr.Read())
            {
                fID = Convert.ToInt32(dr[0].ToString());
            }
            dr.Close();
            return fID;
        }

        private void Btn_ticketShowReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserTicketReportForm userTicketReportForm = new UserTicketReportForm(person);
            userTicketReportForm.ShowDialog();
            this.Close();
        }

        private void lbl_ticketBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserForm uf = new UserForm(person);
            uf.ShowDialog();
            this.Close();
        }

        private void chk_vip_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
