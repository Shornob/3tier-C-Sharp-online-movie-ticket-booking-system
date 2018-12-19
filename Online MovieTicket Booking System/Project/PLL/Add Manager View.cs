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

namespace MovieTicketBookingSystem.PLL
{
    public partial class Add_Manager : MetroFramework.Forms.MetroForm
    {
        employee e1 = new employee();
        employee e2 = new employee();
        public int x;
        //   employee x = new employee();

        //  public Add_Manager(string name, string pass, string email, string dob, string religion, string address, float salary, int role, string phone, string bg, string gender)
        public Add_Manager(employee aa, employee p)
        {

            InitializeComponent();
            e2 = aa;
            EmployeeIdLabel.Text = p.employeeId;
            if (p.role.Equals("Manager"))
            {
                employeeType.Text = "Manager";
            }
            else if (p.role.Equals("Schedule Manager"))
            {
                employeeType.Text = "Schedule Manager";
            }
            else if (p.role.Equals("Employee"))
            {
                employeeType.Text = "Employee";
            }
            else { }
            textBoxEmployeeName.Text = p.Name;
            if (p.gender.Equals("male"))
            {
                radioButtonMale.Enabled = true;
                radioButtonFemale.Enabled = false;

                radioButtonOther.Enabled = false;

            }
            else if (p.gender.Equals("female"))
            {
                radioButtonFemale.Enabled = true;
                radioButtonMale.Enabled = false;
                radioButtonOther.Enabled = false;
            }
            else
            {
                radioButtonFemale.Enabled = false;
                radioButtonMale.Enabled = false;
                radioButtonOther.Enabled = true;
            }

            textBoxPhone.Text = p.mobileNo;
            dateTimePickerBirthDate.Value = p.dateOfBirth;
            textBoxEmail.Text = p.email;
            textBoxPassword.Text = p.password;
            // textBoxReligion.Text
            textboxsalary.Text = p.salary.ToString();
            richTextBoxAddress.Text = p.address;
            comboBoxBloodGroup.Text = p.bloodGroup;
            textBoxPassword.Text = p.password;
            textBoxReligion.Text = p.religion;
            comboBoxBloodGroup.Enabled = false;
            textBoxReligion.Enabled = false;
            textBoxPassword.Enabled = false;
            Add_Mgr_button.Text = "Update";
        }

        public Add_Manager(employee aa, int x)
        {
            InitializeComponent();
            this.x = x;
            if (x == 2)
            {
                employeeType.Text = "Employee";
                employeeType.Enabled = false;
                e2 = aa;
            }
            else
            {
                e2 = aa;
            }
        }

        private void Add_Manager_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }



        private void Logout_button_Click(object sender, EventArgs e)
        {
            FormLogin fl = new FormLogin();
            this.Hide();
            fl.Show();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            /*FormAdminHome ah = new FormAdminHome(e2);
            this.Hide();
            ah.Show();*/

            if (e2.role.Equals("2"))
            {
                Manager_Home ah = new Manager_Home(e2);
                this.Hide();
                ah.Show();
            }
            else
            {
                FormAdminHome fah = new FormAdminHome(e2);
                this.Hide();
                fah.Show();
            }
        }

        private void Add_Mgr_button_Click(object sender, EventArgs e)
        {
            string id = EmployeeIdLabel.Text;
            string name = textBoxEmployeeName.Text;
            string pass = textBoxPassword.Text;
            string email = textBoxEmail.Text;
            DateTime dob = dateTimePickerBirthDate.Value;
            string religion = textBoxReligion.Text;
            string phone = textBoxPhone.Text;
            string bg = comboBoxBloodGroup.Text;
            //  float salary = textboxsalary.Text;
            string gender = "";

            if (radioButtonFemale.Checked == true)
            {
                gender = "female";

            }
            else if (radioButtonMale.Checked == true)
            {
                gender = "male";
            }
            else
            {
                gender = "others";
            }

            float salary = float.Parse(textboxsalary.Text);

            string address = richTextBoxAddress.Text;

            int sts = 1;

            if (employeeType.Text.Equals("Manager"))
            {
                sts = 2;
            }
            else if (employeeType.Text.Equals("Schedule Manager"))
            {
                sts = 4;
            }
            else if (employeeType.Text.Equals("Employee"))
            {
                sts = 3;
            }
            else { }

            if (Add_Mgr_button.Text.Equals("Add Employee"))
            {

                // Console.WriteLine(name + " " + pass);
                if (employeeType.Text.Equals("Manager"))
                {

                    bool q = e1.Createemployee(name, pass, email, dob, religion, address, salary, 2, phone, bg, gender);

                    if (q == true)
                    {
                        MessageBox.Show("Manager Added");
                        Add_Manager am = new Add_Manager(this.e2, this.x);
                        this.Hide();
                        am.Show();
                    }
                    else
                    {
                        MessageBox.Show("Error Occured");
                    }
                }
                else if (employeeType.Text.Equals("Schedule Manager"))
                {
                    bool q = e1.Createemployee(name, pass, email, dob, religion, address, salary, 4, phone, bg, gender);
                    if (q == true)
                    {
                        MessageBox.Show("Schedule Manager Added");

                    }
                    else
                    {
                        MessageBox.Show("Error Occured");
                    }
                }
                else if (employeeType.Text.Equals("Employee"))
                {
                    bool q = e1.Createemployee(name, pass, email, dob, religion, address, salary, 3, phone, bg, gender);
                    if (q == true)
                    {
                        MessageBox.Show("Employee Added");



                    }
                    else
                    {
                        MessageBox.Show("Error Occured");
                    }
                }
                else
                {
                    MessageBox.Show("Please Select Employee Type");
                }
            }
            else if (Add_Mgr_button.Text.Equals("Update"))
            {
                //  MessageBox.Show(id);
                //MessageBox.Show(""+sts);

                bool q = e1.UpdatePerson(id, name, email, address, sts, phone, salary);

                if (q == true)
                {
                    MessageBox.Show("Employee Updated");

                }
                else
                {
                    MessageBox.Show("Error Occured");
                }
            }

            EmployeeIdLabel.Text = textBoxPassword.Text = textBoxEmail.Text = textBoxReligion.Text = textBoxPhone.Text = comboBoxBloodGroup.Text = textboxsalary.Text=string.Empty;
        }

        private void Add_Manager_Load(object sender, EventArgs e)
        {

        }
    }
}

