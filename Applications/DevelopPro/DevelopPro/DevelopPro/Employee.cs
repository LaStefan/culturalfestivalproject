using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace DevelopPro
{
    class Employee
    {
        private int employeeId;
        private string employeeName;
        private string employeePassword;
        private int departmentId;
        private string conn;
        private MySqlConnection connection;

        public int EmployeeId { get { return this.employeeId; } }
        public string EmployeeName { get { return this.employeeName; } }
        public string EmployeePassword { get { return this.employeePassword; } }

        private void DatabaseConnection()
        {
            try
            {
                conn = "server=studmysql01.fhict.local; " +
                                       "database=dbi401148;" +
                                        "user id=dbi401148;" +
                                        "password=123456789;";
                connection = new MySqlConnection(conn);
                connection.Open();
            }
            catch (Exception ex)
            {
                
            }
        }

        public bool ValidateLogIn(string username, string password)
        {
            DatabaseConnection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM employee WHERE username = '" + this.employeeName + "' AND password = '" + this.EmployeePassword + "'";
            cmd.Connection = connection;
            MySqlDataReader logIn = cmd.ExecuteReader();

            if (logIn.Read())
            {
                connection.Close();
                return true;
            }
            else
            {
                connection.Close();
                return false;
            }

        }

        public Employee(string name, string pass)
        {
            name = this.employeeName;
            pass = this.EmployeePassword;
        }
    }
}
