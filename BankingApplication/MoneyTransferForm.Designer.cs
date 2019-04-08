namespace BankingApplication
{
    partial class MoneyTransferForm
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
            this.MessageLabel = new System.Windows.Forms.Label();
            this.TransferButton = new System.Windows.Forms.Button();
            this.MoneyTransferTextBox = new System.Windows.Forms.TextBox();
            this.BalanceShowLabel = new System.Windows.Forms.Label();
            this.MoneyWithdrawLabel = new System.Windows.Forms.Label();
            this.BalanceLabel = new System.Windows.Forms.Label();
            this.WithDrawLabel = new System.Windows.Forms.Label();
            this.BenTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.BalanceMoneyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Location = new System.Drawing.Point(322, 287);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(0, 13);
            this.MessageLabel.TabIndex = 28;
            // 
            // TransferButton
            // 
            this.TransferButton.Location = new System.Drawing.Point(315, 236);
            this.TransferButton.Name = "TransferButton";
            this.TransferButton.Size = new System.Drawing.Size(100, 23);
            this.TransferButton.TabIndex = 27;
            this.TransferButton.Text = "Transfer";
            this.TransferButton.UseVisualStyleBackColor = true;
            this.TransferButton.Click += new System.EventHandler(this.TransferButton_Click);
            // 
            // MoneyTransferTextBox
            // 
            this.MoneyTransferTextBox.Location = new System.Drawing.Point(315, 157);
            this.MoneyTransferTextBox.Name = "MoneyTransferTextBox";
            this.MoneyTransferTextBox.Size = new System.Drawing.Size(175, 20);
            this.MoneyTransferTextBox.TabIndex = 26;
            // 
            // BalanceShowLabel
            // 
            this.BalanceShowLabel.AutoSize = true;
            this.BalanceShowLabel.Location = new System.Drawing.Point(297, 134);
            this.BalanceShowLabel.Name = "BalanceShowLabel";
            this.BalanceShowLabel.Size = new System.Drawing.Size(0, 13);
            this.BalanceShowLabel.TabIndex = 25;
            // 
            // MoneyWithdrawLabel
            // 
            this.MoneyWithdrawLabel.AutoSize = true;
            this.MoneyWithdrawLabel.Location = new System.Drawing.Point(163, 164);
            this.MoneyWithdrawLabel.Name = "MoneyWithdrawLabel";
            this.MoneyWithdrawLabel.Size = new System.Drawing.Size(120, 13);
            this.MoneyWithdrawLabel.TabIndex = 24;
            this.MoneyWithdrawLabel.Text = "Money to be Transfered";
            // 
            // BalanceLabel
            // 
            this.BalanceLabel.AutoSize = true;
            this.BalanceLabel.Location = new System.Drawing.Point(162, 134);
            this.BalanceLabel.Name = "BalanceLabel";
            this.BalanceLabel.Size = new System.Drawing.Size(46, 13);
            this.BalanceLabel.TabIndex = 23;
            this.BalanceLabel.Text = "Balance";
            // 
            // WithDrawLabel
            // 
            this.WithDrawLabel.AutoSize = true;
            this.WithDrawLabel.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WithDrawLabel.Location = new System.Drawing.Point(156, 78);
            this.WithDrawLabel.Name = "WithDrawLabel";
            this.WithDrawLabel.Size = new System.Drawing.Size(225, 32);
            this.WithDrawLabel.TabIndex = 22;
            this.WithDrawLabel.Text = "Money Transfer";
            // 
            // BenTextBox
            // 
            this.BenTextBox.Location = new System.Drawing.Point(315, 190);
            this.BenTextBox.Name = "BenTextBox";
            this.BenTextBox.Size = new System.Drawing.Size(175, 20);
            this.BenTextBox.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Beneficier Account Number";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(396, 87);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(94, 23);
            this.BackButton.TabIndex = 31;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // BalanceMoneyLabel
            // 
            this.BalanceMoneyLabel.AutoSize = true;
            this.BalanceMoneyLabel.Location = new System.Drawing.Point(322, 134);
            this.BalanceMoneyLabel.Name = "BalanceMoneyLabel";
            this.BalanceMoneyLabel.Size = new System.Drawing.Size(0, 13);
            this.BalanceMoneyLabel.TabIndex = 32;
            // 
            // MoneyTransferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BalanceMoneyLabel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.BenTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.TransferButton);
            this.Controls.Add(this.MoneyTransferTextBox);
            this.Controls.Add(this.BalanceShowLabel);
            this.Controls.Add(this.MoneyWithdrawLabel);
            this.Controls.Add(this.BalanceLabel);
            this.Controls.Add(this.WithDrawLabel);
            this.Name = "MoneyTransferForm";
            this.Text = "MoneyTransferForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.Button TransferButton;
        private System.Windows.Forms.TextBox MoneyTransferTextBox;
        private System.Windows.Forms.Label BalanceShowLabel;
        private System.Windows.Forms.Label MoneyWithdrawLabel;
        private System.Windows.Forms.Label BalanceLabel;
        private System.Windows.Forms.Label WithDrawLabel;
        private System.Windows.Forms.TextBox BenTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label BalanceMoneyLabel;
    }
}