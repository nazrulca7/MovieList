using Microsoft.EntityFrameworkCore;

namespace MovieList.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options)
            : base(options)
        { }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
                new Movie {
                    MovieId = 4,
                    MovieName = "Casablanca",
                    MainStar="Mr 1",
                    Year = 1943,
                    Ishorror= 0,
                    EmailAddress = "a@gmail.com",
                    Website = "https://www.youtube.com/watch?v=0KGOB1WIjRs",
                    Rating = 5,
                    GenreId = "D"
                },
                new Movie {
                    MovieId = 2,
                    MovieName = "Wonder Woman",
                    MainStar = "Mr 1",
                    Ishorror = 0,
                    Year = 2017,
                    EmailAddress = "a@gmail.com",
                    Website = "https://www.youtube.com/watch?v=pJCgeOAKXyg",

                    Rating = 3,
                    GenreId = "A"
                },
                new Movie {
                    MovieId = 3,
                    MovieName = "Moonstruck",
                    MainStar = "Mr 1",
                    Year = 1988,
                    Ishorror = 0,
                    EmailAddress ="a@gmail.com",
                    Website = "https://www.youtube.com/watch?v=q9WDbb_OoSo",
                    Rating = 4,
                    GenreId = "R"
                }
            ); ;
            modelBuilder.Entity<Genre>().HasData(
                new Genre { GenreId = "A", Name = "Action" },
                new Genre { GenreId = "C", Name = "Comedy" },
                new Genre { GenreId = "D", Name = "Drama" },
                new Genre { GenreId = "H", Name = "Horror" },
                new Genre { GenreId = "M", Name = "Musical" },
                new Genre { GenreId = "R", Name = "RomCom" },
                new Genre { GenreId = "S", Name = "SciFi" }
            );

        }
    }
}