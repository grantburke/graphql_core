using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using graphql_core.Data.Models;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

namespace graphql_core.Data
{
    public static class Seed
    {
        public static void InitializeDate(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetRequiredService<QuotesContext>();

            context.Database.EnsureCreated();

            if (!context.Employees.Any())
            {
                context.Employees.Add(new Employee
                {
                    Id = 0,
                    FirstName = "Unknown",
                    LastName = ""
                });
                context.SaveChanges();
            }

            if (!context.Quotes.Any())
            {
                using (StreamReader r = new StreamReader("../graphql_core.Data/quotes.json"))
                {
                    string json = r.ReadToEnd();
                    List<Quote> quotes = JsonConvert.DeserializeObject<List<Quote>>(json);
                    context.Quotes.AddRange(quotes);
                    context.SaveChanges();
                }
            }
        }
    }
}