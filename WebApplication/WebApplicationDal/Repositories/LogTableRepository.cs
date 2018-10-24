using System;
using System.Collections.Generic;
using System.Text;
using WebApplicationDal.Entities;
using WebApplicationDal.Interfaces;

namespace WebApplicationDal.Repositories
{
    public class LogTableRepository : IRepository<LogTable>
    {
        private readonly SberDBContext dbContext;

        public LogTableRepository(string connectionString)
        {
            this.dbContext = new SberDBContext(connectionString);
        }

        public void AddLog(LogTable logTable)
        {
            dbContext.LogTable.Add(logTable);
            dbContext.SaveChanges();
        }

        public IEnumerable<LogTable> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LogTable> GetFiltered(Filter filterModel)
        {
            throw new NotImplementedException();
        }
    }
}
