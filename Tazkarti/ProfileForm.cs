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
using System.Text.RegularExpressions;

namespace Tazkarti
{
    public partial class ProfileForm : Form
    {
        OracleConnection conn;
        string ordb = "Data Source = orcl; User ID = hr; Password = hr;";
        Person person;
        Constraints constraint;

        public ProfileForm(Person person)
        {
            InitializeComponent();
            this.person = person;
            conn = new OracleConnection(ordb);
            conn.Open();
            constraint = new Constraints();
        }
        private void Profile_Load(object sender, EventArgs e)
        {
            txt_profileCCNUpd.Hide();
            txt_profileEmailUpd.Hide();
            txt_profileFNameUpd.Hide();
            txt_profileLNameUpd.Hide();
            txt_profileSSNUpd.Hide();

            if (person.hasSSN)
                lbl_SSNUpd.Hide();
            string credit = "";
            string email = "";
            string username = "";
            string fname = "";
            string lname = "";
            string ssn = "";
            //--------- A.2. Select using where ----------\\
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select email ,firstname, lastname, creditcardnumber, ssn " +
                "from passengers where username = :user1";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("user1", person.username);
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                credit = dr[3].ToString();
                email = dr[0].ToString();
                fname = dr[1].ToString();
                lname = dr[2].ToString();
                ssn = dr[4].ToString();
            }
            dr.Close();
            username = person.username;

            lbl_profileCredit.Text = credit;
            lbl_profileFName.Text = fname;
            lbl_profileLName.Text = lname;
            lbl_profileSSN.Text = ssn;
            lbl_profileUsername.Text = username;
            lbl_profileEmail.Text = email;

            txt_profileCCNUpd.Text = credit;
            txt_profileFNameUpd.Text = fname;
            txt_profileLNameUpd.Text = lname;
            txt_profileSSNUpd.Text = ssn;
            txt_profileEmailUpd.Text = email;
        }
        private void Profile_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }
        private void lbl_profileBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserForm userForm = new UserForm(person);
            userForm.ShowDialog();
            this.Close();
        }
        private void lblUpdate_Click(object sender, EventArgs e)
        {
            changeColor();
            Label lbl = (Label)sender;
            if (lbl.Name == "lbl_FNameUpd")
            {
                txt_profileFNameUpd.Show();
                txt_profileFNameUpd.BackColor = Color.White;
            }
            else if (lbl.Name == "lbl_LNameUpd")
            {
                txt_profileLNameUpd.Show();
                txt_profileLNameUpd.BackColor = Color.White;
            }
            else if (lbl.Name == "lbl_EmailUpd")
            {
                txt_profileEmailUpd.Show();
                txt_profileEmailUpd.BackColor = Color.White;
            }
            else if (lbl.Name == "lbl_CreditUpd")
            {
                txt_profileCCNUpd.Show();
                txt_profileCCNUpd.BackColor = Color.White;
            }
            else if (lbl.Name == "lbl_SSNUpd")
            {
                txt_profileSSNUpd.Show();
                txt_profileSSNUpd.BackColor = Color.White;
            }
        }
        private void changeColor()
        {
            txt_profileFNameUpd.BackColor = Color.FromArgb(163, 185, 173);
            txt_profileLNameUpd.BackColor = Color.FromArgb(163, 185, 173);
            txt_profileEmailUpd.BackColor = Color.FromArgb(163, 185, 173);
            txt_profileSSNUpd.BackColor = Color.FromArgb(163, 185, 173);
            txt_profileCCNUpd.BackColor = Color.FromArgb(163, 185, 173);
        }
        private void lbl_profileCP_Click(object sender, EventArgs e)
        {
            ChangePassword cp = new ChangePassword(person);
            cp.ShowDialog();
        }
        private void btn_profileSave_Click(object sender, EventArgs e)
        {
            changeColor();
            bool isWrong = false;
            //Check First Name
            string firstName = txt_profileFNameUpd.Text;
            if (!(isWrong) && firstName == "")
            {
                isWrong = true;
                MessageBox.Show("First Name is empty. Please, Try Again!.", "First Name ERROR");
            }

            //Check Last Name
            string lastName = txt_profileLNameUpd.Text;
            if (!(isWrong) && lastName == "")
            {
                isWrong = true;
                MessageBox.Show("Last Name is empty. Please, Try Again!.", "Last Name ERROR");
            }

            //Check Email
            string email = txt_profileEmailUpd.Text.ToLower();
            if (!isWrong && email != "")
            {
                if (!constraint.checkEmail(email))
                {
                    isWrong = true;
                    MessageBox.Show("You have entered the Email Address in incorrect format. Please, Try Again!.", "Email Address ERROR");
                }
            }

            //Check SSN
            string ssn = txt_profileSSNUpd.Text;
            if (ssn != "")
                if (!isWrong && !constraint.checkSSN(ssn))
                {
                    isWrong = true;
                    MessageBox.Show("You have entered the SSN in incorrect format. Please, Try Again!.", "SSN ERROR");
                }

            //Check Credit Card Number
            string credit = txt_profileCCNUpd.Text;
            if (credit != "")
                if (!isWrong && !constraint.checkCredit(credit))
                {
                    isWrong = true;
                    MessageBox.Show("You have entered the Credit Card Number in incorrect format. Please, Try Again!.", "Credit Card Number ERROR");
                }

            if (!isWrong)
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE Passengers SET FirstName = :fname, " +
                    "LastName = :lname, Email = :emaill, CreditCardNumber = :ccn, " +
                    "SSN = :ssn WHERE Username = :uname";
                cmd.Parameters.Add("fname", txt_profileFNameUpd.Text);
                cmd.Parameters.Add("lname", txt_profileLNameUpd.Text);
                cmd.Parameters.Add("emaill", txt_profileEmailUpd.Text);
                cmd.Parameters.Add("ccn", txt_profileCCNUpd.Text);
                cmd.Parameters.Add("ssn", txt_profileSSNUpd.Text);
                cmd.Parameters.Add("uname", person.username);
                int r = cmd.ExecuteNonQuery();
                if (r != -1)
                    MessageBox.Show("Updated successfully!!");
            }
        }
        private void ProfileForm_Click(object sender, EventArgs e)
        {
            changeColor();
        }
        private void txt_profileUpd_Click(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            changeColor();
            tb.BackColor = Color.White;
        }
    }
}
