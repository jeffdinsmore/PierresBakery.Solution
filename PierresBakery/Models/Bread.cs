using System.Collections.Generic;
using System;

namespace PierresBakery.Models
{
  public class Bread
  {
    public int TwentyOneGrainQuantity {get; set;}
    public int PowerseedQuantity {get; set;}
    public static Dictionary<string, int> Breads = new Dictionary<string, int>() { {"twentyOneGrain", 5}, {"powerseed", 6} };

    public int BreadCost(int twentyOneGrainQuantity, int powerseedQuantity)
    {
      TwentyOneGrainQuantity = twentyOneGrainQuantity;
      PowerseedQuantity = powerseedQuantity;
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
      int total = (Breads["twentyOneGrain"] * formulaTwentyOneGrain) + (Breads["powerseed"] * formulaPowerseed);
      return total;
    }
    
  }
}