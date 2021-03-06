﻿using FootballClub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace FootballClub.Repository
{
    interface IRepository<T> where T:class
    {
        List<T> GetAll();
        T GetById(string username);
        void Insert(T entity);
        void Delete(string username);
        void Edit(T entity);
    }
}
