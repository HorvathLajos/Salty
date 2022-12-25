using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AddressBook;

public class AddressResponse
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
    
    [DisplayName("House photo")]
    public string? housePhoto { get; set; }
    
    public AddressResponse()
    {
        streetName = "";
        housePhoto = "";
    }
    public AddressResponse(int Id, int PostCode, string StreetName, int HouseNumber)
    {
        this.id = Id;
        this.postCode = PostCode;
        this.streetName = StreetName;
        this.houseNumber = HouseNumber;
        this.housePhoto = "";
    }
    public AddressResponse(int Id, int PostCode, string StreetName, int HouseNumber, string HousePhoto)
    {
        this.id = Id;
        this.postCode = PostCode;
        this.streetName = StreetName;
        this.houseNumber = HouseNumber;
        this.housePhoto = HousePhoto;
    }
}