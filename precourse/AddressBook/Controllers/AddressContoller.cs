using Microsoft.AspNetCore.Mvc;

namespace AddressBook.Controllers;
[ApiController]
[Route("api/[controller]")]
public class AddressController : Controller
{
    private DataBase _db;
    public AddressController()
    {
        _db = new DataBase();
    }

    [HttpGet]
    public List<AddressResponse> ListAddresses() {
        List<Address> theList = _db.Addresses;
        List<AddressResponse> AddressResponseList = new List<AddressResponse>();
        foreach (Address add in theList)
        {
            AddressResponseList.Add(new AddressResponse(add.Id, add.PostCode , add.StreetName, add.HouseNumber, add.HousePhoto));
        }
        return AddressResponseList;
    }
    [HttpGet("{id}")]
    public AddressResponse? GetAddressById(int id) {
        List<Address> addresses = _db.Addresses;
        if (addresses.Find(x => x.Id == id) != null)
        {
            Address? found = addresses.Find(x => x.Id == id);

            return new AddressResponse(found.Id, found.PostCode, found.StreetName, found.HouseNumber, found.HousePhoto);
        }
        return null;
    }

    [HttpPost]
    public IActionResult CreateAddress(AddressResponse incomingModel) {
        List<Address> addresses = _db.Addresses;
        int nextId = addresses.Count + 1;
        Address newAddress = new Address(nextId, incomingModel.postCode ,
            incomingModel.streetName, incomingModel.houseNumber, incomingModel.housePhoto);

        _db.Addresses.Add(newAddress);

        return CreatedAtAction(nameof(GetAddressById), new {id = nextId}, newAddress);
    }
    
}