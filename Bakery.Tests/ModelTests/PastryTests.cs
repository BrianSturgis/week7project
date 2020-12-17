using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PastryKitchen.Models;
namespace PastryKitchen.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod] 
      public void Pastry_Object_Pastry()
      {
        Pastry newPastry = new Pastry(1);
        Assert.AreEqual(typeof(Pastry), newPastry.GetType());
      }
      [TestMethod] 
      public void Pastry_PricePastry()
      {
        Pastry newPastry = new Pastry(1);
        int result = newPastry.Price;
        Assert.AreEqual(2, result);
      }
      [TestMethod] 
      public void Pastry_PastryQuantity_Int()
      {
        int quantity = 1;
        Pastry newPastry = new Pastry(quantity);
        int result = newPastry.Quantity;
        Assert.AreEqual(quantity, result);
      }
      [TestMethod]
      public void PastryTotal_Int()
      {
        int quantity = 5;
        Pastry newPastry = new Pastry(quantity);
        Assert.AreEqual(9, newPastry.PastryTotal(quantity));
      }
  }
}