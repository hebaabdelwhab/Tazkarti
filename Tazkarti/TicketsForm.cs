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
using Microsoft.VisualBasic;
using System.Text.RegularExpressions;

namespace Tazkarti
{
    public partial class TicketsForm : Form
    {
        string constr = "Data Source = orcl; User ID = hr; Password = hr;";
        OracleConnection MyConnection;
        Person person;
        string flightID;
        bool needDate;

        public TicketsForm(Person person)
        {
            InitializeComponent();
            MyConnection = new OracleConnection(constr);
            MyConnection.Open();
            this.person = person;
            pnl_member.Hide();
            dateTimePicker_FlightDate.Hide();
            needDate = false;
        }

        //Show available flights depending on passenger's choices
        private void btn_flightsShow_Click(object sender, EventArgs e)
        {
            //---------- A.2. Select using where ----------\\
            string cmdstr = "";

            if ((txt_flightDep.Text != "") && (txt_flightDest.Text != ""))
            {
                if(needDate)
                    cmdstr = "SELECT FlightID AS \"ID\", Price, " +
                    "Company_Name AS \"Company Name\" FROM Flights WHERE " +
                    "Flight_Date > :fD AND AvailableSeats > 0 AND Departure = :dep " +
                    "AND Destination = :dest AND Flight_Date = :fDate";

                else
                    cmdstr = "SELECT FlightID AS \"ID\", Price, " +
                        "Company_Name AS \"Company Name\" FROM Flights WHERE " +
                        "Flight_Date > :fD AND AvailableSeats > 0 AND Departure = :dep " +
                        "AND Destination = :dest";

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = MyConnection;
                cmd.CommandText = cmdstr;
                cmd.Parameters.Add("fD", System.DateTime.Now);
                cmd.Parameters.Add("dep", txt_flightDep.Text);
                cmd.Parameters.Add("dest", txt_flightDest.Text);

                if(needDate)
                    cmd.Parameters.Add("fDate", dateTimePicker_FlightDate.Value.Date);

                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dataGridView1.DataSource = dt;
            }
            else
                MessageBox.Show("You didn't enter any data so please enter your Departure and Destination", "Wrong Data");
        }

        bool isSSN;
        bool isCredit;
        bool isMobile;
        private void TicketsForm_Load(object sender, EventArgs e)
        {
            //Check if he entered his SSN
            if (person.hasSSN)
                pnl_SSN.Hide();
            isSSN = person.hasSSN;
            
            if (person.hasCredit)
                pnl_Credit.Hide();
            isCredit = person.hasCredit;

            if (person.hasMobile)
                pnl_Mobile.Hide();
            isMobile = person.hasMobile;

            getData(txt_flightDep);
            getData(txt_flightDest);
        }

        //Autocomplete textboxes
        private void getData(TextBox tb)
        {
            tb.AutoCompleteMode = AutoCompleteMode.Suggest;
            tb.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();

            //---------- A.1. Select without where ----------\\
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = MyConnection;

            if (tb == txt_flightDep)
                cmd.CommandText = "getDeparture";
            else if (tb == txt_flightDest)
                cmd.CommandText = "getDestination";

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("param", OracleDbType.RefCursor, ParameterDirection.Output);

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
                DataCollection.Add(dr[0].ToString());
            dr.Close();

            tb.AutoCompleteCustomSource = DataCollection;
        }

        //Show all available flights without passenger's choices
        int ticket_type = 0;
        private void btn_ticketShowAll_Click(object sender, EventArgs e)
        {
            showAllFlights();
        }

        private void showAllFlights()
        {
            //---------- A.1. Select without where ----------\\
            string cmdstr = "SELECT FlightID AS \"ID\", Flight_Date AS \"Date\", Price, " +
                "Destination, Departure, Company_Name AS \"Company Name\" FROM Flights WHERE Flight_Date > :fDate AND AvailableSeats > 0";

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = MyConnection;

            cmd.CommandText = cmdstr;

            cmd.Parameters.Add("fDate", System.DateTime.Now);
            OracleDataReader rd = cmd.ExecuteReader();
           
           DataTable dt = new DataTable();
           dt.Load(rd);
           dataGridView1.DataSource = dt;
           rd.Close();
        }

