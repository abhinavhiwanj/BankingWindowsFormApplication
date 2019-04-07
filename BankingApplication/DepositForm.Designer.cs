namespace BankingApplication
{
    partial class DepositForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DepositButton = new System.Windows.Forms.Button();
            this.DepositMoneyTextBox = new System.Windows.Forms.TextBox();
            this.DepositMoneyLabel = new System.Windows.Forms.Label();
            this.BalanceLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BalanceMoneyLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DepositButton
            // 
            this.DepositButton.Location = new System.Drawing.Point(294, 212);
            this.DepositButton.Name = "DepositButton";
            this.DepositButton.Size = new System.Drawing.Size(94, 23);
            this.DepositButton.TabIndex = 25;
            this.DepositButton.Text = "Deposit";
            this.DepositButton.UseVisualStyleBackColor = true;
            this.DepositButton.Click += new System.EventHandler(this.DepositButton_Click);
            // 
            // DepositMoneyTextBox
            // 
            this.DepositMoneyTextBox.Location = new System.Drawing.Point(294, 169);
            this.DepositMoneyTextBox.Name = "DepositMoneyTextBox";
            this.DepositMoneyTextBox.Size = new System.Drawing.Size(216, 20);
            this.DepositMoneyTextBox.TabIndex = 24;
            this.DepositMoneyTextBox.TextChanged += new System.EventHandler(this.DepositMoneyTextBox_TextChanged);
            // 
            // DepositMoneyLabel
            // 
            this.DepositMoneyLabel.AutoSize = true;
            this.DepositMoneyLabel.Location = new System.Drawing.Point(151, 176);
            this.DepositMoneyLabel.Name = "DepositMoneyLabel";
            this.DepositMoneyLabel.Size = new System.Drawing.Size(105, 13);
            this.DepositMoneyLabel.TabIndex = 22;
            this.DepositMoneyLabel.Text = "Money to be Deposit";
            this.DepositMoneyLabel.Click += new System.EventHandler(this.DepositMoneyLabel_Click);
            // 
            // BalanceLabel
            // 
            this.BalanceLabel.AutoSize = true;
            this.BalanceLabel.Location = new System.Drawing.Point(151, 146);
            this.BalanceLabel.Name = "BalanceLabel";
            this.BalanceLabel.Size = new System.Drawing.Size(46, 13);
            this.BalanceLabel.TabIndex = 21;
            this.BalanceLabel.Text = "Balance";
            this.BalanceLabel.Click += new System.EventHandler(this.BalanceLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 32);
            this.label1.TabIndex = 20;
            this.label1.Text = "Deposit";
            // 
            // BalanceMoneyLabel
            // 
            this.BalanceMoneyLabel.AutoSize = true;
            this.BalanceMoneyLabel.Location = new System.Drawing.Point(291, 142);
            this.BalanceMoneyLabel.Name = "BalanceMoneyLabel";
            this.BalanceMoneyLabel.Size = new System.Drawing.Size(0, 13);
            this.BalanceMoneyLabel.TabIndex = 26;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(416, 79);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(94, 23);
            this.BackButton.TabIndex = 27;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // DepositForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.BalanceMoneyLabel);
            this.Controls.Add(this.DepositButton);
            this.Controls.Add(this.DepositMoneyTextBox);
            this.Controls.Add(this.DepositMoneyLabel);
            this.Controls.Add(this.BalanceLabel);
            this.Controls.Add(this.label1);
            this.Name = "DepositForm";
            this.Text = "DepositForm";
            this.Load += new System.EventHandler(this.DepositForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DepositButton;
        private System.Windows.Forms.TextBox DepositMoneyTextBox;
        private System.Windows.Forms.Label DepositMoneyLabel;
        private System.Windows.Forms.Label BalanceLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label BalanceMoneyLabel;
        private System.Windows.Forms.Button BackButton;
    }
}