using Microsoft.AspNetCore.Mvc;
using Tutorial.Database;
using Tutorial.Models;

namespace Tutorial.Controllers;

[ApiController]
[Route("/animals-controller")]
//[Route("[controller]")]
public class AnimalsController : ControllerBase
{

    //getAnimals dla wszytskich zwierzat
    [HttpGet]
    public IActionResult GetAnimals()
    {
        var animals = StaticData.animals;
        return Ok(animals);
    }
    
    //getAnimals dla zwierzecia id
    [HttpGet("{id}")]
    public IActionResult GetAnimalById(int id)
    {
        var animal = StaticData.animals.FirstOrDefault(a => a.Id == id);
        if (animal == null)
        {
            return NotFound("zwierzak o podanym identyfikatorze nie istnieje");
        }
        return Ok(animal);
    }
    
    
    //AddAnimals dodajemy zwierze
    [HttpPost]
    public IActionResult AddAnimals(Animal animal)
    {

        if (animal == null)
        {
            return BadRequest("zwierze nie istneije");
        }
        
        animal.Id = StaticData.animals.Count + 1;
        StaticData.animals.Add(animal);

        return Created($"/animals-controller/{animal.Id}", animal);
    }
    
    
    //UpdateAnimal edytowanie Animala po Id
    [HttpPut("{id}")]
    public IActionResult UpdateAnimal(int id, Animal updatedAnimal)
    {
        var existingAnimal = StaticData.animals.FirstOrDefault(a => a.Id == id);
        if (existingAnimal == null)
        {
            return NotFound("zwierzak o podanym identyfikatorze nie zostal znaleziony");
        }

        existingAnimal.Id = updatedAnimal.Id;
        existingAnimal.Name = updatedAnimal.Name;
        existingAnimal.Category = updatedAnimal.Category;
        existingAnimal.Weight = updatedAnimal.Weight;
        existingAnimal.Color = updatedAnimal.Color;
        
        return Ok(existingAnimal);
    }
    
    
    //DeleteAnimal usuwanie zwierzecia po Id
    [HttpDelete("{id}")]
    public IActionResult DeleteAnimal(int id)
    {
        var existingAnimal = StaticData.animals.FirstOrDefault(a => a.Id == id);
        if (existingAnimal == null)
        {
            return NotFound("zwierzak o podanym identyfikatorze nie zostal znaleziony");
        }
        
        StaticData.animals.Remove(existingAnimal);
        
        return NoContent();
    }
    
    
}