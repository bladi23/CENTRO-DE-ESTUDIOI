using System.ComponentModel.DataAnnotations;

namespace CentroDeEstudios.Models
{
    public class Estudiante
    {
        [Key] // Esto indica que es la clave primaria
        public int ID_Estudiante { get; set; }
        public string Nombre { get; set; }
    }
}
