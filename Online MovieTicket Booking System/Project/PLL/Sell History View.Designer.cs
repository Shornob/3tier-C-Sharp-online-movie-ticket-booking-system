namespace MovieTicketBookingSystem.PLL
{
    partial class Sell_History
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
            this.SellHistorydataGridView = new System.Windows.Forms.DataGridView();
            this.Logout_button = new System.Windows.Forms.Button();
            this.Back_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SellHistorydataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SellHistorydataGridView
            // 
            this.SellHistorydataGridView.AllowUserToAddRows = false;
            this.SellHistorydataGridView.AllowUserToDeleteRows = false;
            this.SellHistorydataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SellHistorydataGridView.Location = new System.Drawing.Point(49, 104);
            this.SellHistorydataGridView.Name = "SellHistorydataGridView";
            this.SellHistorydataGridView.ReadOnly = true;
            this.SellHistorydataGridView.Size = new System.Drawing.Size(541, 416);
            this.SellHistorydataGridView.TabIndex = 0;
            // 
            // Logout_button
            // 
            this.Logout_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Logout_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Logout_button.FlatAppearance.BorderSize = 0;
            this.Logout_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout_button.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout_button.Location = new System.Drawing.Point(675, 59);
            this.Logout_button.Name = "Logout_button";
            this.Logout_button.Size = new System.Drawing.Size(82, 33);
            this.Logout_button.TabIndex = 89;
            this.Logout_button.Text = "Logout";
            this.Logout_button.UseVisualStyleBackColor = false;
            this.Logout_button.Click += new System.EventHandler(this.Logout_button_Click);
            // 
            // Back_button
            // 
            this.Back_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Back_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Back_button.FlatAppearance.BorderSize = 0;
            this.Back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_button.Location = new System.Drawing.Point(675, 114);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(82, 33);
            this.Back_button.TabIndex = 90;
            this.Back_button.Text = "Back";
            this.Back_button.UseVisualStyleBackColor = false;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // Sell_History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 571);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.Logout_button);
            this.Controls.Add(this.SellHistorydataGridView);
            this.Name = "Sell_History";
            this.Text = "Sell History";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Sell_History_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.SellHistorydataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView SellHistorydataGridView;
        private System.Windows.Forms.Button Logout_button;
        private System.Windows.Forms.Button Back_button;
    }
}