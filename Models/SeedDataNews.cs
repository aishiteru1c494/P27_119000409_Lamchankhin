using Microsoft.EntityFrameworkCore;
using P27_119000409_Lamchankhin.Models;
namespace P27_119000409_Lamchankhin.Models
{
    public static class SeedDataNews
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesMovieContext>>()))
            {
                if (context == null || context.News == null)
                {
                    throw new ArgumentNullException("Null RazorPagesMovieContext");
                }

                // Look for any movies.
                if (context.News.Any())
                {
                    return;   // DB has been seeded
                }

                context.News.AddRange(
                    new News
                    {
                    
                    Title = " abc",
                    ImageUrl = " c",
                    Content = " abc",
                    Author = " abc1"
                    },

                    new News
                    {
                   
                    Title = " abc",
                    ImageUrl = " ,",
                    Content = " abc",
                    Author = " abc1"
                    },

                    new News
                    {
                      
                    Title = " abc",
                    ImageUrl = " ,",
                    Content = " abc",
                    Author = " abc1"
                    },

                   new News
                    {
                    Title = " abc",
                    ImageUrl = " ,",
                    Content = " abc",
                    Author = " abc1"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}