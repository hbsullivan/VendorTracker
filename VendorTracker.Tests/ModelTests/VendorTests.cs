using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorTracker.Models;
using System;

namespace VendorTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Suzy", "bread");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Suzy";
      string description = "Suzy sells bread";
      Vendor newVendor = new Vendor(name, description);
      string result = newVendor.Name;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string name = "Suzy";
      string description = "Suzy sells bread";
      Vendor newVendor = new Vendor(name, description);
      string result = newVendor.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string name = "Suzy";
      string description = "Suzy sells bread";
      Vendor newVendor = new Vendor(name, description);
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnListOfVendors_VendorList()
    {
      string name01 = "Suzy";
      string description01 = "Suzy sells bread";
      string name02 = "Brad";
      string description02 = "Brad sells bread";
      Vendor newVendor01 = new Vendor(name01, description01);
      Vendor newVendor02 = new Vendor(name02, description02);
      List<Vendor> newList = new List<Vendor> { newVendor01, newVendor02 };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);   
    }

    [TestMethod]
    public void Find_ReturnsMatchingVendor_Vendor()
    {
      string name01 = "Suzy";
      string description01 = "Suzy sells bread";
      string name02 = "Brad";
      string description02 = "Brad sells bread";
      Vendor newVendor01 = new Vendor(name01, description01);
      Vendor newVendor02 = new Vendor(name02, description02);
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(newVendor02, result);
    }

    [TestMethod]
    public void AddOrder_LinksVendorAndOrder_OrderList()
    {
      string title = "Bread Delivery";
      string descriptionOrder = "20 loaves of bread";
      int price = 100;
      string date = "08/30/2022";
      Order newOrder = new Order(title, descriptionOrder, price, date);
      List<Order> newList = new List<Order> { newOrder };
      string name = "Suzy";
      string description = "Suzy sells bread";
      Vendor newVendor = new Vendor(name, description);
      newVendor.AddOrder(newOrder);
      List<Order> result = newVendor.Orders;
      CollectionAssert.AreEqual(newList, result);
    }
  }
}