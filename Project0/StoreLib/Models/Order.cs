using System.Collections.Generic;

namespace StoreLib.Models
{
    public class Order
    {
        private List<Product> items;
        private int id;
        private double price;

        public int Id{get;set;}
        public double Price{get;}

        public Order(List<Product> pList){
            items = pList;
            //check db for number of orders and create an id from that
        }

        public Order(List<Product> pList, int i){
            items = pList;
            Id = i;
        }


        public void AddProduct(Product p){
            items.Add(p);
        }

        public void RemoveProduct(Product p){
            items.Remove(p);
        }

        public void CancelOrder(){
            items = null;
            id = -1;
            price = 0.0;
        }

        public void UpdatePrice(){
            price = OrderPrice();
        }

        public double OrderPrice(){
            //sum up all product prices in order list
            double priceCounter = 0.0;
            foreach(Product p in items){
                priceCounter += p.Price;
            }
            return priceCounter;
        }

    }
}