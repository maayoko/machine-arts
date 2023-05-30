using Microsoft.EntityFrameworkCore;
using Machine_arts.Data;
using Machine_arts.Models;

namespace Machine_arts.Seed;

public static class SeedGradevinskiStrojevi
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
            if (context.GradevinskiStroj.Any())
            {
                return;   // DB has been seeded
            }

            context.GradevinskiStroj.AddRange(
                new GradevinskiStroj
                {
                    Ime = "Bomag BW 213 DH-5",
                    Slika = "https://machineryline.hr/img/s/gradevinski-strojevi-kompaktor-s-jednim-valjkom-BOMAG-BW213DH-5---1684322358283797469_big--23051714191390200600.jpg",
                    Cijena = "78.500",
                    Specifikacije = @"Tip valjka: Tandemski valjak s vibracijom|_x000d_
                                      Operativna težina: 12.600 kg|_x000d_
                                      Snaga motora: 115 kW|_x000d_
                                      Kapacitet valjka: 213 cm|_x000d_
                                      Maksimalna brzina: 12 km/h|_x000d_
                                      Vibracijske frekvencije: 30/35 Hz|_x000d_
                                      Amplituda vibracija: 1,8/0,9 mm|_x000d_
                                      Dimenzije (DxŠxV): 5.505 mm x 2.260 mm x 2.950 mm"
                },

                new GradevinskiStroj
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
                }
            );
            context.SaveChanges();
        }
    }
}