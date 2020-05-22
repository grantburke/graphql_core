using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using graphql_core.Data;
using graphql_core.Data.Models;

namespace graphql_core.Service
{
    public interface IQuoteService
    {
        IEnumerable<Quote> GetAll();
        Quote GetById(int id);
        void Create(Quote quote);
        void Update(Quote quote);
        void Delete(int id);
    }

    public class QuoteService : IQuoteService
    {
        private readonly QuotesContext _db;

        public QuoteService(QuotesContext db)
        {
            _db = db;
        }
        public IEnumerable<Quote> GetAll()
        {
            return _db.Quotes;
        }

        public Quote GetById(int id)
        {
            return _db.Quotes.FirstOrDefault(f => f.Id == id);
        }

        public void Create(Quote quote)
        {
            _db.Quotes.Add(quote);
            _db.SaveChanges();
        }

        public void Update(Quote quote)
        {
            _db.Quotes.Update(quote);
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            var quote = _db.Quotes.FirstOrDefault(f => f.Id == id);
            if (quote == null)
                return;
            _db.Quotes.Remove(quote);
        }
    }
}