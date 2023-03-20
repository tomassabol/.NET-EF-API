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

        public DbSet<Helicopter> Helicopters { get; set; }
    }
}

