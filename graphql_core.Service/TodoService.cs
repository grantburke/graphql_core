using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using graphql_core.Data;
using graphql_core.Data.Models;

namespace graphql_core.Service
{
    public interface ITodoService
    {
        IEnumerable<Todo> GetAll();
        Todo GetById(int id);
        void Create(Todo todo);
        void Update(Todo todo);
        void Delete(int id);
    }

    public class TodoService : ITodoService
    {
        private readonly TodoContext _db;

        public TodoService(TodoContext db)
        {
            _db = db;
        }
        public IEnumerable<Todo> GetAll()
        {
            return _db.Todos;
        }

        public Todo GetById(int id)
        {
            return _db.Todos.FirstOrDefault(f => f.Id == id);
        }

        public void Create(Todo todo)
        {
            _db.Todos.Add(todo);
            _db.SaveChanges();
        }

        public void Update(Todo todo)
        {
            _db.Todos.Update(todo);
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            var todo = _db.Todos.FirstOrDefault(f => f.Id == id);
            if (todo == null)
                return;
            _db.Todos.Remove(todo);
        }
    }
}