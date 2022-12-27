using System.ComponentModel.DataAnnotations;

namespace AddressBookMVC.Models;
public class AddressRequests{
    [Required]
    public int id { get; set; }

    [Required]
    public int postCode { get; set; }

    [Required]
    public string? streetName { get; set; }

    [Required]
    public int houseNumber { get; set; }
}