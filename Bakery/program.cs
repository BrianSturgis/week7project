using System;
using System.Collections.Generic;
// using Bakery;


public class Program
{
  static void Main()
  { 

    Console.WriteLine("Hello welcome");
    Console.WriteLine("we have some specials today so let me fill you in");
    Console.WriteLine("today our bread which is $5 a loaf is buy 2 get one free and");
    Console.WriteLine("our pastry which is $2 a piece is $5 for 3 of them.");
    Console.WriteLine("Would you like to make an order? ['Y' for yes, 'Enter' for no]");
    string answer = Console.ReadLine();
    if (answer == "Y" || answer == "y")
    {
      Console.WriteLine("Terrific! how many loafs of Bread can i porder for you?");
      int breadOrder = int.Parse(Console.ReadLine());
    }
    else
    {
      Console.WriteLine("ok well please let me know if you change your mind.");
    }
  }
}