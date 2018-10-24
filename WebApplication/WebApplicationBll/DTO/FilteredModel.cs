using System;
using System.Collections.Generic;

namespace WebApplicationBll.DTO
{
    public class FilteredModel
    {
        public List<int> Id { get; set; }
        public List<int?> FtableId { get; set; }
        public List<string> LastName { get; set; }
        public List<DateTime?> SomeDate { get; set; }
        public List<double?> SecondFloatNumber { get; set; }
        public List<bool?> Checker { get; set; }
        public List<bool?> Access { get; set; }
        public List<string> FirstName { get; set; }
        public List<DateTime?> TableDate { get; set; }
        public List<double?> SomeFloatNumber { get; set; }
        public List<int?> SomeIntNumber { get; set; }
    }
}