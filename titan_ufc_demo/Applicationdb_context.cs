using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using titan_ufc_demo.Models;

namespace titan_ufc_demo
{
    public class Applicationdb_context:DbContext
    {
        // internal object locationDataaccessEntity;

        public virtual DbSet<Users> UserEntity { get; set; }
            public virtual DbSet<Location> LocationEntity { get; set; }

        public virtual DbSet<UserXrefLocation> UserXrefLocationEntity { get; set; }

        public virtual DbSet<Device> DeviceEntity { get; set; }

        public Applicationdb_context(DbContextOptions<Applicationdb_context>options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>().HasKey(UserXrefLocation => UserXrefLocation.UserId);
            modelBuilder.Entity<Location>().HasKey(UserXrefLocation => UserXrefLocation.LocationId);
            modelBuilder.Entity<Device>().HasKey(UserXrefLocation => UserXrefLocation.DeviceId);
            modelBuilder.Entity<UserXrefLocation>().HasKey(UserXrefLocation => UserXrefLocation.User_Xref_LocationId);

        }
    }
}
