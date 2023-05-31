using Microsoft.EntityFrameworkCore;
using Machine_arts.Data;
using Machine_arts.Models;

namespace Machine_arts.Seed;

public static class SeedTegljaci
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MachineArtsContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MachineArtsContext>>()))
        {
            if (context == null || context.GradevinskiStroj == null)
            {
                throw new ArgumentNullException("Null MachineArtsContext");
            }

            // Look for any movies.
            if (context.Tegljac.Any())
            {
                return;   // DB has been seeded
            }

            context.Tegljac.AddRange(
                new Tegljac
                {
                    Ime = "HYUNDAI R210LC-9",
                    Slika = "https://machineryline.hr/img/s/gradevinski-strojevi-bager-gusjenicar-HYUNDAI-R210-LC-9-med-tiltrotator---1684784142800187540_big--23052222352195417300.jpg",
                    Cijena = "29.500",
                    Specifikacije = @"Težina : 21.200 kg|_x000d_
                                      Transportna duljina: 9.495 mm|_x000d_
                                      Transportna širina: 2.990 mm|_x000d_
                                      Kapacitet žlice: 0,8 - 1,0 m³|_x000d_
                                      Tip motora: Cummins B5.9-C|_x000d_
                                      Snaga motora: 116 kW (156 KS)"
                },

                new Tegljac
                {
                    Ime = "VOLVO EC220EL",
                    Slika = "https://machineryline.hr/img/s/gradevinski-strojevi-bager-gusjenicar-VOLVO-EC220EL-med-flera-redskap---1684956544296390089_big--23052422283752813500.jpg",
                    Cijena = "29.500",
                    Specifikacije = @"Težina: 22.800 kg|_x000d_
                                      Transportna duljina: 9.650 mm|_x000d_
                                      Transportna širina: 2.990 mm|_x000d_
                                      Kapacitet žlice: 0,6 - 1,3 m³|_x000d_
                                      Tip motora: Volvo D6J|_x000d_
                                      Snaga motora: 129 kW (173 KS)"
                }
            );
            context.SaveChanges();
        }
    }
}