using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace HoneyMarket.Models
{
    public class HoneyContext : DbContext
    {
        public DbSet<Honey> Honeys { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
    }
}