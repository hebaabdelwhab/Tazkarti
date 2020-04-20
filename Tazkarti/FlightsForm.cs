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
    public partial class FlightsForm : Form
    {
        string constr = "Data Source=orcl; User Id=hr; Password=hr;";
        Person person;
        OracleConnection Myconnection;

        public FlightsForm(Person person)
        {
            InitializeComponent();
            this.person = person;
            Myconnection = new OracleConnection(constr);
            Myconnection.Open();
        }

        private void FlightsForm_Load(object sender, EventArgs e)
        {
            insertDataGridView();
        }

        private void insertDataGridView()
        {
            //---------- A.1. Select without where ----------\\
            string cmdstr = "SELECT f.FlightID, ap.AirplaneName, f.Departure, f.Destination," +
                "f.TotalSeats, f.AvailableSeats, f.Company_Name, f.Price, f.DepartureTime, f.ArrivalTime" +
                " from Airplanes ap, Flights f WHERE f.Airplane_ID = ap.AirplaneID";
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = Myconnection;
            cmd.CommandText = cmdstr;
            OracleDataReader rd = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(rd);
            dataGridView1.DataSource = dt;
            rd.Close();

            pnl_updateFlight.Hide();
        }
        private int GetFlightID()
        {
            int MaxId, NewId;
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = Myconnection;
            cmd.CommandText = "GetFlightID";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("id", OracleDbType.Int32, ParameterDirection.Output);
            cmd.ExecuteNonQuery();
            try
            {
                MaxId = Convert.ToInt32(cmd.Parameters["id"].Value.ToString());
                NewId = MaxId + 1;
            }
            catch { NewId = 1; }
            return NewId;
        }

        private void btn_insertFlight_Click(object sender, EventArgs e)
        {
            //---------- A.3.1. Insert without using procedures ----------\\
            try
            {
                if (txt_flightAirplane.Text != "" && txt_flightCompany.Text != "" && txt_flightDep.Text != "" && txt_flightDest.Text != "" && txt_flightPrice.Text != "" && txt_flightSeats.Text != "")
                {
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = Myconnection;
                    cmd.CommandText = "INSERT INTO Flights VALUES ( :PflightId, :ptotalseats, :AvailableSeats, " +
                    ":ArrivalTime, :PdepartureTime, :Destination, :Departure, :Pprice, :companyName, :PAirPlane, " +
                    ":FlightDate)";
                    cmd.CommandType = CommandType.Text;

                    int FlightId = GetFlightID();
                    int TotalSeats = Convert.ToInt32(txt_flightSeats.Text);
                    int AvailableSeats = Convert.ToInt32(txt_flightSeats.Text);
                    DateTime ArrivalTime = dtpkr_FlightArrTime.Value.Date;
                    DateTime DepartureTime = dtpkr_FlightDepTime.Value.Date;
                    string Destination = txt_flightDest.Text;
                    string Departure = txt_flightDep.Text;
                    int Price = Convert.ToInt32(txt_flightPrice.Text);
                    string Company_Name = txt_flightCompany.Text;
                    int Airplane_ID = Convert.ToInt32(txt_flightAirplane.Text);
                    DateTime FlightDate = Convert.ToDateTime(dtpkr_FlightDepTime.Text);

                    cmd.Parameters.Add("PflightId", FlightId);
                    cmd.Parameters.Add("ptotalseats", TotalSeats);
                    cmd.Parameters.Add("AvailableSeats", AvailableSeats);
                    cmd.Parameters.Add("ArrivalTime", ArrivalTime);
                    cmd.Parameters.Add("PdepartureTime", DepartureTime);
                    cmd.Parameters.Add("Destination", Destination);
                    cmd.Parameters.Add("Departure", Departure);
                    cmd.Parameters.Add("Pprice", Price);
                    cmd.Parameters.Add("companyName", Company_Name);
                    cmd.Parameters.Add("PAirPlane", Airplane_ID);
                    cmd.Parameters.Add("FlightDate", FlightDate);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Flight added successfully! :)", "Insert New Flight");
                    insertDataGridView();

                    txt_flightSeats.Text = "";
                    txt_flightSeats.Text = "";
                    txt_flightDest.Text = "";
                    txt_flightDep.Text = "";
                    txt_flightPrice.Text = "";
                    txt_flightCompany.Text = "";
                    txt_flightAirplane.Text = "";
                }
                else
                    MessageBox.Show("Enter full data to insert the flight", "Data ERROR");
            }
            catch (Exception)
            {
                MessageBox.Show("You have entered wrong data! :)", "Insert New Flight ERROR");
            }
        }

        private void btn_updateFlight_Click(object sender, EventArgs e)
        {
            //---------- A.3.2. Update without using procedures ----------\\
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = Myconnection;

            int FlightId = Convert.ToInt32(txt_flightFlightUpd.Text);
            int TotalSeats = Convert.ToInt32(txt_flightTotSeatsUpd.Text);
            int AvailableSeats = Convert.ToInt32(txt_flightAvaSeatsUpd.Text);
            string Destination = txt_flightDestUpd.Text;
            string Departure = txt_flightDepUpd.Text;
            int Price = Convert.ToInt32(txt_flightPriceUpd.Text);
            string Company_Name = txt_flightCompanyUpd.Text;
            int Airplane_ID = Convert.ToInt32(txt_flightAirplaneUpd.Text);
            DateTime FlightDate = dtpkr_flightDepUpd.Value.Date;
            DateTime DepartureTime = dtpkr_flightDepUpd.Value.Date;
            DateTime ArrivalTime = dtpkr_flightArrUpd.Value.Date;

            string Update_Flight = "Update Flights SET TotalSeats = :ptotalseats," +
                "AvailableSeats = :AvailableSeats, ArrivalTime = :ArrivalTime, DepartureTime = :PdepartureTime," +
                "Destination = :Destination, Departure = :Departure, Price = :Pprice, Company_Name = :companyName," +
                "Airplane_ID = :PAirPlane, Flight_Date = :FlightDate WHERE FlightID = :MYFlight";

            cmd.CommandText = Update_Flight;
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("ptotalseats", TotalSeats);
            cmd.Parameters.Add("AvailableSeats", AvailableSeats);
            cmd.Parameters.Add("ArrivalTime", ArrivalTime);
            cmd.Parameters.Add("PdepartureTime", DepartureTime);
            cmd.Parameters.Add("Destination", Destination);
            cmd.Parameters.Add("Departure", Departure);
            cmd.Parameters.Add("Pprice", Price);
            cmd.Parameters.Add("companyName", Company_Name);
            cmd.Parameters.Add("PAirPlane", Airplane_ID);
            cmd.Parameters.Add("FlightDate", FlightDate);
            cmd.Parameters.Add("MYFlight", FlightId);

            cmd.ExecuteNonQuery();
            
            MessageBox.Show("Flight updated successfully! :)", "Flight Update");
            insertDataGridView();
        }

        private void lbl_flightEdit_Click(object sender, EventArgs e)
        {
            if (txt_flightFlightUpd.Text != "")
                showUpdates(txt_flightFlightUpd.Text);
            else
                MessageBox.Show("Please, Enter the flight you want to update!", "Flight ID Update ERROR");
        }

        private void showUpdates(string flightID)
        {
            //---------- A.2. Select using bind variables ----------\\
            int fID = Convert.ToInt32(flightID);
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = Myconnection;

            cmd.CommandText = "SELECT TotalSeats, AvailableSeats, ArrivalTime, DepartureTime, Destination," +
                "Departure, Price, Company_Name, Airplane_ID FROM Flights WHERE FlightID = :flightid1";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("flightid1", fID);
            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                dtpkr_flightDepUpd.Value = Convert.ToDateTime(dr[3].ToString());
                txt_flightTotSeatsUpd.Text = dr[0].ToString();
                txt_flightAvaSeatsUpd.Text = dr[1].ToString();
                dtpkr_flightArrUpd.Value = Convert.ToDateTime(dr[2].ToString());
                txt_flightDestUpd.Text = dr[4].ToString();
                txt_flightDepUpd.Text = dr[5].ToString();
                txt_flightPriceUpd.Text = dr[6].ToString();
                txt_flightCompanyUpd.Text = dr[7].ToString();
                txt_flightAirplaneUpd.Text = dr[8].ToString();
                pnl_updateFlight.Show();
            }
            else
                MessageBox.Show("Please, Enter the flight you want to update!", "Flight ID Update ERROR");

            dr.Close();
        }

        private void lbl_flightDelete_Click(object sender, EventArgs e)
        {
            //---------- A.3.3. Delete without using procedures ----------\\
            if (txt_flightFlightUpd.Text != "")
            {
                int FlightId = Convert.ToInt32(txt_flightFlightUpd.Text);
                string delete_flight = "DELETE Flights WHERE FlightID = :my_flight";
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = Myconnection;
                cmd.CommandText = delete_flight;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("my_flight", FlightId);
                int r = cmd.ExecuteNonQuery();

                if (r != -1)
                {
                    MessageBox.Show("Flight deleted successfully! :)", "Flight Delete");
                    insertDataGridView();
                }
                else
                    MessageBox.Show("Please, Enter the flight you want to delete!", "Flight ID Delete ERROR");
            }
            else
                MessageBox.Show("Please, Enter the flight you want to delete!", "Flight ID Delete ERROR");
        }

        private void lbl_flightBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm adminForm = new AdminForm(person);
            adminForm.ShowDialog();
            this.Close();
        }

        private void Btn_flightsShowReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            FlightsReportForm TheFlightReport = new FlightsReportForm(person);
            TheFlightReport.ShowDialog();
            this.Close();
        }
    }
}
