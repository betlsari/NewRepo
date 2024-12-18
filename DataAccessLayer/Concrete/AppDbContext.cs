using EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace DataAccessLayer
{
    // The AppDbContext class inherits from DbContext and provides the database context for the application.
    public class AppDbContext : DbContext
    {
        // Constructor that passes the connection string name "CarRental" to the base DbContext class.
        // This connection string is defined in the application's configuration file (e.g., App.config or Web.config).
        public AppDbContext() : base("name=CarRental") { }


        // DbSet property for the Rentals table in the database.
        public DbSet<Rental> Rentals { get; set; }

        // DbSet property for the Cars table in the database.
        public DbSet<Car> Cars { get; set; }
    }
}
