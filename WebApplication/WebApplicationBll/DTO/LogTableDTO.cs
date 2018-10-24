using System;

namespace WebApplicationBll.DTO
{
    public class LogTableDTO
    {
        public int Id { get; set; }
        public string FilterName { get; set; }
        public DateTime? WhenItUse { get; set; }
    }
}