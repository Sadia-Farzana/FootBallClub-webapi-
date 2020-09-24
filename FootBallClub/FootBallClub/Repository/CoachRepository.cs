
using FootballClub.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FootballClub.Repository
{
    public class CoachRepository : ICoachRepository<Coach>
    {
        protected FinalDataContext context;
        public CoachRepository()
        {
            this.context = new FinalDataContext();
        }
        public void Delete(string userName)
        {
            context.Set<Coach>().Remove(GetById(userName));
            context.SaveChanges();
        }

        public void Edit(Coach entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public List<Coach> GetAll()
        {
            return context.Set<Coach>().ToList();
        }

        public Coach GetById(string userName)
        {
            return context.Set<Coach>().Find(userName);
        }

        public void Insert(Coach entity)
        {
            context.Set<Coach>().Add(entity);
            context.SaveChanges();
        }
    }
}