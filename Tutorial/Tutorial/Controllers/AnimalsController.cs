using Microsoft.AspNetCore.Mvc;
using Tutorial.Database;

namespace Tutorial.Controllers;

[ApiController]
[Route("/animals-controller")]
//[Route("[controller]")]
public class AnimalsController : ControllerBase
{




    [HttpGet]
    public IActionResult GetAnimals()
    {
        var animals = new MockDb().Animals;
        return Ok(animals);
    }
    
    [HttpPost]
    public IActionResult AddAnimals()
    {
        return Created();
    }
}