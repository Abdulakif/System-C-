using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class config : Form
    {
        public config()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            String mysqlcon = "server=localhost;user=root;database=stock_db;password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlcon);
            string check_querry = "SELECT u_name FROM users WHERE u_name = '" + txt_name.Text + "'";
            MySqlDataAdapter da = new MySqlDataAdapter(check_querry, mySqlConnection);
            DataTable dt = new DataTable();
            da.Fill(dt);


            if (dt.Rows.Count >= 1)
            {
                MessageBox.Show("User Already Exist. Try again with a different username");
                txt_name.Text = "";
                txt_pw.Text = "";
                txt_tp.Text = "";
                txt_age.Text = "";
                txt_email.Text = "";
                txt_fullname.Text = "";
            }
            else
            {
                if (txt_name.Text == string.Empty)
                {
                    MessageBox.Show("User Name is required");
                    return;
                }
                else if (txt_pw.Text == string.Empty)
                {
                    MessageBox.Show("User password is required");
                    return;
                } else if (txt_email.Text == string.Empty)
                {
                    MessageBox.Show("Enter a valid email address");
                    return;
                } else if( txt_age.Text == string.Empty){
                    MessageBox.Show("Enter your age");
                    return;
                } else if (txt_fullname.Text == string.Empty)
                {
                    MessageBox.Show("Enter your full name");
                    return;
                } else if (txt_tp.Text == string.Empty)
                {
                    MessageBox.Show("Enter your telephone number");
                    return;
                }
                else
                {
                    try
                    {
                        User adduser = new User(txt_name.Text, txt_pw.Text, txt_email.Text, Int32.Parse(txt_age.Text), txt_fullname.Text, Int32.Parse(txt_tp.Text));
                        string insert_query = "INSERT INTO users(u_name,pw,email, age, full_name, tp) VALUES('" + adduser.getUser_name() + "','" + adduser.getPw() + "', '"+adduser.getemail()+ "', '"+adduser.getAge()+ "', '"+adduser.getFullName()+ "', '"+adduser.getTp()+"')";
                        mySqlConnection.Open();
                        MySqlCommand cmd = new MySqlCommand(insert_query, mySqlConnection);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("User Added Successfully");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error" + ex);
                    }
                    finally
                    {
                        mySqlConnection.Close();
                    }
                }
            }
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            String mysqlcon = "server=localhost;user=root;database=stock_db;password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlcon);
            string check_querry = "SELECT u_name FROM users WHERE u_name = '" + txt_name.Text + "'AND pw ='"+txt_pw.Text+"' AND  email='"+txt_email.Text+"'";
            MySqlDataAdapter da = new MySqlDataAdapter(check_querry, mySqlConnection);
            DataTable dt = new DataTable();
            da.Fill(dt);


            if (dt.Rows.Count >= 1)
            {
                MessageBox.Show("User Exist");
                try
                {
                    string delete_query = "DELETE FROM users WHERE u_name = '" + txt_name.Text + "' AND pw ='"+txt_pw.Text+"' AND  email='"+txt_email.Text+"' ";
                    mySqlConnection.Open();
                    MySqlCommand cmd = new MySqlCommand(delete_query, mySqlConnection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Removed Successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
                finally
                {
                    mySqlConnection.Close();
                }
            }
            else
            {
                if (txt_name.Text == string.Empty)
                {
                    MessageBox.Show("User name is required");
                    return;
                } else if (txt_pw.Text == string.Empty)
                {
                    MessageBox.Show("Please enter youre email and password to confirm your identity");
                }
                else if(txt_email.Text == string.Empty)
                {
                    MessageBox.Show("Please enter youre email and password to confirm your identity");
                }
                else
                {

                }
            }
        }

        private void config_Load(object sender, EventArgs e)
        {

        }
    }
}
