using System;
using System.Collections.Generic;

namespace WebApplicationDal
{
    public partial class FirstTable
    {
        public FirstTable()
        {
            SecondTable = new HashSet<SecondTable>();
        }

        public int Id { get; set; }
        public bool? Access { get; set; }
        public string FirstName { get; set; }
        public DateTime? TableDate { get; set; }
        public double? SomeFloatNumber { get; set; }
        public int? SomeIntNumber { get; set; }

        public ICollection<SecondTable> SecondTable { get; set; }
    }
}
