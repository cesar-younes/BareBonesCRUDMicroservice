using BareBonesCRUDMicroservice.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BareBonesCRUDMicroservice.Data
{
    public class BareBonesCRUDContext : DbContext
    {
        //NOTE: Constructor that passes options to base DbContext is mandatory
        public BareBonesCRUDContext(DbContextOptions<BareBonesCRUDContext> options) : base(options)
        {

        }

        public DbSet<BareBonesCRUDItem> BareBonesCRUDItems { get; set; }
        public DbSet<SubBareBonesCRUDItem> SubBareBonesCRUDItems { get; set; }
    }
}
