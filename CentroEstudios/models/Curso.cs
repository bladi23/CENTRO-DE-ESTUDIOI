using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CentroDeEstudios.Models
{
    [Table("Cursos")] // Asegura que la tabla se llame "Profesores" en la base de datos

    public class Curso
    {
        [Key]
        public int ID_Curso { get; set; }
        public string Idioma { get; set; }

        public int ID_Profesor { get; set; }
        public virtual Profesor Profesor { get; set; }
    }
}
