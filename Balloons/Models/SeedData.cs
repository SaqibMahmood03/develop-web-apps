using System;
using System.Collections.Generic;
using System.Linq;
using Balloons.Data;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Balloons.Models
{
    public class SeedData
}

namespace Balloons.Models
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcBalloonContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcBalloonContext>>()))
        {
            // Look for any movies.
            if (context.Balloon.Any())
            {
                return;   // DB has been seeded
            }

            context.Balloon.AddRange(
                new Balloon
                {
                    Name = "Balloon Bonanza",
                    Size = 6,
                    Color = "Black",
                    Price = 7.99M
                },

                new Balloon
                {
                    Name = "Pretty Balloons",
                    Size = 9,
                    Color = "pink",
                    Price = 5.99M
                },

                new Balloon
                {
                    Name = "Helium Heaven",
                    Size = 7,
                    Color = "grey",
                    Price = 5.49M
                },

                new Balloon
                {
                    Name = "Sweet Serenity Balloons",
                    Size = 11,
                    Color = "blue",
                    Price = 10.99M
                },
                  new Balloon
                  {
                      Name = "Mr. Air",
                      Size = 8,
                      Color = "white",
                      Price = 7.49M
                  },
                    new Balloon
                    {
                        Name = "Bubblegum Balloons",
                        Size = 3,
                        Color = "purple",
                        Price = 9.49M
                    },
                      new Balloon
                      {
                          Name = "Balloon Headquarters",
                          Size = 12,
                          Color = "red",
                          Price = 8.88M
                      },
                        new Balloon
                        {
                            Name = "Balloons Galore!",
                            Size = 11,
                            Color = "cherry",
                            Price = 12.49M
                        },
                          new Balloon
                          {
                              Name = "Bang Bang Balloons",
                              Size = 2,
                              Color = "pink",
                              Price = 6.49M
                          },
                            new Balloon
                            {
                                Name = "Butterfly Balloons",
                                Size = 19,
                                Color = "yellow",
                                Price = 19.99M
                            }
                             
            );
            context.SaveChanges();
        }
    }
}
}
