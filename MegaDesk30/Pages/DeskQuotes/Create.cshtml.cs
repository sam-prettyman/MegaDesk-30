using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MegaDesk30.Models;
using Microsoft.EntityFrameworkCore;

namespace MegaDesk30.Pages.DeskQuotes
{
    public class CreateModel : PageModel
    {
        private readonly MegaDesk30.Models.MegaDesk30Context _context;

        [BindProperty]
        public DeskQuote DeskQuote { get; set; }
        public Desk Desk { get; set; }
        public Delivery Delivery { get; set; }
        public Material Material { get; set; }
        public SelectList Materials { get; set; }
        [BindProperty(SupportsGet = true)]
        public string DeskMaterial { get; set; }
        public CreateModel(MegaDesk30.Models.MegaDesk30Context context)
        {
            _context = context;
            IQueryable<string> matQuery = from m in _context.Material_1
                                          orderby m.MaterialType
                                          select m.MaterialType;

            Materials = new SelectList(matQuery.Distinct().ToList());
        }
        public IActionResult OnGet()
        {
            return Page();
        }
     
      
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }


            
            _context.DeskQuote.Add(DeskQuote);
            await _context.SaveChangesAsync();
            return RedirectToPage("./Index");
        }
    }
}