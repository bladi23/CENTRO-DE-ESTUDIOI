using System;
using System.Linq;
using System.Windows.Forms;
using CentroDeEstudios.Controllers;

namespace CentroEstudios.Views
{
    public partial class FrmEstudiantes : Form
    {
        private EstudianteController estudianteController;

        public FrmEstudiantes()
        {
            InitializeComponent();
            estudianteController = new EstudianteController();
        }

        // Cargar la lista de estudiantes al abrir el formulario
        private void FrmEstudiantes_Load(object sender, EventArgs e)
        {
            ListarEstudiantes(); // Llama al método que lista los estudiantes cuando el formulario carga
        }

        // Método para listar los estudiantes en el DataGridView
        private void ListarEstudiantes()
        {
            var estudiantes = estudianteController.ObtenerEstudiantes();
            dgvEstudiantes.DataSource = estudiantes.Select(est => new { est.ID_Estudiante, est.Nombre }).ToList();
        }

        // Evento para agregar un nuevo estudiante
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNombre.Text))
            {
                estudianteController.CrearEstudiante(txtNombre.Text);
                MessageBox.Show("Estudiante agregado exitosamente.");
                LimpiarCampos();
                ListarEstudiantes(); // Actualizar la lista de estudiantes después de agregar
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un nombre.");
            }
        }

        // Evento para actualizar un estudiante seleccionado
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvEstudiantes.SelectedRows.Count > 0)
            {
                int idEstudiante = Convert.ToInt32(dgvEstudiantes.SelectedRows[0].Cells["ID_Estudiante"].Value);
                estudianteController.ActualizarEstudiante(idEstudiante, txtNombre.Text);
                MessageBox.Show("Estudiante actualizado exitosamente.");
                LimpiarCampos();
                ListarEstudiantes(); // Actualizar la lista de estudiantes después de actualizar
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un estudiante para actualizar.");
            }
        }

        // Evento para eliminar un estudiante seleccionado
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEstudiantes.SelectedRows.Count > 0)
            {
                // Pedir confirmación antes de eliminar
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este estudiante?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    int idEstudiante = Convert.ToInt32(dgvEstudiantes.SelectedRows[0].Cells["ID_Estudiante"].Value);
                    estudianteController.EliminarEstudiante(idEstudiante);
                    MessageBox.Show("Estudiante eliminado exitosamente.");
                    LimpiarCampos();
                    ListarEstudiantes(); // Actualizar la lista de estudiantes después de eliminar
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un estudiante para eliminar.");
            }
        }

        // Método para limpiar los campos después de agregar, actualizar o eliminar
        private void LimpiarCampos()
        {
            txtNombre.Text = string.Empty;
        }

        // Cuando se selecciona un estudiante en el DataGridView, cargar su información en los campos
        private void dgvEstudiantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEstudiantes.Rows[e.RowIndex];
                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
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


        private void dgvEstudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
