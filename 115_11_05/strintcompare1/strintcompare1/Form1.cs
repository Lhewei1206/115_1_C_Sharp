using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace strintcompare1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompare_Click(object sender, System.EventArgs e)
        {
            int result = string.Compare(txtString1.Text, txtString2.Text, System.StringComparison.Ordinal);
            string message = result == 0 ? "兩個字串相同。" : result < 0 ? "字串1小於字串2。" : "字串1大於字串2。";
            MessageBox.Show(message, "比較結果", MessageBoxButtons.OK, MessageBoxIcon.Information);


           string string1, string2;

            string str1 = txtString1.Text;
            string str2 = txtString2.Text;

            if (string.Compare(str1, str2) == 0)
            {
                MessageBox.Show("兩個字串相同。");
            }
            else if (string.Compare(str1, str2) < 0)
            {
                MessageBox.Show($"{str1} 小於 {str2}");
            }
            else
            {
                MessageBox.Show($"{str1} 大於 {str2}");
            }







        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
