using Microsoft.AspNetCore.Mvc;
using AddressBookMVC.Models;

namespace AddressBookMVC.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return RedirectToAction("Index", "Addresses");
    }
    public IActionResult Cat()
    {
        return View();
    }
}
