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
    public partial class FormLogin : MetroFramework.Forms.MetroForm
    {
      
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            /*if (usernametextbox.Text.Equals("1"))
             {
                 FormAdminHome ah = new FormAdminHome();
                 this.Hide();
                 ah.Show();
             }
             else if (usernametextbox.Text.Equals("2"))
             {
                 Manager_Home mh = new Manager_Home();
                 this.Hide();
                 mh.Show();
             }
             else if (usernametextbox.Text.Equals("3"))
             {
                 Employee_Home hh = new Employee_Home();
                 this.Hide();
                 hh.Show();
             }
             else if (usernametextbox.Text.Equals("4"))
             {
                 Schedule_Manager_Home smg = new Schedule_Manager_Home();
                 this.Hide();
                 smg.Show();
             }*/
             employee x = new employee();
             x.employeeId = usernametextbox.Text;
             x.password= Passwordtextbox.Text;
             x= x.loginValidation(x);
            string role = x.role;
            if(role.Equals("none"))
            {
                MessageBox.Show("INVALID USERNAME OF PASSWORD");
            }
            else
            {
                if (role.Equals("1"))
                {
                    FormAdminHome ah = new FormAdminHome(x);
                    this.Hide();
                    ah.Show();
                }
                else if (role.Equals("2"))
                {
                    Manager_Home mh = new Manager_Home(x);
                    this.Hide();
                    mh.Show();
                }
                else if (role.Equals("3"))
                {
                    Employee_Home hh = new Employee_Home(x);
                    this.Hide();
                    hh.Show();
                }
                else if (role.Equals("4"))
                {
                    Schedule_Manager_Home smg = new Schedule_Manager_Home(x);
                    this.Hide();
                    smg.Show();
                }
              

            }

            
        }
        private void Exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void FormLogin_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
