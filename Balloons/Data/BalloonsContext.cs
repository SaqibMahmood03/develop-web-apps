using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Balloons.Models;

namespace Balloons.Data
{
    public class BalloonsContext : DbContext
    {
        public BalloonsContext (DbContextOptions<BalloonsContext> options)
            : base(options)
        {
        }

        public DbSet<Balloons.Models.Balloon> Balloon { get; set; }
    }
}
