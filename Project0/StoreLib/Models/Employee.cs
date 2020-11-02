namespace StoreLib.Models
{
    public class Employee:Person
    {

        public Employee(){
            Id = 1;
            Name = "Jim";
        }

        public Employee(string n, int i){
            Id = i;
            Name = n;
        }
    }
}