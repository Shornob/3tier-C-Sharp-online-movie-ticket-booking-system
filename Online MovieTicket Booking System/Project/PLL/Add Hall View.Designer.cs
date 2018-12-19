namespace MovieTicketBookingSystem.PLL
{
    partial class Add_Hall
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
            this.label1 = new System.Windows.Forms.Label();
            this.Logout_button = new System.Windows.Forms.Button();
            this.Back_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Confirm_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "New Hall Name :";
            // 
            // Logout_button
            // 
            this.Logout_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Logout_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Logout_button.FlatAppearance.BorderSize = 0;
            this.Logout_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout_button.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout_button.Location = new System.Drawing.Point(669, 57);
            this.Logout_button.Name = "Logout_button";
            this.Logout_button.Size = new System.Drawing.Size(82, 33);
            this.Logout_button.TabIndex = 90;
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
            this.Back_button.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_button.Location = new System.Drawing.Point(669, 113);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(82, 33);
            this.Back_button.TabIndex = 91;
            this.Back_button.Text = "Back";
            this.Back_button.UseVisualStyleBackColor = false;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(420, 190);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 92;
            // 
            // Confirm_button
            // 
            this.Confirm_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Confirm_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Confirm_button.FlatAppearance.BorderSize = 0;
            this.Confirm_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Confirm_button.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirm_button.Location = new System.Drawing.Point(349, 274);
            this.Confirm_button.Name = "Confirm_button";
            this.Confirm_button.Size = new System.Drawing.Size(82, 33);
            this.Confirm_button.TabIndex = 93;
            this.Confirm_button.Text = "Confirm";
            this.Confirm_button.UseVisualStyleBackColor = false;
            // 
            // Add_Hall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 571);
            this.Controls.Add(this.Confirm_button);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.Logout_button);
            this.Controls.Add(this.label1);
            this.Name = "Add_Hall";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Add_Hall_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Logout_button;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Confirm_button;
    }
}