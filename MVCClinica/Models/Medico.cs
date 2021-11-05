using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCClinica.Models
{
    public class Medico
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "El apellido no debe superar los 50 caracteres")]
        [Column(TypeName = "varchar")]
        public string Apellido { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "El nombre no debe superar los 50 caracteres")]
        [Column(TypeName = "varchar")]
        public string Nombre { get; set; }

        public int NroMatricula { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50, ErrorMessage = "La especialidad no debe superar los 50 caracteres")]
        public string Especialidad { get; set; }

        [Column(TypeName ="date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? FechaNacimiento { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50, ErrorMessage = "La ciudad no debe superar los 50 caracteres")]
        public string Ciudad { get; set; }
    }
}