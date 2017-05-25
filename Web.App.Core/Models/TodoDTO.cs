using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.App.Core.Models
{
    public class TodoDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool Complete { get; set; }
    }
}