        //Save the ticket in DB
        private void btn_ticketSave_Click(object sender, EventArgs e)
        {
            //---------- A.6.1 Insert rows using stored procedures ----------\\
            bool isWrong = false;

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = MyConnection;
            cmd.CommandText = "Insert_Ticket";
            cmd.CommandType = CommandType.StoredProcedure;

            //ID
            int NewId = getTicketID();
            cmd.Parameters.Add("TicketId", NewId);

            //Status is always active in reserving a ticket
            cmd.Parameters.Add("Status", 1);

            //Ticket Type 
            //VIP = 1
            //Regular = 0
            if (chk_vip.Checked)
                ticket_type = 1;
            cmd.Parameters.Add("Type", ticket_type);

            //Flight ID
            int fID = Convert.ToInt32(flightID);
            if (fID != 0)
                cmd.Parameters.Add("FightId", fID);
            else
            {
                isWrong = true;
                MessageBox.Show("Please choose your flight before reservation", "Reservation ERROR");
            }

            //Username
            cmd.Parameters.Add("Pusername", person.username);

            //Booking Date (System Date)
            cmd.Parameters.Add("BookingDate", DateTime.Now);

            //SSN
            if (isSSN == false)
                if (!isWrong)
                {
                    if (txt_ticketSSN.Text != "")
                    {
                        if (!(Regex.IsMatch(txt_ticketSSN.Text, "\\A[0-9]{14}\\z")))
                        {
                            isWrong = true;
                            MessageBox.Show("You don't have SSN so please write it.", "SSN ERROR");
                        }
                        else
                            isSSN = true;
                    }
                    else
                    {
                        isWrong = true;
                        MessageBox.Show("You don't have SSN so please write it.", "SSN ERROR");
                    }
                }

            //Credit
            if (!isCredit)
                if (!isWrong)
                {
                    if (txt_ticketCredit.Text != "")
                    {
                        if (!(Regex.IsMatch(txt_ticketCredit.Text, "\\A[0-9]{11}\\z")))
                        {
                            isWrong = true;
                            MessageBox.Show("You don't have Credit Card Number so please write it.", "Credit Card Number ERROR");
                        }
                        else
                            isCredit = true;
                    }
                    else
                    {
                        isWrong = true;
                        MessageBox.Show("You don't have Credit Card Number so please write it.", "Credit Card Number ERROR");
                    }
                }

            //Mobile Number
            if (isMobile == false)
                if (!isWrong)
                {
                    if (txt_ticketMobile.Text != "")
                    {
                        if (!(Regex.IsMatch(txt_ticketMobile.Text, "\\A[0-9]{11}\\z")))
                        {
                            isWrong = true;
                            MessageBox.Show("You don't have Mobile Number so please write it.", "Mobile Number ERROR");
                        }
                        else
                            isMobile = true;
                    }
                    else
                    {
                        isWrong = true;
                        MessageBox.Show("You don't have Mobile Number so please write it.", "Mobile Number ERROR");
                    }
                }

            if (isWrong == false)
            {
                cmd.ExecuteNonQuery();
                if (chk_member.Checked)
                    insertMember();
                updateFlightSeats(fID);
                
                MessageBox.Show("You've reserved a flight ticket successfully :)");
                
                if(!person.hasMobile)
                    updateMissingPassengerData(txt_ticketMobile.Text, 'm');
                if(!person.hasSSN)
                    updateMissingPassengerData(txt_ticketSSN.Text, 's');
                if(!person.hasCredit)
                    updateMissingPassengerData(txt_ticketCredit.Text, 'c');
            }
        }

