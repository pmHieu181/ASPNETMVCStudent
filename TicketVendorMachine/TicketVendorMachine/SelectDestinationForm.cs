using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketVendorMachine.Models;

namespace TicketVendorMachine
{
    public partial class SelectDestinationForm : Form
    {
        public SelectDestinationForm()
        {
            InitializeComponent();
        }

        private void SelectDestinationForm_Load(object sender, EventArgs e)
        {
            DataTable stations = DatabaseHelper.GetStations();
            cbFrom.DataSource = stations.Copy();
            cbFrom.DisplayMember = "StationName";

            cbTo.DataSource = stations.Copy();
            cbTo.DisplayMember = "StationName";
        }
        private void btnContinue_Click(object sender, EventArgs e)
        {
            string from = cbFrom.Text;
            string to = cbTo.Text;
            int fare = DatabaseHelper.GetFare(from, to);

            SelectPaymentForm paymentForm = new SelectPaymentForm(from, to, fare);
            paymentForm.Show();
            this.Hide();
        }
    }
}
