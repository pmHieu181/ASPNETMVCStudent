using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketVendorMachine.Models;


namespace TicketVendorMachine
{
    public partial class SelectPaymentForm : Form
    {
        string fromStation, toStation;
        int fare;

        public SelectPaymentForm(string from, string to, int fare)
        {
            InitializeComponent();
            fromStation = from;
            toStation = to;
            this.fare = fare;
        }

        private void SelectPaymentForm_Load(object sender, EventArgs e)
        {
            lblFrom.Text = "From: " + fromStation;
            lblTo.Text = "To: " + toStation;
            lblFare.Text = "Fare: " + fare + " VND";
            MessageBox.Show("Form loaded!");
        }

        private void lblFrom_Click(object sender, EventArgs e)
        {

        }

        private void lblTo_Click(object sender, EventArgs e)
        {

        }

        private void lblFare_Click(object sender, EventArgs e)
        {

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            string method = cbPaymentMethod.Text;
            DatabaseHelper.SaveTicket(fromStation, toStation, fare, method);
            MessageBox.Show("Payment successful!");
        }

    }
}
