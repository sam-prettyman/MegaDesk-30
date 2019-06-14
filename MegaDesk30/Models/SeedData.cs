using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

using System.Linq;

namespace MegaDesk30.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MegaDesk30Context(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MegaDesk30Context>>()))
            {
                // Look for any movies.
                if (context.Material_1.Any())
                {
                    return;   // DB has been seeded
                }


                context.Material_1.AddRange(
                    new MegaDesk30.Models.Material
                    {
                        MaterialType = "Oak",
                        Price = 200
                    },
                    new MegaDesk30.Models.Material
                    {
                         MaterialType = "Laminate",
                         Price = 100
                    },
                    new MegaDesk30.Models.Material
                    {
                          MaterialType = "Pine",
                          Price = 50
                    },
                    new MegaDesk30.Models.Material
                    {
                           MaterialType = "Veneer",
                           Price = 125
                    },
                    new MegaDesk30.Models.Material
                    {
                            MaterialType = "Oak",
                            Price = 200
                    }
                );

                context.Delivery.AddRange(
                    new MegaDesk30.Models.Delivery
                    {
                        RushOrderDay = "3 Day"
                    },
                     new MegaDesk30.Models.Delivery
                     {
                         RushOrderDay = "5 Day"
                     },
                     new MegaDesk30.Models.Delivery
                     {
                         RushOrderDay = "7 Day"
                     },
                     new MegaDesk30.Models.Delivery
                     {
                         RushOrderDay = "14 Day"
                     }
                    );

                context.SaveChanges();
            }
        }
    }
}
