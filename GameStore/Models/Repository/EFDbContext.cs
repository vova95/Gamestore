using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace GameStore.Models.Repository
{
    public class EFDbContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<User> Users { get; set; }
    }
}