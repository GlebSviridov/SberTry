using System.Collections.Generic;
using WebApplicationBll.DTO;

namespace WebApplicationBll.Interfaces
{
    public interface IDataService
    {
        IEnumerable<MergedTablesDTO> GetAll();
        IEnumerable<MergedTablesDTO> GetFiltered(FilteredModel model);
        void AddLog(LogTableDTO logTable);
        void Report(IEnumerable<MergedTablesDTO> result);
    }
}