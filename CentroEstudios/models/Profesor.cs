using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CentroDeEstudios.Models
{
    [Table("Profesores")] // Asegura que la tabla se llame "Profesores" en la base de datos
    public class Profesor
    {
        [Key]
        public int ID_Profesor { get; set; }
        public string Nombre { get; set; }
    }
}
