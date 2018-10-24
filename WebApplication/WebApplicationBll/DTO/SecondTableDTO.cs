using System;
using WebApplicationDal;

namespace WebApplicationBll.DTO
{
    public class SecondTableDTO
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