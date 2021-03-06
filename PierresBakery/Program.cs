using System;
using PierresBakery.Models;

class Program
{
  static void Main()
  {
    int breadTotal = 0;
    int pastryTotal = 0;
    int twentyOneGrainQuantity = 0;
    int powerseedQuantity = 0;
    int doughnutQuantity = 0;
    int muffinQuantity = 0;
    Console.WriteLine("Welcome to Pierre's Bakery! The best baked goods in town!");
    Console.WriteLine("We sell bread and we sell pastries.");
    Console.ForegroundColor = ConsoleColor.Cyan; 
    Console.WriteLine("Would you like to buy any bread today? Twenty One Grain is $5 each or buy 2, get 1 free and Powerseed is $6 each or buy 3, get 1 free.");
    Console.ForegroundColor = ConsoleColor.White;
    string buyBreadResponse = Console.ReadLine().ToLower();
    if (buyBreadResponse.Substring(0,1) == "y")
    {
      System.Threading.Thread.Sleep(800);
      Console.WriteLine("-------------------------------------------------------------------------------------");
      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.WriteLine("Very good! What type of bread would you like? Twenty One Grain or Powerseed or both?");
      Console.ForegroundColor = ConsoleColor.White;
      string breadType = Console.ReadLine().ToLower();
      
      if (breadType.Substring(0,1) == "b")
      {
        System.Threading.Thread.Sleep(600);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("How many loaves of 21 Grain bread would you like?");
        Console.ForegroundColor = ConsoleColor.White;
        twentyOneGrainQuantity = int.Parse(Console.ReadLine());
        System.Threading.Thread.Sleep(600);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("How many loaves of Powerseed bread would you like?");
        Console.ForegroundColor = ConsoleColor.White;
        powerseedQuantity = int.Parse(Console.ReadLine());
      }
      else if (breadType.Substring(0,1) == "p")
      {
        System.Threading.Thread.Sleep(600);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("How many loaves of Powerseed bread would you like?");
        Console.ForegroundColor = ConsoleColor.White;
        powerseedQuantity = int.Parse(Console.ReadLine());
      }
      else if (breadType.Substring(0,1) == "t")
      {
        System.Threading.Thread.Sleep(600);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("How many loaves of 21 Grain bread would you like?");
        Console.ForegroundColor = ConsoleColor.White;
        twentyOneGrainQuantity = int.Parse(Console.ReadLine());
      }
      Console.WriteLine("----------");
      Console.WriteLine("Excellent!");
      Bread newBread = new Bread();
      breadTotal = newBread.BreadCost(twentyOneGrainQuantity, powerseedQuantity);
      System.Threading.Thread.Sleep(600);
    }
    System.Threading.Thread.Sleep(600);
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Would you like to buy any Pastries today? Doughnuts are $1 each or 3 for $2 and muffins are $2 each or 3 for $5.");
    Console.ForegroundColor = ConsoleColor.White;
    string buyPastryResponse = Console.ReadLine().ToLower();
    if (buyPastryResponse.Substring(0,1) == "y")
    {
      System.Threading.Thread.Sleep(800);
      Console.WriteLine("-----------------------------------------------------");
      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.WriteLine("Very good! Would you like doughnuts, muffins or both?");
      Console.ForegroundColor = ConsoleColor.White;
      string pastryTypeResponse = Console.ReadLine().ToLower();
      if (pastryTypeResponse.Substring(0,1) == "b")
      {
        System.Threading.Thread.Sleep(600);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("How many doughnuts would you like?");
        Console.ForegroundColor = ConsoleColor.White;
        doughnutQuantity = int.Parse(Console.ReadLine());
        System.Threading.Thread.Sleep(600);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("How many muffins would you like?");
        Console.ForegroundColor = ConsoleColor.White;
        muffinQuantity = int.Parse(Console.ReadLine());
      }
      else if (pastryTypeResponse.Substring(0,1) == "d")
      {
        System.Threading.Thread.Sleep(600);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("How many doughnuts would you like?");
        Console.ForegroundColor = ConsoleColor.White;
        doughnutQuantity = int.Parse(Console.ReadLine());
      }
      else if (pastryTypeResponse.Substring(0,1) == "m")
      {
        System.Threading.Thread.Sleep(600);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("How many muffins would you like?");
        Console.ForegroundColor = ConsoleColor.White;
        muffinQuantity = int.Parse(Console.ReadLine());
      }
      Console.WriteLine("----------");
      Console.WriteLine("Excellent!");
      Pastry newPastry = new Pastry();
      pastryTotal = newPastry.PastryCost(doughnutQuantity, muffinQuantity);
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
      System.Threading.Thread.Sleep(2000);
      Console.WriteLine("We really appreciate you coming in today!");
    }
  }
}