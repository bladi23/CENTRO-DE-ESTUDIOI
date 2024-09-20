using System.Data.Entity;

namespace CentroDeEstudios.Models
{
    public class CentroDeIdiomasContext : System.Data.Entity.DbContext
    {
        public CentroDeIdiomasContext() : base("name=CentroDeIdiomasDB")
        {
        }

        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Profesor> Profesores { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Inscripcion> Inscripciones { get; set; }
    }
}
