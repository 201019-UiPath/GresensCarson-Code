using StoreLib.Models;
using System.Collections.Generic;

namespace StoreLib
{
    public class EmployeeTasks
    {

        public List<Product> CheckInventory(){
            //check total inventory
            List<Product> lst = new List<Product>();
            return lst;
        }

        public List<Product> CheckInventory(Location loc){
            //check inventory at a specific store location
            List<Product> lst = new List<Product>();
            return lst;
        }

        public void RestockProductLocation(Product p, Location loc){
            //restock product at location
        }

        public void RestockProductGlobal(Product p){
            //restock product everywhere
        }

        public void RestockLocation(Location loc){
            //restock everything at a specific location
        }

        public void GlobalRestock(){
            //restock everything everywhere
        }
    }
}