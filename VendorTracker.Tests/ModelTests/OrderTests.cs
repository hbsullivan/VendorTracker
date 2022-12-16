using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorTracker.Models;
using System;

namespace VendorTracker.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_CreateOrderConstructor_Order()
    {
      Order newOrder = new Order("title", "description", 10, "08/30/2022");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
  }
}