namespace TrainingGround;

public class Address
{
    public string? Street { get; set; }
    public int? StreetNo { get; set; }
    public string? City { get; set; }

    public Address(){}
    public Address(string street, int streetNo, string city)
    {
        Street = street;
        StreetNo = streetNo;
        City = city;
    }
}