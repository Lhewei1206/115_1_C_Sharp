namespace strintcompare1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblString1;
        private System.Windows.Forms.Label lblString2;
        private System.Windows.Forms.TextBox txtString1;
        private System.Windows.Forms.TextBox txtString2;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Button btnExit;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblString1 = new System.Windows.Forms.Label();
            this.lblString2 = new System.Windows.Forms.Label();
            this.txtString1 = new System.Windows.Forms.TextBox();
            this.txtString2 = new System.Windows.Forms.TextBox();
            this.btnCompare = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblString1
            // 
            this.lblString1.AutoSize = true;
            this.lblString1.Location = new System.Drawing.Point(40, 42);
            this.lblString1.Name = "lblString1";
            this.lblString1.Size = new System.Drawing.Size(70, 18);
            this.lblString1.TabIndex = 0;
            this.lblString1.Text = "字串1：";
            // 
            // lblString2
            // 
            this.lblString2.AutoSize = true;
            this.lblString2.Location = new System.Drawing.Point(40, 89);
            this.lblString2.Name = "lblString2";
            this.lblString2.Size = new System.Drawing.Size(70, 18);
            this.lblString2.TabIndex = 1;
            this.lblString2.Text = "字串2：";
            // 
            // txtString1
            // 
            this.txtString1.Location = new System.Drawing.Point(112, 39);
            this.txtString1.Name = "txtString1";
            this.txtString1.Size = new System.Drawing.Size(248, 29);
            this.txtString1.TabIndex = 2;
            // 
            // txtString2
            // 
            this.txtString2.Location = new System.Drawing.Point(112, 86);
            this.txtString2.Name = "txtString2";
            this.txtString2.Size = new System.Drawing.Size(248, 29);
            this.txtString2.TabIndex = 3;
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(112, 137);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(98, 31);
            this.btnCompare.TabIndex = 4;
            this.btnCompare.Text = "比較";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(262, 137);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(98, 31);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "離開";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(410, 210);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.txtString2);
            this.Controls.Add(this.txtString1);
            this.Controls.Add(this.lblString2);
            this.Controls.Add(this.lblString1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "字串比較";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

