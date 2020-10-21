using System;

namespace ProductLib
{
  public abstract class Product
  {

    int productId;
    int locationId;
    int Sold;
    int stock;
    string name;

    public int ProductId { get; set; }
    public int LocationId { get; set; }
    public string Name { get; set; }
    public string Sold { get; set; }
    public string Stock { get; set; }







  }
}
