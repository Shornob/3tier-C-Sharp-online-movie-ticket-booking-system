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
    public partial class Employee_List : MetroFramework.Forms.MetroForm
    {
        employee x = new employee();
        employee aa = new employee();

        public Employee_List(employee a)
        {
            InitializeComponent();
            aa = a;
            //employeelistdataGridView.DataSource = null;
         //   employeelistdataGridView.ColumnCount = 5;
            employeelistdataGridView.DataSource = x.GetAllEmployee();

            employeelistdataGridView.Columns[5].Visible = false;

            employeelistdataGridView.Columns[6].Visible = false;

            employeelistdataGridView.Columns[7].Visible = false;

            employeelistdataGridView.Columns[8].Visible = false;

            employeelistdataGridView.Columns[9].Visible = false;

            employeelistdataGridView.Columns[10].Visible = false;

            employeelistdataGridView.Columns[11].Visible = false;

            employeelistdataGridView.Columns[12].Visible = false;

            employeelistdataGridView.Columns[13].Visible = false;

        }

        

        void GridUpdate()
        {
            employeelistdataGridView.DataSource = x.GetAllEmployee();

            employeelistdataGridView.Columns[5].Visible = false;

            employeelistdataGridView.Columns[6].Visible = false;

            employeelistdataGridView.Columns[7].Visible = false;

            employeelistdataGridView.Columns[8].Visible = false;

            employeelistdataGridView.Columns[9].Visible = false;

            employeelistdataGridView.Columns[10].Visible = false;

            employeelistdataGridView.Columns[11].Visible = false;

            employeelistdataGridView.Columns[12].Visible = false;

            employeelistdataGridView.Columns[13].Visible = false;
        }

        private void Logout_button_Click(object sender, EventArgs e)
        {
            FormLogin fl = new FormLogin();
            this.Hide();
            fl.Show();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            /* FormAdminHome ah = new FormAdminHome(aa);
             this.Hide();
             ah.Show();*/
            if (aa.role.Equals("2"))
            {
                Manager_Home ah = new Manager_Home(aa);
                this.Hide();
                ah.Show();
            }
            else
            {
                FormAdminHome fah = new FormAdminHome(aa);
                this.Hide();
                fah.Show();
            }
        }

        private void employeelistdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            x.employeeId = employeelistdataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            employeeIdlabelname.Text = "Employee Id :" + x.employeeId.ToString();
            x.Name = employeelistdataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            x.gender = employeelistdataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            x.role = employeelistdataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            x.mobileNo = employeelistdataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            x.age = int.Parse(employeelistdataGridView.Rows[e.RowIndex].Cells[5].Value.ToString());
            x.salary = float.Parse(employeelistdataGridView.Rows[e.RowIndex].Cells[6].Value.ToString());
            x.dateOfBirth = Convert.ToDateTime(employeelistdataGridView.Rows[e.RowIndex].Cells[7].Value);
            x.password = employeelistdataGridView.Rows[e.RowIndex].Cells[8].Value.ToString();
            x.bloodGroup = employeelistdataGridView.Rows[e.RowIndex].Cells[9].Value.ToString();
            x.bonusPercentage = float.Parse(employeelistdataGridView.Rows[e.RowIndex].Cells[10].Value.ToString());
            x.email = employeelistdataGridView.Rows[e.RowIndex].Cells[11].Value.ToString();
            x.address = employeelistdataGridView.Rows[e.RowIndex].Cells[12].Value.ToString();
            x.religion = employeelistdataGridView.Rows[e.RowIndex].Cells[13].Value.ToString();

            //  x.salary = float.Parse(employeelistdataGridView.Rows[e.RowIndex].Cells[15].Value.ToString());

            

        }

        private void Del_Emp_button_Click(object sender, EventArgs e)
        {

            if (aa.employeeId.Equals(x.employeeId))
            {
                MessageBox.Show("Can Not Delete Own Information");
            }
            else
            {

                if (aa.role.Equals("2") && !x.role.Equals("Employee"))
                {
                    MessageBox.Show("Unprivileged Access ");
                }
                else
                {
                    bool i = x.DeletePerson(x.employeeId);
                    if (i)
                    {

                        MessageBox.Show("Employee Deleted");
                        GridUpdate();
                    }
                    else { MessageBox.Show("Error occured"); }

                }
            }
        }

        private void Edit_Emp_button_Click(object sender, EventArgs e)
        {
            if (aa.employeeId.Equals(x.employeeId))
            {
                MessageBox.Show("Can Not Edit Own Information");
            }
            else
            {
                if (aa.role.Equals("2")&&!x.role.Equals("Employee"))
                {
                    MessageBox.Show("Unprivileged Access ");
                }
                else
                {
                    Add_Manager mg = new Add_Manager(aa, x);
                    this.Hide();
                    mg.Show();
                }
             
            }
        }

        private void Employee_List_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Employee_List_Load(object sender, EventArgs e)
        {

        }

        private void GridSearchEmployee()
        {
            x.SearchEmployee(textBoxSearch.Text);
        }

        private void Search_button_Click(object sender, EventArgs e)
        {

            //x.SearchEmployee(textBoxSearch.Text);
            String ss = "" + textBoxSearch.Text;

            employeelistdataGridView.DataSource = x.SearchEmployee(ss);

            employeelistdataGridView.Columns[5].Visible = false;

            employeelistdataGridView.Columns[6].Visible = false;

            employeelistdataGridView.Columns[7].Visible = false;

            employeelistdataGridView.Columns[8].Visible = false;

            employeelistdataGridView.Columns[9].Visible = false;

            employeelistdataGridView.Columns[10].Visible = false;

            employeelistdataGridView.Columns[11].Visible = false;

            employeelistdataGridView.Columns[12].Visible = false;

            employeelistdataGridView.Columns[13].Visible = false;
        }
    }
}
