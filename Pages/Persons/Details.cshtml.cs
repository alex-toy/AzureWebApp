﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AzureWebApp.Data;
using AzureWebApp.Entities;

namespace AzureWebApp.Pages.Persons
{
    public class DetailsModel : PageModel
    {
        private readonly AzureWebApp.Data.AppDbContext _context;

        public DetailsModel(AzureWebApp.Data.AppDbContext context)
        {
            _context = context;
        }

      public Person Person { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Persons == null)
            {
                return NotFound();
            }

            var person = await _context.Persons.FirstOrDefaultAsync(m => m.Id == id);
            if (person == null)
            {
                return NotFound();
            }
            else 
            {
                Person = person;
            }
            return Page();
        }
    }
}
