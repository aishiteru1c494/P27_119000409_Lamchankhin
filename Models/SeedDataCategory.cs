using Microsoft.EntityFrameworkCore;
using P27_119000409_Lamchankhin.Models;

namespace P27_119000409_Lamchankhin.Models
{
    public static class SeedDataCategory
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesMovieContext>>()))
            {
                if (context == null || context.Category == null)
                {
                    throw new ArgumentNullException("Null RazorPagesMovieContext");
                }

                // Look for any movies.
                if (context.Category.Any())
                {
                    return;   // DB has been seeded
                }

                context.Category.AddRange(
                    new Category
                    {
                      Name="BaoThanhNien"  
                    },

                    new Category
                    {
                        Name="BaoThanhNien" 
                    },

                    new Category
                    {
                         Name="BaoThanhNien" 
                    },

                    new Category
                    {
                          Name="BaoThanhNien"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}