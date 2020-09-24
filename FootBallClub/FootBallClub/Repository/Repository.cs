using FootballClub.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FootballClub.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected FinalDataContext context;

        public Repository()
        {
            this.context = new FinalDataContext();
        }

        public void Delete(string username)
        {
            context.Set<T>().Remove(GetById(username));
            context.SaveChanges();
        }

        public void Edit(T entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return context.Set<T>().ToList();
        }

        public T GetById(string username)
        {
            return context.Set<T>().Find(username);
        }

        public void Insert(T entity)
        {
            context.Set<T>().Add(entity);
            context.SaveChanges();

        }
    }
}