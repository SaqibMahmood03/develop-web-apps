using System;
using Microsoft.EntityFrameworkCore;
using Balloons.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Balloons.Data
{
    public class MvcBalloonContext : DbContext
    {
        public MvcBalloonContext(DbContextOptions<MvcBalloonContext> options)
            : base(options)
        {
        }

        public DbSet<Balloon> Balloon { get; set; }
    }
}