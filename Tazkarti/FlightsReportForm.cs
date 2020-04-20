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
    public partial class FlightsReportForm : Form
    {
        FlightsReport CR;
        Person person;

        public FlightsReportForm(Person person)
        {
            InitializeComponent();
            this.person = person;

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FlightsReportForm_Load(object sender, EventArgs e)
        {
            CR = new FlightsReport();
            foreach (ParameterDiscreteValue v in CR.ParameterFields[0].DefaultValues)
                CMB_CompanyName.Items.Add(v.Value);
            foreach (ParameterDiscreteValue v in CR.ParameterFields[1].DefaultValues)
                CMB_FlightDate.Items.Add(v.Value);
        }

        private void BTN_ShowReport_Click(object sender, EventArgs e)
        {
            CR.SetParameterValue(0, CMB_CompanyName.Text);
            CR.SetParameterValue(1, CMB_FlightDate.Text);
            crystalReportViewer1.ReportSource = CR;
        }

        private void lbl_passenegerBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FlightsForm ff = new FlightsForm(person);
            ff.ShowDialog();
            this.Close();
        }
    }

}
