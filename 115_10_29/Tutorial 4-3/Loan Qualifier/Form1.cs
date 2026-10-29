using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loan_Qualifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // 初始化表單上的所有元件。
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
           const decimal MIN_SALARY = 40000m; // 最低年收入
              const int MIN_YEARS = 2; // 最低工作年資
    

            decimal salary; // 年收入
            int yearsOnjob ; // 工作年資


            try
                {
               
                salary = decimal.Parse(salaryTextBox.Text);// 取得使用者輸入的年收入與工作年資。
                yearsOnjob = int.Parse(yearsTextBox.Text);// 取得使用者輸入的年收入與工作年資。

                if (salary >= MIN_SALARY)// 如果年收入符合資格，則檢查工作年資是否符合資格。
                {
                   if (yearsOnjob >= MIN_YEARS)
                    {
                        decisionLabel.Text = "您符合貸款資格。";
                    }
                    else
                    {
                        decisionLabel.Text = "您薪資符合但年資不符合貸款資格。";
                    }
                }
                else
                {
                    decisionLabel.Text = "您薪資不符合貸款資格。";
                }
            }
            catch (Exception ex)
            {
                // 如果使用者輸入的資料格式不正確，顯示錯誤訊息。
                MessageBox.Show("請輸入有效的數字。", "輸入錯誤");
            }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清除年收入、工作年資及貸款審核結果。
            salaryTextBox.Text = "";
            yearsTextBox.Text = "";
            decisionLabel.Text = "";

            // 清除後將輸入焦點移回年收入欄位。
            salaryTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉目前的表單。
            this.Close();
        }
    }
}
