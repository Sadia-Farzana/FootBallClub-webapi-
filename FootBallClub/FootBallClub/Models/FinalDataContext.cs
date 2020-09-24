using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FootBallClub.Models
{
    public class FinalDataContext : DbContext 
    {
        public FinalDataContext()
        {
            Database.SetInitializer<FinalDataContext>(new DropCreateDatabaseAlways<FinalDataContext>());
        }

        virtual public DbSet<Player> Players { get; set; }
    }
}