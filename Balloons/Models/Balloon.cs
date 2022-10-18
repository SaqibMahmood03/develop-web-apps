using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Balloons.Models
{
    public class Balloon
    {
        public int Id { get; set; }
        [Display (Name ="Balloon Name")]
        public string Name { get; set; }

        public string Color { get; set; }
        public decimal Price { get; set; }

        public int Size { get; set; }
    }
}
