using AddressBookMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace AddressBookMVC.Controllers;
public class AddressesController : Controller
{
    private DataBase _db;
    public AddressesController(DataBase db)
    {
        _db = db;
    }

    [HttpGet("Index")]
    public IActionResult Index() {
        List<Address> theList = _db.Addresses;
        List<AddressViewModel> AddressResponseList = new List<AddressViewModel>();
        foreach (Address add in theList)
        {
            AddressResponseList.Add(new AddressViewModel(add.Id, add.PostCode , add.StreetName, add.HouseNumber));
        }
        return View(AddressResponseList);
    }
    [HttpGet("Details/{id}")]
    public IActionResult Details(int id) {
        List<Address> addresses = _db.Addresses;
        Address? found = addresses.Find(x => x.Id == id);
        if (found != null)
        {
            AddressViewModel res = new AddressViewModel(found.Id, found.PostCode, found.StreetName, found.HouseNumber);
            return View(res);
        }
        // return RedirectToAction(nameof(Error), "The address requested cannot be found!");
        return View();
    }
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(AddressViewModel incomingModel) {
        List<Address> addresses = _db.Addresses;
        int nextId = addresses.Count + 1;
        if (incomingModel != null && incomingModel.streetName != null)
        {
            Address newAddress = new Address(nextId, incomingModel.postCode ,
            incomingModel.streetName, incomingModel.houseNumber);

            _db.Addresses.Add(newAddress);
        }
    
        return RedirectToAction(nameof(Details), new {id = nextId});
    }
}