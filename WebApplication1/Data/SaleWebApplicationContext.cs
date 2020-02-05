using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SaleWebApplication.Models;

namespace SaleWebApplication.Data
{
    public class SaleWebApplicationContext : DbContext
    {
        public SaleWebApplicationContext (DbContextOptions<SaleWebApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<SaleWebApplication.Models.Department> Department { get; set; }
    }
}
