using System;
using System.Collections.Generic;
// using Bakery;


public class Program
{
  static void Main()
  { 

    Console.WriteLine("Would you like to make an order? ['Y' for yes, 'Enter' for no]");
    string answer = Console.ReadLine();
    if (answer == "Y" || answer == "y")
    {
      Console.WriteLine("Terrific!");
    }
    else
    {
      Console.WriteLine("well then goodbye");
    }
  }
  
  

}