using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Lab_11_version_2.Models
{
    public static class SeedData
    {
    public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ProfessorDbContext(serviceProvider.GetRequiredService<DbContextOptions<ProfessorDbContext>>()))
            {
                // Look for any professors.
                if (context.Professor.Any())
                {
                    return; // DB has been seeded
                }

                context.Professor.AddRange(
                    new Professor
                    {
                        FirstName = "Mickey" ,
                        LastName = "Mouse",
                    },

                    new Professor
                    {
                        FirstName = "Minnie",
                        LastName = "Mouse",
                        
                    },
                    new Professor
                    {
                        FirstName = "Donald",
                        LastName = "Duck",
                    },
                    new Professor
                    {
                        FirstName = "Daisy",
                        LastName = "Duck"
                    }
                );
                
                context.SaveChanges();
            }    
        }
    }
}