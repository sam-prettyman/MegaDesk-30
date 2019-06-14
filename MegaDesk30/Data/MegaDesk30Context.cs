using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MegaDesk30.Models;

namespace MegaDesk30.Models
{
    public class MegaDesk30Context : DbContext
    {
        public MegaDesk30Context (DbContextOptions<MegaDesk30Context> options)
            : base(options)
        {
        }

        public DbSet<MegaDesk30.Models.Desk> Desk { get; set; }

        public DbSet<MegaDesk30.Models.DeskQuote> DeskQuote { get; set; }
        public object Material { get; internal set; }
        public DbSet<MegaDesk30.Models.Delivery> Delivery { get; set; }
        public DbSet<MegaDesk30.Models.Material> Material_1 { get; set; }
    }
}
