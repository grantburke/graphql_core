using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using graphql_core.Data;
using graphql_core.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace graphql_core.Service
{
    public interface IQuoteService : IBaseService<Quote>
    {
        IEnumerable<Quote> GetAllWithEmployees();
    }

    public class QuoteService : BaseService<Quote>, IQuoteService
    {
        private readonly QuotesContext _db;

        public QuoteService(QuotesContext db) : base(db)
        {
            _db = db;
        }
        public IEnumerable<Quote> GetAllWithEmployees()
        {
            return _db.Quotes
                .Include(i => i.Employee);
        }
    }
}