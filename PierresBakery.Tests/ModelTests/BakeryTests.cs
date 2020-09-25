using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System;


namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void FindTotalCostOfMultipleBreads_InputBreadQuantityAndGetPrice_ReturnPriceOfMultipleBreads()
    {
      // testing code will go here
      Bread testBread = new Bread();
      int quantity = 7;
      Assert.AreEqual(25, testBread.BreadCost(quantity));
    }

    [TestMethod]
    public void FindTotalCostOfBread_InputBreadQuantityAndGetPrice_ReturnPriceOfBuy2Get1Free()
    {
      // testing code will go here
      Bread testBread = new Bread();
      int quantity = 3;
      Assert.AreEqual(1, testBread.BreadCost(quantity));
    }

    [TestMethod]
    public void FindTotalCostOfOneLoaf_InputBreadQuantityAndGetPrice_ReturnPriceOfLoaf()
    {
      // testing code will go here
      Bread testBread = new Bread();
      int quantity = 1;
      Assert.AreEqual(5, testBread.BreadCost(quantity));
    }
  }
  [TestClass]
  public class PastryTests
  {
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