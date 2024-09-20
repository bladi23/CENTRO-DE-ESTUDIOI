using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using CentroDeEstudios.Models;

namespace CentroDeEstudios.Controllers
{
    public class ProfesorController
    {
        private CentroDeIdiomasContext context;

        public ProfesorController()
        {
            context = new CentroDeIdiomasContext();
        }

        // Crear un nuevo profesor
        public void CrearProfesor(string nombre)
        {
            var profesor = new Profesor { Nombre = nombre };
            context.Profesores.Add(profesor);
            context.SaveChanges();
        }

        // Obtener la lista de profesores
        public List<Profesor> ObtenerProfesores()
        {
            return context.Profesores.ToList();
        }

        // Actualizar un profesor
        public void ActualizarProfesor(int id, string nombre)
        {
            var profesor = context.Profesores.Find(id);
            if (profesor != null)
            {
                profesor.Nombre = nombre;
                context.SaveChanges();
            }
        }

        // Eliminar un profesor
        public void EliminarProfesor(int id)
        {
            var profesor = context.Profesores.Find(id);
            if (profesor != null)
            {
                context.Profesores.Remove(profesor);
                context.SaveChanges();
            }
        }
    }
}
