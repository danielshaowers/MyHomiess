using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyHomies.Data;
using MyHomies.Models;

namespace MyHomies
{
    public class IndexModel : PageModel
    {
        private readonly MyHomies.Data.MyHomiesContext _context;

        public IndexModel(MyHomies.Data.MyHomiesContext context)
        {
            _context = context;
        }

        public IList<Item> Item { get;set; }

        public async Task OnGetAsync()
        {
            Item = await _context.Item.ToListAsync();
        }
    }
}
