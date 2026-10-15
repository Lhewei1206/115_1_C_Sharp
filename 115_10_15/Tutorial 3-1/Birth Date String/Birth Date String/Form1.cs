using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Birth_Date_String
{
    /// <summary>
    /// 生日日期字串應用程式
    /// 此表單用於接收使用者輸入的星期、月份、日期和年份，
    /// 並將這些資訊組合顯示在輸出標籤中
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Form1 建構子
        /// 初始化表單元件
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 顯示日期按鈕的點擊事件處理程序
        /// 將使用者輸入的星期、月份、日期和年份組合成字串並顯示
        /// </summary>
        private void showDateButton_Click(object sender, EventArgs e)
        {
            // 宣告輸出字串變數
            string output;

            // 將四個 TextBox 中的文字以「/」符號連接
            output = dayOfWeekTextBox.Text + "/" + monthTextBox.Text + "/" + dayOfMonthTextBox.Text + "/" + yearTextBox.Text;

            // 將組合後的字串顯示在輸出標籤中
            dateOutputLabel.Text = output;
        }

        /// <summary>
        /// 清除按鈕的點擊事件處理程序
        /// 清空所有輸入欄位和輸出標籤的內容
        /// </summary>
        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清空星期 TextBox
            dayOfWeekTextBox.Text = "";
            // 清空月份 TextBox
            monthTextBox.Text = "";
            // 清空日期 TextBox
            dayOfMonthTextBox.Text = "";
            // 清空年份 TextBox
            yearTextBox.Text = "";
            // 清空輸出標籤
            dateOutputLabel.Text = "";
        }

        /// <summary>
        /// 結束按鈕的點擊事件處理程序
        /// 關閉應用程式視窗
        /// </summary>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單視窗
            this.Close();
        }
    }
}
