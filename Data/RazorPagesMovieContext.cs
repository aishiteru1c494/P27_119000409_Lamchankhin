#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using P27_119000409_Lamchankhin.Models;

    public class RazorPagesMovieContext : DbContext
    {
        public RazorPagesMovieContext (DbContextOptions<RazorPagesMovieContext> options)
            : base(options)
        {
        }

        public DbSet<P27_119000409_Lamchankhin.Models.Category> Category { get; set; }

        public DbSet<P27_119000409_Lamchankhin.Models.News> News { get; set; }

        public DbSet<P27_119000409_Lamchankhin.Models.Comment> Comment { get; set; }
    }
