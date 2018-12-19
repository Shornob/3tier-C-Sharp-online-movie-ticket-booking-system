using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.BLL;
using Project.DLL;

namespace MovieTicketBookingSystem.PLL
{
    public partial class Change_Password : MetroFramework.Forms.MetroForm
    {
        employee emp;
        Form previousForm;

        public Change_Password(Form previousForm, employee aa)
        {
            InitializeComponent();

            this.emp = aa;
            this.previousForm = previousForm;
        }
        private void Change_Password_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            // first check if both new passwords match
            // then check if password update is success
            if (textBox1.Text == textBox2.Text)
            {
                if (emp.UpdatePassword(emp, textBoxOld.Text, textBox1.Text))
                {
                    MessageBox.Show("Password updated successfully");
                }
                else
                {
                    MessageBox.Show("Failed to update password");
                }
            }
            else
            {
                MessageBox.Show("New passwords don't match, try again");
            }
            textBoxOld.Text = textBox1.Text = textBox2.Text = string.Empty;
        }

        private void Logout_button_Click(object sender, EventArgs e)
        {
            FormLogin fl = new FormLogin();
            this.Hide();
            fl.Show();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Hide();
        }

        private void Change_Password_Load(object sender, EventArgs e)
        {

        }
    }
}
