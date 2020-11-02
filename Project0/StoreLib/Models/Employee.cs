namespace StoreLib.Models
{
    public class Employee:Person
    {
        private double employeeDiscount;
        public double EmployeeDiscount{get;set;}

        public Employee(){
            Id = 1;
            Name = "Jim";
            EmployeeDiscount = 0.0;
        }

        public Employee(int i, string n, double discount){
            Id = i;
            Name = n;
            EmployeeDiscount = discount;
        }


    }
}