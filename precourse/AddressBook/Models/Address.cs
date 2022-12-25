namespace AddressBook;

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
        set {
            if(value > 999){
                _postCode = value; 
            }
        }
    }
    private string? _streetName;
    public string? StreetName
    {
        get { return _streetName; }
        set {
            if (!String.IsNullOrEmpty(value) && !String.IsNullOrEmpty(value.Trim()))
            {
                _streetName = value;
            }
        }
    }
    private int _houseNumber;
    public int HouseNumber
    {
        get { return _houseNumber; }
        set {
            if (value > 0)
            {
                _houseNumber = value;
            }
        }
    }
    private string? _housePhoto; // base64
    public string? HousePhoto
    {
        get { return _housePhoto; }
        set {
            if (!String.IsNullOrEmpty(value) && !String.IsNullOrEmpty(value.Trim()))
            {
                _housePhoto = value;
            }
        }
    }
    public Address()
    {
        _streetName = "";
        _housePhoto = "";
    }
    public Address(int id, int postCode, string streetName, int houseNumber)
    {
        this.Id = id;
        this.PostCode = postCode;
        this.StreetName = streetName;
        this.HouseNumber = houseNumber;
        this.HousePhoto = "";
    }
    public Address(int id, int postCode, string streetName, int houseNumber, string housePhoto)
    {
        this.Id = id;
        this.PostCode = postCode;
        this.StreetName = streetName;
        this.HouseNumber = houseNumber;
        this.HousePhoto = housePhoto;
    }
}