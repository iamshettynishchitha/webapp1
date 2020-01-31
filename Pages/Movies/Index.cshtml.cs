using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjectDemo.Data;
using ProjectDemo.Models;

namespace ProjectDemo
{
    public class IndexModel : PageModel
    {
        private readonly ProjectDemo.Data.ProjectDemoContext _context;

        public IndexModel(ProjectDemo.Data.ProjectDemoContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
