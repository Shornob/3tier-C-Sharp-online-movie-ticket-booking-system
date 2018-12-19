using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.DLL;
using System.Data.SqlClient;
using System.Data;
using Project.BLL;
using System.Windows.Forms;

namespace Project.DLL
{
    class Dataaccess
    {

        SqlConnection con;
        public Dataaccess()
        {

            con = new SqlConnection(@"Data Source=TITLY-PC\SQLEXPRESS;Initial Catalog=Central_Cinema;Integrated Security=True;Max Pool Size=50000;Pooling=True");

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }


        public DataTable GetEmployee(string id, string password)
        {
            //    string query = string.Format("select logins.employeeId,employeesInfo.name,employeesInfo.gender,employeesContact.mobileNo,logins.status from employeesContact,employeesInfo,logins where employeesContact.employeeId=logins.employeeId and employeesInfo.employeeId=logins.employeeId;");

            string query = string.Format("select * from logins,employeesInfo,employeesContact,employeesSalary where  logins.employeeId='{0}' and logins.password='{1}' and employeesContact.employeeId=logins.employeeId and logins.employeeId=employeesInfo.employeeId and employeesInfo.employeeId=employeesSalary.employeeId ;", id, password);

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }


        public DataTable GetAllEmployees()
        {
            //    string query = string.Format("select logins.employeeId,employeesInfo.name,employeesInfo.gender,employeesContact.mobileNo,logins.status from employeesContact,employeesInfo,logins where employeesContact.employeeId=logins.employeeId and employeesInfo.employeeId=logins.employeeId;");

            string query = string.Format("select * from logins,employeesInfo,employeesContact,employeesSalary where employeesContact.employeeId=logins.employeeId and logins.employeeId=employeesInfo.employeeId and employeesInfo.employeeId=employeesSalary.employeeId ;");

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }




        //(string id,string name, string pass,string email,string dob, string religion, string address, float salary, int role,string phone, string bg ,string gender)

        public bool InsertIntoEmployeesInfo(string id, string name, DateTime dob, string religion, string bg, string gender)
        {
            //con.Open();
            string query = string.Format("INSERT INTO employeesInfo(employeeId,name,dateOfBirth,religion,bloodGroup,gender) VALUES('{0}','{1}','{2}','{3}','{4}','{5}')",id, name, dob,religion,bg,gender);
            SqlCommand cmd = new SqlCommand(query, con);
            int rows = -1;

            rows = cmd.ExecuteNonQuery();
                con.Close();
            if (rows >= 0)
            {
                return true;
            }                                 
            return false;
        }

        public bool InsertIntoEmployeesContact(string id, string mobile, string address, string email)
        {
            con.Open();
            string query = string.Format(@"INSERT INTO employeesContact(employeeId,mobileNo,address,email) VALUES('{0}','{1}','{2}','{3}')", id, mobile,address,email);
            SqlCommand cmd = new SqlCommand(query, con);
            int rows = -1;

            rows = cmd.ExecuteNonQuery();
            con.Close();
            if (rows >= 0)
            {
                return true;
            }
            return false;
        }

        public bool InsertIntologins(string id, string pass, int status)
        {
            con.Open();
            string query = string.Format("INSERT INTO logins(employeeId,password,status) VALUES('{0}','{1}','{2}')", id, pass,status);
            SqlCommand cmd = new SqlCommand(query, con);
            int rows = -1;

            rows = cmd.ExecuteNonQuery();
            con.Close();

           // Console.WriteLine("ulala1");
            if (rows >= 0)
            {
                return true;
            }
            return false;
        }

        public bool InsertIntoEmployeeSalary(string id, float salary)
        {
            con.Open();
            string query = string.Format("INSERT INTO employeesSalary(employeeId,salary,bonus) VALUES('{0}','{1}','{2}')", id, salary, 0.0f);
            SqlCommand cmd = new SqlCommand(query, con);
            int rows = -1;

            rows = cmd.ExecuteNonQuery();
            con.Close();

            // Console.WriteLine("ulala1");
            if (rows >= 0)
            {
                return true;
            }
            return false;
        }

        public bool UpdateSalary(string id, float salary)
        {
            con.Close();
            con.Open();
            

            string query = string.Format("UPDATE employeesSalary SET salary={0} WHERE employeeId='{1}' ", salary,id);
            SqlCommand cmd = new SqlCommand(query, con);
            int rows = -1;
            rows = cmd.ExecuteNonQuery();
            if (rows >= 0)
            {
                return true;
            }
            return false;
        }

        public bool UpdateInfo(string id, string name)
        {
            con.Close();
            con.Open();
            string query = string.Format("UPDATE employeesInfo SET name='{0}' WHERE employeeId='{1}' ", name,id);
            SqlCommand cmd = new SqlCommand(query, con);
            int rows = -1;
            rows = cmd.ExecuteNonQuery();
            if (rows >= 0)
            {
                return true;
            }
            return false;
        }

        public bool UpdateContact(string id, string email,string address,string phone)
        {
            con.Close();
            con.Open();
            string query = string.Format("UPDATE employeesContact SET email='{0}',address='{1}',mobileNo='{2}' WHERE employeeId='{3}' ", email,address,phone,id );
            SqlCommand cmd = new SqlCommand(query, con);

            int rows = -1;
            rows = cmd.ExecuteNonQuery();
            if (rows >= 0)
            {
                return true;
            }
            return false;
        }

        public bool UpdateSts(string id,int sts)
        {
            con.Close();
            con.Open();
            string query = string.Format("UPDATE logins SET status={0} WHERE employeeId='{1}' ", sts, id);
            SqlCommand cmd = new SqlCommand(query, con);
            int rows = -1;
            rows = cmd.ExecuteNonQuery();
            if (rows >= 0)
            {
                return true;
            }
            return false;
        }

        public bool UpdatePassword(employee emp, string oldPassword, string newPassword)
        {
            con.Close();
            con.Open();
            string query = string.Format("UPDATE logins SET password='{0}' WHERE employeeId='{1}' AND password='{2}' ", newPassword, emp.employeeId, oldPassword);
            SqlCommand cmd = new SqlCommand(query, con);
            int rows = -1;
            rows = cmd.ExecuteNonQuery();
            if (rows >= 0)
            {
                return true;
            }
            return false;
        }

        public bool Delete(string id)
        {
            con.Open();
            string query = string.Format("DELETE FROM logins WHERE employeeId={0} ", id);
            SqlCommand cmd = new SqlCommand(query, con);
            int rows = -1;
            rows = cmd.ExecuteNonQuery();
            if (rows >= 0)
            {
                return true;
            }
            return false;
        }

        public DataTable Search(String searchText)
        {
            string query = string.Format("select * from logins,employeesInfo,employeesContact,employeesSalary where employeesContact.employeeId=logins.employeeId and logins.employeeId=employeesInfo.employeeId and employeesInfo.employeeId=employeesSalary.employeeId and employeesInfo.name like '%{0}%'", searchText );

            SqlCommand cmd1 = new SqlCommand(query, con);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            con.Close();
            return dt1;
        }

    }
}
