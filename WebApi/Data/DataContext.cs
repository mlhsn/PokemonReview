namespace WebApi.Data
{

    using Microsoft.EntityFrameworkCore;
    using Microsoft.Identity.Client;
    using WebApi.Models;

    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Owner> Owners { get; set; }

        public DbSet<Pokemon> Pokemons { get; set; }

        public DbSet<PokemonCategory> PokemonCategories { get; set; }

        public DbSet<PokemonOwner> PokemonOwners { get; set; }

        public DbSet<Review> Reviews { get; set; }

        public DbSet<Reviewer> Reviewers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // PokemonCategory relations
            modelBuilder.Entity<PokemonCategory>()
                        .HasKey(poCat => new { poCat.PokemonId, poCat.CategoryId });

            modelBuilder.Entity<PokemonCategory>()
                        .HasOne(p => p.Pokemon)
                        .WithMany(pc => PokemonCategories)
                        .HasForeignKey(p => p.PokemonId);

            modelBuilder.Entity<PokemonCategory>()
                        .HasOne(p => p.Category)
                        .WithMany(pc => PokemonCategories)
                        .HasForeignKey(c => c.CategoryId);

            // PokemonOwners relations
            modelBuilder.Entity<PokemonOwner>()
                        .HasKey(pOwn => new { pOwn.PokemonId, pOwn.OwnerId });

            modelBuilder.Entity<PokemonOwner>()
                        .HasOne(p => p.Pokemon)
                        .WithMany(po => PokemonOwners)
                        .HasForeignKey(p => p.PokemonId);

            modelBuilder.Entity<PokemonOwner>()
                        .HasOne(p => p.Owner)
                        .WithMany(po => PokemonOwners)
                        .HasForeignKey(c => c.OwnerId);

        }
    }
}