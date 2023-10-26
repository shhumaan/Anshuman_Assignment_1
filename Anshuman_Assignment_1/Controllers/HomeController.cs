using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Anshuman_Assignment_1.Models;

namespace Anshuman_Assignment_1.Controllers;

public class HomeController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View(new PriceQuote());
    }

    [HttpPost]
    public IActionResult Calculate(PriceQuote model)
    {
        if (ModelState.IsValid)
        {
            return View("Index", model);
        }
        else
        {
            return View("Index");
        }
    }
}

