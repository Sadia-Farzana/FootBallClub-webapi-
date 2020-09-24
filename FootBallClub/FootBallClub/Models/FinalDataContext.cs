using System;
using System.Collections.Generic;

using System.Data.Entity;
using System.Linq;
using System.Web;
//using FootballClub.Migrations;

namespace FootballClub.Models
{
    public class FinalDataContext: DbContext
    {

        virtual public DbSet<Admin> Admins { get; set; }
        virtual public DbSet<Player> Players { get; set; }
        virtual public DbSet<Coach> Coaches { get; set; }
        virtual public DbSet<Notification> Notifications { get; set; }
        public FinalDataContext()
        {
            //Database.SetInitializer<FinalDataContext>(new MigrateDatabaseToLatestVersion<FinalDataContext, Configuration>());
        }

    }
}