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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btn_AddQuantity_Click(object sender, EventArgs e)
        {
            Add_quantity add_Quantity = new Add_quantity();
            this.Close();
            add_Quantity.Show();
        }

        private void btn_RemQuantity_Click(object sender, EventArgs e)
        {
            Remove_quantity remove_quantity = new Remove_quantity();
            this.Close();
            remove_quantity.Show();
        }

        private void btn_ViewStockLevel_Click(object sender, EventArgs e)
        {
            View_stock_level obj = new View_stock_level();
            obj.Show();
            this.Close();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btn_DelStock_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Close();
            home.Show();
        }

        private void btn_AddNewStock_Click(object sender, EventArgs e)
        {
            New_Stock stock = new New_Stock();
            this.Close();
            stock.Show();
        }

        private void btn_DelStock_Click_1(object sender, EventArgs e)
        {
            Del_stock stock = new Del_stock();
            this.Close();
            stock.Show();
        }

        private void btn_ViewTransaction_Click(object sender, EventArgs e)
        {
            view_trans_log obj = new view_trans_log();
            obj.Show();
            this.Close();
        }

        private void lbl_User_Click(object sender, EventArgs e)
        {

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            config config = new config();
            config.Show();
            this.Close();
        }
    }
}
