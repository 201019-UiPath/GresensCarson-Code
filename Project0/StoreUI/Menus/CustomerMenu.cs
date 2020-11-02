using System;
using StoreLib;
using System.Text.RegularExpressions;
using StoreLib.Models;

namespace StoreUI.Menus
{
  public class CustomerMenu : IMenu
  {
    public void Start(){
      // first step: get info to create a customer object & check if that
      // customer is in the db

      string proceed = "";
      Customer c;
      do{
      c = LogIn();
      if(c.Id == -1){
        Console.WriteLine("Quitting now.");
        return;}
      if(c.Id == -2){
        Console.WriteLine("Sorry, that account is already claimed. Select an option to proceed");
        Console.WriteLine("[0] Try Again");
        Console.WriteLine("[1] Quit"); 
        proceed = Console.ReadLine();
        }
      }while(ValidInput(proceed, "0"));

      // Next Step: 

      Console.WriteLine($"Hello {c.Name}! Here are Today's Products: ");
      Console.Write("Milk \nCheese \nIce Cream");

      Console.WriteLine("Would you like to place an order? \n[0] Yes \n[1] No");
      string proceed = Console.ReadLine();
      while(!ValidInput(continue, "0|1")){
        Console.WriteLine("Sorry, please enter 0 to proceed or 1 to quit");
        proceed = Console.ReadLine();
      }

      if(ValidInput(proceed, "1")){return;}

      Order newOrder = PlaceOrder();

    }

    public Order PlaceOrder(){
      Console.WriteLine("Time to place an order!");
      Order o = MakeOrder();
    }

    public Order MakeOrder(){
      int numMilk = askForProduct("milk", "gallons");
      int numCheese = askForProduct("cheese", "wheels");
      int numIceCream = askForProduct("ice cream", "cartons");    
    }

    public int askForProduct(string name, string container){
      int num;
      Console.Write($"How many {container} of {name} would you like: ");
      string numProd = Console.ReadLine();
      while(ValidInput(numProd,"\\D")){
        Console.WriteLine("Sorry, please enter a whole number!");
        numProd = Console.ReadLine();
      }
      num = Convert.ToInt32(numProd);

    }
    
    public Customer LogIn(){
      //ask user for customer details or quit
      Console.WriteLine("Welcome Customer! To proceed you must either:");
      Console.WriteLine("[0] Log in");
      Console.WriteLine("[1] Create an Account");
      Console.WriteLine("Press any other key to quit");
      string newCus = Console.ReadLine();
      
      if(!ValidInput(newCus, "0|1")){return new Customer("",-1);} //exit if customer wants to quit
      
      Console.Clear();
      Console.Write("Please enter your Name: ");
      string cusName = Console.ReadLine();
      Console.Write("Please enter your numeric Id: ");
      string cusId = Console.ReadLine(); 
        
      while(ValidInput(cusId,"\\D")){
        Console.WriteLine("Sorry, that was not a valid Id.");
        Console.Write("Please enter a positive integer: ");
        cusId = Console.ReadLine();
      }
      Customer cus = new Customer(cusName,Convert.ToInt32(cusId));
      // if( cus in db && newCus = [0]){
      //           get customer object/info from db
      // }
      // if (cus in db && newCus = [1]){
      //  return customer with -2 id
      // }

      return cus;

    }

    public bool ValidInput(string input,string regex){
      if(Regex.IsMatch(input, regex)){
        return true;
      } else{
        return false;
        }
    }
  }
}