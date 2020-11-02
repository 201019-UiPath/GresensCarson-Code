using StoreLib.Models;
using System.Collections.Generic;

namespace StoreLib
{
    public class OrderTasks
    {
        public void AddProduct(Order o, Product p){
            //add product to items list
            o.AddProduct(p);
            o.UpdatePrice();
        }

        public void RemoveProduct(Order o, Product p){
            //remove product from items list
            o.RemoveProduct(p);
            o.UpdatePrice();
        }

        public void CancelOrder(Order o){
            //remove all products from product list
            o.CancelOrder();
        }

        public void RecordOrderLoc(Order o, Location loc){
            //record order made at this location
        }

        public void RecordOrderGlobal(Order o){
            //record order made at this location
        }

        public double OrderPrice(Order o){
            //sum up all product prices in order list
            return o.OrderPrice();

        }
    }
}