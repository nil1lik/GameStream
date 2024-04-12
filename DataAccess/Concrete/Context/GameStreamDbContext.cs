using Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.Context
{
    public class GameStreamDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Database=GameStreamingDb; Integrated Security=true; TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(x =>
            {
                x.ToTable("Users");
                x.HasKey(e => e.Id);

                x.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(50);

                x.Property(e => e.Description)
                .HasMaxLength(500);

                x.Property(e => e.Status)
                .IsRequired();

                x.HasMany(e => e.UserGames);
            });

            modelBuilder.Entity<Game>(x =>
            {
                x.ToTable("Games");
                x.HasKey(e => e.Id);

                x.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                x.Property(e => e.ImageUrl)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<GameDetail>(x =>
            {
                x.ToTable("GameDetails");
                x.HasKey(e => e.Id);
                x.Property(e => e.GameType)
                    .IsRequired()
                    .HasMaxLength(50);
                x.Property(e => e.Platform)
                    .IsRequired()
                    .HasMaxLength(100);
                x.Property(e => e.DiskSize)
                    .IsRequired();
                x.Property(e => e.VideoUrl)
                    .IsRequired()
                    .HasMaxLength(500);
                x.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500);

                x.HasOne(x => x.Game)
                .WithOne()
                .HasForeignKey<GameDetail>(x => x.GameId);

            });

            modelBuilder.Entity<GameImage>(x =>
            {
                x.ToTable("GameImages");
                x.HasKey(e => e.Id);

                x.Property(e => e.ImageUrl)
                    .IsRequired()
                    .HasMaxLength(500);

                x.HasOne(x => x.Game)
                .WithMany(g => g.GameImages)
                .HasForeignKey(x => x.GameId);
            });

            modelBuilder.Entity<Streaming>(x =>
            {
                x.ToTable("Streamings");
                x.HasKey(e => e.Id);

                x.Property(x => x.GameId)
                .IsRequired();

                x.Property(x => x.StreamerId)
                .IsRequired();

                x.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(200);

                x.Property(e => e.GameName)
                    .IsRequired()
                    .HasMaxLength(100);

                x.HasOne(x => x.Game)
                .WithMany(g => g.Streamings)
                .HasForeignKey(x => x.GameId);

                x.HasOne(x => x.Streamer)
                .WithMany(s => s.Streamings)
                .HasForeignKey(x => x.StreamerId);
            });

            modelBuilder.Entity<Streamer>(x =>
            {
                x.ToTable("Streamers");
                x.HasKey(e => e.Id);

                x.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                x.Property(e => e.ImageUrl)
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<UserGame>(x =>
            {
                x.ToTable("UserGames");
                x.HasKey(e => e.Id);

                x.Property(x => x.GameId)
                .IsRequired();

                x.Property(x => x.UserId)
                .IsRequired();

                x.HasOne(x => x.User)
                .WithMany(u => u.UserGames)
                .HasForeignKey(x => x.UserId);

                x.HasOne(x => x.Game)
                .WithMany(u => u.UserGames)
                .HasForeignKey(x => x.GameId);
            });
        }

        public DbSet<Game> Games { get; set; }
        public DbSet<GameDetail> GameDetails { get; set; }
        public DbSet<GameImage> GameImages { get; set; }
        public DbSet<Streamer> Streamers { get; set; }
        public DbSet<Streaming> Streamings { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserGame> UserGames { get; set; }

    }
}
