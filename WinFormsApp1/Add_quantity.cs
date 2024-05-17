using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Math.EC;
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
    public partial class Add_quantity : Form
    {
        public Add_quantity()
        {
            InitializeComponent();
        }

        private void txt_quantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            String mysqlcon = "server=localhost;user=root;database=stock_db;password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlcon);
            string check_querry = "SELECT item_name FROM item WHERE item_name = '" + txt_name.Text + "' OR id = '" + txt_code.Text + "'";
            MySqlDataAdapter da = new MySqlDataAdapter(check_querry, mySqlConnection);
            DataTable dt = new DataTable();
            da.Fill(dt);


            if ((txt_code.Text != string.Empty && txt_name.Text == string.Empty) || (txt_code.Text == string.Empty && txt_name.Text != string.Empty))
            {
                if (dt.Rows.Count >= 1)
                {
                    MessageBox.Show("Item Available");
                    if (txt_quantity.Text == string.Empty)
                    {
                        MessageBox.Show("Please enter a valid Quantity");
                    }
                    else
                    {
                        try
                        {
                            string selectQuery = "SELECT quantity FROM item WHERE item_name = '" + txt_name.Text + "'OR id = '" + txt_code.Text + "' ";
                            MySqlCommand selectCmd = new MySqlCommand(selectQuery, mySqlConnection);

                            mySqlConnection.Open();
                            Item itm_add = new Item();
                            itm_add.addQuantity((Convert.ToInt32(selectCmd.ExecuteScalar())), Int32.Parse(txt_quantity.Text));

                            Log log2 = new Log();
                            

                            string updateQuery = "UPDATE item SET quantity = '" + itm_add.getNewQuantity() + "' WHERE item_name = '" + txt_name.Text + "' OR id = '" + txt_code.Text + "' ";
                            MySqlCommand updateCmd = new MySqlCommand(updateQuery, mySqlConnection);

                            int rowsAffected = updateCmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Quantity added successfully");
                            }
                            else
                            {
                                MessageBox.Show("No records updated. Item not found.", "Information");
                            }

                            string selectquan = "SELECT quantity FROM item WHERE item_name =  '" + txt_name.Text + "' OR id = '" + txt_code.Text + "'";
                            MySqlCommand selectCmdquan = new MySqlCommand(selectquan, mySqlConnection);
                            log2.newStockAction(txt_name.Text, Convert.ToInt32(selectCmdquan.ExecuteScalar()));

                            string selectlog = "SELECT id FROM item WHERE item_name =  '" + txt_name.Text + "' OR id = '" + txt_code.Text + "'";
                            MySqlCommand selectCmdlog = new MySqlCommand(selectlog, mySqlConnection);
                            log2.setId(Convert.ToInt32(selectCmdlog.ExecuteScalar()));

                            string selectname = "SELECT item_name FROM item WHERE item_name =  '" + txt_name.Text + "' OR id = '" + txt_code.Text + "'";
                            MySqlCommand selectCmdname = new MySqlCommand(selectname, mySqlConnection);
                            log2.setname(selectCmdname.ExecuteScalar() as string);


                            string log = "INSERT INTO logs (item_id, item_name, quantity,action,date_time) VALUES ('" + log2.getItemID() + "', '" + log2.getItemName() + "', '" + log2.getQuantity() + "', 'Quantity Added', NOW())";
                            MySqlCommand logCmd = new MySqlCommand(log, mySqlConnection);
                            logCmd.ExecuteNonQuery();

                            MessageBox.Show("Log Added Successfully");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                            finally { mySqlConnection.Close(); }

                    }

                }
                else
                {
                    MessageBox.Show("Item Does not exist. Please Add the stock to proceed");

                }

            }
            else
            {
                MessageBox.Show("Please Enter a Valid Stock code or name");
            }



        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_code.Text = "";
            txt_name.Text = "";
            txt_quantity.Text = "";
        }
    }
}
