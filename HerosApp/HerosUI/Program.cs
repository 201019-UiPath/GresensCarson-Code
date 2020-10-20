using System;
using HerosLib;

namespace HerosUI
{
  class Program
  {
    static void Main(string[] args)
    {


      #region default constructor
      //Hero obj = new Hero();
      //Console.WriteLine($"{obj.id} {obj.name}"); 
      // can't access variables if they aren't public
      #endregion
      #region Parametrized constructor
      //Hero obj1 = new Hero(2, "Ironman");
      //Console.WriteLine($"{obj1.id} {obj1.name}"); 
      // can't access variables if they aren't public
      #endregion
      #region Access via Properties
      /*Console.WriteLine(obj1.Id);
      obj1.Id = 3;
      Console.WriteLine($"New Id: {obj1.Id}");
      
      */
      #endregion
      #region Accessing 1-d arrays


      Hero obj = new Hero();
      /* Console.Write("Please enter your hero's id: ");
      obj.Id = Int32.Parse(Console.ReadLine());
      Console.Write("Please enter your hero's name: ");
      obj.Name = Console.ReadLine();
      Console.Write("Please enter your hero's first power: ");
      obj.superPowers[0] = Console.ReadLine();

      Console.Write($"{obj.Id} {obj.Name} {obj.superPowers[0]}");
   */

      // Jagged Arrays row initializations
      obj.jagarr[0] = new int[2]; //first column
      obj.jagarr[1] = new int[3]; //second column
      obj.jagarr[2] = new int[1]; // third column
      obj.jagarr[0][0] = 10;
      obj.jagarr[1][2] = 15;
      Console.WriteLine(obj.jagarr.Length); // Length is the number of elements of the array
      Console.WriteLine(obj.jagarr.Rank); // Rank is the dimension of the array


      #endregion
    }
  }
}
