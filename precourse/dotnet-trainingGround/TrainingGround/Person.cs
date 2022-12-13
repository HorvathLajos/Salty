namespace TrainingGround;

public class Person :IPrintable
{
    private string? _name;
    public string? Name {
        get {return this._name;}
        set
            {
                if(!String.IsNullOrEmpty(value) && value.Length > 5){
                this._name = value;
            }
        }
    }

    // public void setName(string nameToSet)
    // {
    //     if(!String.IsNullOrEmpty(nameToSet) && nameToSet.Length > 5){
    //         this._name = nameToSet;
    //     }
    // }
    private int _birthYear;
    public int BirthYear { 
        get {return this._birthYear;}
        set
            {
                if(value > 1900){
                this._birthYear = value;
            }
        }
     }
    public double LengthInMeters { get; set; }
    public Address Address
    {
        get { return Address; }
        set { Address = value; }
    }
    
    public Person(){}
    public Person(string name){
        this.Name = name;
    }
    public Person(string name, int birthYear, double lengthInMeters)
    {
        this.Address = new Address();
        this.Name = name;
        this.BirthYear = birthYear;
        this.LengthInMeters = lengthInMeters;
    }

    public int getAge()
    {
        return DateTime.Now.Year - this.BirthYear;
    }

    public string GetPrintString()
    {
        return @$"{this.Name}
        {this.BirthYear} {this.LengthInMeters}";
    }
}