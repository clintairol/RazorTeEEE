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
                if (context.Tees.Any())
                {
                    return;
                }
            }
        }

    }
}
