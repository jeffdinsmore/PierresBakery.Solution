using System;

namespace PierresBakery.Models
{
  public class Bakery
  {
    public int BreadCost(int quantity)
    {
      int breadCost = 5;
      int count = 0;
      int countModulo = 0;
      for (int i = 0; i < quantity; i++)
      {
        count ++;
        if (count % 3 == 0)
        {
          countModulo ++;
        }
      }
      int formula = count - countModulo;
      int total = breadCost * formula;
      return total;
    }
    

  }
  public class Pastry
  {

  }
}