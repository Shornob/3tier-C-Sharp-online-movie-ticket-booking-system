namespace MovieTicketBookingSystem.PLL
{
    partial class Ticket_Booking
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
            this.Back_button = new System.Windows.Forms.Button();
            this.Logout_button = new System.Windows.Forms.Button();
            this.Search_Movie_button = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.movieListdataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.movieListdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Back_button
            // 
            this.Back_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Back_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Back_button.FlatAppearance.BorderSize = 0;
            this.Back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back_button.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_button.Location = new System.Drawing.Point(653, 128);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(82, 33);
            this.Back_button.TabIndex = 99;
            this.Back_button.Text = "Back";
            this.Back_button.UseVisualStyleBackColor = false;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // Logout_button
            // 
            this.Logout_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Logout_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Logout_button.FlatAppearance.BorderSize = 0;
            this.Logout_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout_button.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout_button.Location = new System.Drawing.Point(653, 78);
            this.Logout_button.Name = "Logout_button";
            this.Logout_button.Size = new System.Drawing.Size(82, 33);
            this.Logout_button.TabIndex = 98;
            this.Logout_button.Text = "Logout";
            this.Logout_button.UseVisualStyleBackColor = false;
            this.Logout_button.Click += new System.EventHandler(this.Logout_button_Click);
            // 
            // Search_Movie_button
            // 
            this.Search_Movie_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Search_Movie_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Search_Movie_button.FlatAppearance.BorderSize = 0;
            this.Search_Movie_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_Movie_button.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_Movie_button.Location = new System.Drawing.Point(280, 117);
            this.Search_Movie_button.Name = "Search_Movie_button";
            this.Search_Movie_button.Size = new System.Drawing.Size(129, 34);
            this.Search_Movie_button.TabIndex = 97;
            this.Search_Movie_button.Text = "Search a Movie";
            this.Search_Movie_button.UseVisualStyleBackColor = false;
            this.Search_Movie_button.Click += new System.EventHandler(this.Search_Movie_button_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(100, 125);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(143, 20);
            this.textBoxSearch.TabIndex = 96;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.Search_Movie_button_Click);
            // 
            // movieListdataGridView
            // 
            this.movieListdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.movieListdataGridView.Location = new System.Drawing.Point(23, 189);
            this.movieListdataGridView.Name = "movieListdataGridView";
            this.movieListdataGridView.Size = new System.Drawing.Size(712, 299);
            this.movieListdataGridView.TabIndex = 95;
            this.movieListdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.movieListdataGridView_CellContentClick);
            // 
            // Ticket_Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 571);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.Logout_button);
            this.Controls.Add(this.Search_Movie_button);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.movieListdataGridView);
            this.Name = "Ticket_Booking";
            this.Text = "Ticket Booking/ Movie List";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ticket_Booking_FormClosing);
            this.Load += new System.EventHandler(this.Ticket_Booking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.movieListdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.Button Logout_button;
        private System.Windows.Forms.Button Search_Movie_button;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.DataGridView movieListdataGridView;
    }
}