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
      Bread testBread = new Bread();
      int quantity = 7;
      Assert.AreEqual(25, testBread.BreadCost(quantity));
    }

    [TestMethod]
    public void FindTotalCostOfBread_InputBreadQuantityAndGetPrice_ReturnPriceOfBuy2Get1Free()
    {
      Bread testBread = new Bread();
      int quantity = 3;
      Assert.AreEqual(10, testBread.BreadCost(quantity));
    }

    [TestMethod]
    public void FindTotalCostOfOneLoaf_InputBreadQuantityAndGetPrice_ReturnPriceOfLoaf()
    {
      Bread testBread = new Bread();
      int quantity = 1;
      Assert.AreEqual(5, testBread.BreadCost(quantity));
    }
  }
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void FindTotalCostOfPastries_InputPastryQuantityAndGetPrice_ReturnPriceOfMultiplePastries()
    {
      Pastry testPastry = new Pastry();
      int quantity = 7;
      Assert.AreEqual(12, testPastry.PastryCost(quantity));
    }

    [TestMethod]
      public void FindTotalCostOf3Pastries_InputPastryQuantityAndGetPrice_ReturnPriceOfBuy3For5()
    {
      Pastry testPastry = new Pastry();
      int quantity = 3;
      Assert.AreEqual(6, testPastry.PastryCost(quantity));
    }
    [TestMethod]
    public void FindCostOfOnePastry_InputPastryQuantityAndGetPrice_ReturnPriceOfOnePastry()
    {
      Pastry testPastry = new Pastry();
      int quantity = 1;
      Assert.AreEqual(2, testPastry.PastryCost(quantity));
    }
    
  }
}