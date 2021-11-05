using MVCClinica.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCClinica.Data
{
    public class MedicoDbContext : DbContext
    {
        public DbSet<Medico> Medicos { get; set; }

        public MedicoDbContext() : base("KeyDB") { }
    }
}