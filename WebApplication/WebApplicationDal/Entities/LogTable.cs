using System;
using System.Collections.Generic;
using System.Text;

namespace WebApplicationDal.Entities
{
    public class LogTable
    {
        public int Id { get; set; }
        public string FilterName { get; set; }
        public DateTime? WhenItUse { get; set; }

        public LogTable(int id, string filterName, DateTime? whenItUse)
        {
            Id = id;
            FilterName = filterName;
            WhenItUse = whenItUse;
        }
    }
}
