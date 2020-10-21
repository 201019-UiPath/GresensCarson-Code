using System;

namespace StoreLib
{
  public abstract class Store
  {

    string name;
    string address;
    string[] orders;
    int phoneNumber;
    int id;

    public int Id { get; set; }
    public int PhoneNumber { get; set; }
    public string Name { get; set; }
    public string address { get; set; }


  }
}
