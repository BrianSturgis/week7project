using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;
namespace Bakery.Tests
{
  [TestClass]
  public class BakeryTests
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

    [TestMethod] 
    public void Bread_Object_Bread()
    {
      Bread newBread = new Bread(1);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    [TestMethod] 
    public void Bread_BreadPrice_Bread()
    {
      Bread newBread = new Bread(1);
      int result = newBread.Price;
      Assert.AreEqual(5, result);
    }
    [TestMethod] 
    public void Bread_BreadQuantity_Int()
    {
      int quantity = 1;
      Bread newBread = new Bread(quantity);
      int result = newBread.Quantity;
      Assert.AreEqual(quantity, result);
    }
    [TestMethod] 
    public void Bread_Total_Int()
    {
      Bread newBread = new Bread(1);
      int result = newBread.Total;
      Assert.AreEqual(0, result);
    }
    [TestMethod]
    public void BreadTotal_Int()
    {
      int quantity = 5;
      Bread newBread = new Bread(quantity);
      Assert.AreEqual(20, newBread.BreadTotal(quantity));
    }
  }
}