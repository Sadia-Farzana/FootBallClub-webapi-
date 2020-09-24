using FootballClub.Models;
using FootballClub.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Principal;
using System.Threading;
using System.Web.Http;

namespace FootballClub.Controllers
{
    public class LoginController : ApiController
    {
        LoginRepository logrepo = new LoginRepository();

        //LOGIN

        [Route("validate")]
        public IHttpActionResult PostLogin([FromBody] Login l)
        {
            string userid = l.username;
            string password = l.password;
            string type = logrepo.checkUsername(userid);

            if (type == "01" && logrepo.ValidateAdmin(userid, password) != null)
            {
                string uid = logrepo.ValidateAdmin(userid, password).ToString();
                Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity(uid), null);
                //var response = Request.CreateResponse(HttpStatusCode.Moved);
                //response.Headers.Location = new Uri("http://127.0.0.1:5500/views/superadmin/superadmindashboard.html");
                //return response;

                return Ok();

            }
            else if (type == "02" && logrepo.ValidateCoach(userid, password) != null)
            {
                string uid = logrepo.ValidateCoach(userid, password).ToString();
                Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity(uid), null);
                //var response = Request.CreateResponse(HttpStatusCode.Moved);
                //response.Headers.Location = new Uri("http://127.0.0.1:5500/views/admin/admindashboard.html");
                //return response;

                return Ok();
            }
            else if (type == "03" && logrepo.ValidatePlayer(userid, password) != null)
            {
                string uid = logrepo.ValidatePlayer(userid, password).ToString();
                Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity(uid), null);
                //var response = Request.CreateResponse(HttpStatusCode.Moved);
                //response.Headers.Location = new Uri("http://127.0.0.1:5500/views/teacher/teacherdashboard.html");
                //return response;

                return Ok();
            }
            else
            {
                //var responseMessage = new HttpResponseMessage(HttpStatusCode.Unauthorized);
                //return responseMessage;
                return Unauthorized();
            }
        }
    }
}
