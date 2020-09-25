using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System;


namespace PierresBakery.Tests
{
  [TestClass]
  public class BakeryTests
  {
    [TestMethod]
    public void FindTotalCostOfBread_InputBreadQuantityAndGetPrice_ReturnPriceOfBuy2Get1Free()
    {
      // testing code will go here
      Bakery testBread = new Bakery();
      int quantity = 6;
      Assert.AreEqual(20, testBread.BreadCost(quantity));
    }

    [TestMethod]
    public void FindTotalCostOfPastry_InputPastryQuantityAndGetPrice_ReturnPriceOfTwoOrBuy3For5()
    {
      // testing code will go here
      Pastry testPastry = new Pastry();
      int quantity = 7;
      Assert.AreEqual(12, testPastry.PastryCost(quantity));
    }
  }
}