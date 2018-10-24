using System;
using System.Collections.Generic;
using System.Linq;
using WebApplicationDal.Entities;
using WebApplicationDal.Interfaces;

namespace WebApplicationDal.Repositories
{
    public class FirstTableRepository : IRepository<FirstTable>
    {
        private readonly SberDBContext dbContext;

        public FirstTableRepository(SberDBContext dbContext)
        {
            this.dbContext = dbContext;
        }


        public void AddLog(FirstTable logTable)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FirstTable> GetAll()
        {
            return dbContext.FirstTable;
        }

        public IEnumerable<FirstTable> GetFiltered(Filter filterModel)
        {
            throw new NotImplementedException();
        }



    }
}