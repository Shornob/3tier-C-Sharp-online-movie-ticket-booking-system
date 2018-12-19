using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.DLL;

namespace Project.BLL
{
    public class employee
    {
        
        public string employeeId { get; set; }
        public string Name { get; set; }
        public string gender { get; set; }
        public string role { get; set; }
        public string mobileNo { get; set; }
        public int age { get; set; }
        public float salary { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string password { get; set; }
        public string bloodGroup { get; set; }
        public float bonusPercentage { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public string religion { get; set; }

        Dataaccess da = new Dataaccess();
        employee e1;
        employee s;
       

        public List<employee> GetAllEmployee()
        {
            var Employee = da.GetAllEmployees();
            List<employee> list = new List<employee>();
            for (int i = 0; i < Employee.Rows.Count; i++)
            {
                e1 = new employee();
                e1.employeeId = Employee.Rows[i][0].ToString();
                e1.password= Employee.Rows[i][1].ToString();
                e1.role = Employee.Rows[i][2].ToString();
                e1.Name = Employee.Rows[i][3].ToString();
                e1.dateOfBirth= Convert.ToDateTime( Employee.Rows[i][4]);
                e1.gender = Employee.Rows[i][5].ToString();
                e1.religion = Employee.Rows[i][7].ToString();
                e1.bloodGroup = Employee.Rows[i][8].ToString();
                e1.mobileNo = Employee.Rows[i][9].ToString();         
                e1.address = Employee.Rows[i][10].ToString();
                e1.email = Employee.Rows[i][12].ToString();
                e1.salary= float.Parse(Employee.Rows[i][14].ToString());
                if (e1.role == "1")
                {
                    e1.role = "Admin";
                }
                else if (e1.role == "2")
                {

                    e1.role = "Manager";
                }
                else if (e1.role == "3")
                {

                    e1.role = "Employee";

                }
                else if (e1.role == "4")
                {

                    e1.role = "Schedule Manager";
                }
                
                else { }
                list.Add(e1);
            }
            return list;
        }

        public bool Createemployee(string name, string pass, string email, DateTime dob, string religion, string address, float salary, int role, string phone, string bg,string gender)
        {
            //string id = "1";// Guid.NewGuid().ToString();
            string id = DateTime.Now.ToString("mmss");
            bool a, b, c,d;

            a = da.InsertIntoEmployeesInfo( id,  name,  dob,  religion,  bg,  gender);
            b = da.InsertIntoEmployeesContact( id,phone,  address,  email);
            c = da.InsertIntologins( id,  pass, role);
            d = da.InsertIntoEmployeeSalary(id, salary);
            Console.WriteLine(name + " " + pass+" emp er vhitor");

            if (a== true && b== true && c==true && d==true)
            {
                return true;
            }
            else
            {
                return false;

            }
           // return da.Insert( id, name,  pass,  email,  dob,  religion,  address,  salary,  role,  phone,bg,gender);
        }

        // public bool InsertIntoEmployeesContact(string id, string mobile, string address, string email)
        public bool UpdatePerson(string id, string name, string email, string address, int sts, string phone, float salary)
        {
            bool a = da.UpdateSalary(id, salary);
            bool b = da.UpdateContact(id, email, address, phone);
            bool c = da.UpdateSts(id, sts);
            bool d = da.UpdateInfo(id, name);

            return a && b && c && d;
        }

        public bool UpdatePassword(employee emp, string oldPassword, string newPassword)
        {
            return da.UpdatePassword(emp, oldPassword, newPassword);
        }

        public bool DeletePerson(string id)
        {
            return da.Delete(id);
        }

        public employee loginValidation(employee a)
        {
            employee f = new employee();
            f.role = "none";
            var Employee = da.GetEmployee(a.employeeId, a.password);
            if (Employee.Rows.Count > 0)
            {
                int i = 0;
                e1 = new employee();
                e1.employeeId = Employee.Rows[i][0].ToString();
                e1.password = Employee.Rows[i][1].ToString();
                e1.role = Employee.Rows[i][2].ToString();
                e1.Name = Employee.Rows[i][3].ToString();
                e1.dateOfBirth = Convert.ToDateTime(Employee.Rows[i][4]);
                e1.gender = Employee.Rows[i][5].ToString();
                e1.religion = Employee.Rows[i][7].ToString();
                e1.bloodGroup = Employee.Rows[i][8].ToString();
                e1.mobileNo = Employee.Rows[i][9].ToString();
                e1.address = Employee.Rows[i][10].ToString();
                e1.email = Employee.Rows[i][12].ToString();
                e1.salary = float.Parse(Employee.Rows[i][14].ToString());
                return e1;
            }

            else { return f; }
        }

        public List<employee> SearchEmployee(String searchText)
        {
            var Employee = da.Search(searchText);
            List<employee> searchList = new List<employee>();
            for (int i = 0; i < Employee.Rows.Count; i++)
            {
                s = new employee();
                s.employeeId = Employee.Rows[i][0].ToString();
                s.password = Employee.Rows[i][1].ToString();
                s.role = Employee.Rows[i][2].ToString();
                s.Name = Employee.Rows[i][3].ToString();
                s.dateOfBirth = Convert.ToDateTime(Employee.Rows[i][4]);
                s.gender = Employee.Rows[i][5].ToString();
                s.religion = Employee.Rows[i][7].ToString();
                s.bloodGroup = Employee.Rows[i][8].ToString();
                s.mobileNo = Employee.Rows[i][9].ToString();
                s.address = Employee.Rows[i][10].ToString();
                s.email = Employee.Rows[i][12].ToString();
                s.salary = float.Parse(Employee.Rows[i][14].ToString());
                if (s.role == "1")
                {
                    s.role = "Admin";
                }
                else if (s.role == "2")
                {
                    s.role = "Manager";
                }
                else if (s.role == "4")
                {
                    s.role = "Schedule Manager";
                }
                else if (s.role == "3")
                {
                    s.role = "Employee";
                }
                else {}
                searchList.Add(s);
            }
            return searchList;
        }

    }

}

