using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FinalCodebase.Models;

namespace FinalCodebase.Data
{
    public class FinalCodebaseContext : DbContext
    {
        public FinalCodebaseContext (DbContextOptions<FinalCodebaseContext> options)
            : base(options)
        {
        }

        public DbSet<FinalCodebase.Models.Employee> Employee { get; set; }
    }
}
