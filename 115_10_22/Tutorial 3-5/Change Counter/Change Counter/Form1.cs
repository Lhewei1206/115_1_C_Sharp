using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Change_Counter
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void fiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            const decimal FIVE_CENTS = 5m;
            decimal total = totalLabel.Text == "" ? 0.0m : decimal.Parse(totalLabel.Text, System.Globalization.NumberStyles.Currency);
            total = total + FIVE_CENTS;
            totalLabel.Text = total.ToString("C");
           
        }

        private void tenCentsPictureBox_Click(object sender, EventArgs e)
        {
            const decimal TEN_CENTS = 10m;    
            decimal total = totalLabel.Text == "" ? 0.0m : decimal.Parse(totalLabel.Text, System.Globalization.NumberStyles.Currency);
            total = total + TEN_CENTS;
            totalLabel.Text = total.ToString("C");  
        }

        private void twentyFiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            const decimal TWENTY_FIVE_CENTS = 25m;
            decimal total = totalLabel.Text == "" ? 0.0m : decimal.Parse(totalLabel.Text, System.Globalization.NumberStyles.Currency);
            total = total + TWENTY_FIVE_CENTS;
            totalLabel.Text = total.ToString("C");
        }

        private void fiftyCentsPictureBox_Click(object sender, EventArgs e)
        {
            const decimal FIFTY_CENTS = 50m;
            decimal total = totalLabel.Text == "" ? 0.0m : decimal.Parse(totalLabel.Text, System.Globalization.NumberStyles.Currency);
            total = total + FIFTY_CENTS;
            totalLabel.Text = total.ToString("C");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void totalLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            totalLabel.Text = "";
        }
    }
}
