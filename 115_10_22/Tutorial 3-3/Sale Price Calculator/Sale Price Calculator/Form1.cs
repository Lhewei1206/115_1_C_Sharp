using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sale_Price_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double originalPrice;// 儲存原價。
            double discountPercentage;// 儲存折扣百分比。
            double salePrice;// 儲存售價。

            originalPrice = double.Parse(originalPriceTextBox.Text);// 將原價文字方塊的文字轉換為 double。
            discountPercentage = double.Parse(discountPercentageTextBox.Text);// 將折扣百分比文字方塊的文字轉換為 double。

            salePrice = originalPrice - (originalPrice * discountPercentage / 100);// 計算售價。

            salePriceLabel.Text = salePrice.ToString("F2");// 將售價轉換為字串，並顯示在售價標籤上。
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}
