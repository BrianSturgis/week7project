using System;
using Bakery.Models;
namespace Bakery
{
  public class Program
  {
    static void Main()
    { 

      Console.WriteLine("Ciao!");
      Console.WriteLine("We have some specials today so let me fill you in");
      Console.WriteLine("Today our bread which is $5 a loaf is buy 2 get one free and");
      Console.WriteLine("our Pastry which is $2 a piece is $5 for 3 of them.");
      Console.WriteLine("Would you like to make an order? ['Y' for yes, 'Enter' for no]");
      string answer = Console.ReadLine();
      if (answer == "Y" || answer == "y")
      {
        Console.WriteLine("Terrific! how many loafs of Bread can i get for you?");
        int breadQuantity = int.Parse(Console.ReadLine());
        Bread newBread = new Bread(breadQuantity);
        if (breadQuantity >= 0)
        Console.WriteLine("Terrific! how many pastry ya want?");
        int pastryQuantity = int.Parse(Console.ReadLine());
        Pastry newPastry = new Pastry(pastryQuantity);
        if (pastryQuantity >= 0)
        {
          newBread.BreadTotal(breadQuantity);
          newPastry.PastryTotal(pastryQuantity);
          Console.WriteLine(" Your total for the bread is $" + newBread.Total + " and your Pastries come to a total of $" + newPastry.Total);
          Console.WriteLine("Grazie Mille Tutti!  Ciao!");
        }
      }
    }
  }
}
