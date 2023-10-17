using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using azure_learning_biginner;
using azure_learning_biginner.Model;

namespace azure_learning_biginner.Pages.Persons
{
    public class IndexModel : PageModel
    {
        private readonly azure_learning_biginner.AppDbContext _context;

        public IndexModel(azure_learning_biginner.AppDbContext context)
        {
            _context = context;
        }

        public IList<Person> Person { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Person = await _context.Persons.ToListAsync();
        }
    }
}
