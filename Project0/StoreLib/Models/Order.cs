using System.Collections.Generic;

namespace StoreLib.Models
{
    public class Order
    {
        private List<Product> items;
        private int id;
        private double price;

        public int Id{get;set;}
        
        public double GetPrice(){
            //sum up the prices of all the products in order list
            return 0.0;
        }

        public Order(List<Product> pList){
            items = pList;
        }

        public Order(List<Product> pList, int i){
            items = pList;
            Id = i;
        }


    }
}