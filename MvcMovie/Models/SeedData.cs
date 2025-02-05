using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Romantic Comedy",
                    Price = 7.99M
                },
                new Movie
                {
                    Title = "Ghostbusters ",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Comedy",
                    Price = 8.99M
                },
                new Movie
                {
                    Title = "Ghostbusters 2",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "Comedy",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "Rio Bravo",
                    ReleaseDate = DateTime.Parse("1959-4-15"),
                    Genre = "Western",
                    Price = 3.99M
                },
                new Movie
                {
                    Title = "Armand",
                    ReleaseDate = DateTime.Parse("2025-02-07"),
                    Genre = "Psychological Drama",
                    Price = 12.00M
                },
                new Movie
                {
                    Title = "Bring Them Down",
                    ReleaseDate = DateTime.Parse("2025-02-7"),
                    Genre = "Family Drama",
                    Price = 10.00M
                },
                                
                new Movie
                {
                Title = "Hear Eyes",
                ReleaseDate = DateTime.Parse("2025-02-7"),
                Genre = "Horror",
                Price = 15.00M
                },
                new Movie
                {
                    Title = "I'm Still Here",
                    ReleaseDate = DateTime.Parse("2025-02-7"),
                    Genre = "Drama",
                    Price = 13.00M
                },
                new Movie
                {
                    Title = "Captain America: Brave New World",
                    ReleaseDate = DateTime.Parse("2025-02-14"),
                    Genre = "Superhero",
                    Price = 18.00M
                }
            );
            context.SaveChanges();
        }
    }
}