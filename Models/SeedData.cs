using Microsoft.EntityFrameworkCore;
using Machine_arts.Data;

namespace Machine_arts.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MachineArtsContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MachineArtsContext>>()))
        {
            if (context == null || context.User == null)
            {
                throw new ArgumentNullException("Null MachineArtsContext");
            }

            // Look for any movies.
            if (context.User.Any())
            {
                return;   // DB has been seeded
            }

            context.User.AddRange(
                new User
                {
                    Username = "emi",
                    Email = "emi@gmail.com",
                    Password = "emi"
                },

                new User
                {
                     Username = "pero",
                    Email = "pero@gmail.com",
                    Password = "pero"
                }
            );
            context.SaveChanges();
        }
    }
}