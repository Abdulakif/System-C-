using MySql.Data.MySqlClient;
using System.Data;

namespace WinFormsApp1
{
    public partial class New_Stock : Form
    {

        public New_Stock()
        {
            InitializeComponent();

        }
        /*
        {
            String mysqlcon = "server=localhost;user=root;database=stock_db;password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlcon);

            try
            {
                mySqlConnection.Open();
                MessageBox.Show("Connection Established");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { mySqlConnection.Close(); }
        }*/
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
            string check_querry = "SELECT item_name FROM item WHERE item_name = '" + txt_name.Text + "'";
            MySqlDataAdapter da = new MySqlDataAdapter(check_querry, mySqlConnection);
            DataTable dt = new DataTable();
            da.Fill(dt);


            if (dt.Rows.Count >= 1) //if there are more than 1 rows in the database  which matches the txt_name
            {
                MessageBox.Show("Item Already Exist");
            }
            else
            {
                if (txt_name.Text == string.Empty)
                {
                    MessageBox.Show("Item Name is required");
                    return;
                }
                else if (txt_quantity.Text == string.Empty)
                {
                    MessageBox.Show("Item Quantity is required");
                    return;
                }
                else
                {
                    Log  log1 = new Log();
                    log1.newStockAction(txt_name.Text,Int32.Parse(txt_quantity.Text));
                    Item itm_add_stock = new Item();
                    itm_add_stock.SetItem(txt_name.Text, Int32.Parse(txt_quantity.Text));
                    try
                    {
                        string insert_query = "INSERT INTO item(item_name, quantity) VALUES('" + itm_add_stock.getItemName() + "','" + itm_add_stock.getQuantity() + "')";
                        mySqlConnection.Open();
                        MySqlCommand cmd = new MySqlCommand(insert_query, mySqlConnection);
                       
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Item Added Successfully");


                        string selectQuery = "SELECT id FROM item WHERE item_name =  '" + txt_name.Text + "'";
                        MySqlCommand selectCmd = new MySqlCommand(selectQuery, mySqlConnection);

                        log1.setId(Convert.ToInt32(selectCmd.ExecuteScalar()));


                        string log = "INSERT INTO logs (item_id, item_name, quantity,action,date_time) VALUES ('"+ log1.getItemID() + "', '"+log1.getItemName() +"', '"+ log1.getQuantity() + "', 'Item Added', NOW())";
                        MySqlCommand logCmd = new MySqlCommand(log, mySqlConnection);



                        logCmd.ExecuteNonQuery();
                        mySqlConnection.Close();

                        MessageBox.Show("Log Added Successfully");

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

        private void txt_code_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; return;
            }
        }



        private void txt_quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; return;
            }
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_quantity_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void txt_code_TextChanged(object sender, EventArgs e)
        {
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_name.Text = "";
            txt_quantity.Text = "";
        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {
        }
    }
}
