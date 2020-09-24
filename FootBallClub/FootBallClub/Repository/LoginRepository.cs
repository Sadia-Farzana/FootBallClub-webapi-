using FootballClub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootballClub.Repository
{
    public class LoginRepository : Repository<Login>, ILoginRepository
    {
        public string checkUsername(string id)
        {
            string[] idList = id.Split('-');
            string id3 = idList[2];
            return id3;
        }

        public string ValidateAdmin(string username, string password)
        {
            var u = context.Admins.Where(x => x.userName == username && x.password == password).FirstOrDefault();

            if (u != null)
            {
                return u.userName;


            }
            else

            {
                return null;
            }

        }

        public string ValidateCoach(string username, string password)
        {
            var u = context.Coaches.Where(x => x.UserName == username && x.Password == password).FirstOrDefault();

            if (u != null)
            {
                return u.UserName;


            }
            else

            {
                return null;
            }

        }



        public string ValidatePlayer(string username, string password)
        {
            var u = context.Players.Where(x => x.userName == username && x.password == password).FirstOrDefault();

            if (u != null)
            {
                return u.userName;


            }
            else

            {
                return null;
            }

        }

    }
}
    
