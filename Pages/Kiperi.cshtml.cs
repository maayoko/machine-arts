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
    public class KiperiModel : PageModel
    {
        public List<Kiper> Kiperi { get; set; }

         private readonly Machine_arts.Data.MachineArtsContext _context;

        public KiperiModel(Machine_arts.Data.MachineArtsContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            var kiperi = from g in _context.Kiper select g;
            Kiperi = kiperi.ToList();
        }
    }
}
