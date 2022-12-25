namespace AddressBook;

public class DataBase
{
    public List<Address> Addresses { get; set; }

    public DataBase()
    {
        Addresses = new List<Address>() {
            new Address(1, 1531, "Veerdijk", 50),
            new Address(2, 1512, "Nullreference street", 1),
            new Address(3, 1765, "Recursion road", 5),
            new Address(4, 1765, "Class avenue", 5),
            new Address(5 ,1765, "Model road", 5)
        };
    }

    
    public bool IsThisIdValid(Address address)
    {
        return Addresses.Find(x => x.Id == address.Id) != null; 
    }
}