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
      int quantity = 1;
      Assert.AreEqual(3, testBread.BreadCost(quantity));
    }
  }
}