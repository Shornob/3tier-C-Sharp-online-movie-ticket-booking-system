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
    public partial class Add_Employee : MetroFramework.Forms.MetroForm

    {
        public Add_Employee()
        {
            InitializeComponent();

        }

        private void Logout_button_Click(object sender, EventArgs e)
        {
            FormLogin fl = new FormLogin();
            this.Hide();
            fl.Show();
        }


        private void Add_Employee_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            Manager_Home mh = new Manager_Home();
            this.Hide();
            mh.Show();
        }

        private void Add_Employee_Load(object sender, EventArgs e)
        {

        }

        private void Add_Emp_button_Click(object sender, EventArgs e)
        {

        }
    }
}
