namespace StoreLib.Models
{
    public class Location
    {
        private int id;
        private string address;

        public int Id{get;set;}
        public string Address{get;set;}

        public Location(){
            Id = 0;
            Address = "1 Store Ave";
        }

        public Location(int i, string add){
            Id = i;
            Address = add;
        }

    }
}