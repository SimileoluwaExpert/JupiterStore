﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace JupiterStore.Models
{
    public class StoreDbContext : DbContext 
    {
        public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options) { 
            
        }
        public DbSet<Product> Products => Set<Product>();
    }
}
