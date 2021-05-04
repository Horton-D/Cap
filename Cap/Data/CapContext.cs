using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cap.Models.Model;

namespace Cap.Data
{
    public class CapContext : DbContext
    {
        public CapContext (DbContextOptions<CapContext> options)
            : base(options)
        {
        }

        public DbSet<Cap.Models.Model.Task> Task { get; set; }
    }
}
