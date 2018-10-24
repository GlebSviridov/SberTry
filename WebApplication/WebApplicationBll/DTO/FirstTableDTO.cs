using System;

namespace WebApplicationBll.DTO
{
    public class FirstTableDTO
    {
        public int Id { get; set; }
        public bool? Access { get; set; }
        public string FirstName { get; set; }
        public DateTime? TableDate { get; set; }
        public double? SomeFloatNumber { get; set; }
        public int? SomeIntNumber { get; set; }
    }
}