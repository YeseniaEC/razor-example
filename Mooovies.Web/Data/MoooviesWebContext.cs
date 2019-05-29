using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Mooovies.Web.Models
{
    public class MoooviesWebContext : DbContext
    {
        public MoooviesWebContext (DbContextOptions<MoooviesWebContext> options)
            : base(options)
        {
        }

        public DbSet<Mooovies.Web.Models.Movie> Movie { get; set; }
    }
}
