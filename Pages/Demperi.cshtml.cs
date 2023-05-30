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
    public class DemperiModel : PageModel
    {
        public List<Demper> Demperi { get; set; }

        private readonly Machine_arts.Data.MachineArtsContext _context;

        public DemperiModel(Machine_arts.Data.MachineArtsContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            var demperi = from g in _context.Demper select g;
            Demperi = demperi.ToList();
        }
    }
}
