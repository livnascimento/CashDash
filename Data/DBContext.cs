using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CashDash.Models;

namespace CashDash.Data
{
    public class DBContext : DbContext
    {
        public DBContext (DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public DbSet<CashDash.Models.Category> Category { get; set; } = default!;
        public DbSet<CashDash.Models.Product> Product { get; set; }
        public DbSet<CashDash.Models.EmployeeType> EmployeeType { get; set; }
        public DbSet<CashDash.Models.Employee> Employee { get; set; }
        public DbSet<CashDash.Models.Customer> Customer { get; set; }
        public DbSet<CashDash.Models.Sale> Sale { get; set; }
    }
}
