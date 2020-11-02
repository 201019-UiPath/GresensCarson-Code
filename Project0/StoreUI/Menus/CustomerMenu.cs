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