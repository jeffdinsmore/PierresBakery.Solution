using System;
using PierresBakery.Models;

class Program
{
  static void Main()
  {
    int breadTotal = 0;
    int pastryTotal = 0;
    Console.WriteLine("Welcome to Pierre's Bakery! The best baked goods in town!");
    Console.WriteLine("We sell bread and we sell pastries.");
    Console.WriteLine("Would you like to buy any bread today? Twenty One Grain is $5 each or buy 2, get 1 free and Powerseed is $6 each or buy 3, get one free.");
    string buyBreadResponse = Console.ReadLine().ToLower();
    if (buyBreadResponse.Substring(0,1) == "y")
    {
      System.Threading.Thread.Sleep(800);
      Console.WriteLine("---------------------------------------------------");
      Console.WriteLine("Very good! What type of bread would you like? Twenty One Grain or Powerseed or both?");
      string breadType = Console.ReadLine().ToLower();
      if (breadType.Substring(0,1) == "t")
      {
        Console.WriteLine("How many loaves would you like?");

      }
      
      int breadQuantityResponse = int.Parse(Console.ReadLine());
      Console.WriteLine("----------");
      Console.WriteLine("Excellent!");
      Bread newBread = new Bread();
      breadTotal = newBread.BreadCost(breadQuantityResponse, 0);
      System.Threading.Thread.Sleep(600);
    }
    System.Threading.Thread.Sleep(600);
    Console.WriteLine("Would you like to buy any Pastries today? They are $2 each or 3 for $5.");
    string buyPastryResponse = Console.ReadLine().ToLower();
    if (buyPastryResponse.Substring(0,1) == "y")
    {
      System.Threading.Thread.Sleep(800);
      Console.WriteLine("--------------------------------------------");
      Console.WriteLine("Very good! How many pastries would you like?");
      int pastryQuantityResponse = int.Parse(Console.ReadLine());
      Console.WriteLine("Excellent!");
      Pastry newPastry = new Pastry();
      pastryTotal = newPastry.PastryCost(pastryQuantityResponse);
      System.Threading.Thread.Sleep(800);
    }
    int purchaseTotal = breadTotal + pastryTotal;
    if (purchaseTotal == 0)
    {
      System.Threading.Thread.Sleep(800);
      Console.WriteLine("------------------------------------------------------------------------------");
      Console.WriteLine("We are sorry to see you go without any delicious baked goods! Have a nice day!");
    }
    else
    {
      System.Threading.Thread.Sleep(800);
      Console.WriteLine("-----------------------");
      Console.WriteLine("You total today is " + "$" + purchaseTotal + ".");
      System.Threading.Thread.Sleep(1700);
      Console.WriteLine("-----------------------------");
      Console.WriteLine("(Money is being exchanged...)");
      Console.WriteLine("-----------------------------");
      System.Threading.Thread.Sleep(2600);
      Console.WriteLine("We really appreciate you coming in today!");
    }
  }
}