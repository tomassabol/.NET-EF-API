using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace API;

public partial class Deck1Context : DbContext
{
    public Deck1Context()
    {
    }

    public Deck1Context(DbContextOptions<Deck1Context> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=deck1.sk;Database=deck1;Username=deckone;Password=deckone");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
