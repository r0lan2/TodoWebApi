using Web.App.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.App.Core.Models;

namespace Web.App.Core.Services
{
    public interface ITodoRepository
    {
        bool TodoExists(int todoId);
        IEnumerable<Todo> GetTodos();
        Todo GetTodo(int todoId);
        void AddTodo(Todo newTodo);
        void DeletePointOfInterest(Todo pointOfInterest);
        bool Save();
    }
}
