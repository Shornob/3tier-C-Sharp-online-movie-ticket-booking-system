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
    public partial class Employee_Home : MetroFramework.Forms.MetroForm, IEmployee

    {
        public employee emp = new employee();
        public employee Emp { get { return emp; } set { emp = value; } }
        public Employee_Home(employee d)
        {
            InitializeComponent();
            emp = emp.loginValidation(d);

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

        public Employee_Home()
        { }


        private void Logout_button_Click(object sender, EventArgs e)
        {
            FormLogin fl = new FormLogin();
            this.Hide();
            fl.Show();
        }

        private void Tck_book_button_Click(object sender, EventArgs e)
        {
            Ticket_Booking tb = new Ticket_Booking(emp);
            this.Hide();
            tb.Show();
        }


        private void Employee_Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void Chg_Pw_button_Click(object sender, EventArgs e)
        {
            Change_Password cp = new Change_Password(this, emp);
            this.Hide();
            cp.Show();
        }

        private void Sell_Cancel_button_Click(object sender, EventArgs e)
        {
           AssignMovieToHall sc = new AssignMovieToHall(3,emp);
            this.Hide();
            sc.Show();

        }

        private void Edit_Profile_button_Click(object sender, EventArgs e)
        {
            Edit_Profile ep = new Edit_Profile(this, emp);
            this.Hide();
            ep.Show();
        }

        private void Print_button_Click(object sender, EventArgs e)
        {
            Print_Ticket pt = new Print_Ticket(emp);
            this.Hide();
            pt.Show();
        }

        private void Employee_Home_Load(object sender, EventArgs e)
        {

        }
    }
}
