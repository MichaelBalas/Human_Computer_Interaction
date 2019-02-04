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
    public partial class promotions : UserControl
    {
        public promotions()
        {
            InitializeComponent();
            promotionComplete1.Hide();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (customMsgBox.Show("You can only take one promotional offer. Are you sure you want the deal for " + label5.Text + "?", "Print Promotion", "Yes", "", "No") == DialogResult.Yes)
            {
                promotionComplete1.Show();
                promotionComplete1.BringToFront();
                promotionComplete1.foo();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (customMsgBox.Show("You can only take one promotional offer. Are you sure you want the deal for " + label7.Text + "?", "Print Promotion", "Yes", "", "No") == DialogResult.Yes)
            {
                promotionComplete1.Show();
                promotionComplete1.BringToFront();
                promotionComplete1.foo();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (customMsgBox.Show("You can only take one promotional offer. Are you sure you want the deal for " + label9.Text + "?", "Print Promotion", "Yes", "", "No") == DialogResult.Yes)
            {
                promotionComplete1.Show();
                promotionComplete1.BringToFront();
                promotionComplete1.foo();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (customMsgBox.Show("You can only take one promotional offer. Are you sure you want the deal for " + label10.Text + "?", "Print Promotion", "Yes", "", "No") == DialogResult.Yes)
            {
                promotionComplete1.Show();
                promotionComplete1.BringToFront();
                promotionComplete1.foo();
            }
        }
    }
}
