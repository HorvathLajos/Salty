using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AddressBookMVC.Models;

public class AddressViewModel
{
    [Required]
    public int id { get; set; }

    [DisplayName("Post code")]
    [Required]
    public int postCode { get; set; }

    [DisplayName("Street name")]
    [Required]
    public string? streetName { get; set; }

    [DisplayName("House nr.")]
    [Required]
    public int houseNumber { get; set; }

    public AddressViewModel()
    {
        streetName = "";
    }
    public AddressViewModel(int Id, int PostCode, string StreetName, int HouseNumber)
    {
        id = Id;
        postCode = PostCode;
        streetName = StreetName;
        houseNumber = HouseNumber;
    }
}