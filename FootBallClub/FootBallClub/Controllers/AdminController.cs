using FootballClub.Models;
using FootballClub.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FootballClub.Controllers
{
    [RoutePrefix("api/admins")]
    public class AdminController : ApiController
    {

        PlayerRepository playerrepo = new PlayerRepository();
        AdminRepository signrepo = new AdminRepository();
        CoachRepository coachrepo = new CoachRepository();

        [Route("",Name ="GetAdmin")]
        public IHttpActionResult Get()
        {
            return Ok(signrepo.GetAll());
        }

        [Route("{username}", Name = "GetAdminById")]
        public IHttpActionResult Get(string username)
        {
            Admin sign = signrepo.GetById(username);
            if (sign == null)
            {
                return StatusCode(HttpStatusCode.NoContent);
            }


            return Ok(sign);
        }

        [Route("")]
        public IHttpActionResult Post(Admin add)
        {
            signrepo.Insert(add);
            string url = Url.Link("GetById", new { id = add.userName });
            return Created( url,add);
        }


        [Route("{username}", Name = "EditAdmin"), HttpPut]
        public IHttpActionResult PutAdmin([FromBody] Admin sign, [FromUri] string username)
        {
            sign.userName = username;
            signrepo.Edit(sign);
            return Ok(sign);
        }

        [Route("{username}",Name = "DeleteAdmin")]
        public IHttpActionResult Delete(string username)
        {
            signrepo.Delete(username);
            return StatusCode(HttpStatusCode.NoContent);

        }

        [Route("players",Name ="GetAllPlayers")]
        public IHttpActionResult GetPlayer()
        {
            return Ok(playerrepo.GetAll());
        }

        [Route("players/{username}", Name = "GetPlayerById")]
        public IHttpActionResult GetPlayerById(string username)
        {
            Player p = playerrepo.GetById(username);
            if (p == null)
            {
                return StatusCode(HttpStatusCode.NoContent);
            }

            return Ok(p);
        }


        [Route("players")]
        public IHttpActionResult CreatePlayer(Player p)
        {
            playerrepo.Insert(p);
            string url = Url.Link("GetPlayerById", new { id = p.userName });
            return Created(url, p);
        }

        [Route("players/{username}"), HttpPut]
        public IHttpActionResult PutPlayer([FromBody] Player p, [FromUri] string username)
        {
            p.userName = username;
            playerrepo.Edit(p);
            return Ok(p);
        }

        [Route("{username}")]
        public IHttpActionResult DeletePlayer(string username)
        {
            playerrepo.Delete(username);
            return StatusCode(HttpStatusCode.NoContent);

        }


        [Route("coachs", Name = "GetAllCoachs")]
        public IHttpActionResult GetCoach()
        {
            return Ok(coachrepo.GetAll());
        }

        [Route("coachs/{UserName}", Name = "GetCoachById")]
        public IHttpActionResult GetCoachById(string username)
        {
            Coach c = coachrepo.GetById(username);
            if (c == null)
            {
                return StatusCode(HttpStatusCode.NoContent);
            }

            return Ok(c);
        }


        [Route("coachs")]
        public IHttpActionResult CreateCoach(Coach c)
        {
            coachrepo.Insert(c);
            string url = Url.Link("GetCoachById", new { id = c.UserName });
            return Created(url, c);
        }

        [Route("coachs/{username}"), HttpPut]
        public IHttpActionResult PutCoach([FromBody] Coach c, [FromUri] string username)
        {
             c.UserName = username;
            coachrepo.Edit(c);
            return Ok(c);
        }

        [Route("{username}")]
        public IHttpActionResult DeleteCoach(string username)
        {
            coachrepo.Delete(username);
            return StatusCode(HttpStatusCode.NoContent);

        }

    }
}
