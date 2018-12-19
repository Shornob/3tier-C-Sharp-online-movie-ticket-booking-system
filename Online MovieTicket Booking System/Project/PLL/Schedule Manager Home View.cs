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
    public partial class Schedule_Manager_Home : MetroFramework.Forms.MetroForm, IEmployee
    {
        public employee Emp { get { return x; } set { x = value; } }
        public employee x = new employee();
        public Schedule_Manager_Home(employee d)
        {
            InitializeComponent();
            x = x.loginValidation(d);
            Reload();
        }

        public void Reload()
        {
            eName.Text = x.Name;
            eEmail.Text = x.email;
            eMobile.Text = x.mobileNo;
            eAddress.Text = x.address;
            eGender.Text = x.gender;
        }

        private void Logoutbutton_Click(object sender, EventArgs e)
        {
            FormLogin fl = new FormLogin();
            this.Hide();
            fl.Show();
        }

        private void movie_List_button_Click(object sender, EventArgs e)
        {
            Delete_Movie dm = new Delete_Movie(x);
            this.Hide();
            dm.Show();
        }

        private void Chg_Pw_button_Click(object sender, EventArgs e)
        {
            Change_Password cp = new Change_Password(this, x);
            this.Hide();
            cp.Show();
        }

        private void Schedule_Manager_Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Add_movie_button_Click(object sender, EventArgs e)
        {
            Add_Movie am = new Add_Movie(x);
            this.Hide();
            am.Show();
        }

        private void Edit_Profile_button_Click(object sender, EventArgs e)
        {
            Edit_Profile ep = new Edit_Profile(this, x);
            this.Hide();
            ep.Show();
        }

        private void MDUpdatebutton_Click(object sender, EventArgs e)
        {
            Movie_Date_Update mdu = new Movie_Date_Update(x);
            this.Hide();
            mdu.Show();
        }

        private void buttonAssignMovieToHall_Click(object sender, EventArgs e)
        {
            AssignMovieToHall amth = new AssignMovieToHall(4,x);
            this.Hide();
            amth.Show();
        }

        private void Schedule_Manager_Home_Load(object sender, EventArgs e)
        {

        }
    }
}
