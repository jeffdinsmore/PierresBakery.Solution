using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System;


namespace PierresBakery.Tests
{

[TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryCost_BuySevenMuffinsAtBuy3For5_Twelve()
    {
      Pastry testPastry = new Pastry();
      int quantity = 7;
      Assert.AreEqual(12, testPastry.PastryCost(0, quantity));
    }

    [TestMethod]
      public void PastryCost_Buy3MuffinsAtBuy3For5_Five()
    {
      Pastry testPastry = new Pastry();
      int quantity = 3;
      Assert.AreEqual(5, testPastry.PastryCost(0, quantity));
    }
    [TestMethod]
    public void PastryCost_Buy1Muffin_Two()
    {
      Pastry testPastry = new Pastry();
      int quantity = 1;
      Assert.AreEqual(2, testPastry.PastryCost(0, quantity));
    }

    [TestMethod]
    public void PastryCost_Buy7Each_Seventeen()
    {
      Pastry testPastry = new Pastry();
      int doughnutQuantity = 7;
      int muffinQuantity = 7;
      Assert.AreEqual(17, testPastry.PastryCost(doughnutQuantity, muffinQuantity));
    }

    [TestMethod]
      public void PastryCost_Buy3For2AndBuy3For5_Seven()
    {
      Pastry testPastry = new Pastry();
      int doughnutQuantity = 3;
      int muffinQuantity = 3;
      Assert.AreEqual(7, testPastry.PastryCost(doughnutQuantity, muffinQuantity));
    }
    [TestMethod]
    public void PastryCost_Buy1PastryEach_Three()
    {
      Pastry testPastry = new Pastry();
      int doughnutQuantity = 1;
      int muffinQuantity = 1;
      Assert.AreEqual(3, testPastry.PastryCost(doughnutQuantity, muffinQuantity));
    }
    
  }
}