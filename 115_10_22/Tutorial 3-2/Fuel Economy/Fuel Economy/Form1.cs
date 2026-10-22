using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel_Economy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double km;  // 宣告 km、liters 和 kmpl 變數。
            double liters;// 宣告 km、liters 和 kmpl 變數。
            double kmpl;// 宣告 km、liters 和 kmpl 變數。


            km =double.Parse(milesTextBox.Text);// 將公里數輸入轉換為 double。
            liters =double.Parse(gallonsTextBox.Text);//    將公升數輸入轉換為 double。
            kmpl =km/liters;// 計算每公升公里數。
          
            mpgLabel.Text=kmpl.ToString("n2") + " 公里/公升";// 將每公升公里數顯示在 mpgLabel 上，並格式化為小數點後兩位。
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}
