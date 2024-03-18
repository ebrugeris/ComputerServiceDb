using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerServiceDb.Models
{
    public class ComputerServiceContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-IO74TBU\SQLEXPRESS01;Database=ComputerServiceDb;Trusted_Connection=true;TrustServerCertificate=true;");
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<ServiceStatus> ServiceStatuses { get; set; }
        public DbSet<ServiceRecord> ServiceRecords { get; set; }

        public DbSet<SparePart> SpareParts { get; set; }
        public DbSet<Staff> Staff { get; set;}
        public DbSet<Invoice> Invoices { get; set; }


    }
}
