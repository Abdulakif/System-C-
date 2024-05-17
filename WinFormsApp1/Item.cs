using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Item
    {
        public int Id;
        public string Name;
        public int Quantity;

        public void SetItem (string name, int quantity) { 
            this.Name = name;
            this.Quantity = quantity;
        }
        
        public string getItemName()
        {
            return this.Name;
        }
        public int getQuantity()
        {
            return this.Quantity;
        }
        public void addQuantity(int quantity, int quanadd)
        {
            this.Quantity = quantity;
            int newQuantity;
            newQuantity = this.Quantity + quanadd;
            this.Quantity = newQuantity;
        }
        public void removeQuantity(int quantity, int quanremove)
        {
            this.Quantity = quantity;
            int newQuantity;

            newQuantity = this.Quantity - quanremove;

            this.Quantity = newQuantity;
        }
        public int getNewQuantity()
        {
            return Quantity;
        }

        public void deleteItem(string name)
        {
            this.Name = name;
        }

        public void setid(int id)
        {
            this.Id = id;
        }
        public int getid(int id) 
        {
            return Id;
        }
        /*public void AddQuantity(int n1, int n2)
        {
            int newQuan;

            newQuan = n1 + n2;
            Quantity = newQuan;
        }
        public int GetNewQuantity(int n1, int n2)
        {
            int newQuantity = n1 + n2;
            return newQuantity;
        }

        public void RemoveQuantity(int n1, int n2)
        {
            int newQuan;

            newQuan = n1 + n2;
            Quantity = newQuan;
        }
        public int GetRemovedStockQuan(int n1, int n2)
        {
            int newQuantity = n1 + n2;
            return newQuantity;
        }*/

    }
}
