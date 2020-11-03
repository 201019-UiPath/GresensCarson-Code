using System;
using Xunit;
using StoreLib;
using StoreLib.Models;
using System.Collections.Generic;

namespace StoreTest
{
  public class UnitTest1
  {
    Product testCheese = new Cheese();
    Product testMilk = new Milk();
    Product testIceCream = new IceCream();




    [Fact]
    public void TestFindOrderPrice()
    {
      List<Product> testItems = new List<Product>();
      testItems.Add(testCheese);
      testItems.Add(testMilk);
      testItems.Add(testIceCream);

      Order testOrder = new Order(testItems);
      OrderTasks ot = new OrderTasks();

      double expectedPrice = testCheese.Price + testMilk.Price + testIceCream.Price;
      double orderPrice = ot.OrderPrice(testOrder);

      Assert.Equal(expectedPrice, orderPrice);

    }

    [Fact]
    public void TestAddProducttoItemList()
    {
      List<Product> testItems = new List<Product>();
      testItems.Add(testCheese);
      testItems.Add(testMilk);
      testItems.Add(testIceCream);

      Order testOrder = new Order(testItems);
      OrderTasks ot = new OrderTasks();

      List<Product> emptyItems = new List<Product>();
      Order emptyOrder = new Order(emptyItems);
      ot.AddProduct(emptyOrder, testCheese);
      ot.AddProduct(emptyOrder, testMilk);
      ot.AddProduct(emptyOrder, testIceCream);

      Assert.Equal(emptyOrder.Items, testOrder.Items);
    }

    [Fact]
    public void TestRemoveProducttoItemList()
    {
      List<Product> testItems = new List<Product>();
      testItems.Add(testCheese);
      testItems.Add(testMilk);
      testItems.Add(testIceCream);

      Order testOrder = new Order(testItems);
      OrderTasks ot = new OrderTasks();
      ot.RemoveProduct(testOrder, testMilk);

      List<Product> emptyItems = new List<Product>();
      Order emptyOrder = new Order(emptyItems);
      ot.AddProduct(emptyOrder, testCheese);
      ot.AddProduct(emptyOrder, testIceCream);


      Assert.Equal(emptyOrder.Items, testOrder.Items);
    }

    [Fact]
    public void TestCancelOrder()
    {
      List<Product> testItems = new List<Product>();
      testItems.Add(testCheese);
      testItems.Add(testMilk);
      testItems.Add(testIceCream);

      List<Product> emptyProductList = new List<Product>();


      Order testOrder = new Order(testItems);
      OrderTasks ot = new OrderTasks();
      ot.CancelOrder(testOrder);

      Order nullOrder = new Order(emptyProductList);
      nullOrder.Price = 0;
      nullOrder.Id = -1;


      Assert.Equal(nullOrder.Items, testOrder.Items);
      Assert.Equal(nullOrder.Id, testOrder.Id);
      Assert.Equal(nullOrder.Price, testOrder.Price);
    }








  }
}
