using System;

namespace WebApplicationDal
{
    public class JoinedTables
    {
        public int Id { get; set; }
        public int? FtableId { get; set; }
        public string LastName { get; set; }
        public DateTime? SomeDate { get; set; }
        public double? SecondFloatNumber { get; set; }
        public bool? Checker { get; set; }
        public bool? Access { get; set; }
        public string FirstName { get; set; }
        public DateTime? TableDate { get; set; }
        public double? SomeFloatNumber { get; set; }
        public int? SomeIntNumber { get; set; }
    }
}