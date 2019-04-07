namespace BankingApplication
{
    partial class WithDrawForm
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
            this.BackButton = new System.Windows.Forms.Button();
            this.BalanceMoneyLabel = new System.Windows.Forms.Label();
            this.WithDrawButton = new System.Windows.Forms.Button();
            this.WithDrawMoneyTextBox = new System.Windows.Forms.TextBox();
            this.WithDrawMoneyLabel = new System.Windows.Forms.Label();
            this.BalanceLabel = new System.Windows.Forms.Label();
            this.WithDrawLabel = new System.Windows.Forms.Label();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(416, 78);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(94, 23);
            this.BackButton.TabIndex = 34;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // BalanceMoneyLabel
            // 
            this.BalanceMoneyLabel.AutoSize = true;
            this.BalanceMoneyLabel.Location = new System.Drawing.Point(291, 141);
            this.BalanceMoneyLabel.Name = "BalanceMoneyLabel";
            this.BalanceMoneyLabel.Size = new System.Drawing.Size(0, 13);
            this.BalanceMoneyLabel.TabIndex = 33;
            // 
            // WithDrawButton
            // 
            this.WithDrawButton.Location = new System.Drawing.Point(294, 211);
            this.WithDrawButton.Name = "WithDrawButton";
            this.WithDrawButton.Size = new System.Drawing.Size(94, 23);
            this.WithDrawButton.TabIndex = 32;
            this.WithDrawButton.Text = "WithDraw";
            this.WithDrawButton.UseVisualStyleBackColor = true;
            this.WithDrawButton.Click += new System.EventHandler(this.WithDrawButton_Click);
            // 
            // WithDrawMoneyTextBox
            // 
            this.WithDrawMoneyTextBox.Location = new System.Drawing.Point(294, 168);
            this.WithDrawMoneyTextBox.Name = "WithDrawMoneyTextBox";
            this.WithDrawMoneyTextBox.Size = new System.Drawing.Size(216, 20);
            this.WithDrawMoneyTextBox.TabIndex = 31;
            // 
            // WithDrawMoneyLabel
            // 
            this.WithDrawMoneyLabel.AutoSize = true;
            this.WithDrawMoneyLabel.Location = new System.Drawing.Point(151, 175);
            this.WithDrawMoneyLabel.Name = "WithDrawMoneyLabel";
            this.WithDrawMoneyLabel.Size = new System.Drawing.Size(116, 13);
            this.WithDrawMoneyLabel.TabIndex = 30;
            this.WithDrawMoneyLabel.Text = "Money to be WithDraw";
            // 
            // BalanceLabel
            // 
            this.BalanceLabel.AutoSize = true;
            this.BalanceLabel.Location = new System.Drawing.Point(151, 145);
            this.BalanceLabel.Name = "BalanceLabel";
            this.BalanceLabel.Size = new System.Drawing.Size(46, 13);
            this.BalanceLabel.TabIndex = 29;
            this.BalanceLabel.Text = "Balance";
            // 
            // WithDrawLabel
            // 
            this.WithDrawLabel.AutoSize = true;
            this.WithDrawLabel.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WithDrawLabel.Location = new System.Drawing.Point(143, 69);
            this.WithDrawLabel.Name = "WithDrawLabel";
            this.WithDrawLabel.Size = new System.Drawing.Size(135, 32);
            this.WithDrawLabel.TabIndex = 28;
            this.WithDrawLabel.Text = "WithDraw";
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Location = new System.Drawing.Point(291, 262);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(0, 13);
            this.MessageLabel.TabIndex = 35;
            // 
            // WithDrawForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.BalanceMoneyLabel);
            this.Controls.Add(this.WithDrawButton);
            this.Controls.Add(this.WithDrawMoneyTextBox);
            this.Controls.Add(this.WithDrawMoneyLabel);
            this.Controls.Add(this.BalanceLabel);
            this.Controls.Add(this.WithDrawLabel);
            this.Name = "WithDrawForm";
            this.Text = "WithDrawForm";
            this.Load += new System.EventHandler(this.WithDrawForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label BalanceMoneyLabel;
        private System.Windows.Forms.Button WithDrawButton;
        private System.Windows.Forms.TextBox WithDrawMoneyTextBox;
        private System.Windows.Forms.Label WithDrawMoneyLabel;
        private System.Windows.Forms.Label BalanceLabel;
        private System.Windows.Forms.Label WithDrawLabel;
        private System.Windows.Forms.Label MessageLabel;
    }
}