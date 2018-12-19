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
    public partial class FormAdminHome : MetroFramework.Forms.MetroForm, IEmployee
    {
        public employee emp = new employee();
        public employee Emp { get { return emp; } set { emp = value; } }
        public FormAdminHome(employee d)
        {
            InitializeComponent();

            emp=emp.loginValidation(d);

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

     /*   private void InitializeComponent()
        {
            throw new NotImplementedException();
        }
        */
        private void FormAdminHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Sell_History_button_Click(object sender, EventArgs e)
        {
            Sell_History sh = new Sell_History(emp);
            this.Hide();
            sh.Show();
        }

        private void Chg_Pw_button_Click(object sender, EventArgs e)
        {
            Change_Password cp = new Change_Password(this, emp);
            this.Hide();
            cp.Show();
        }

        private void Add_Manager_button_Click(object sender, EventArgs e)
        {
            Add_Manager mg = new Add_Manager(emp,1);
            this.Hide();
            mg.Show();
        }

        private void Logout_button_Click(object sender, EventArgs e)
        {
            FormLogin fl = new FormLogin();
            this.Hide();
            fl.Show();
        }

        private void Emp_List_button_Click(object sender, EventArgs e)
        {
            Employee_List el = new Employee_List(emp);
            this.Hide();
            el.Show();
        }

        private void Edit_Profile_button_Click(object sender, EventArgs e)
        {
            Edit_Profile ep = new Edit_Profile(this, emp);
            this.Hide();
            ep.Show();
        }

        private void Add_employee_button_Click(object sender, EventArgs e)
        {
            //Add_Employee mg = new Add_Employee(x);
          //  this.Hide();
           // mg.Show();
        }

        private void FormAdminHome_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
