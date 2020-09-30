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
    public int DoughnutQuantity {get; set;}
    public int MuffinQuantity {get; set;}
    public int PastryCost(int doughnutQuantity, int muffinQuantity)
    {
      DoughnutQuantity = doughnutQuantity;
      MuffinQuantity = muffinQuantity;
      int muffinCost = 2;
      int doughnutCost = 1;
      int countMuffin = 0;
      int countDoughnut = 0;
      int countFreeMuffinItem = 0;
      int countFreeDoughnutItem = 0;
      for (int i = 0; i < muffinQuantity; i++)
      {
        countMuffin ++;
        if (countMuffin % 3 == 0)
        {
          countFreeMuffinItem ++;
        }
      }
      for (int i = 0; i < doughnutQuantity; i++)
      {
        countDoughnut ++;
        if (countDoughnut % 3 == 0)
        {
          countFreeDoughnutItem ++;
        }
      }
      int muffinTotal = muffinCost * countMuffin - countFreeMuffinItem;
      int doughnutTotal = doughnutCost * countDoughnut - countFreeDoughnutItem;
      int total = muffinTotal + doughnutTotal;
      return total;
    }
  }
}