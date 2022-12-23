using Microsoft.AspNetCore.Mvc;
using webapiDotNetTrainingGround;
using webapiDotNetTrainingGround.Models;

[ApiController]
[Route("/api/[controller]")]
public class DevelopersController :ControllerBase
{
    private Db _db;

    public DevelopersController(Db db)
    {
        _db = db;
    }

    [HttpGet]
    public List<CreateDeveloperResponse> GetAllDevelopers() {

        List<Developer> theList = _db.Developers;
        List<CreateDeveloperResponse> theCreateDeveloperResponseList = new List<CreateDeveloperResponse>();
        foreach (Developer dev in theList)
        {
            theCreateDeveloperResponseList.Add(new CreateDeveloperResponse(dev.Id, dev.Name, dev.Email));
        }
        return theCreateDeveloperResponseList;
    }
    [HttpGet("{id}")]
    public CreateDeveloperResponse? GetDevById(int id) {
        if(_db != null){
            Developer theDev = _db.Developers.Find(x => x.Id == id);
            return new CreateDeveloperResponse(theDev.Id, theDev.Name, theDev.Email);
        }
        return null;
    }

    [HttpGet("{name}/{email}")]
    public CreateDeveloperResponse? getDevFull(string name, string email){
        if(_db != null){
            Developer theDev = _db.Developers.Find(x => (x.Name == name && x.Email == email));
            return new CreateDeveloperResponse(theDev.Id, theDev.Name, theDev.Email);
        }
        return null;
    }

    [HttpPost]
    public IActionResult CreateNewDeveloper(CreateDeveloperRequests request){
        int nextId = _db.Developers.Count + 1;
        Developer devToAdd = new Developer() {
            Id = nextId,
            Name = request.Name,
            Email = request.Email,
        };
        _db.Developers.Add(devToAdd);

        return CreatedAtAction(nameof(GetDevById), new {id = nextId}, devToAdd);
    }
}