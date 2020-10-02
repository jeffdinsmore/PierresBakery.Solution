using System;

namespace PierresBakery.Models
{
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