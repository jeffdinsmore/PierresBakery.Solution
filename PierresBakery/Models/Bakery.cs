using System;

namespace PierresBakery.Models
{
  public class Bakery
  {
    public int BreadCost(int quantity)
    {
      int breadCost = 4.99;
      // Bread is buy 2, get 1 free
      int formula = Math.Floor((quantity/3)*2) + Math.Floor(quantity % 3);
      int total = breadCost * formula;
      return total;
    }
    

  }
  public class Pastry
  {

  }
}