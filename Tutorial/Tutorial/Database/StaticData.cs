﻿using Tutorial.Models;


namespace Tutorial.Database;

public class StaticData
{
    public static List<Animal> animals = new List<Animal>()
    {
        new Animal(),
        new Animal(),
        new Animal(),
    };

    public static List<Visit> visits = new List<Visit>()
    {
        new Visit { Id = 1, VisitDate = DateTime.Now, AnimalId = 1, Description = "First visit", Price = 50.00m },
        new Visit()
    };
}