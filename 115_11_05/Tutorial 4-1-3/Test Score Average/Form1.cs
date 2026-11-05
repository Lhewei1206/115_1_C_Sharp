using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Score_Average
{
    public partial class Form1 : Form
    {
        // 建立表單並初始化所有介面元件。
        public Form1()
        {
            InitializeComponent();
        }

        // 按下「計算平均值」按鈕時執行成績計算。
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 宣告三次測驗成績與平均值所需的變數。
            double test1, test2, test3, average;
            string grade;


            const double MIN_SCORE = 95.0;
            // TODO：從三個文字方塊讀取成績，計算平均值並顯示結果。


            try
            {
                // 從三個文字方塊讀取成績，並將其轉換為 double 型別。
                test1 = double.Parse(test1TextBox.Text);
                test2 = double.Parse(test2TextBox.Text);
                test3 = double.Parse(test3TextBox.Text);

                // 計算三次測驗的平均值。
                average = (test1 + test2 + test3) / 3.0;

                // 將平均值顯示在 averageLabel 上，格式化為小數點後一位。
                averageLabel.Text = average.ToString("F1");

                if (average >= 90)
                {
                    grade = "A";
                }
                else if (average >= 80 && average < 90)
                {
                    grade = "B";
                }
                else if (average >= 70 && average < 80)
                {
                    grade = "C";
                }
                else if (average >= 60 && average < 70)
                {
                    grade = "D";
                }
                else
                {
                    grade = "F";
                }

                MessageBox.Show("成績等級: " + grade);

            }



            catch (FormatException)
            {
                // 如果輸入的成績不是有效的數字，顯示錯誤訊息。
                MessageBox.Show("請輸入有效的數字成績。");
            }

        }

        // 按下「清除」按鈕時清空所有輸入與計算結果。
        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清除三個成績輸入欄位與平均成績顯示欄位。
            test1TextBox.Text = "";
            test2TextBox.Text = "";
            test3TextBox.Text = "";
            averageLabel.Text = "";

            // 清除後將游標移回第一個輸入欄位。
            test1TextBox.Focus();
        }

        // 按下「離開」按鈕時關閉目前的表單。
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉應用程式主畫面。
            this.Close();
        }
    }
}
