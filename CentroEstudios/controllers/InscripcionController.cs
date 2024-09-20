using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using CentroDeEstudios.Models;

namespace CentroDeEstudios.Controllers
{
    public class InscripcionController
    {
        private CentroDeIdiomasContext context;

        public InscripcionController()
        {
            context = new CentroDeIdiomasContext();
        }

        // Crear una nueva inscripción
        public void CrearInscripcion(int idEstudiante, int idCurso, DateTime fecha)
        {
            var inscripcion = new Inscripcion
            {
                ID_Estudiante = idEstudiante,
                ID_Curso = idCurso,
                Fecha = fecha
            };
            context.Inscripciones.Add(inscripcion);
            context.SaveChanges();
        }

        // Obtener la lista de inscripciones
        public List<Inscripcion> ObtenerInscripciones()
        {
            return context.Inscripciones.ToList();
        }

        // Eliminar una inscripción
        public void EliminarInscripcion(int id)
        {
            var inscripcion = context.Inscripciones.Find(id);
            if (inscripcion != null)
            {
                context.Inscripciones.Remove(inscripcion);
                context.SaveChanges();
            }
        }
    }
}

