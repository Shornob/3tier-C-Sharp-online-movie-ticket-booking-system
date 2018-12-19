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
using Project.PLL;

namespace MovieTicketBookingSystem.PLL
{
    public partial class Manager_Home : MetroFramework.Forms.MetroForm, IEmployee
    {
        public employee emp = new employee();

        public employee Emp { get { return emp; } set { emp = value; } }

        public Manager_Home(employee x)
        {
            InitializeComponent();

            emp = emp.loginValidation(x);
            Reload();
        }

        public void Reload()
        {
            eName.Text = emp.Name;
            eEmail.Text = emp.email;
            eMobile.Text = emp.mobileNo;
            eAddress.Text = emp.address;
            eGender.Text = emp.gender;
        }
        public Manager_Home()
        {

        }

        private void Chg_Pw_button_Click(object sender, EventArgs e)
        {
            Change_Password cp = new Change_Password(this, emp);
            this.Hide();
            cp.Show();
        }

        private void Logout_button_Click(object sender, EventArgs e)
        {
            FormLogin fl = new FormLogin();
            this.Hide();
            fl.Show();
        }

        private void Add_Emp_button_Click(object sender, EventArgs e)
        {
            Add_Manager am= new Add_Manager(emp,2);
           // Add_Employee ae = new Add_Employee();
            this.Hide();
            am.Show();
        }

        private void Add_Hall_button_Click(object sender, EventArgs e)
        {
            Add_Hall ah = new Add_Hall();
            this.Hide();
            ah.Show();
        }

        private void Emp_List_button_Click(object sender, EventArgs e)
        {
            Employee_List ml = new Employee_List(emp);
            this.Hide();
            ml.Show();
        }

        private void Manager_Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Edit_Profile_button_Click(object sender, EventArgs e)
        {
            Edit_Profile ep = new Edit_Profile(this, emp);
            this.Hide();
            ep.Show();
        }

        private void Manager_Home_Load(object sender, EventArgs e)
        {

        }

        private void buttonSellHistory_Click(object sender, EventArgs e)
        {
            Sell_History sh = new Sell_History(emp);
            this.Hide();
            sh.Show();
        }
    }
}
