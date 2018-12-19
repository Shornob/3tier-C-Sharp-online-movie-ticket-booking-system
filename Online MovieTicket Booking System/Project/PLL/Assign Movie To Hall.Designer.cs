namespace MovieTicketBookingSystem.PLL
{
    partial class AssignMovieToHall
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
            this.dataGridViewMovieInfo = new System.Windows.Forms.DataGridView();
            this.dataGridViewMovieHallInfo = new System.Windows.Forms.DataGridView();
            this.setMovieDate = new MetroFramework.Controls.MetroDateTime();
            this.setSlottime = new MetroFramework.Controls.MetroComboBox();
            this.setMovieIdtxt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.setDate = new MetroFramework.Controls.MetroLabel();
            this.setTime = new MetroFramework.Controls.MetroLabel();
            this.setMovieId = new MetroFramework.Controls.MetroLabel();
            this.setHallIdLabel = new MetroFramework.Controls.MetroLabel();
            this.ssHallIdlbl = new MetroFramework.Controls.MetroLabel();
            this.setHallIdTxt = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new System.Windows.Forms.Button();
            this.assignHall_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovieInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovieHallInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMovieInfo
            // 
            this.dataGridViewMovieInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMovieInfo.Location = new System.Drawing.Point(17, 92);
            this.dataGridViewMovieInfo.Name = "dataGridViewMovieInfo";
            this.dataGridViewMovieInfo.Size = new System.Drawing.Size(260, 175);
            this.dataGridViewMovieInfo.TabIndex = 0;
            // 
            // dataGridViewMovieHallInfo
            // 
            this.dataGridViewMovieHallInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMovieHallInfo.Location = new System.Drawing.Point(301, 92);
            this.dataGridViewMovieHallInfo.Name = "dataGridViewMovieHallInfo";
            this.dataGridViewMovieHallInfo.Size = new System.Drawing.Size(493, 175);
            this.dataGridViewMovieHallInfo.TabIndex = 1;
            this.dataGridViewMovieHallInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMovieHallInfo_CellContentClick);
            // 
            // setMovieDate
            // 
            this.setMovieDate.Location = new System.Drawing.Point(27, 360);
            this.setMovieDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.setMovieDate.Name = "setMovieDate";
            this.setMovieDate.Size = new System.Drawing.Size(200, 29);
            this.setMovieDate.TabIndex = 2;
            this.setMovieDate.ValueChanged += new System.EventHandler(this.setMovieDate_ValueChanged);
            // 
            // setSlottime
            // 
            this.setSlottime.FormattingEnabled = true;
            this.setSlottime.ItemHeight = 23;
            this.setSlottime.Items.AddRange(new object[] {
            "11-2",
            "2-5",
            "5-8"});
            this.setSlottime.Location = new System.Drawing.Point(259, 360);
            this.setSlottime.Name = "setSlottime";
            this.setSlottime.Size = new System.Drawing.Size(121, 29);
            this.setSlottime.TabIndex = 4;
            this.setSlottime.UseSelectable = true;
            // 
            // setMovieIdtxt
            // 
            // 
            // 
            // 
            this.setMovieIdtxt.CustomButton.Image = null;
            this.setMovieIdtxt.CustomButton.Location = new System.Drawing.Point(71, 1);
            this.setMovieIdtxt.CustomButton.Name = "";
            this.setMovieIdtxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.setMovieIdtxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.setMovieIdtxt.CustomButton.TabIndex = 1;
            this.setMovieIdtxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.setMovieIdtxt.CustomButton.UseSelectable = true;
            this.setMovieIdtxt.CustomButton.Visible = false;
            this.setMovieIdtxt.Lines = new string[0];
            this.setMovieIdtxt.Location = new System.Drawing.Point(497, 360);
            this.setMovieIdtxt.MaxLength = 32767;
            this.setMovieIdtxt.Name = "setMovieIdtxt";
            this.setMovieIdtxt.PasswordChar = '\0';
            this.setMovieIdtxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.setMovieIdtxt.SelectedText = "";
            this.setMovieIdtxt.SelectionLength = 0;
            this.setMovieIdtxt.SelectionStart = 0;
            this.setMovieIdtxt.ShortcutsEnabled = true;
            this.setMovieIdtxt.Size = new System.Drawing.Size(93, 23);
            this.setMovieIdtxt.TabIndex = 5;
            this.setMovieIdtxt.UseSelectable = true;
            this.setMovieIdtxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.setMovieIdtxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AllowDrop = true;
            this.metroLabel1.Location = new System.Drawing.Point(419, 360);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(72, 23);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Movie Id :";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // setDate
            // 
            this.setDate.AllowDrop = true;
            this.setDate.Location = new System.Drawing.Point(71, 324);
            this.setDate.Name = "setDate";
            this.setDate.Size = new System.Drawing.Size(105, 23);
            this.setDate.TabIndex = 10;
            this.setDate.Text = "SET DATE";
            // 
            // setTime
            // 
            this.setTime.AllowDrop = true;
            this.setTime.Location = new System.Drawing.Point(285, 324);
            this.setTime.Name = "setTime";
            this.setTime.Size = new System.Drawing.Size(71, 23);
            this.setTime.TabIndex = 11;
            this.setTime.Text = "SET TIME";
            // 
            // setMovieId
            // 
            this.setMovieId.AllowDrop = true;
            this.setMovieId.Location = new System.Drawing.Point(461, 324);
            this.setMovieId.Name = "setMovieId";
            this.setMovieId.Size = new System.Drawing.Size(105, 23);
            this.setMovieId.TabIndex = 12;
            this.setMovieId.Text = "Set Movie Id ";
            this.setMovieId.Click += new System.EventHandler(this.setMovieId_Click);
            // 
            // setHallIdLabel
            // 
            this.setHallIdLabel.AllowDrop = true;
            this.setHallIdLabel.Location = new System.Drawing.Point(665, 324);
            this.setHallIdLabel.Name = "setHallIdLabel";
            this.setHallIdLabel.Size = new System.Drawing.Size(105, 23);
            this.setHallIdLabel.TabIndex = 15;
            this.setHallIdLabel.Text = "Set Hall Id";
            // 
            // ssHallIdlbl
            // 
            this.ssHallIdlbl.AllowDrop = true;
            this.ssHallIdlbl.Location = new System.Drawing.Point(623, 360);
            this.ssHallIdlbl.Name = "ssHallIdlbl";
            this.ssHallIdlbl.Size = new System.Drawing.Size(72, 23);
            this.ssHallIdlbl.TabIndex = 14;
            this.ssHallIdlbl.Text = "Hall Id:";
            // 
            // setHallIdTxt
            // 
            // 
            // 
            // 
            this.setHallIdTxt.CustomButton.Image = null;
            this.setHallIdTxt.CustomButton.Location = new System.Drawing.Point(71, 1);
            this.setHallIdTxt.CustomButton.Name = "";
            this.setHallIdTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.setHallIdTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.setHallIdTxt.CustomButton.TabIndex = 1;
            this.setHallIdTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.setHallIdTxt.CustomButton.UseSelectable = true;
            this.setHallIdTxt.CustomButton.Visible = false;
            this.setHallIdTxt.Lines = new string[0];
            this.setHallIdTxt.Location = new System.Drawing.Point(701, 360);
            this.setHallIdTxt.MaxLength = 32767;
            this.setHallIdTxt.Name = "setHallIdTxt";
            this.setHallIdTxt.PasswordChar = '\0';
            this.setHallIdTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.setHallIdTxt.SelectedText = "";
            this.setHallIdTxt.SelectionLength = 0;
            this.setHallIdTxt.SelectionStart = 0;
            this.setHallIdTxt.ShortcutsEnabled = true;
            this.setHallIdTxt.Size = new System.Drawing.Size(93, 23);
            this.setHallIdTxt.TabIndex = 13;
            this.setHallIdTxt.UseSelectable = true;
            this.setHallIdTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.setHallIdTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroButton1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.metroButton1.FlatAppearance.BorderSize = 0;
            this.metroButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metroButton1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroButton1.Location = new System.Drawing.Point(301, 453);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(82, 33);
            this.metroButton1.TabIndex = 92;
            this.metroButton1.Text = "Back";
            this.metroButton1.UseVisualStyleBackColor = false;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click_1);
            // 
            // assignHall_button
            // 
            this.assignHall_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.assignHall_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.assignHall_button.FlatAppearance.BorderSize = 0;
            this.assignHall_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.assignHall_button.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignHall_button.Location = new System.Drawing.Point(446, 453);
            this.assignHall_button.Name = "assignHall_button";
            this.assignHall_button.Size = new System.Drawing.Size(120, 33);
            this.assignHall_button.TabIndex = 93;
            this.assignHall_button.Text = "Assign Hall";
            this.assignHall_button.UseVisualStyleBackColor = false;
            this.assignHall_button.Click += new System.EventHandler(this.assignHall_button_Click);
            // 
            // AssignMovieToHall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 571);
            this.Controls.Add(this.assignHall_button);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.setHallIdLabel);
            this.Controls.Add(this.ssHallIdlbl);
            this.Controls.Add(this.setHallIdTxt);
            this.Controls.Add(this.setMovieId);
            this.Controls.Add(this.setTime);
            this.Controls.Add(this.setDate);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.setMovieIdtxt);
            this.Controls.Add(this.setSlottime);
            this.Controls.Add(this.setMovieDate);
            this.Controls.Add(this.dataGridViewMovieHallInfo);
            this.Controls.Add(this.dataGridViewMovieInfo);
            this.Name = "AssignMovieToHall";
            this.Text = "Assign Movie To Hall/ Sell Ticket";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AssignMovieToHall_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovieInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovieHallInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMovieInfo;
        private System.Windows.Forms.DataGridView dataGridViewMovieHallInfo;
        private MetroFramework.Controls.MetroDateTime setMovieDate;
        private MetroFramework.Controls.MetroComboBox setSlottime;
        private MetroFramework.Controls.MetroTextBox setMovieIdtxt;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel setDate;
        private MetroFramework.Controls.MetroLabel setTime;
        private MetroFramework.Controls.MetroLabel setMovieId;
        private MetroFramework.Controls.MetroLabel setHallIdLabel;
        private MetroFramework.Controls.MetroLabel ssHallIdlbl;
        private MetroFramework.Controls.MetroTextBox setHallIdTxt;
        private System.Windows.Forms.Button metroButton1;
        private System.Windows.Forms.Button assignHall_button;
    }
}