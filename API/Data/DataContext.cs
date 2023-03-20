global using Microsoft.EntityFrameworkCore;
using API.Models;
using System.Collections.Generic;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //    //optionsBuilder.UseNpgsql("Host=deck1.sk;Port=5432;Database=deck1;Username=deckone;Password=deckone");
        //}

        public DbSet<Helicopter> Helicopters { get; set; }
    }
}

