using System.Collections.Generic;
using System.Text;
using System.Xml;
using WebApplicationBll.DTO;
using WebApplicationDal;
using WebApplicationDal.Interfaces;
using WebApplicationBll.Infrastructure;
using WebApplicationBll.Interfaces;
using WebApplicationDal.Entities;

namespace WebApplicationBll.Services
{
    public class DataService : IDataService
    {
        private readonly IRepository<FirstTable> repositoryFirstTable;
        private readonly IRepository<SecondTable> repositorySecondTable;
        private readonly IRepository<JoinedTables> repositoryJoinedTables;
        private readonly IRepository<LogTable> repositoryLogTable;

        public DataService()
        {
            repositoryJoinedTables = ServiceModule.JoinedTables;
            repositoryLogTable = ServiceModule.LogTable;
            // repositoryFirstTable = ServiceModule.FirstTable;
            // repositorySecondTable = ServiceModule.SecondTable;

        }

        public IEnumerable<MergedTablesDTO> GetAll()
        {
            var joinedTables = repositoryJoinedTables.GetAll();
            var mergedList = new List<MergedTablesDTO>();
            foreach (var j in joinedTables)
            {
                mergedList.Add(new MergedTablesDTO(j));
            }

            return mergedList;
        }
        public IEnumerable<MergedTablesDTO> GetFiltered(FilteredModel model)
        {
            var filterModel = new Filter(model.Id, model.FtableId, model.LastName, model.SomeDate,
                model.SecondFloatNumber, model.Checker, model.Access, model.FirstName, model.TableDate,
                model.SomeFloatNumber, model.SomeIntNumber);
            
            var joinedTables = repositoryJoinedTables.GetFiltered(filterModel);
            var mergedList = new List<MergedTablesDTO>();
            foreach (var j in joinedTables)
            {
                mergedList.Add(new MergedTablesDTO(j));
            }

            return mergedList;
        }

        public void AddLog(LogTableDTO logTable)
        {
            repositoryLogTable.AddLog(new LogTable(logTable.Id, logTable.FilterName, logTable.WhenItUse));
        }

        public void Report(IEnumerable<MergedTablesDTO> result)
        {
            
            using (XmlTextWriter xmlWriter = new XmlTextWriter("C:\\Users\\Gleb\\Documents\\GlebSviridov\\SberTry\\SberTry\\WebApplication\\WebApplication.sln\\Report.xml", Encoding.UTF8))
            {
                xmlWriter.WriteStartElement("List");
                foreach (var l in result)
                {
                    xmlWriter.WriteElementString("Id", l.Id.ToString());
                    xmlWriter.WriteElementString("FtableId", l.FtableId.ToString());
                    xmlWriter.WriteElementString("LastName", l.LastName);
                    xmlWriter.WriteElementString("SomeDate", l.SomeDate.ToString());
                    xmlWriter.WriteElementString("SecondFloatNumber", l.SecondFloatNumber.ToString());
                    xmlWriter.WriteElementString("Checker", l.Checker.ToString());
                    xmlWriter.WriteElementString("Access", l.Access.ToString());
                    xmlWriter.WriteElementString("FirstName", l.FirstName);
                    xmlWriter.WriteElementString("TableDate", l.TableDate.ToString());
                    xmlWriter.WriteElementString("SomeFloatNumber", l.SomeFloatNumber.ToString());
                    xmlWriter.WriteElementString("SomeIntNumber", l.SomeIntNumber.ToString());

                    xmlWriter.Flush();
                }
                xmlWriter.WriteEndElement();


            }
        }
    }
}