        private void updateMissingPassengerData(string value, char obj)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = MyConnection;
            string cmdstr = "";
            if (obj == 'm')
            {
                cmdstr = "insert into passenger_mobile_number values (:uname, :mob)";
                cmd.CommandText = cmdstr;
                cmd.Parameters.Add("uname", person.username);
                cmd.Parameters.Add("mob", value);
                cmd.ExecuteNonQuery();
                person.hasMobile = true;
            }
            else if (obj == 's')
            {
                cmdstr = "update passengers set ssn = :ssn where username = :uname";
                cmd.CommandText = cmdstr;
                cmd.Parameters.Add("ssn", value);
                cmd.Parameters.Add("uname", person.username);
                cmd.ExecuteNonQuery();
                person.hasSSN = true;
            }
            else if (obj == 'c')
            {
                cmdstr = "update passengers set creditcardnumber = :credit where username = :uname";
                cmd.CommandText = cmdstr;
                cmd.Parameters.Add("credit", value);
                cmd.Parameters.Add("uname", person.username);
                cmd.ExecuteNonQuery();
                person.hasCredit = true;
            }
        }
        private void updateFlightSeats(int fID)
        {
            //---------- A.6.2. Update using procedures ----------\\
            OracleCommand cmd=new OracleCommand();
            cmd.Connection = MyConnection;
            cmd.CommandText = "update_flight_seats";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("FlightId", fID);
            cmd.ExecuteNonQuery();
        }

        //Reserving a ticket for a member
        private void insertMember()
        {
            //---------- A.3.1 Insert rows (without using procedures) ----------\\
            bool isWrong = false;
            int TicketId = getTicketID();
            //First Name
            if (!(isWrong) && txt_memFName.Text == "")
            {
                isWrong = true;
                MessageBox.Show("First Name is empty. Please, Try Again!.", "First Name ERROR");
            }

            //Last Name
            if (!(isWrong) && txt_memLName.Text == "")
            {
                isWrong = true;
                MessageBox.Show("Last Name is empty. Please, Try Again!.", "Last Name ERROR");
            }

            //SSN
            if (txt_memSSN.Text != "")
                if (!isWrong && !(Regex.IsMatch(txt_memSSN.Text, "\\A[0-9]{14}\\z")))
                {
                    isWrong = true;
                    MessageBox.Show("You have entered the SSN in incorrect format. Please, Try Again!.", "SSN ERROR");
                }
            
            //Mobile Number
            if(!isWrong)
                if (txt_memNumber.Text == "" || !(Regex.IsMatch(txt_memNumber.Text, "\\A[0-9]{11}\\z")) || txt_memNumber.Text[0] != '0' || txt_memNumber.Text[1] != '1')
                {
                    isWrong = true;
                    MessageBox.Show("You have entered the Mobile Number in incorrect format. Please, Try Again!.", "Mobile Number ERROR");
                }
            if (!isWrong)
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = MyConnection;
                cmd = new OracleCommand();
                cmd.Connection = MyConnection;
                cmd.CommandText = "insert into Members values(:ssn,:UserName,:MobileNum,:FirstName,:LastName)";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("ssn", txt_memSSN.Text);
                cmd.Parameters.Add("UserName", person.username);
                cmd.Parameters.Add("MobileNum", txt_memNumber.Text);
                cmd.Parameters.Add("FirstName", txt_memFName.Text);
                cmd.Parameters.Add("LastName", txt_memLName.Text);
                cmd.ExecuteNonQuery();
            }
        }
        //Get last ticket ID from DB
        private int getTicketID()
        {
            //---------- A.4. Select ONE row from DB using stored procedures ----------\\
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = MyConnection;
            cmd.CommandText = "GetIDTicket";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("TicketId", OracleDbType.Int32, ParameterDirection.Output);
            cmd.ExecuteNonQuery();
            int MaxId, NewId;
            try
            {
                MaxId = Convert.ToInt32(cmd.Parameters["TicketId"].Value.ToString());
                NewId = MaxId + 1;
            }
            catch { NewId = 1; }
            return NewId;
        }

        //Reserve for a member Panel
        private void chk_member_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_member.Checked)
                pnl_member.Show();
            else
                pnl_member.Hide();
        }

        private void lbl_ticketBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserForm userForm = new UserForm(person);
            userForm.ShowDialog();
            this.Close();
        }

        //Get flight ID
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                flightID = row.Cells["ID"].Value.ToString();
        }

        private void TicketsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MyConnection.Dispose();
        }

        private void chk_flightDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_flightDate.Checked)
            {
                needDate = true;
                dateTimePicker_FlightDate.Show();
            }
            else
            {
                needDate = false;
                dateTimePicker_FlightDate.Hide();
            }
        }
    }
}
