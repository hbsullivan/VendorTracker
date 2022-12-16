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

    [TestMethod]
    public void GetTitle_ReturnsTitleOfOrder_String()
    {
      string title = "Bread Delivery";
      string description = "20 loaves of bread";
      int price = 100;
      string date = "08/30/2022";
      Order newOrder = new Order(title, description, price, date);
      string result = newOrder.Title;
      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void GetDescrip_ReturnsDescriptionOfOrder_String()
    {
      string title = "Bread Delivery";
      string description = "20 loaves of bread";
      int price = 100;
      string date = "08/30/2022";
      Order newOrder = new Order(title, description, price, date);
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetPrice_ReturnsPriceOfOrder_Int()
    {
      string title = "Bread Delivery";
      string description = "20 loaves of bread";
      int price = 100;
      string date = "08/30/2022";
      Order newOrder = new Order(title, description, price, date);
      int result = newOrder.Price;
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void GetDate_ReturnsDateOfOrder_String()
    {
      string title = "Bread Delivery";
      string description = "20 loaves of bread";
      int price = 100;
      string date = "08/30/2022";
      Order newOrder = new Order(title, description, price, date);
      string result = newOrder.Date;
      Assert.AreEqual(date, result);
    }
  }
}