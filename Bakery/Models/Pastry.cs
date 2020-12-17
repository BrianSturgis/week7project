using System;
using System.Collections.Generic;


namespace Bakery.Models
{
  public class Pastry
    {
      
      public int Quantity { get; set; }
      public int Total { get; set; }

      public Pastry(int a)
      {
        Quantity = 0;
        Total = 0;
      }
      public int PastryTotal(int Quantity)
      {
        Total = (Quantity * 2) - ((Quantity / 3) * 1);
        return Total;
      }
  }
}