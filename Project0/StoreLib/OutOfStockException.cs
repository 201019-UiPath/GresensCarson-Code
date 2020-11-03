using System;
namespace StoreLib
{
  public class OutOfStockException : Exception
  {
    public string errorMessage;
    public OutOfStockException(string message)
    {
      errorMessage = message;
    }

  }
}