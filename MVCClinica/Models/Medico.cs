using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCClinica.Models
{
    public class Medico
    {
        public int Id { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Matricula { get; set; }
        public string Especialidad { get; set; }
        public string Domicilio { get; set; }
        public string Email { get; set; }
        public int Telefono { get; set; }

        public Medico(string apellido, string nombre, string matricula, string especialidad, string domicilio, string email, int telefono)
        {
            Apellido = apellido;
            Nombre = nombre;
            Matricula = matricula;
            Especialidad = especialidad;
            Domicilio = domicilio;
            Email = email;
            Telefono = telefono;
        }
    }
}