using System.Linq;
using PhotoApi.Models;  // Change "PhotoApi" to your actual project name

namespace PhotoApi.Data  // Change "PhotoApi" to your actual project name
{
    public static class DbSeeder
    {
        public static void SeedData(ApplicationDbContext context)
        {
            if (!context.Photos.Any())
            {
                context.Photos.AddRange(
                    new Photo { Name = "Winter", Width = 200, Height = 150 },
                    new Photo { Name = "Family", Width = 1024, Height = 768 }
                );
                context.SaveChanges();
            }
        }
    }
}