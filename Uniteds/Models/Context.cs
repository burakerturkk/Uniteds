using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Uniteds.Models
{
    public class Context : DbContext
    {
       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = DESKTOP-J9F7GS9\\MSSQLSERVER02; database=Uniteds; integrated security = true");
        }

      public  DbSet<Note> Notes { get; set; }
      public  DbSet<SubNote> SubNotes { get; set; }
  
    }
}
