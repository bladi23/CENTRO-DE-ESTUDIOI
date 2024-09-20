using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CentroDeEstudios.Models
{
    [Table("Inscripciones")] // Asegura que la tabla se llame "Profesores" en la base de datos
    public class Inscripcion
    {

        [Key]
        public int ID_Inscripcion { get; set; }

        public int ID_Estudiante { get; set; }
        public virtual Estudiante Estudiante { get; set; }

        public int ID_Curso { get; set; }
        public virtual Curso Curso { get; set; }

        public DateTime Fecha { get; set; }
    }
}
