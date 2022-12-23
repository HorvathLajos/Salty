using System.ComponentModel.DataAnnotations;

public class CreateDeveloperRequests{
    public int Id { get; set; }
    [Required]
    public string? Name { get; set; }
    [EmailAddress(ErrorMessage = "The 'Email' needs to be proper")] // .com deleted, still valid address... don't use!
    public string? Email { get; set; }

}