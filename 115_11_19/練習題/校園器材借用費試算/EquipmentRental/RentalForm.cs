using System;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace EquipmentRental
{
    public partial class RentalForm : Form
    {
        public RentalForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            dailyRateLabel.Text = "—";
            totalLabel.Text = "—";
            feedbackLabel.Text = "";
            // TODO 1：新增優惠結果標籤後，每次試算也要將它重設為「—」。

            int days;
            if (int.TryParse(daysTextBox.Text, out days))
            {
                if (clubCheckBox.Checked && days <= 2)
                {
                    dailyRateLabel.Text = "80";
                    label2.Text = "未滿三天";
                    totalLabel.Text= (days * 80).ToString();
                    // TODO 3：在天數有效的分支內判斷日費及社團優惠。
                    // TODO 4：算出應付金額並更新三個結果欄位。
                    // 完成 TODO 2～4 後，用你的程式取代下一行。

                }
                else
                {
                    if (days <= 2)
                    {
                        dailyRateLabel.Text = "80";
                        label2.Text = "0";
                        totalLabel.Text = (days * 80).ToString();
                    }

                    else
                    {
                        if (clubCheckBox.Checked && days <= 4 && days > 2)
                        {
                            dailyRateLabel.Text = "70";
                            label2.Text = "30";
                            totalLabel.Text = ((days * 70)-30).ToString();
                        }
                        else
                        {
                            if ( days <= 4 && days > 2)
                            {
                                dailyRateLabel.Text = "70";
                                label2.Text = "0";
                                totalLabel.Text = (days * 70).ToString();
                            }

                            else
                                {
                                if (clubCheckBox.Checked && days <= 7 && days > 4)
                                {
                                    dailyRateLabel.Text = "60";
                                    label2.Text = "30";
                                    totalLabel.Text = ((days * 60)-30).ToString();
                                }
                                else
                                {
                                    if ( days <= 7 && days > 4)
                                    {
                                        dailyRateLabel.Text = "60";
                                        label2.Text = "0";
                                        totalLabel.Text = (days * 60).ToString();
                                    }
                                    else
                                    {
                                        feedbackLabel.Text = "請輸入 1 到 7 之間的整數。";
                                    }
                                }
                            }

                        }
                    }
            }
            }
            else
            {
                feedbackLabel.Text = "請輸入 1 到 7 之間的整數。";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            daysTextBox.Text = "";
            dailyRateLabel.Text = "—";
            label2.Text = "—";
            totalLabel.Text = "—";
            feedbackLabel.Text = "";
        }
    }
}
