using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballClub.Repository
{
    interface ICoachRepository<T> where T : class
    {
        List<T> GetAll();
        T GetById(string userName);
        void Insert(T entity);
        void Delete(string userName);
        void Edit(T entity);
    }
}
