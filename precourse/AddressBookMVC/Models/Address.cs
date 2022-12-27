namespace AddressBookMVC.Models;

public class Address
{
    private int _id;
    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }

    private int _postCode;
    public int PostCode
    {
        get { return _postCode; }
        set
        {
            if (value > 999)
            {
                _postCode = value;
            }
        }
    }
    private string? _streetName;
    public string? StreetName
    {
        get { return _streetName; }
        set
        {
            if (!string.IsNullOrEmpty(value) && !string.IsNullOrEmpty(value.Trim()))
            {
                _streetName = value;
            }
        }
    }
    private int _houseNumber;
    public int HouseNumber
    {
        get { return _houseNumber; }
        set
        {
            if (value > 0)
            {
                _houseNumber = value;
            }
        }
    }
    public Address()
    {
        _streetName = "";
    }
    public Address(int id, int postCode, string streetName, int houseNumber)
    {
        Id = id;
        PostCode = postCode;
        StreetName = streetName;
        HouseNumber = houseNumber;
    }
}