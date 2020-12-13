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
    
  }
}