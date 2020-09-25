using System;
using System.Boolean;
using PierresBakery.Models;

class Program
{
  static void Main()
  {
    int breadTotal, pastryTotal = 0;
    Console.WriteLine("Welcome to Pierre's Bakery! The best baked goods in town!");
    Console.WriteLine("We sell bread and we sell pastries.");
    Console.WriteLine("Would you like to buy any bread today? They are $5 each or buy 2 get one free.");
    string buyBreadResponse = Console.ReadLine().ToLower();
    if (buyBreadResponse == "y" || buyBreadResponse == "yes" || buyBreadResponse == "ya" || buyBreadResponse == "yep" || buyBreadResponse == "yeah")
    {
      Console.WriteLine("Very good! How many loaves of bread would you like?");
      int breadQuantityResponse = int.Parse(Console.ReadLine());
      Console.WriteLine("Excellent!");
      breadTotal = Bread.BreadCost(breadQuantityResponse);
    }
    Console.WriteLine("Would you like to buy any Pastries today? They are $2 each or 3 for $5.");
    string buyPastryResponse = Console.ReadLine().ToLower();
    if (buyPastryResponse == "y" || buyPastryResponse == "yes" || buyPastryResponse == "ya" || buyPastryResponse == "yep" || buyPastryResponse == "yeah")
    {
      Console.WriteLine("Very good! How many pastries would you like?");
      int pastryQuantityResponse = int.Parse(Console.ReadLine());
      Console.WriteLine("Excellent!");
      pastryTotal = Pastry.PastryCost(pastryQuantityResponse);
    }
    if ((breatTotal + pastryTotal) == 0)
    {
      Console.WriteLine("We are sorry to see you go without any delicious baked goods! Have a nice day!");
    }

    
  }
}