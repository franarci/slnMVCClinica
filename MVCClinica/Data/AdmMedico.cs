﻿using MVCClinica.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public static List<string> ListarSoloEspecialidades()
        {
            var esps = context.Medicos.Select(m => m.Especialidad).Distinct();
            return esps.ToList();
        }

        public static List<Medico> ListarPorEspecialidad(string especialidad)
        {
            var medicos= context.Medicos.Select(m => m.Especialidad == especialidad);
            return (List<Medico>)medicos;
        }

        internal static void Insertar(Medico medico)
        {
            context.Medicos.Add(medico);
            context.SaveChanges();
        }

        internal static Medico GetPorId(int id)
        {
            Medico medico= context.Medicos.Find(id);
            context.Entry(medico).State = EntityState.Detached;
            return medico;
        }

        internal static void Modificar(Medico medico)
        {
            context.Medicos.Attach(medico);
            context.SaveChanges();
        }

        internal static void Eliminar(int id)
        {
            Medico medico = context.Medicos.Find(id);
            context.Medicos.Remove(medico);
            context.SaveChanges();
        }
    }
}