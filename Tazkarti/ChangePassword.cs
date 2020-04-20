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
    public partial class ChangePassword : Form
    {
        OracleConnection conn;
        string ordb = "Data Source = orcl; User ID = hr; Password = hr;";
        Person person;

        public ChangePassword(Person person)
        {
            InitializeComponent();
            this.person = person;
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void btn_CPass_Click(object sender, EventArgs e)
        {
            //--------- A.3.2. Update without Procedures ----------\\
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            if (txt_newPass.Text == txt_conPass.Text && txt_newPass.Text != "")
            {
                if (!person.isAdmin)
                    cmd.CommandText = "UPDATE Passengers SET Password = :pw WHERE Username = :uname";
                else
                    cmd.CommandText = "UPDATE Administrators SET Password = :pw WHERE Username = :uname";

                cmd.Parameters.Add("pw", txt_newPass.Text);
                cmd.Parameters.Add("uname", person.username);

                int r = cmd.ExecuteNonQuery();
                if (r != -1)
                    MessageBox.Show("New Password had successfully changed :)", "Password Change");
            }
            else
                MessageBox.Show("Please enter the password correctly", "Wrong Password");

            this.Close();
        }
    }
}
