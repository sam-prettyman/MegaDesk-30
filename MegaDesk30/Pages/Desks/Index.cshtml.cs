using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDesk30.Models;

namespace MegaDesk30.Pages.Desks
{
    public class IndexModel : PageModel
    {
        private readonly MegaDesk30.Models.MegaDesk30Context _context;

        public IndexModel(MegaDesk30.Models.MegaDesk30Context context)
        {
            _context = context;
        }

        public IList<Desk> Desk { get;set; }

        public async Task OnGetAsync()
        {
            Desk = await _context.Desk.ToListAsync();
        }
    }
}
