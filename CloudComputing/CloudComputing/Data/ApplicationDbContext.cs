using System;
using System.Collections.Generic;
using System.Text;
using CloudComputing.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CloudComputing.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Balance> balances { get; set; }
        public DbSet<Server> servers { get; set; }
        public DbSet<Transaction> transactions { get; set; }
        public DbSet<Template> templates { get; set; }
        public DbSet<Switch> switches { get; set; }
    }
}
