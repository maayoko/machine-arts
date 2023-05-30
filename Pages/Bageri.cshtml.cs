using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Data.OleDb;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using Machine_arts.UtilitiesHelpers;
using Machine_arts.Models;

namespace Machine_arts.Pages
{
    public class BageriModel : PageModel
    {
        private readonly Machine_arts.Data.MachineArtsContext _context;
        
        public List<Bager> Bageri { get; set; }

        public BageriModel(Machine_arts.Data.MachineArtsContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            var bageri = from g in _context.Bager select g;
            Bageri = bageri.ToList();
        }
    }
}
