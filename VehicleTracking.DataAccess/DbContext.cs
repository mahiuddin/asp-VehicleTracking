using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTracking.DataAccess
{
    

    public class DbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbContext(DbContextOptions<DbContext> options) : base(options)
        {
        }
        //public DbSet<UserType> UserType { get; set; }
        //public DbSet<User> User { get; set; }
        //public DbSet<Vehicle> Vehicle { get; set; }
        //public DbSet<Device> Device { get; set; }
        //public DbSet<Location> Location { get; set; }
        
    }
}
