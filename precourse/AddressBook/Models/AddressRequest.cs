using System.ComponentModel.DataAnnotations;

public class AddressRequests{
    [Required]
    public int id { get; set; }

    [Required]
    public int postCode { get; set; }

    [Required]
    public string? streetName { get; set; }

    [Required]
    public int houseNumber { get; set; }
    
    public string? housePhoto { get; set; }

}