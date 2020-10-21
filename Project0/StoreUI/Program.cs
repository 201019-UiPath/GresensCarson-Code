using System;

namespace StoreUI
{
  class Program
  {


    static void Employee()
    {
      Console.WriteLine("Hello employee");
    }

    static void Customer()
    {
      Console.WriteLine("Hello customer");

    }


    static void Main(string[] args)
    {
      Console.WriteLine("Hello Welcome to Store! Are you a customer or employee?");
      string user = Console.ReadLine();

      Boolean employee = false;
      Boolean customer = false;
      if (employee) { Employee(); }
      else
      {
        if (!employee && customer) { Customer(); }
        else { Console.WriteLine("Neither? Goodbye"); }
      }

    }
  }
}
