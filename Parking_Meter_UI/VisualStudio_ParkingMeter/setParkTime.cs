using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingMeter
{
    public partial class setParkTime : UserControl
    {
        public setParkTime()
        {
            InitializeComponent();
            paymentMethod.Hide();
            /*
            double ratePerMinute = 0.10;
            int nextHour = ((DateTime.Now.Hour + 11) % 12) + 2;
            if (nextHour == 13) { nextHour = 1; }
            if (nextHour < 10)
            {
                hours.Text = "0" + nextHour.ToString();
            } else
            {
                hours.Text = nextHour.ToString();
            }
            if (DateTime.Now.ToString("tt") == "PM") { toggleAmPm.Text = "PM"; }
            // Update price and countdown
            var dt2 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, Convert.ToInt32(hours.Text), Convert.ToInt32(minutes.Text), 0);
            if (toggleAmPm.Text == "PM") { dt2 = dt2.AddHours(12); }
            DateTime dt = DateTime.Now;
            TimeSpan ts = (dt2 - dt);
            countdown.Text = Math.Abs(ts.Hours).ToString() + " hours and " + (Math.Abs(ts.Minutes)+1).ToString() + " minutes.";
            double totalDif = Math.Abs(ratePerMinute * (ts.Hours*60 + ts.Minutes));
            updatePriceToPay(totalDif);
            price.Text = "$" + totalDif.ToString("n");
            */

            // Changing "Parking Until..." Time event handlers
            hours.TextChanged += new System.EventHandler(this.hours_TextChanged);
            minutes.TextChanged += new System.EventHandler(this.minutes_TextChanged);
            
        }

        public void nextHour(int hour, string meridium, DateTime dt2)
        {
            double ratePerMinute = 0.10;
            if (hour < 10)
            {
                hours.Text = "0" + hour.ToString();
            }
            else
            {
                hours.Text = hour.ToString();
            }
            if (meridium == "PM") { toggleAmPm.Text = "PM"; }
            DateTime dt = DateTime.Now;
            TimeSpan ts = (dt2 - dt);
            countdown.Text = Math.Abs(ts.Hours).ToString() + " hours and " + (Math.Abs(ts.Minutes) + 1).ToString() + " minutes.";
            double totalDif = Math.Abs(ratePerMinute * (ts.Hours * 60 + ts.Minutes));
            updatePriceToPay(totalDif);
            price.Text = "$" + totalDif.ToString("n");

            DateTime expire = DateTime.Now + new TimeSpan(Math.Abs(ts.Hours), (Math.Abs(ts.Minutes) + 1), 0);
            string exp = expire.ToString("ddd") + ", " + expire.ToString("MMM") + " " + expire.Day.ToString();
            expireTicket(expire.ToShortTimeString() + " " + expire.ToShortDateString());
            todayOrTmrw.Text = exp;

            // Changing "Parking Until..." Time event handlers
            hours.TextChanged += new System.EventHandler(this.hours_TextChanged);
            minutes.TextChanged += new System.EventHandler(this.minutes_TextChanged);
        }

        private void hours_TextChanged(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            double ratePerMinute = 0.10;
            var dt2 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, Convert.ToInt32(hours.Text), Convert.ToInt32(minutes.Text), 0);
            if (toggleAmPm.Text == "PM")
            {
                if (dt2.Hour != 12) { dt2 = dt2.AddHours(12); }
            } else
            {
                if (dt2.Hour == 12) { dt2 = dt2.AddHours(12);  }
            }
            if (dt.Hour >= dt2.Hour && dt.Minute >= dt2.Minute) { dt2 = dt2.AddHours(24); }
            TimeSpan ts = (dt2 - dt);
            countdown.Text = Math.Abs(ts.Hours).ToString() + " hours and " + (Math.Abs(ts.Minutes) + 1).ToString() + " minutes.";
            double totalDif = Math.Abs(ratePerMinute * (ts.Hours * 60 + ts.Minutes));
            updatePriceToPay(totalDif);
            price.Text = "$" + totalDif.ToString("n");

            DateTime expire = DateTime.Now + new TimeSpan(Math.Abs(ts.Hours), (Math.Abs(ts.Minutes) + 1), 0);
            string exp = expire.ToString("ddd") + ", " + expire.ToString("MMM") + " " + expire.Day.ToString();
            expireTicket(expire.ToShortTimeString() + " " + expire.ToShortDateString());
            todayOrTmrw.Text = exp;
        }

        private void minutes_TextChanged(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            double ratePerMinute = 0.10;
            var dt2 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, Convert.ToInt32(hours.Text), Convert.ToInt32(minutes.Text), 0);
            if (toggleAmPm.Text == "PM")
            {
                if (dt2.Hour != 12) { dt2 = dt2.AddHours(12); }
            }
            else
            {
                if (dt2.Hour == 12) { dt2 = dt2.AddHours(12); }
            }
            if (dt.Hour >= dt2.Hour && dt.Minute >= dt2.Minute) { dt2 = dt2.AddHours(24); }
            TimeSpan ts = (dt2 - dt);
            countdown.Text = Math.Abs(ts.Hours).ToString() + " hours and " + (Math.Abs(ts.Minutes) + 1).ToString() + " minutes.";
            double totalDif = Math.Abs(ratePerMinute * (ts.Hours * 60 + ts.Minutes));
            updatePriceToPay(totalDif);
            price.Text = "$" + totalDif.ToString("n");

            DateTime expire = DateTime.Now + new TimeSpan(Math.Abs(ts.Hours), (Math.Abs(ts.Minutes) + 1), 0);
            string exp = expire.ToString("ddd") + ", " + expire.ToString("MMM") + " " + expire.Day.ToString();
            expireTicket(expire.ToShortTimeString() + " " + expire.ToShortDateString());
            todayOrTmrw.Text = exp;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void toggleAmPm_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            double ratePerMinute = 0.10;
            var dt2 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, Convert.ToInt32(hours.Text), Convert.ToInt32(minutes.Text), 0);
            if (toggleAmPm.Text == "AM") {
                toggleAmPm.Text = "PM";
                if (dt2.Hour != 12) { dt2 = dt2.AddHours(12); }
            } else
            {
                toggleAmPm.Text = "AM";
                if (dt2.Hour == 12) { dt2 = dt2.AddHours(12); }
            }
            if (dt.Hour >= dt2.Hour && dt.Minute >= dt2.Minute) { dt2 = dt2.AddHours(24); }
            TimeSpan ts = (dt2 - dt);
            countdown.Text = Math.Abs(ts.Hours).ToString() + " hours and " + (Math.Abs(ts.Minutes) + 1).ToString() + " minutes.";
            double totalDif = Math.Abs(ratePerMinute * (ts.Hours * 60 + ts.Minutes));
            updatePriceToPay(totalDif);
            price.Text = "$" + totalDif.ToString("n");

            DateTime expire = DateTime.Now + new TimeSpan(Math.Abs(ts.Hours), (Math.Abs(ts.Minutes) + 1), 0);
            string exp = expire.ToString("ddd") + ", " + expire.ToString("MMM") + " " + expire.Day.ToString();
            expireTicket(expire.ToShortTimeString() + " " + expire.ToShortDateString());
            todayOrTmrw.Text = exp;
        }

        private void increaseMinutes_Click(object sender, EventArgs e)
        {
            int min = Convert.ToInt32(minutes.Text) + 15;
            if (min > 45) { min = 0;  }
            if (min == 0)
            {
                minutes.Text = "0" + min.ToString();
            } else
            {
                minutes.Text = min.ToString();
            }
        }

        private void decreaseMinutes_Click(object sender, EventArgs e)
        {
            int min = Convert.ToInt32(minutes.Text) - 15;
            if (min < 0) { min = 45; }
            if (min == 0)
            {
                minutes.Text = "0" + min.ToString();
            } else
            {
                minutes.Text = min.ToString();
            }
        }

        private void increaseHours_Click(object sender, EventArgs e)
        {
            int hour = Convert.ToInt32(hours.Text) + 1;
            if (hour == 12)
            {
                if (toggleAmPm.Text == "AM")
                {
                    toggleAmPm.Text = "PM";
                }
                else
                {
                    toggleAmPm.Text = "AM";
                }
            }
            if (hour > 12) { hour = 1; }
            if (hour < 10)
            {
                hours.Text = "0" + hour.ToString();
            } else
            {
                hours.Text = hour.ToString();
            }
        }

        private void decreaseHours_Click(object sender, EventArgs e)
        {
            int hour = Convert.ToInt32(hours.Text) - 1;
            if (hour == 11)
            {
                if (toggleAmPm.Text == "PM")
                {
                    toggleAmPm.Text = "AM";
                }
                else
                {
                    toggleAmPm.Text = "PM";
                }
            }
            if (hour < 1) { hour = 12;  }
            if (hour < 10)
            {
                hours.Text = "0" + hour.ToString();
            }
            else
            {
                hours.Text = hour.ToString();
            }
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            paymentMethod.Show();
            paymentMethod.BringToFront();
            paymentMethod.getTimePaidFor(hours.Text.ToString(), minutes.Text.ToString(), toggleAmPm.Text.ToString());

        }
        public void updatePriceToPay(Double totalDif)
        {
            paymentMethod.updatePriceToPay(totalDif);
        }

        public void minusCash(double amt)
        {
            paymentMethod.minusCash(amt);
        }
        public void payWithCard(bool paid)
        {
            paymentMethod.payWithCard(paid);
        }
        public void insertedCard(bool inserted)
        {
            paymentMethod.insertedCard(inserted);
        }
        public void expireTicket(string expirey)
        {
            paymentMethod.expireTicket(expirey);
        }
    }
}