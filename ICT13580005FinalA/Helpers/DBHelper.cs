using System;
using System.Collections.Generic;
using System.Linq;
using ICT13580005FinalA.Models;
using SQLite;
namespace ICT13580005FinalA.Helpers
{
    public class DBHelper
    {
        SQLiteConnection db;

        public DBHelper(string dbPath)
        {
            db = new SQLiteConnection(dbPath);
            db.CreateTable<Employee>();
        }

        public int AddEmployee(Employee employee)
        {
            db.Insert(employee);
            return employee.Id;
        }

        public List<Employee> GetEmployee()
        {
            return db.Table<Employee>().ToList();
        }
        public int UpdateEmployee(Employee employee)
        {
            return db.Update(employee);
        }
        public int DeleteEmployee(Employee employee)
        {
            return db.Delete(employee);
        }
    }
}
