using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Log 
    {
        public DateTime DateNTime;
        public string Action;
        public int ItemID;
        public string ItemName;
        public int Quantity;

        public void newStockAction(string name, int quantity)
        {
           /* Action = "Item Added";*/
            this.ItemName = name;
            this.Quantity = quantity;
        }

        public void remStockAction(string name)
        {
            /* Action = "Item Added";*/
            this.ItemName = name;
        }
        public void Setquanto0(int quan) 
        {
            this.Quantity = quan;
            int setquan = 0;

            this.Quantity = setquan;
        }

        
        public int getnewquan() 
        {
            return this.Quantity; 
        }
        

        public string getDate() 
        {
            string formattedDateTime = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            return formattedDateTime;

        }
        public void setId(int id)
        {
            this.ItemID = id;
        }
        
        public int getItemID()
        {
            return this.ItemID;
        }
        public string getAction()
        {
            return this.Action;
        }
        public void setname(string name)
        {
            this.ItemName = name;
        }
        public string getItemName()
        {
            return this.ItemName;
        }
        public int getQuantity() { 
            return this.Quantity;
        }
        


    }
}
