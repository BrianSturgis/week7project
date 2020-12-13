using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;
namespace Bakery.Tests
{
  [TestClass]
  public class BakeryTests
  {
    [TestMethod] 
    public void Pastry_PastryCreation_Pastry()
    {
      Pastry newPastry = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
    [TestMethod] 
    public void Pastry_PastryCreationPrice_Pastry()
    {
      Pastry newPastry = new Pastry(1);
      int result = newPastry.Price;
      Assert.AreEqual(2, result);
    }
    [TestMethod] 
    public void Pastry_PastryCreationQuantity_Int()
    {
      int quantity = 1;
      Pastry newPastry = new Pastry(quantity);
      int result = newPastry.Quantity;
      Assert.AreEqual(quantity, result);
    }
    
    [TestMethod]
    public void Order_CreatesOrder_Order()
    {
      Order newOrder = new Order(1, 1);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void PastryTotal_PastryCreationTotal_Int()
    {
      int quantity = 5;
      Pastry newPastry = new Pastry(quantity);
      Assert.AreEqual(9, newPastry.PastryTotal(quantity));
    }
    [TestMethod] 
    public void Bread_BreadCreation_Bread()
    {
      Bread newBread = new Bread(1);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    [TestMethod] 
    public void Bread_BreadCreationPrice_Bread()
    {
      Bread newBread = new Bread(1);
      int result = newBread.Price;
      Assert.AreEqual(5, result);
    }
    [TestMethod] 
    public void Bread_BreadCreationQuantity_Int()
    {
      int quantity = 1;
      Bread newBread = new Bread(quantity);
      int result = newBread.Quantity;
      Assert.AreEqual(quantity, result);
    }





    
  }
}