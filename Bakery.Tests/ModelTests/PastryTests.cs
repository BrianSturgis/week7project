using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;
namespace Bakery.Tests
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
      public void Pastry_PastryQuantity_Int()
      {
        Pastry newPastry = new Pastry(1);
        int result = newPastry.Quantity;
        Assert.AreEqual(0, result);
      }
      [TestMethod]
      public void Pastry_PastryTotal_Int()
      {
        Pastry newPastry = new Pastry(1);
        int result = newPastry.Total;
        Assert.AreEqual(0, result);
      }
      [TestMethod]
      public void Pastry_SinglePastryNoDiscount_Int()
      {
        int quantity = 1;
        Pastry newPastry = new Pastry(quantity);
        Assert.AreEqual(2, newPastry.PastryTotal(quantity));
      }
      [TestMethod]
      public void Pastry_PastryDiscount_Int()
      {
      int Quantity = 5;
      Pastry newPastry = new Pastry(Quantity);
      Assert.AreEqual(9, newPastry.PastryTotal(Quantity));
      }
  }
}