using System;
using System.Collections.Generic;
using System.Text;

namespace WebApplicationDal.Entities
{
    public class Filter
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

        public Filter(List<int> id, List<int?> ftableId, List<string> lastName, List<DateTime?> someDate, List<double?> secondFloatNumber, List<bool?> checker, List<bool?> access, List<string> firstName, List<DateTime?> tableDate, List<double?> someFloatNumber, List<int?> someIntNumber)
        {
            Id = id;
            FtableId = ftableId;
            LastName = lastName;
            SomeDate = someDate;
            SecondFloatNumber = secondFloatNumber;
            Checker = checker;
            Access = access;
            FirstName = firstName;
            TableDate = tableDate;
            SomeFloatNumber = someFloatNumber;
            SomeIntNumber = someIntNumber;
        }
    }
}
