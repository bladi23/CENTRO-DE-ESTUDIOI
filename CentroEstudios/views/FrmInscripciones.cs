using System;
using System.Linq;
using System.Windows.Forms;
using CentroDeEstudios.Controllers;

namespace CentroEstudios.Views
{
    public partial class FrmInscripciones : Form
    {
        private InscripcionController inscripcionController;
        private EstudianteController estudianteController;
        private CursoController cursoController;

        public FrmInscripciones()
        {
            InitializeComponent();
            inscripcionController = new InscripcionController();
            estudianteController = new EstudianteController();
            cursoController = new CursoController();
        }

        // Cargar la lista de inscripciones, estudiantes y cursos al abrir el formulario
        private void FrmInscripciones_Load(object sender, EventArgs e)
        {
            ListarInscripciones();
            InicializarEstudiantes();
            InicializarCursos();
        }

        // Método para listar las inscripciones en el DataGridView
        private void ListarInscripciones()
        {
            var inscripciones = inscripcionController.ObtenerInscripciones();
            dgvInscripciones.DataSource = inscripciones.Select(inscripcion => new
            {
                inscripcion.ID_Inscripcion,
                Estudiante = inscripcion.Estudiante.Nombre,
                Curso = inscripcion.Curso.Idioma,
                Fecha = inscripcion.Fecha.ToShortDateString()
            }).ToList();
        }

        // Método para inicializar el ComboBox con los estudiantes
        private void InicializarEstudiantes()
        {
            var estudiantes = estudianteController.ObtenerEstudiantes();
            cmbEstudiantes.DataSource = estudiantes;
            cmbEstudiantes.DisplayMember = "Nombre"; // Mostrar el nombre del estudiante
            cmbEstudiantes.ValueMember = "ID_Estudiante"; // Usar el ID_Estudiante como valor
        }

        // Método para inicializar el ComboBox con los cursos
        private void InicializarCursos()
        {
            var cursos = cursoController.ObtenerCursos();
            cmbCursos.DataSource = cursos;
            cmbCursos.DisplayMember = "Idioma"; // Mostrar el idioma del curso
            cmbCursos.ValueMember = "ID_Curso"; // Usar el ID_Curso como valor
        }

        // Evento para agregar una nueva inscripción
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cmbEstudiantes.SelectedItem != null && cmbCursos.SelectedItem != null && dtpFechaInscripcion.Value != null)
            {
                int idEstudiante = Convert.ToInt32(cmbEstudiantes.SelectedValue);
                int idCurso = Convert.ToInt32(cmbCursos.SelectedValue);
                DateTime fecha = dtpFechaInscripcion.Value;

                inscripcionController.CrearInscripcion(idEstudiante, idCurso, fecha);
                MessageBox.Show("Inscripción agregada exitosamente.");
                LimpiarCampos();
                ListarInscripciones(); // Actualizar la lista de inscripciones
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un estudiante, un curso y una fecha.");
            }
        }

        // Evento para eliminar una inscripción seleccionada
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvInscripciones.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar esta inscripción?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    int idInscripcion = Convert.ToInt32(dgvInscripciones.SelectedRows[0].Cells["ID_Inscripcion"].Value);
                    inscripcionController.EliminarInscripcion(idInscripcion);
                    MessageBox.Show("Inscripción eliminada exitosamente.");
                    LimpiarCampos();
                    ListarInscripciones(); // Actualizar la lista de inscripciones después de eliminar
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una inscripción para eliminar.");
            }
        }

        // Función para el botón "Regresar"
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();  // Cerrar el formulario secundario
        }


        // Función para el botón "Salir"
        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Cierra toda la aplicación
            Application.Exit();
        }

        // Método para limpiar los campos después de agregar o eliminar
        private void LimpiarCampos()
        {
            cmbEstudiantes.SelectedIndex = -1;
            cmbCursos.SelectedIndex = -1;
            dtpFechaInscripcion.Value = DateTime.Now;
        }
    }
}
