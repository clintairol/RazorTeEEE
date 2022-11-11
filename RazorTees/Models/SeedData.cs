using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorTees.Data;
using System;
using System.Linq;
namespace RazorTees.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using ( var context = new RazorTeesContext(serviceProvider.GetRequiredService<DbContextOptions<RazorTeesContext>>()))
            {
                //LOOKING FOR T-SHIRTS OR APPARELS
                if (context.Tees.Any())
                {
                    return;
                }

                context.Tees.AddRange(
                    new Tees
                    {

                    },
                     new Tees
                     {

                     },
                      new Tees
                      {

                      },
                       new Tees
                       {

                       }
                    );
                context.SaveChanges();
            }
        }

    }
}
