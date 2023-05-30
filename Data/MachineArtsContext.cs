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

        public DbSet<Machine_arts.Models.UserLogin> UserLogin { get; set; } = default!;
    }
}