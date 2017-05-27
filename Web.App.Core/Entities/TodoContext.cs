using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Web.App.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Web.App.Core.Entities
{
    public class TodoContext : DbContext
    {

       public TodoContext(DbContextOptions<TodoContext> options)
           : base(options)
        {
           Database.Migrate();
        }

       
        public DbSet<Todo> Todos { get; set; }
      
    }
}
