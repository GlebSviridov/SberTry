using System;
using WebApplicationDal;

namespace WebApplicationBll.DTO
{
    public class MergedTablesDTO
    {
        public MergedTablesDTO(JoinedTables joinedTables)
        {
            Id = joinedTables.Id;
            FtableId = joinedTables.FtableId;
            LastName = joinedTables.LastName;
            SomeDate = joinedTables.SomeDate;
            SecondFloatNumber = joinedTables.SecondFloatNumber;
            Checker = joinedTables.Checker;
            Access = joinedTables.Access;
            FirstName = joinedTables.FirstName;
            TableDate = joinedTables.TableDate;
            SomeFloatNumber = joinedTables.SomeFloatNumber;
            SomeIntNumber = joinedTables.SomeIntNumber;
        }

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