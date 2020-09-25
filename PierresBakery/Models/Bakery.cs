using System;

namespace PierresBakery.Models
{
  public class Bread
  {
    public int BreadCost(int quantity)
    {
      int breadCost = 5;
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
      int formula = count - countFreeItem;
      int total = breadCost * formula;
      return total;
    }
    

  }
  public class Pastry
  {
    public int PastryCost(int quantity)
    {
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