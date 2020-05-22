using System.Collections;
using System.Collections.Generic;
using graphql_core.Data;
using graphql_core.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace graphql_core.Service
{
    public interface IEmployeeService : IBaseService<Employee>
    {
        IEnumerable<Employee> GetAllWithQuotes();
    }

    public class EmployeeService : BaseService<Employee>, IEmployeeService
    {
        private readonly QuotesContext _db;
        
        public EmployeeService(QuotesContext db) : base(db)
        {
            _db = db;
        }
        
        public IEnumerable<Employee> GetAllWithQuotes()
        {
            return _db.Employees
                .Include(i => i.Quotes);
        }
    }
}