using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.App.Core.Entities;

namespace CityInfo.API.Controllers
{
    public class DummyController : Controller
    {
        private TodoContext _ctx;

        public DummyController(TodoContext ctx)
        {
            _ctx = ctx;
        }

        [HttpGet]
        [Route("api/testdatabase")]
        public IActionResult TestDatabase()
        {
            return Ok();
        }
    }
}
