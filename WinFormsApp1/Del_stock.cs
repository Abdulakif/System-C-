using Microsoft.VisualBasic.Logging;
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
    public partial class Del_stock : Form
    {
        public Del_stock()
        {
            InitializeComponent();
        }

        private void btn_rem_Click(object sender, EventArgs e)
        {
            String mysqlcon = "server=localhost;user=root;database=stock_db;password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlcon);
            string check_querry = "SELECT item_name FROM item WHERE item_name = '" + txt_name.Text + "' ";
            MySqlDataAdapter da = new MySqlDataAdapter(check_querry, mySqlConnection);
            DataTable dt = new DataTable();
            da.Fill(dt);


            if (dt.Rows.Count >= 1)
            {
                MessageBox.Show("Item Available");
                try
                {

                    Item stock_del = new Item();
                    stock_del.deleteItem(txt_name.Text);

                    Log log3 = new Log();
                    log3.remStockAction(txt_name.Text);

                    string selectlog = "SELECT id FROM item WHERE item_name =  '" + txt_name.Text + "' ";
                    MySqlCommand selectCmdlog = new MySqlCommand(selectlog, mySqlConnection);

                    string selectname = "SELECT item_name FROM item WHERE item_name =  '" + txt_name.Text + "'";
                    MySqlCommand selectCmdname = new MySqlCommand(selectname, mySqlConnection);

                    string delete_query = "DELETE FROM item WHERE item_name = '" + stock_del.getItemName() + "' ";
                    mySqlConnection.Open();
                    MySqlCommand cmd = new MySqlCommand(delete_query, mySqlConnection);

                    log3.setId(Convert.ToInt32(selectCmdlog.ExecuteScalar()));
                    log3.setname(selectCmdname.ExecuteScalar() as string);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item Removed Successfully");



                    string selectquan = "SELECT quantity FROM item WHERE item_name =  '" + txt_name.Text + "'";
                    MySqlCommand selectCmdquan = new MySqlCommand(selectquan, mySqlConnection);
                    log3.Setquanto0(Convert.ToInt32(selectCmdquan.ExecuteScalar()));

                    string log = "INSERT INTO logs (item_id, item_name, quantity,action,date_time) VALUES ('" + log3.getItemID() + "', '" + log3.getItemName() + "', '" + log3.getnewquan() + "', 'Item Deleted', NOW())";
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
            else
            {
                if (txt_name.Text == string.Empty)
                {
                    MessageBox.Show("Stock name is required");
                    return;
                }
                else
                {
                    MessageBox.Show("Stock does not exist");
                }
            }
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_name.Text = "";
        }
    }
}
