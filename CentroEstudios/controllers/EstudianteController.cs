using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using CentroDeEstudios.Models;

namespace CentroDeEstudios.Controllers
{
    public class EstudianteController
    {
        private CentroDeIdiomasContext context;

        public EstudianteController()
        {
            context = new CentroDeIdiomasContext();
        }

        // Crear un nuevo estudiante
        public void CrearEstudiante(string nombre)
        {
            var estudiante = new Estudiante { Nombre = nombre };
            context.Estudiantes.Add(estudiante);
            context.SaveChanges();
        }

        // Obtener la lista de estudiantes
        public List<Estudiante> ObtenerEstudiantes()
        {
            return context.Estudiantes.ToList();
        }

        // Actualizar un estudiante
        public void ActualizarEstudiante(int id, string nombre)
        {
            var estudiante = context.Estudiantes.Find(id);
            if (estudiante != null)
            {
                estudiante.Nombre = nombre;
                context.SaveChanges();
            }
        }

        // Eliminar un estudiante
        public void EliminarEstudiante(int id)
        {
            var estudiante = context.Estudiantes.Find(id);
            if (estudiante != null)
            {
                context.Estudiantes.Remove(estudiante);
                context.SaveChanges();
            }
        }
    }
}
