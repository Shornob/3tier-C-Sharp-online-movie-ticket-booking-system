namespace MovieTicketBookingSystem.PLL
{
    partial class Employee_List
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
            this.employeelistdataGridView = new System.Windows.Forms.DataGridView();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.Search_button = new System.Windows.Forms.Button();
            this.Logout_button = new System.Windows.Forms.Button();
            this.Back_button = new System.Windows.Forms.Button();
            this.Edit_Emp_button = new System.Windows.Forms.Button();
            this.Del_Emp_button = new System.Windows.Forms.Button();
            this.employeeIdlabelname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.employeelistdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // employeelistdataGridView
            // 
            this.employeelistdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeelistdataGridView.Location = new System.Drawing.Point(23, 169);
            this.employeelistdataGridView.Name = "employeelistdataGridView";
            this.employeelistdataGridView.Size = new System.Drawing.Size(518, 363);
            this.employeelistdataGridView.TabIndex = 0;
            this.employeelistdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeelistdataGridView_CellContentClick);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(23, 106);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(143, 20);
            this.textBoxSearch.TabIndex = 1;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.Search_button_Click);
            // 
            // Search_button
            // 
            this.Search_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Search_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Search_button.FlatAppearance.BorderSize = 0;
            this.Search_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_button.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_button.Location = new System.Drawing.Point(198, 92);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(129, 34);
            this.Search_button.TabIndex = 90;
            this.Search_button.Text = "Search Employee";
            this.Search_button.UseVisualStyleBackColor = false;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // Logout_button
            // 
            this.Logout_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Logout_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Logout_button.FlatAppearance.BorderSize = 0;
            this.Logout_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout_button.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout_button.Location = new System.Drawing.Point(592, 49);
            this.Logout_button.Name = "Logout_button";
            this.Logout_button.Size = new System.Drawing.Size(106, 33);
            this.Logout_button.TabIndex = 91;
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
            this.Back_button.Location = new System.Drawing.Point(592, 99);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(106, 33);
            this.Back_button.TabIndex = 92;
            this.Back_button.Text = "Back";
            this.Back_button.UseVisualStyleBackColor = false;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // Edit_Emp_button
            // 
            this.Edit_Emp_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Edit_Emp_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Edit_Emp_button.FlatAppearance.BorderSize = 0;
            this.Edit_Emp_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit_Emp_button.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_Emp_button.Location = new System.Drawing.Point(602, 429);
            this.Edit_Emp_button.Name = "Edit_Emp_button";
            this.Edit_Emp_button.Size = new System.Drawing.Size(118, 34);
            this.Edit_Emp_button.TabIndex = 93;
            this.Edit_Emp_button.Text = "Edit Employee";
            this.Edit_Emp_button.UseVisualStyleBackColor = false;
            this.Edit_Emp_button.Click += new System.EventHandler(this.Edit_Emp_button_Click);
            // 
            // Del_Emp_button
            // 
            this.Del_Emp_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Del_Emp_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Del_Emp_button.FlatAppearance.BorderSize = 0;
            this.Del_Emp_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Del_Emp_button.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Del_Emp_button.Location = new System.Drawing.Point(764, 429);
            this.Del_Emp_button.Name = "Del_Emp_button";
            this.Del_Emp_button.Size = new System.Drawing.Size(125, 34);
            this.Del_Emp_button.TabIndex = 94;
            this.Del_Emp_button.Text = "Delete Employee";
            this.Del_Emp_button.UseVisualStyleBackColor = false;
            this.Del_Emp_button.Click += new System.EventHandler(this.Del_Emp_button_Click);
            // 
            // employeeIdlabelname
            // 
            this.employeeIdlabelname.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.employeeIdlabelname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeIdlabelname.Location = new System.Drawing.Point(599, 348);
            this.employeeIdlabelname.Name = "employeeIdlabelname";
            this.employeeIdlabelname.Size = new System.Drawing.Size(290, 41);
            this.employeeIdlabelname.TabIndex = 95;
            this.employeeIdlabelname.Text = "Employee ID :";
            // 
            // Employee_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 571);
            this.Controls.Add(this.employeeIdlabelname);
            this.Controls.Add(this.Del_Emp_button);
            this.Controls.Add(this.Edit_Emp_button);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.Logout_button);
            this.Controls.Add(this.Search_button);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.employeelistdataGridView);
            this.Name = "Employee_List";
            this.Text = "Employee List";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Employee_List_FormClosing);
            this.Load += new System.EventHandler(this.Employee_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeelistdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView employeelistdataGridView;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.Button Logout_button;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.Button Edit_Emp_button;
        private System.Windows.Forms.Button Del_Emp_button;
        private System.Windows.Forms.Label employeeIdlabelname;
    }
}