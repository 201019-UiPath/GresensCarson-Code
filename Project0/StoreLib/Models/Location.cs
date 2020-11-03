using System.Collections.Generic;
namespace StoreLib.Models
{
  public class Location
  {
    private int id;
    private string address;
    private List<Product> inventory;

    public int Id { get; set; }
    public string Address { get; set; }

    public Location()
    {
      Id = 0;
      Address = "1 Store Ave";
      List<Product> stuff = new List<Product>();
      inventory = stuff;
    }

    public Location(int i, string add, List<Product> stuff)
    {
      Id = i;
      Address = add;
      inventory = stuff;
    }

    public void AddToInventory(Product p)
    {
      inventory.Add(p);
    }
    public List<Product> Inventory { get { return inventory; } }

  }
}