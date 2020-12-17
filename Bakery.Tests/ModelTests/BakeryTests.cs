using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;
namespace Bakery.Tests
{
  [TestClass]
  public class BakeryTests
  {
    
    [TestMethod] 
    public void Bread_Object_Bread()
    {
      Bread newBread = new Bread(1);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    
    [TestMethod] 
    public void Bread_BreadQuantity_Int()
    {
      Bread newBread = new Bread(1);
        int result = newBread.Quantity;
        Assert.AreEqual(0, result);
    }
    [TestMethod] 
    public void Bread_BreadTotal_Int()
    {
      Bread newBread = new Bread(1);
      int result = newBread.Total;
      Assert.AreEqual(0, result);
    }
    [TestMethod]
    public void Bread_SingleBreadNoDiscount_Int()
    {
      int quantity = 1;
      Bread newBread = new Bread(quantity);
      Assert.AreEqual(5, newBread.BreadTotal(quantity));
    }
    [TestMethod]
      public void Bread_BreadDiscount_Int()
      {
      int Quantity = 5;
      Bread newBread = new Bread(Quantity);
      Assert.AreEqual(20, newBread.BreadTotal(Quantity));
      }
  }
}