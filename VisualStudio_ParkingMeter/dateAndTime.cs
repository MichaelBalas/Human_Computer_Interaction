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
    public partial class dateAndTime : UserControl
    {
        public dateAndTime()
        {
            InitializeComponent();
        }

        private void dateAndTime_Load(object sender, EventArgs e)
        {
            masterTimer.Start();
            date.Text = DateTime.Now.ToLongDateString();
            time.Text = DateTime.Now.ToShortTimeString();
        }

        private void masterTimer_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToShortTimeString();
            masterTimer.Start();
        }
    }
}
