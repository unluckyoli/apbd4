using Microsoft.AspNetCore.Mvc;
using Tutorial.Database;
using Tutorial.Models;

namespace Tutorial.Controllers;

[ApiController]
[Route("/visits-controller")]
public class VisitsController : ControllerBase
{

    
    //pobierz wizyte po id animala
    [HttpGet("/animals-controller/{animalId}/visits")]
    public IActionResult GetAnimalVisits(int animalId)
    {
        var animalVisits = StaticData.visits.Where(v => v.AnimalId == animalId).ToList();
        return Ok(animalVisits);
    }
    
    
    //dodaj wizyte po Id zwierzaka
    [HttpPost("/animals-controller/{animalId}/visits")]
    public IActionResult AddVisit(int animalId, Visit visit)
    {
        visit.Id = StaticData.visits.Count + 1;
        visit.AnimalId = animalId;
        StaticData.visits.Add(visit);

        return Created($"/visits-controller/{visit.Id}", visit);
    }
    
    
}