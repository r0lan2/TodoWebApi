using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.App.Core.Models;

namespace Web.App.Core
{
    public class TodoDataStore
    {
        public static TodoDataStore Current { get; } = new TodoDataStore();
        public List<TodoDTO> Todos { get; set; }

        public TodoDataStore()
        {
            Todos = new List<TodoDTO>()
            {
                new TodoDTO() {Id = 1, Title = "Task 1", Complete = true},
                new TodoDTO() {Id = 2, Title = "Task 2", Complete = true},
                new TodoDTO() {Id = 3, Title = "Task 3", Complete = true}
            };
        }
    }
}
