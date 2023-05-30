using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Machine_arts.Models;

namespace Machine_arts.Data
{
    public class MachineArtsContext : DbContext
    {
        public MachineArtsContext (DbContextOptions<MachineArtsContext> options)
            : base(options)
        {
        }

        public DbSet<UserLogin> UserLogin { get; set; } = default!;
        public DbSet<User> User { get; set; } = default!;
        public DbSet<GradevinskiStroj> GradevinskiStroj { get; set; } = default!;
        public DbSet<Bager> Bager { get; set; } = default!;
        public DbSet<Buldozer> Buldozer { get; set; } = default!;
        public DbSet<Demper> Demper { get; set; } = default!;
        public DbSet<Kiper> Kiper { get; set; } = default!;
        public DbSet<Kombinirka> Kombinirka { get; set; } = default!;
        public DbSet<KranDizalica> KranDizalica { get; set; } = default!;
        public DbSet<Mikser> Mikser { get; set; } = default!;
        public DbSet<Tegljac> Tegljac { get; set; } = default!;
        public DbSet<Utovarivac> Utovarivac { get; set; } = default!;
        public DbSet<Valjak> Valjak { get; set; } = default!;
        public DbSet<GradevinskoVozilo> GradevinskoVozilo { get; set; } = default!;
    }
}