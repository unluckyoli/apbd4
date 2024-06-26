﻿using Tutorial.Models;


namespace Tutorial.Database;

public class StaticData
{
    public static List<Animal> animals = new List<Animal>()
    {
        new Animal{Id = 1, Category = "pies", Name = "Burek", Color = "szary", Weight = "4kg"},
    };

    public static List<Visit> visits = new List<Visit>()
    {
        new Visit { Id = 1, VisitDate = DateTime.Now, AnimalId = 1, Description = "Druga wizyta", Price = 50.00m },
    };
}