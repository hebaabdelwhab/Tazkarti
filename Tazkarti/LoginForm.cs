using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Tazkarti
{
    public partial class LoginForm : Form
    {
        string ordb = "Data Source = orcl; User ID = hr; Password = hr;";
        OracleConnection conn;
        Person person;
        Constraints constraint;

        public LoginForm()
        {
            InitializeComponent();
            conn = new OracleConnection(ordb);
            conn.Open();
            constraint = new Constraints();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //Login Panel
            pnl_login.BackColor = Color.FromArgb(100, 0, 0, 0);
            lbl_loginUsername.BackColor = Color.FromArgb(0, 0, 0, 0);
            lbl_loginPassword.BackColor = Color.FromArgb(0, 0, 0, 0);

            //Register Panel
            pnl_register.Hide();
            pnl_register.BackColor = Color.FromArgb(100, 0, 0, 0);
            lbl_regEmail.BackColor = Color.FromArgb(0, 0, 0, 0);
            lbl_regFName.BackColor = Color.FromArgb(0, 0, 0, 0);
            lbl_regLName.BackColor = Color.FromArgb(0, 0, 0, 0);
            lbl_regUsername.BackColor = Color.FromArgb(0, 0, 0, 0);
            lbl_regPassword.BackColor = Color.FromArgb(0, 0, 0, 0);
            lbl_regConPassword.BackColor = Color.FromArgb(0, 0, 0, 0);
            lbl_regSSN.BackColor = Color.FromArgb(0, 0, 0, 0);
            lbl_regCredit.BackColor = Color.FromArgb(0, 0, 0, 0);
            lbl_regNumber.BackColor = Color.FromArgb(0, 0, 0, 0);
            
            label1.BackColor = Color.FromArgb(0, 0, 0, 0);
            label2.BackColor = Color.FromArgb(0, 0, 0, 0);
            label3.BackColor = Color.FromArgb(0, 0, 0, 0);
            label4.BackColor = Color.FromArgb(0, 0, 0, 0);
            label5.BackColor = Color.FromArgb(0, 0, 0, 0);

            lbl_registerBack.BackColor = Color.FromArgb(0, 0, 0, 0);
            txt_loginMob2.Hide();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            //Login Button
            string uname = txt_loginUsername.Text.ToLower(); //USERNAME IS IN LOWERCASE HERE AND IN DATABASE...
            
            //check username and password validity
            if (checkLogin(uname, txt_loginPassword.Text))
            {
                hasSSN = checkSSN(uname);
                hasCredit = checkCredit(uname);
                hasMobile = checkMobile(uname);
                person = new Person(uname, txt_loginPassword.Text, false, hasSSN, hasCredit, hasMobile);
                gotoUserForm();
            }
            else if (checkAdmin(uname, txt_loginPassword.Text))
            {
                person = new Person(uname, txt_loginPassword.Text, true, false, false,false);
                gotoAdminForm();
            }
            else
                MessageBox.Show("Invalid username or password!", "Login Validaty");
        }

        //Check SSN
        private bool checkSSN(string uname)
        {
            //---------- A.2. Select one or more rows from DB using bind variables and command parameters ----------\\
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT COUNT(SSN) FROM Passengers WHERE Username = :uname";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("uname", uname);
            int rowCount = Convert.ToInt32(cmd.ExecuteScalar());
            if (rowCount > 0)
                return true; //There's a SSN for this Username
            return false;
        }

        //Check Credit Card Number
        private bool checkCredit(string uname)
        {
            //---------- A.2. Select one or more rows from DB using bind variables and command parameters ----------\\
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT COUNT(CreditCardNumber) FROM Passengers WHERE Username = :uname";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("uname", uname);
            int rowCount = Convert.ToInt32(cmd.ExecuteScalar());
            if (rowCount > 0)
                return true; //There's a Credit Card Number for this Username
            return false;
        }

        //Check Mobile Number
        private bool checkMobile(string uname)
        {
            //---------- A.2. Select one or more rows from DB using bind variables and command parameters ----------\\
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT COUNT(PMobile_Number) FROM Passenger_Mobile_Number WHERE PUsername = :uname";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("uname", uname);
            int rowCount = Convert.ToInt32(cmd.ExecuteScalar());
            if (rowCount > 0)
                return true; //There's a Mobile Number for this Username
            return false;
        }

        //Check administration
        private bool checkAdmin(string uname, string password)
        {
            //---------- A.2. Select one or more rows from DB using bind variables and command parameters ----------\\
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT COUNT(*) FROM Administrators WHERE Username = :uname AND Password = :pw";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("uname", uname);
            cmd.Parameters.Add("pw", txt_loginPassword.Text);
            int rowCount = Convert.ToInt32(cmd.ExecuteScalar());
            if (rowCount > 0)
                return true; //There's a row in Administrators table matches with this Username
            return false;
        }

        //Check username and password
        private bool checkLogin(string uname, string password)
        {
            //---------- A.2. Select one or more rows from DB using bind variables and command parameters ----------\\
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT COUNT(*) FROM Passengers WHERE Username = :uname AND Password = :pass";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("uname", uname);
            cmd.Parameters.Add("pass", password);
            int rowCount = Convert.ToInt32(cmd.ExecuteScalar());
            if (rowCount > 0)
                return true; //There's a row in Passengers table matches with this Username and Password
            return false;
        }

        //If the user wants to add second mobile number during registeration
        bool secondMob = false; 
        private void btn_loginAddMob_Click(object sender, EventArgs e)
        {
            string mobileNumber = txt_loginMob1.Text;

            //Check mobile number 1..
            if (mobileNumber != "" && Regex.IsMatch(mobileNumber, "\\A[0-9]{11}\\z") && mobileNumber[0] == '0' && mobileNumber[1] == '1')
            {
                txt_loginMob2.Show();
                secondMob = true; //Can have second number
            }
            else
                MessageBox.Show("You have entered the Mobile Number in incorrect format. Please, Try Again!.", "Mobile Number ERROR");
        }

        //If the user doesn't have an account
        private void btn_Register_Click(object sender, EventArgs e)
        {
            pnl_login.Hide();
            pnl_register.Show();
        }

        //Register Button
        bool hasSSN = false;
        bool hasCredit = false;
        bool hasMobile = false;
        private void btn_registerReg_Click(object sender, EventArgs e)
        {
            bool isWrong = false;

            //Check First Name
            string firstName = txt_regFName.Text;
            if (!(isWrong) && firstName == "")
            {
                isWrong = true;
                MessageBox.Show("First Name is empty. Please, Try Again!.", "First Name ERROR");
            }

            //Check Last Name
            string lastName = txt_regLName.Text;
            if (!(isWrong) && lastName == "")
            {
                isWrong = true;
                MessageBox.Show("Last Name is empty. Please, Try Again!.", "Last Name ERROR");
            }

            //Check Username
            string username = txt_regUsername.Text.ToLower();
            if (!isWrong)
                if(username == "" || checkUsername(username) == false)
                {
                    isWrong = true;
                    MessageBox.Show("You have entered invalid Username. Please, Try Again!.", "Username ERROR");
                }

            //Check Email
            string email = txt_regEmail.Text.ToLower();
            if (!isWrong && email != "")
            {
                if (!constraint.checkEmail(email))
                {
                    isWrong = true;
                    MessageBox.Show("You have entered the Email Address in incorrect format. Please, Try Again!.", "Email Address ERROR");
                }
            }

            //Check Password
            if (!isWrong)
                if (txt_regPassword.Text != txt_regConPassword.Text || txt_regPassword.Text == "")
                {
                    isWrong = true;
                    MessageBox.Show("You have entered wrong Passwords. Please, Try Again!.", "Password ERROR");
                }

            //Check SSN
            string ssn = txt_regSSN.Text;
            if (ssn != "")
                if (!isWrong && !constraint.checkSSN(ssn))
                {
                    isWrong = true;
                    MessageBox.Show("You have entered the SSN in incorrect format. Please, Try Again!.", "SSN ERROR");
                }
                else
                    hasSSN = true;

            //Check Credit Card Number
            string credit = txt_regCredit.Text;
            if (credit != "")
                if (!isWrong && !constraint.checkCredit(credit))
                {
                    isWrong = true;
                    MessageBox.Show("You have entered the Credit Card Number in incorrect format. Please, Try Again!.", "Credit Card Number ERROR");
                }
                else
                    hasCredit = true;

            //Check Second Mobile Number
            if (secondMob)
            {
                string mobileNumber = txt_loginMob2.Text;
                if(mobileNumber!="" && !isWrong)
                    if (!constraint.checkMobile(mobileNumber))
                    {
                        isWrong = true;
                        MessageBox.Show("You have entered the second Mobile Number in incorrect format. Please, Try Again!.", "Mobile Number ERROR");
                    }
            }
           
            if(!isWrong)
            {
                savePassenger(username,email, txt_regPassword.Text, firstName, lastName, credit, ssn);
                savePassengerMobile(txt_loginMob1.Text,txt_loginMob2.Text);
                gotoUserForm();
             }
        }

        //Check Username Validaty
        private bool checkUsername(string uname)
        {
            //---------- A.2. Select one or more rows from DB using bind variables and command parameters ----------\\
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT COUNT(*) FROM Passengers WHERE Username = :uname";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("uname", uname);
            int rowCount = Convert.ToInt32(cmd.ExecuteScalar());
            if (rowCount > 0)
                return false;
            return true;
        }

        //Save the passenger in the DB
        private void savePassenger(string uname, string email,string pass,string fname,string lname,string credit,string ssn)
        {
            //---------- A.3.1. Insert rows (without using procedures) ----------\\
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            string cmdstr = "INSERT INTO Passengers VALUES (:uname, :email, :password, :fname, :lname, :credit, :ssn)";
            cmd.CommandText = cmdstr;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("uname", uname);
            cmd.Parameters.Add("email", email);
            cmd.Parameters.Add("password", pass);
            cmd.Parameters.Add("fname", fname);
            cmd.Parameters.Add("lname", lname);
            cmd.Parameters.Add("credit", credit);
            cmd.Parameters.Add("ssn", ssn);
            cmd.ExecuteNonQuery();
            person = new Person(uname, pass, false, hasSSN, hasCredit, hasMobile);
            MessageBox.Show("You have been registered successfully! :)", "Registeration");
        }

        //Save passenger mobile numbers in DB
        private void savePassengerMobile(string mob1, string mob2)
        {
            //---------- A.6.1. Insert rows using stored procedures ----------\\
            if (mob1 != "")
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "save_mobile_number";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("uname", person.username);
                cmd.Parameters.Add("mob_number", mob1);
                cmd.ExecuteNonQuery(); 
            }

            if (mob2 != "")
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "save_mobile_number";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("uname", person.username);
                cmd.Parameters.Add("mob_number", mob2);
                cmd.ExecuteNonQuery(); 
            }
        }

        private void gotoAdminForm()
        {
            this.Hide();
            AdminForm adminForm = new AdminForm(person);
            adminForm.ShowDialog();
            this.Close();
        }

        private void gotoUserForm()
        {
            this.Hide();
            UserForm userForm = new UserForm(person);
            userForm.ShowDialog();
            this.Close();
        }

        //Register back button
        private void lbl_registerBack_Click(object sender, EventArgs e)
        {
            pnl_register.Hide();
            pnl_login.Show();
        }
    }
}