using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using WebApplicationDal.Entities;
using WebApplicationDal.Interfaces;

namespace WebApplicationDal.Repositories
{
    public class SecondTableRepository : IRepository<SecondTable>
    {
        private readonly SberDBContext dbContext;

        public SecondTableRepository(SberDBContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void AddLog(SecondTable logTable)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SecondTable> GetAll()
        {
            return dbContext.SecondTable.Include(s => s.Ftable);
        }

        public IEnumerable<SecondTable> GetFiltered(Filter filterModel)
        {
            throw new NotImplementedException();
        }


    }
}