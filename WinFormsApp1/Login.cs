using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp1
{
    
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();

        }

       
        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_password.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string mysqlcon = "server=localhost;user=root;database=stock_db;password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlcon);

            string user_name = txt_username.Text;
            string u_password = txt_password.Text;
            try
            {
                if (txt_username.Text != "" && txt_password.Text != "")
                {
                    mySqlConnection.Open();

                    string query = "SELECT u_name, pw FROM users WHERE u_name = '"+txt_username.Text+"' AND pw = '"+txt_password.Text+"'";
                    MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            user_name = reader["u_name"].ToString(); // Change "username" to "u_name"
                            u_password = reader["pw"].ToString();    // Change "password" to "pw"
                        }
                        MessageBox.Show("Login Successful");
                        Home home = new Home();
                        home.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Login Failed! Please check your credentials");
                        txt_username.Text = "";
                        txt_password.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Username or Password is empty", "Information");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error: " + ex.Message, "Information");
            }
            finally
            {
                mySqlConnection.Close();
            }

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
