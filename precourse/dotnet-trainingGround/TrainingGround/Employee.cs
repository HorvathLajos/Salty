namespace TrainingGround;

public class Employee : Person, IPrintable
{
    private string? _employeeId;
    public string? EmployeeId
    {
        get { return _employeeId; }
        set { _employeeId = value; }
    }
    public List<Address>? Addresses {get; set;}

    public Employee()
    {
    }
    public Employee(string name, string employeeId) : base(name)
    {
        this.Addresses = new List<Address>();
        this.EmployeeId = employeeId;
    }

    public Employee(string name, int birthYear, double lengthInMeters) : base(name, birthYear, lengthInMeters)
    {
    }

    new public string GetPrintString()
    {
    return @$"{this.Name} ({this.EmployeeId})
    {this.Address.Street} {this.Address.StreetNo}
    {this.Address.City}";
    }
}