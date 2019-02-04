using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingMeter
{
    public partial class parkingMeter : Form
    {
        public parkingMeter()
        {
            InitializeComponent();
            this.BringToFront();
            setParkTime1.Hide();
            enterRefund.Hide();
        }

        private void payParking_Click(object sender, EventArgs e)
        {
            setParkTime1.Show();
            setParkTime1.BringToFront();
            
            // RESET TIME
            string meridium = "AM";
            int nextHour = ((DateTime.Now.Hour + 11) % 12) + 2;
            if (nextHour == 13) { nextHour = 1; }
            if (DateTime.Now.ToString("tt") == "PM") { meridium = "PM"; }
            // Update price and countdown
            var dt2 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, nextHour, 0, 0);
            if (meridium == "PM") { dt2 = dt2.AddHours(12); }
            setParkTime1.nextHour(nextHour, meridium, dt2);
        }

        private void french_Click(object sender, EventArgs e)
        {
            // Convert buttons to French
            payParking.Text = "Payer";
            refundParking.Text = "Rembourser";
            pleaseTouchScreen.Text = "Écran Tactile...";
            // Change look of french button
            french.Enabled = false;
            french.BackColor = Color.DarkSlateBlue;
            french.Font = new Font(french.Font, FontStyle.Bold);
            // Change look of english button
            english.Enabled = true;
            english.BackColor = Color.SlateBlue;
            english.Font = new Font(english.Font, FontStyle.Regular);
        }

        private void english_Click(object sender, EventArgs e)
        {
            // Convert buttons to English
            payParking.Text = "Pay for Parking";
            refundParking.Text = "Refund Parking";
            pleaseTouchScreen.Text = "Please Touch Screen...";
            // Change look of english button
            english.Enabled = false;
            english.BackColor = Color.DarkSlateBlue;
            english.Font = new Font(english.Font, FontStyle.Bold);
            // Change look of french button
            french.Enabled = true;
            french.BackColor = Color.SlateBlue;
            french.Font = new Font(french.Font, FontStyle.Regular);
        }

        public void fiveDollars_Click(object sender, EventArgs e)
        {
            setParkTime1.minusCash(5.0);
        }
        private void tenDollars_Click_1(object sender, EventArgs e)
        {
            setParkTime1.minusCash(10.0);
        }

        private void twentyDollars_Click(object sender, EventArgs e)
        {
            setParkTime1.minusCash(20.0);
        }

        private void twoDollars_Click(object sender, EventArgs e)
        {
            setParkTime1.minusCash(2.0);
        }

        private void oneDollar_Click(object sender, EventArgs e)
        {
            setParkTime1.minusCash(1.0);
        }

        private void twentyfiveCents_Click(object sender, EventArgs e)
        {
            setParkTime1.minusCash(0.25);
        }

        private void tenCents_Click(object sender, EventArgs e)
        {
            setParkTime1.minusCash(0.10);
        }

        private void fiveCents_Click(object sender, EventArgs e)
        {
            setParkTime1.minusCash(0.05);
        }

        private void tapCard_Click(object sender, EventArgs e)
        {
            setParkTime1.payWithCard(true);
        }

        private void swipeCard_Click(object sender, EventArgs e)
        {
            setParkTime1.payWithCard(true);
        }

        private void insertCard_Click(object sender, EventArgs e)
        {
            setParkTime1.insertedCard(true);
            enterRefund.insertedCard(true);
        }

        private void refundParking_Click(object sender, EventArgs e)
        {
            enterRefund.Show();
            enterRefund.BringToFront();
        }

        private void refundTicket_Click(object sender, EventArgs e)
        {
            enterRefund.insertTicket();
        }
    }
}
