using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootballClub.Repository
{
     interface ILoginRepository
    {
        string ValidateAdmin(string username, string password);

        string ValidatePlayer(string username, string password);

        string ValidateCoach(string username, string password);


        string checkUsername(string id);
    }
}