using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransportManagementApplication.Models
{
    public class TransportContext:DbContext
    {
        public TransportContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Route> Routes { get; set; }      
    }
}

