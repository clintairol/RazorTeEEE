using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorTees.Data;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Policy;

namespace RazorTees.Models
{
        public class SeedData
        {
            public static void Initialize(IServiceProvider serviceProvider)
            {
                using (var context = new RazorTeesContext(serviceProvider.GetRequiredService<DbContextOptions<RazorTeesContext>>()))
                {
                    //LOOKING FOR T-SHIRTS OR APPARELS
                    if (context.Tees.Any())
                    {
                        return;
                    }

                    context.Tees.AddRange(
                        new Tees
                        {
                            Product = "Tshirt",
                            Quantity = 12,
                            Brand = "Penshoppe",
                            Color = "Red",
                            Design = "Plain",
                            Sizes = "S",
                            Neckline = "V-shape",
                            Material = "Linen",
                            Price = 3.99,
                            Date = DateTime.Now


                        }
                        );
                    context.SaveChanges();
                }
            }

        }
}
