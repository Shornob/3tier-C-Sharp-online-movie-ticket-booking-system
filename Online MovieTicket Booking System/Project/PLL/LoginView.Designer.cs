namespace MovieTicketBookingSystem.PLL
{
    partial class FormLogin
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
            this.label2 = new System.Windows.Forms.Label();
            this.Login_button = new System.Windows.Forms.Button();
            this.Exit_button = new System.Windows.Forms.Button();
            this.usernametextbox = new MetroFramework.Controls.MetroTextBox();
            this.Passwordtextbox = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(267, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // Login_button
            // 
            this.Login_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Login_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Login_button.FlatAppearance.BorderSize = 0;
            this.Login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_button.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_button.Location = new System.Drawing.Point(304, 290);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(73, 33);
            this.Login_button.TabIndex = 89;
            this.Login_button.Text = "Login";
            this.Login_button.UseVisualStyleBackColor = false;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // Exit_button
            // 
            this.Exit_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Exit_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Exit_button.FlatAppearance.BorderSize = 0;
            this.Exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_button.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_button.Location = new System.Drawing.Point(427, 290);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(73, 33);
            this.Exit_button.TabIndex = 90;
            this.Exit_button.Text = "Exit";
            this.Exit_button.UseVisualStyleBackColor = false;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // usernametextbox
            // 
            // 
            // 
            // 
            this.usernametextbox.CustomButton.Image = null;
            this.usernametextbox.CustomButton.Location = new System.Drawing.Point(122, 1);
            this.usernametextbox.CustomButton.Name = "";
            this.usernametextbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.usernametextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.usernametextbox.CustomButton.TabIndex = 1;
            this.usernametextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.usernametextbox.CustomButton.UseSelectable = true;
            this.usernametextbox.CustomButton.Visible = false;
            this.usernametextbox.Lines = new string[0];
            this.usernametextbox.Location = new System.Drawing.Point(403, 170);
            this.usernametextbox.MaxLength = 32767;
            this.usernametextbox.Name = "usernametextbox";
            this.usernametextbox.PasswordChar = '\0';
            this.usernametextbox.PromptText = "Enter Username";
            this.usernametextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.usernametextbox.SelectedText = "";
            this.usernametextbox.SelectionLength = 0;
            this.usernametextbox.SelectionStart = 0;
            this.usernametextbox.ShortcutsEnabled = true;
            this.usernametextbox.Size = new System.Drawing.Size(144, 23);
            this.usernametextbox.TabIndex = 91;
            this.usernametextbox.UseSelectable = true;
            this.usernametextbox.WaterMark = "Enter Username";
            this.usernametextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.usernametextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Passwordtextbox
            // 
            // 
            // 
            // 
            this.Passwordtextbox.CustomButton.Image = null;
            this.Passwordtextbox.CustomButton.Location = new System.Drawing.Point(122, 1);
            this.Passwordtextbox.CustomButton.Name = "";
            this.Passwordtextbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Passwordtextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Passwordtextbox.CustomButton.TabIndex = 1;
            this.Passwordtextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Passwordtextbox.CustomButton.UseSelectable = true;
            this.Passwordtextbox.CustomButton.Visible = false;
            this.Passwordtextbox.Lines = new string[0];
            this.Passwordtextbox.Location = new System.Drawing.Point(403, 221);
            this.Passwordtextbox.MaxLength = 32767;
            this.Passwordtextbox.Name = "Passwordtextbox";
            this.Passwordtextbox.PasswordChar = '•';
            this.Passwordtextbox.PromptText = "Enter Password";
            this.Passwordtextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Passwordtextbox.SelectedText = "";
            this.Passwordtextbox.SelectionLength = 0;
            this.Passwordtextbox.SelectionStart = 0;
            this.Passwordtextbox.ShortcutsEnabled = true;
            this.Passwordtextbox.Size = new System.Drawing.Size(144, 23);
            this.Passwordtextbox.TabIndex = 92;
            this.Passwordtextbox.UseSelectable = true;
            this.Passwordtextbox.WaterMark = "Enter Password";
            this.Passwordtextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Passwordtextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackLocation = MetroFramework.Forms.BackLocation.TopRight;
            this.ClientSize = new System.Drawing.Size(807, 586);
            this.Controls.Add(this.Passwordtextbox);
            this.Controls.Add(this.usernametextbox);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.Login_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormLogin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLogin_FormClosing_1);
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.Button Exit_button;
        private MetroFramework.Controls.MetroTextBox usernametextbox;
        private MetroFramework.Controls.MetroTextBox Passwordtextbox;
    }
}

