using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.App.Core.Entities;

namespace Web.App.Core
{
    public static class TodoExtensions
    {
        public static void EnsureSeedDataForContext(this TodoContext context)
        {
            if (context.Todos.Any())
            {
                return;
            }


            var todos = new List<Todo>()
            {
                new Todo() {Title = "Task 1", Complete = true},
                new Todo() {Title = "Task 2", Complete = true},
                new Todo() {Title = "Task 3", Complete = true}
            };

            context.Todos.AddRange(todos);
            context.SaveChanges();

        }
            
    }

}




