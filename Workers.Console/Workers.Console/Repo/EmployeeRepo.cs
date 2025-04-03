using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workers.Console.Models;

namespace Workers.Console.Repo
{
    public class EmployeeRepo
    {
        private readonly DatabaseContext _context = new();

        public int GetNumberOfEmployees()
        {
            return _context.Manyworkers.Count();
        }
        public int GetEmployeeCount()
        {
            return _context.Manyworkers.Count();
        }

        public int GetPaidEmployeeCount()
        {
            return _context.Manyworkers.Count(e => e.Salary > 0);
        }

        public int GetUnpaidEmployeeCount()
        {
            return GetEmployeeCount() - GetPaidEmployeeCount();
        }

        public string GetHighestSalaryEmployee()
        {
            return _context.Manyworkers.OrderByDescending(e => e.Salary).FirstOrDefault();
        }

        public Employee GetLowestSalaryEmployee()
        {
            return _context.Manyworkers.OrderBy(e => e.Salary).FirstOrDefault();
        }

        public decimal GetAverageSalary()
        {
            return _context.Manyworkers.Average(e => e.Salary);
        }




        
    }
}
