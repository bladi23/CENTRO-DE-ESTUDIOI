using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using CentroDeEstudios.Models;

namespace CentroDeEstudios.Controllers
{
    public class CursoController
    {
        private CentroDeIdiomasContext context;

        public CursoController()
        {
            context = new CentroDeIdiomasContext();
        }

        // Crear un nuevo curso
        public void CrearCurso(string idioma, int idProfesor)
        {
            var curso = new Curso { Idioma = idioma, ID_Profesor = idProfesor };
            context.Cursos.Add(curso);
            context.SaveChanges();
        }

        // Obtener la lista de cursos
        public List<Curso> ObtenerCursos()
        {
            return context.Cursos.ToList();
        }

        // Actualizar un curso
        public void ActualizarCurso(int id, string idioma, int idProfesor)
        {
            var curso = context.Cursos.Find(id);
            if (curso != null)
            {
                curso.Idioma = idioma;
                curso.ID_Profesor = idProfesor;
                context.SaveChanges();
            }
        }

        // Eliminar un curso
        public void EliminarCurso(int id)
        {
            var curso = context.Cursos.Find(id);
            if (curso != null)
            {
                context.Cursos.Remove(curso);
                context.SaveChanges();
            }
        }
    }
}
