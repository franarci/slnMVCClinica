using MVCClinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCClinica.Data
{
    public static class AdmMedico
    {
        private static MedicoDbContext context = new MedicoDbContext();

        public static List<Medico> Listar()  //Modelo conectado
        {
            return context.Medicos.ToList();           
        }

        internal static void Insertar(Medico medico)
        {
            context.Medicos.Add(medico);
            context.SaveChanges();
        }

        internal static Medico GetPorId(int id)
        {
            return context.Medicos.Find(id);
        }
    }
}