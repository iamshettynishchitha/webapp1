using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectDemo.Models;

namespace ProjectDemo.Data
{
    public class ProjectDemoContext : DbContext
    {
        public ProjectDemoContext (DbContextOptions<ProjectDemoContext> options)
            : base(options)
        {
        }

        public DbSet<ProjectDemo.Models.Movie> Movie { get; set; }
    }
}
