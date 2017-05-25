using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Web.App.Core.Controllers
{
    [Route("api/todos")]
    public class TodoController: Controller
    {
        [HttpGet()]
        public IActionResult GetTodos()
        {
            return Ok(TodoDataStore.Current.Todos);
        }


        [HttpGet("{id}")]
        public IActionResult GetTodo(int id)
        {
            var todo = TodoDataStore.Current.Todos.FirstOrDefault(t => t.Id == id);
            if (todo == null)
                return NotFound();
            return Ok(todo);
        }

    }
}
