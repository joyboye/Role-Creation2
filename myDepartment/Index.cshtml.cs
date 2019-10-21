using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NewApp1.Data;

namespace NewApp1.Pages.myDepartment
{
    public class IndexModel : PageModel
    {
        private readonly NewApp1.Data.ApplicationDbContext _context;

        public IndexModel(NewApp1.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Departments> Departments { get;set; }

        public async Task OnGetAsync()
        {
            Departments = await _context.Departments.ToListAsync();
        }
    }
}
