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
  }
}