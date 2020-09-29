using System;

namespace PierresBakery.Models
{
  public class Bread
  {
    public int TwentyOneGrainQuantity {get; set;}
    public int PowerseedQuantity {get; set;}
    public int BreadCost(int twentyOneGrainQuantity, int powerseedQuantity)
    {
      TwentyOneGrainQuantity = twentyOneGrainQuantity;
      PowerseedQuantity = powerseedQuantity;
      int twentyOneGrainCost = 5;
      int powerseedCost = 6;
      int countFreeTwentyOneGrainItem = 0;
      int countFreePowerseedItem = 0;
      int count = 0;
      for (int i = 0; i < twentyOneGrainQuantity; i++)
      {
        count ++;
        if (count % 3 == 0)
        {
          countFreeTwentyOneGrainItem ++;
        }
      }
      for (int i = 0; i < powerseedQuantity; i++)
      {
        count ++;
        if (count % 4 == 0)
        {
          countFreePowerseedItem ++;
        }
      }
      int formulaTwentyOneGrain = count - countFreeTwentyOneGrainItem;
      int formulaPowerseed = count - countFreePowerseedItem;
      int total = (twentyOneGrainCost * formulaTwentyOneGrain) + (powerseedCost * countFreePowerseedItem);
      return total;
    }
    

  }
  public class Pastry
  {
    public int Quantity {get; set;}
    public int PastryCost(int quantity)
    {
      Quantity = quantity;
      int pastryCost = 2;
      int count = 0;
      int countFreeItem = 0;
      for (int i = 0; i < quantity; i++)
      {
        count ++;
        if (count % 3 == 0)
        {
          countFreeItem ++;
        }
      }
      // int formula = count - countFreeItem;
      int total = pastryCost * count - countFreeItem;
      return total;
    }
  }
}