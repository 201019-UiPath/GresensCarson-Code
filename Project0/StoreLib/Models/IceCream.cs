namespace StoreLib.Models
{
  public class IceCream : Product
  {
    public IceCream()
    {
      this.maxStock = 150;
      Stock = 50;
      Name = "Carton of Ice Cream";
      Id = 3;
      Price = 11.99;
    }
  }
}