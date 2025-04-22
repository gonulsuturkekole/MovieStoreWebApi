using Microsoft.EntityFrameworkCore;
using MovieStoreWebApi.Schema;

namespace MovieStoreWebApi.Context

{
    public class MovieStoreDbContext : DbContext
    {
        public MovieStoreDbContext(DbContextOptions<MovieStoreDbContext> options)
            : base(options) { }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<ActorMovie> ActorMovies { get; set; }
        public DbSet<CustomerGenre> CustomerGenres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ActorMovie>()
                .HasKey(am => new { am.ActorId, am.MovieId });

            modelBuilder.Entity<ActorMovie>()
                .HasOne(am => am.Actor)
                .WithMany(a => a.ActorMovies)
                .HasForeignKey(am => am.ActorId);

            modelBuilder.Entity<ActorMovie>()
                .HasOne(am => am.Movie)
                .WithMany(m => m.ActorMovies)
                .HasForeignKey(am => am.MovieId);

            modelBuilder.Entity<CustomerGenre>()
                .HasKey(cg => new { cg.CustomerId, cg.GenreId });

            modelBuilder.Entity<CustomerGenre>()
                .HasOne(cg => cg.Customer)
                .WithMany(c => c.FavoriteGenres)
                .HasForeignKey(cg => cg.CustomerId);

            modelBuilder.Entity<CustomerGenre>()
                .HasOne(cg => cg.Genre)
                .WithMany(g => g.CustomerGenres)
                .HasForeignKey(cg => cg.GenreId);

            modelBuilder.Entity<Movie>()
                .Property(m => m.Price)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Order>()
                .Property(m => m.Price)
                .HasPrecision(10, 2);

        }
    }
}
