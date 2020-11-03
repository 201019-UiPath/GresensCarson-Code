namespace StoreLib.Models
{
  public class Cheese : Product
  {
    public Cheese()
    {
      this.maxStock = 100;
      Stock = 50;
      Name = "Wheel of Cheese";
      Id = 1;
      Price = 24.99;
    }
  }
}