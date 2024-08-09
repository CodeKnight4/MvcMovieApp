using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovieAA.Data
{
    public class MvcMovieDbContext : DbContext
    {
        public MvcMovieDbContext (DbContextOptions<MvcMovieDbContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.Movie> Movie { get; set; } = default!;
    }
}
