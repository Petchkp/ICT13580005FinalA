using System;
using SQLite;
namespace ICT13580005FinalA.Models
{
    public class Employee
    {
        [PrimaryKey, AutoIncrement]
        public int Id{get;set;}

        [NotNull]
        [MaxLength(200)]
        public string Name{get;set;}

		[NotNull]
		[MaxLength(200)]
        public string Lastname{get;set;}

		[NotNull]
		[MaxLength(2)]
        public string Age{get;set;}

		[NotNull]
		[MaxLength(100)]
        public string Departmant{get;set;}

		[NotNull]
		[MaxLength(11)]
        public string Phone{get;set;}

		[NotNull]
		[MaxLength(100)]
        public string Mail{get;set;}

		[NotNull]
		[MaxLength(500)]
        public string Address{get;set;}

        public string Marry
        {
            get;
            set;
        }
        public string Child
        {
            get;
            set;
        }
        public string saraly
        {
            get;
            set;
        }
    }
}
