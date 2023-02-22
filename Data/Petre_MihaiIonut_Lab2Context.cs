using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Petre_MihaiIonut_Lab2.Models;

namespace Petre_MihaiIonut_Lab2.Data
{
    public class Petre_MihaiIonut_Lab2Context : DbContext
    {
        public Petre_MihaiIonut_Lab2Context (DbContextOptions<Petre_MihaiIonut_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Petre_MihaiIonut_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Petre_MihaiIonut_Lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Petre_MihaiIonut_Lab2.Models.Category> Category { get; set; }
       
    }
}
