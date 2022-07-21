using Microsoft.EntityFrameworkCore;
using SadarakDeptProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SadarakDeptProject.Data
{
    public class DebtContext : DbContext
    {
        public DebtContext(DbContextOptions<DebtContext> options) : base(options)
        {
        }
        public DbSet<Debt> Debts { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
