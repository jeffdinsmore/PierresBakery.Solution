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
      int countTwentyOneGrain = 0;
      int countPowerseed = 0;
      for (int i = 0; i < twentyOneGrainQuantity; i++)
      {
        countTwentyOneGrain ++;
        if (countTwentyOneGrain % 3 == 0)
        {
          countFreeTwentyOneGrainItem ++;
        }
      }
      for (int i = 0; i < powerseedQuantity; i++)
      {
        countPowerseed ++;
        if (countPowerseed % 4 == 0)
        {
          countFreePowerseedItem ++;
        }
      }
      int formulaTwentyOneGrain = countTwentyOneGrain - countFreeTwentyOneGrainItem;
      int formulaPowerseed = countPowerseed - countFreePowerseedItem;
      int total = (twentyOneGrainCost * formulaTwentyOneGrain) + (powerseedCost * formulaPowerseed);
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
      int total = pastryCost * count - countFreeItem;
      return total;
    }
  }
}