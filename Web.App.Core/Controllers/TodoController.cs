using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.App.Core.Services;

using AutoMapper;
using Web.App.Core.Models;

namespace Web.App.Core.Controllers
{
    [Route("api/todos")]
    public class TodoController: Controller
    {

        private ITodoRepository _todoRepository;

        public TodoController(ITodoRepository todoRepository)
        {
            _todoRepository = todoRepository;
        }


        [HttpGet()]
        public IActionResult GetTodos()
        {
            var todos = _todoRepository.GetTodos();
            var results = Mapper.Map<IEnumerable<TodoDTO>>(todos);
            return Ok(results);
        }


        [HttpGet("{id}",Name = "GetTodo")]
        public IActionResult GetTodo(int id)
        {
            var todo = _todoRepository.GetTodo(id);
            if (todo == null)
                return NotFound();
            var todoResult = Mapper.Map<TodoDTO>(todo);
            return Ok(todoResult);
        }

        [HttpPost("createtodo")]
        public IActionResult CreateTodo([FromBody] TodoDTO newTodo)
        {
            var todoEntity= Mapper.Map<Entities.Todo>(newTodo);
            _todoRepository.AddTodo(todoEntity);
            if (!_todoRepository.Save())
            {
                return StatusCode(500, "A problem happened while handling your request.");
            }
            var savedTodo = Mapper.Map<Models.TodoDTO>(todoEntity);

            return CreatedAtRoute("GetTodo", new { id = savedTodo.Id }, savedTodo);
        }
    }
}
