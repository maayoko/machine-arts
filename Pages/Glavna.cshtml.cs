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
    public class GlavnaModel : PageModel
    {
        private readonly Machine_arts.Data.MachineArtsContext _context;

        public List<GradevinskiStroj> GradevinskiStrojevi { get; set; }

        public GlavnaModel(Machine_arts.Data.MachineArtsContext context)
        {
            _context = context;
        }


        public async Task OnGetAsync()
        {

            var gradevinskiStrojevi = from g in _context.GradevinskiStroj select g;
            GradevinskiStrojevi = gradevinskiStrojevi.ToList();
        }
    }
}
