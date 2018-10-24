using System;
using System.Collections.Generic;
using WebApplicationDal.Entities;

namespace WebApplicationDal.Interfaces
{
    public interface IRepository<T> where T : class
    {
        void AddLog(T logTable);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetFiltered(Filter filterModel);
    }
}