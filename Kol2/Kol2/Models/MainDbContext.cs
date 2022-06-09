using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace Kol2.Models
{
    public class MainDbContext : DbContext
    {
        readonly IConfiguration _configuration;
        public MainDbContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }

        protected MainDbContext()
        {
        }
        protected MainDbContext(IConfiguration confguration)
        {
            _configuration = confguration;
        }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Musician> Musicians { get; set; }
        public DbSet<Musician_track> Musician_Tracks { get; set; }
        public DbSet<MusicLabel> MusicLabels { get; set; }
        public DbSet<Track> Tracks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = db - mssql; Initial Catalog = 2019SBD; Integrated Security = True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
