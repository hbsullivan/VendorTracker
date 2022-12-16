using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using VendorTracker.Models;

namespace VendorTracker.Controllers
{
  public class VendorController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    // [HttpPost("/")]
    // public ActionResult Create(string name, string description)
    // {
    //   Vendor newVendor = new Vendor(name, description);
    //   return RedirectToAction("Index");
    // }
  }
}