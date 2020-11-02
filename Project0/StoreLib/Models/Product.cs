namespace StoreLib.Models
{
    public class Product
    {
        private double price;
        private int id;
        private string name;
        private int stock;
        private static int maxStock = 50;

        public double Price{get;set;}
        public int Id{get;set;}
        public string Name{get;set;}
        public int Stock{get;set;}
        public int MaxStock(){return maxStock;}
    }
}