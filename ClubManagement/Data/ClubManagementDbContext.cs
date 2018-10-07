using ClubManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ClubManagement.Data
{
    public class ClubManagementDbContext: DbContext
    {
        public DbSet<ClubCenter> ClubCenters { get; set; }

        public DbSet<Club> Clubs { get; set; }

        public DbSet<Manager> Managers { get; set; }

        public DbSet<Membership> MemberShips { get; set; }

        public DbSet<Person> People { get; set; }
    }
}