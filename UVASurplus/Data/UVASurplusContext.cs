using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UVASurplus.Models;

namespace UVASurplus.Data
{
    public class UVASurplusContext : DbContext
    {
        public UVASurplusContext (DbContextOptions<UVASurplusContext> options)
            : base(options)
        {
        }

        public DbSet<UVASurplus.Models.Request> Request { get; set; }
        public DbSet<UVASurplus.Models.Item> Item { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Request>().ToTable("Request");
            modelBuilder.Entity<Item>().ToTable("Item");
        }
    }
}
