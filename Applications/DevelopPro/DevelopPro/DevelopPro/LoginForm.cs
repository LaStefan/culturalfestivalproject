using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace DevelopPro
{
    public partial class LoginForm : Form
    {
        private string conn;
        private MySqlConnection connection;
        public LoginForm()
        {
            InitializeComponent();
        }
        
        private void button7_Click(object sender, EventArgs e)
        {
           this.Close();
        }
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
                MessageBox.Show(ex.Message);
            }
        }

        public bool ValidateLogIn(string username, string password)
        {
            DatabaseConnection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM employee WHERE username = '" + tbUsername.Text + "' AND password = '" + tbPassword.Text + "'";
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
        private void btnLogIn_Click(object sender, EventArgs e)
        {

            string user = tbUsername.Text;
            string pass = tbPassword.Text;
            bool r = ValidateLogIn(user, pass);
            
            try
            {
                if (user == "" || pass == "")
                {
                    MessageBox.Show("Please fill in your username and password.");
                }
                else if(r)
                {
                    this.Hide();
                    Departments department = new Departments();
                    department.Show();
              
                }
                else
                {
                    MessageBox.Show("Incorrect username or password. Please try again!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
    }
}
