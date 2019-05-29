using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Mooovies.Web.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider )
        {
            using ( var context = new MoooviesWebContext (
                serviceProvider.GetRequiredService<DbContextOptions<MoooviesWebContext>> ( ) ) )
            {
                if ( context.Movie.Any ( ) )
                {
                    return;
                }

                context.Movie.AddRange (
                    new Movie
                    {
                        Title ="Ghostbusters ",
                        ReleaseDate = DateTime.Parse ( "1984-3-13" ),
                        Genre = "Comedy",
                        Price = 8.99M,
                        Rating = "8"
                    },
                    new Movie
                    {
                        Title= "Thor: The Dark World",
                        ReleaseDate=DateTime.Parse ( "2018-7-13" ),
                        Genre= "Action/Fiction" ,
                        Price= 20.99M,
                        Rating="9.9"
                    },
                    new Movie
                    {
                        Title= "The Matrix",
                        ReleaseDate=DateTime.Parse ( "2008-5-12" ),
                        Genre= "Fiction",
                        Price= 12.99M,
                        Rating="7.9"
                    },
                    new Movie
                    {
                        Title= "Aquaman",
                        ReleaseDate=DateTime.Parse ( "2018-2-12" ),
                        Genre= "Fiction",
                        Price= 15.99M,
                        Rating="7.2"
                    },
                    new Movie
                    {
                        Title= "Die Hard",
                        ReleaseDate=DateTime.Parse ( "1989-1-12" ),
                        Genre= "Action",
                        Price= 1.75M,
                        Rating="8.7"
                    },
                    new Movie
                    {
                        Title= "Interstellar",
                        ReleaseDate=DateTime.Parse ( "2012-12-12" ),
                        Genre= "Suspense",
                        Price= 19.99M,
                        Rating="9.4"
                    }
                );
                context.SaveChanges ( );
            }
        }
    }
}
