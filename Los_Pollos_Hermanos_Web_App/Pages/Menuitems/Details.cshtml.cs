﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Los_Pollos_Hermanos_Web_App.Data;
using Los_Pollos_Hermanos_Web_App.Models;

namespace Los_Pollos_Hermanos_Web_App.Pages.Menuitems
{
    public class DetailsModel : PageModel
    {
        private readonly Los_Pollos_Hermanos_Web_App.Data.ResturantContext _context;

        public DetailsModel(Los_Pollos_Hermanos_Web_App.Data.ResturantContext context)
        {
            _context = context;
        }

      public MenuItem MenuItem { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.MenuItem == null)
            {
                return NotFound();
            }

            var menuitem = await _context.MenuItem.FirstOrDefaultAsync(m => m.MenuItemID == id);
            if (menuitem == null)
            {
                return NotFound();
            }
            else 
            {
                MenuItem = menuitem;
            }
            return Page();
        }
    }
}
