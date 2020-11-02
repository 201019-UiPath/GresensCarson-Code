using StoreLib.Models;
using System.Collections.Generic;

namespace StoreLib
{
    public class OrderTasks
    {
        public List<Product> AddProduct(Order o, Product p){
            //add product to items list
            List<Product> lst = new List<Product>();
            return lst;
        }

        public List<Product> RemoveProduct(Order o, Product p){
            //remove product from items list
            List<Product> lst = new List<Product>();
            return lst;
        }

        public void CancelOrder(Order o){
            //remove all products from product list
            //foreach item in order, removeproduct
        }

        public double OrderPrice(Order o){
            //sum up all product prices in order list
            return 0.0;
        }

        public double OrderPrice(Order o, double discount){
            //sum up the prices of all the products in order list
            // then apply discount
            return 0.0;
        }
    }
}