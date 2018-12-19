using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.BLL;
using Project.PLL;

namespace MovieTicketBookingSystem.PLL
{
    public partial class Edit_Profile : MetroFramework.Forms.MetroForm
    {
        employee emp = new employee();
        Form previousForm;

        public Edit_Profile(Form previousForm, employee emp)
        {
            InitializeComponent();
            this.emp = emp;
            this.previousForm = previousForm;
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

        private void Edit_Profile_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Edit_Profile_Load(object sender, EventArgs e)
        {

        }

        private bool VerifyEmail(string email)
        {
            return Regex.IsMatch(email, @".+@.+\...+", RegexOptions.IgnoreCase);
        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            string phone = textBoxPhone.Text;
            string address = richTextBoxAddress.Text;

            if (!VerifyEmail(email))
            {
                MessageBox.Show("Invalid email address");
                return;
            }

            try
            {
                // string id, string name, string email, string address, int sts, string phone, float salary
                if (emp.UpdatePerson(emp.employeeId, emp.Name, email, address, int.Parse(emp.role), phone, emp.salary))
                {
                    MessageBox.Show("Profile updated");

                    var f = (IEmployee)previousForm;
                    f.Emp.mobileNo = phone;
                    f.Emp.address = address;
                    f.Emp.email = email;
                    f.Reload();
                }
                else
                {
                    MessageBox.Show("Failed to update profile");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Failed to update profile. Invalid input(s).");
                MessageBox.Show(exc.Message);
            }
            textBoxEmail.Text = textBoxPhone.Text = richTextBoxAddress.Text = string.Empty;
        }
    }
}

