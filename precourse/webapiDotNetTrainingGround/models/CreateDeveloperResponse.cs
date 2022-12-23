using webapiDotNetTrainingGround.Models;

public class CreateDeveloperResponse{
    private int _id;
    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }

    private string? _name;
    public string? Name
    {
        get { return _name; }
        set { _name = value; }
    }
    
    private string? _email;
    public string? Email
    {
        get { return _email; }
        set { _email = value; }
    }
    
    public CreateDeveloperResponse(int id, string name, string email)
    {
        this.Id = id;
        this.Name = name;
        this.Email = email;
    }

    public CreateDeveloperResponse()
    {
    }
}