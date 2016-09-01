using DemoConcurrency.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace DemoConcurrency.Helper
{
    public class DbTestContext : DbContext
    {
        public DbTestContext()
            : base("DbTestContext")
        {
        }
        
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Bank> Banks { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}