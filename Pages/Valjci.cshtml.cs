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
    public class ValjciModel : PageModel
    {
        public List<Valjak> Valjci { get; set; }

        private readonly Machine_arts.Data.MachineArtsContext _context;

        public ValjciModel(Machine_arts.Data.MachineArtsContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            var valjci = from g in _context.Valjak select g;
            Valjci = valjci.ToList();
        }
    }
}
