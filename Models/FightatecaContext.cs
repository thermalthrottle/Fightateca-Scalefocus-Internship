using Microsoft.EntityFrameworkCore;
using Models.Models;
using System;

namespace Models
{
    public class FightatecaContext : DbContext
    {
        public FightatecaContext() { }
        public FightatecaContext(DbContextOptions options) : base(options) { }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Character> Characters { get; set; }
        public virtual DbSet<CharacterStates> CharacterStates { get; set; }
        public virtual DbSet<BattleResults> BattleResults { get; set; }
        //public virtual DbSet<RoundResults> RoundResults { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Fightateca;Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasIndex(user => new { user.Username })
                .IsUnique(true);
            modelBuilder.Entity<Character>()
                .HasOne<User>(c => c.User)
                .WithMany(u => u.characters);
            modelBuilder.Entity<Character>()
                .HasIndex(character => new { character.Name })
                .IsUnique(true);
            modelBuilder.Entity<BattleResults>()
                .HasMany<Character>(br => br.Winner)
                .WithMany(u => u.battlesWon);
            modelBuilder.Entity<BattleResults>()
                .HasMany<Character>(br => br.Loser)
                .WithMany(u => u.battlesLost);

            //modelBuilder.Entity<RoundResults>()
            //    .HasIndex(roundResults => new { roundResults.RoundIndex, roundResults.Character1State, roundResults.Character2State })
            //    .IsUnique();
        }
    }
}
