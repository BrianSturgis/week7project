using System;
using System.Collections.Generic;
namespace Bakery.Models
{
  public class Order
  {
    public int BreadTotal { get; set; }
    public int PastryTotal { get; set; }

    public Order(int breadTotal, int pastryTotal)
    {
      BreadTotal = breadTotal;
      PastryTotal = pastryTotal;
    }
    public int Total(int num1, int num2)
    {
      int total = num1 + num2;
      return total;
    }
  }
  public class Pastry
  {
    public int Price { get; set; }
    public int Quantity { get; set; }
    public int Total { get; set; }
  
    public Pastry(int quantity)
    {
      Price = 2;
      Quantity = quantity;
      Total = 0;
    }
    public int PastryTotal(int quantity)
    {
      Total = (quantity * 2) - ((quantity / 3) * 1);
      return Total;
    }
  }
  public class Bread
  {
    public int Price { get; set; }
    public int Quantity { get; set; }
    public int Total { get; set; }

    public Bread(string quantity)
    {
      Price = 5;
      Quantity = quantity;
      Total = 0;
    }

    public int BreadTotal(int quantity)
    {
      Total = (quantity * 5) - ((quantity / 3) * 5);
      return Total;
    }
  }
}