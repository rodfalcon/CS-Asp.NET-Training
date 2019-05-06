using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _db;

        public IndexModel(AppDbContext db) { _db = db; }

        public IList<Cliente> Clientes { private set; get; }

        public async Task OnGetAsync()
        {
            Clientes = await _db.Clientes.AsNoTracking().ToListAsync();
        }
    }
}
