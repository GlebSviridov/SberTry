using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore.Internal;
using WebApplicationDal.Entities;
using WebApplicationDal.Interfaces;

namespace WebApplicationDal.Repositories
{
    public class JoinedTablesRepository : IRepository<JoinedTables>
    {
        private readonly SberDBContext dbContext;

        public JoinedTablesRepository(string connectionString)
        {
            this.dbContext = new SberDBContext(connectionString);
        }

        public void AddLog(JoinedTables logTable)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<JoinedTables> GetAll()
        {
            var joinedTables = dbContext.SecondTable.Join(dbContext.FirstTable,
                s => s.FtableId,
                f => f.Id,
                (s, f) => new JoinedTables()
                {
                    Id = s.Id, 
                    FtableId = s.FtableId,
                    LastName = s.LastName,
                    SomeDate = s.SomeDate,
                    SecondFloatNumber = s.SecondFloatNumber,
                    Checker = s.Checker,
                    Access = f.Access,
                    FirstName = f.FirstName, 
                    TableDate = f.TableDate,
                    SomeFloatNumber = f.SomeFloatNumber, 
                    SomeIntNumber = f.SomeIntNumber 
    }).ToList();
            var list = joinedTables;
            return list;
        }


        public IEnumerable<JoinedTables> GetFiltered(Filter filterModel)
        {

            var joinedTables = dbContext.SecondTable.Join(dbContext.FirstTable,
                s => s.FtableId,
                f => f.Id,
                (s, f) => new JoinedTables()
                {
                    Id = s.Id,
                    FtableId = s.FtableId,
                    LastName = s.LastName,
                    SomeDate = s.SomeDate,
                    SecondFloatNumber = s.SecondFloatNumber,
                    Checker = s.Checker,
                    Access = f.Access,
                    FirstName = f.FirstName,
                    TableDate = f.TableDate,
                    SomeFloatNumber = f.SomeFloatNumber,
                    SomeIntNumber = f.SomeIntNumber
                }).ToList();
            IEnumerable<JoinedTables> result = new List<JoinedTables>();
            if (filterModel.Id != null)
            {
                result = joinedTables.Where(s => filterModel.Id.Contains(s.Id)).ToList();
            }
            if (filterModel.FtableId != null)
            {
                result = joinedTables.Where(s => filterModel.FtableId.Contains(s.FtableId)).ToList();
            }
            if (filterModel.Access != null)
            {
                result = joinedTables.Where(s => filterModel.Access.Contains(s.Access)).ToList();
            }
            if (filterModel.Checker != null)
            {
                result = joinedTables.Where(s => filterModel.Checker.Contains(s.Checker)).ToList();
            }
            if (filterModel.FirstName != null)
            {
                result = joinedTables.Where(s => filterModel.FirstName.Contains(s.FirstName)).ToList();
            }
            if (filterModel.LastName != null)
            {
                result = joinedTables.Where(s => filterModel.LastName.Contains(s.LastName)).ToList();
            }
            if (filterModel.SecondFloatNumber != null)
            {
                result = joinedTables.Where(s => filterModel.SecondFloatNumber.Contains(s.SecondFloatNumber)).ToList();
            }
            if (filterModel.SomeDate != null)
            {
                result = joinedTables.Where(s => filterModel.SomeDate.Contains(s.SomeDate)).ToList();
            }
            if (filterModel.SomeFloatNumber != null)
            {
                result = joinedTables.Where(s => filterModel.SomeFloatNumber.Contains(s.SomeFloatNumber)).ToList();
            }
            if (filterModel.SomeIntNumber != null)
            {
                result = joinedTables.Where(s => filterModel.SomeIntNumber.Contains(s.SomeIntNumber)).ToList();
            }
            if (filterModel.TableDate != null)
            {
                result = joinedTables.Where(s => filterModel.TableDate.Contains(s.TableDate)).ToList();
            }
            return result.ToList();
        }
    }
}