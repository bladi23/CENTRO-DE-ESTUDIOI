using System;
using System.Linq;
using System.Windows.Forms;
using CentroDeEstudios.Controllers;
using CentroDeEstudios.Models;

namespace CentroEstudios.Views
{
    public partial class FrmCursos : Form
    {
        private CursoController cursoController;
        private ProfesorController profesorController;

        public FrmCursos()
        {
            InitializeComponent();
            cursoController = new CursoController();
            profesorController = new ProfesorController();
        }

        // Cargar la lista de cursos y profesores al abrir el formulario
        private void FrmCursos_Load(object sender, EventArgs e)
        {
            ListarCursos();
            InicializarProfesores();  // Cargar la lista de profesores en el ComboBox
        }

        // Método para listar los cursos en el DataGridView
        private void ListarCursos()
        {
            var cursos = cursoController.ObtenerCursos();
            dgvCursos.DataSource = cursos.Select(curso => new
            {
                curso.ID_Curso,
                curso.Idioma,
                Profesor = curso.Profesor.Nombre // Solo mostramos el nombre del profesor
            }).ToList();
        }

        // Método para inicializar el ComboBox con los nombres de los profesores
        private void InicializarProfesores()
        {
            var profesores = profesorController.ObtenerProfesores();
            cmbProfesores.DataSource = profesores;  // Asignar la lista de profesores al ComboBox
            cmbProfesores.DisplayMember = "Nombre"; // Mostrar el nombre del profesor
            cmbProfesores.ValueMember = "ID_Profesor"; // Usar el ID_Profesor como valor
        }

        // Evento para agregar un nuevo curso
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIdioma.Text) && cmbProfesores.SelectedItem != null)
            {
                int idProfesor = Convert.ToInt32(cmbProfesores.SelectedValue);
                cursoController.CrearCurso(txtIdioma.Text, idProfesor);
                MessageBox.Show("Curso agregado exitosamente.");
                LimpiarCampos();
                ListarCursos(); // Actualizar la lista de cursos después de agregar
            }
            else
            {
                MessageBox.Show("Por favor, ingresa el idioma y selecciona un profesor.");
            }
        }

        // Evento para actualizar un curso seleccionado
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvCursos.SelectedRows.Count > 0 && cmbProfesores.SelectedItem != null)
            {
                int idCurso = Convert.ToInt32(dgvCursos.SelectedRows[0].Cells["ID_Curso"].Value);
                int idProfesor = Convert.ToInt32(cmbProfesores.SelectedValue);
                cursoController.ActualizarCurso(idCurso, txtIdioma.Text, idProfesor);
                MessageBox.Show("Curso actualizado exitosamente.");
                LimpiarCampos();
                ListarCursos(); // Actualizar la lista de cursos después de actualizar
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un curso para actualizar.");
            }
        }

        // Evento para eliminar un curso seleccionado
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCursos.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este curso?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    int idCurso = Convert.ToInt32(dgvCursos.SelectedRows[0].Cells["ID_Curso"].Value);
                    cursoController.EliminarCurso(idCurso);
                    MessageBox.Show("Curso eliminado exitosamente.");
                    LimpiarCampos();
                    ListarCursos(); // Actualizar la lista de cursos después de eliminar
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un curso para eliminar.");
            }
        }

        // Método para limpiar los campos después de agregar, actualizar o eliminar
        private void LimpiarCampos()
        {
            txtIdioma.Text = string.Empty;
            cmbProfesores.SelectedIndex = -1;
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

        // Cuando se selecciona un curso en el DataGridView, cargar su información en los campos
        private void dgvCursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCursos.Rows[e.RowIndex];
                txtIdioma.Text = row.Cells["Idioma"].Value.ToString();

                // Buscar en el ComboBox el profesor cuyo nombre coincide con el de la fila seleccionada
                string nombreProfesor = row.Cells["Profesor"].Value.ToString();
                var profesorEncontrado = (cmbProfesores.Items.Cast<Profesor>()
                                          .FirstOrDefault(p => p.Nombre == nombreProfesor));

                if (profesorEncontrado != null)
                {
                    cmbProfesores.SelectedValue = profesorEncontrado.ID_Profesor;
                }
            }
        }

        private void dgvCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
