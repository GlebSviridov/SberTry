using System;
using System.Collections.Generic;

namespace WebApplicationDal
{
    public partial class SecondTable
    {
        public int Id { get; set; }
        public int? FtableId { get; set; }
        public string LastName { get; set; }
        public DateTime? SomeDate { get; set; }
        public double? SecondFloatNumber { get; set; }
        public bool? Checker { get; set; }

        public FirstTable Ftable { get; set; }
    }
}
