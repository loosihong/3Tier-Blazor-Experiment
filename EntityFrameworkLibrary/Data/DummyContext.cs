using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkLibrary
{
    public partial class DummyContext : DbContext
    {
        public DummyContext (DbContextOptions<DummyContext> options)
            : base(options)
        {
        }

        public DbSet<Dummy> Dummies { get; set; }
        public DbSet<DummyItem> DummyItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dummy>().ToTable(nameof(Dummy));
            modelBuilder.Entity<DummyItem>().ToTable(nameof(DummyItem));
        }
    }
}
