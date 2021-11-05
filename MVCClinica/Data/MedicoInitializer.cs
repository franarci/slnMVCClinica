using MVCClinica.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCClinica.Data
{
    public class MedicoInitializer : DropCreateDatabaseAlways<MedicoDbContext>
    {
        protected override void Seed(MedicoDbContext context)
        {
            var medicos = new List<Medico>
            {
               new Medico
               {
                  Apellido = "Milagro",
                  Nombre = "Dr",
                  NroMatricula=666,
                  FechaNacimiento= new DateTime(1996,5,5),
                  Ciudad="Lima",
                  Especialidad="Milagros"
               }
            };
            medicos.ForEach(b => context.Medicos.Add(b));
            context.SaveChanges();
        }
    }
}