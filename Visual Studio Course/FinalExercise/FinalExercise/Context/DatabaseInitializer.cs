using System;
using System.Collections.Generic;
using System.Data.Entity;
using FinalExercise.Models;

namespace FinalExercise.Context
{
    public class DatabaseInitializer : DropCreateDatabaseIfModelChanges<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            var students = new List<Student>()
            {
                new Student {Name = "Rhys Bussiere", DoB = DateTime.Parse("1987-03-28"), Gender=Gender.Male},
                new Student {Name = "Wesley Kennedy", DoB = DateTime.Parse("1993-02-12"), Gender=Gender.Male},
                new Student {Name = "Aimee Louise", DoB = DateTime.Parse("1987-03-19"), Gender=Gender.Female},
                new Student {Name = "John OConnor", DoB = DateTime.Parse("1993-02-14"), Gender=Gender.Male},
                new Student {Name = "Laura Willey", DoB = DateTime.Parse("1995-11-14"), Gender=Gender.Female},
                new Student {Name = "Meghan Foley", DoB = DateTime.Parse("1987-03-19"), Gender=Gender.Female},
                new Student {Name = "Rachel", DoB = DateTime.Parse("2015-04-12"), Gender=Gender.Other},
                new Student {Name = "Roscoe", DoB = DateTime.Parse("2015-09-22"), Gender=Gender.Other},
            };

            students.ForEach(x => context.Students.Add(x));
            context.SaveChanges();
        }
    }
}