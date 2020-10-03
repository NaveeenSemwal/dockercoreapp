using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace DockerAPI
{
    public class PrepData
    {
        public static void PopulateData(IApplicationBuilder applicationBuilder)
        {
            using (var scope = applicationBuilder.ApplicationServices.CreateScope())
            {
                SeedData(scope.ServiceProvider.GetRequiredService<DockerDbContext>());
            }
        }

        public static void SeedData(DockerDbContext dbContext)
        {
            dbContext.Database.Migrate();

            if (!dbContext.Summaries.Any())
            {
                System.Console.WriteLine("Applying seeding............");

                dbContext.Summaries.AddRange(new Summary { Id = 1, Name = "Freezing" }, new Summary { Id = 2, Name = "Bracing" });
            }
            else
            {
                System.Console.WriteLine("Already have Data- no seeding !");
            }
        }
    }
}
