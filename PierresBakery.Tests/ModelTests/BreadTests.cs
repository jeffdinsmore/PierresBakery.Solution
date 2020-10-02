using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System;


namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadCost_7LoavesAtBuy2Get1FreeAt5Each_TwentyFive()
    {
      Bread testBread = new Bread();
      int quantity = 7;
      Assert.AreEqual(25, testBread.BreadCost(quantity, 0));
    }

    [TestMethod]
    public void BreadCost_Buy2Get1FreeAt5Each_Ten()
    {
      Bread testBread = new Bread();
      int quantity = 3;
      Assert.AreEqual(10, testBread.BreadCost(quantity, 0));
    }

    [TestMethod]
    public void BreadCost_BuyOneLoaf_Five()
    {
      Bread testBread = new Bread();
      int quantity = 1;
      Assert.AreEqual(5, testBread.BreadCost(quantity, 0));
    }
    [TestMethod]
    public void BreadCost_Buy2Get1FreeAndBuy3Get1Free_SixtySeven()
    {
      Bread testBread = new Bread();
      int quantity1 = 7;
      int quantity2 = 9;
      Assert.AreEqual(67, testBread.BreadCost(quantity1, quantity2));
    }

    [TestMethod]
    public void BreadCost_Buy2Get1FreeAndBuy3Get1Free_TwentyEight()
    {
      Bread testBread = new Bread();
      int quantity1 = 3;
      int quantity2 = 4;
      Assert.AreEqual(28, testBread.BreadCost(quantity1, quantity2));
    }

    [TestMethod]
    public void BreadCost_BuyOneBreadEach_Eleven()
    {
      Bread testBread = new Bread();
      int quantity1 = 1;
      int quantity2 = 1;
      Assert.AreEqual(11, testBread.BreadCost(quantity1, quantity2));
    }
  }
}