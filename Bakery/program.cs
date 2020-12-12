using System;
using System.Collections.Generic;
using Bakery;


public class Program
{
  static void Main()
  { 

    // greetting
    Console.WriteLine("Would you like to make an order? ['Y' for yes, 'Enter' for no]");
    string answer = Console.ReadLine();
    if (answer == "Y" || answer == "y")
    {
      Console.WriteLine("Terrific!");
    }
    else
    {
      Console.WriteLine("hi hi");
    }
  }
  
  

}