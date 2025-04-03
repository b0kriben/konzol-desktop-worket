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
            return _context.Workers.Count();
        }
    }
}
