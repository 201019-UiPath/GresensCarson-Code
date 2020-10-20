//1. predifined namespace
using System;

//1.1 Custom defined namespace
namespace helloWorld
{
  class Program
  {
    // execution starts here
    //command line arguments
    // vvv
    static void Main(string[] args)
    {
      //Console.WriteLine("Hello World! " + DateTime.Now);

      string name;
      string lastname;
      double num; // added this to see if it applied to other types
      Console.WriteLine("Please enter your first name");
      name = Console.ReadLine(); // takes users input in string form
      Console.WriteLine("Please enter your last name");
      lastname = Console.ReadLine();
      //Console.WriteLine("Welcome" +name);
      num = 3;
      Console.WriteLine($"Welcome {name} {lastname} {num}");
    }
  }
}
