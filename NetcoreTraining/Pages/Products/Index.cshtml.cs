using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NetcoreTraining.Data;
using NetcoreTraining.Models;

namespace NetcoreTraining.Views.Products
{
	public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Product> Products;

        public async Task OnGet()
        {
            Products = await _db.Products.ToListAsync();
        }

        
    }
}
