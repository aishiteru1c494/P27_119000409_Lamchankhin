using Microsoft.EntityFrameworkCore;
using P27_119000409_Lamchankhin.Models;

namespace P27_119000409_Lamchankhin.Models
{
    public static class SeedDataComment
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesMovieContext>>()))
            {
                if (context == null || context.Comment == null)
                {
                    throw new ArgumentNullException("Null RazorPagesMovieContext");
                }

                // Look for any movies.
                if (context.Comment.Any())
                {
                    return;   // DB has been seeded
                }

                context.Comment.AddRange(
                    new Comment
                    {
                        
                     Content ="phim abc",
                     Author =" tokuda",
                     CreatedAt = " abc"
                     
                    },

                    new Comment
                    { 
                    Author =" tokuda",
                    Content ="phim abc",
                    CreatedAt = "abc"                    
                    },

                    new Comment
                    {
                        Content ="phim abc",
                     Author =" tokuda",
                     CreatedAt = " abc"
                     
                    },

                   new Comment
                    {
                     Content ="phim abc",
                     Author =" tokuda",
                     CreatedAt = " abc"
                    
                    }
                );
                context.SaveChanges();
            }
        }
    }
}