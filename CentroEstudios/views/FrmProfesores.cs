using System;
using System.Linq;
using System.Windows.Forms;
using CentroDeEstudios.Controllers;

namespace CentroEstudios.Views
{
    public partial class FrmProfesores : Form
    {
        private ProfesorController profesorController;

        public FrmProfesores()
        {
            InitializeComponent();
            profesorController = new ProfesorController();
        }

        // Cargar la lista de profesores al abrir el formulario
        private void FrmProfesores_Load(object sender, EventArgs e)
        {
            ListarProfesores();
        }

        // Método para listar los profesores en el DataGridView
        private void ListarProfesores()
        {
            var profesores = profesorController.ObtenerProfesores();
            dgvProfesores.DataSource = profesores.Select(prof => new { prof.ID_Profesor, prof.Nombre }).ToList();
        }

        // Evento para agregar un nuevo profesor
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNombre.Text))
            {
                profesorController.CrearProfesor(txtNombre.Text);
                MessageBox.Show("Profesor agregado exitosamente.");
                LimpiarCampos();
                ListarProfesores(); // Actualizar la lista de profesores
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un nombre.");
            }
        }

        // Evento para actualizar un profesor seleccionado
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvProfesores.SelectedRows.Count > 0)
            {
                int idProfesor = Convert.ToInt32(dgvProfesores.SelectedRows[0].Cells["ID_Profesor"].Value);
                profesorController.ActualizarProfesor(idProfesor, txtNombre.Text);
                MessageBox.Show("Profesor actualizado exitosamente.");
                LimpiarCampos();
                ListarProfesores(); // Actualizar la lista de profesores
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un profesor para actualizar.");
            }
        }

        // Evento para eliminar un profesor seleccionado
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProfesores.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este profesor?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    int idProfesor = Convert.ToInt32(dgvProfesores.SelectedRows[0].Cells["ID_Profesor"].Value);
                    profesorController.EliminarProfesor(idProfesor);
                    MessageBox.Show("Profesor eliminado exitosamente.");
                    LimpiarCampos();
                    ListarProfesores(); // Actualizar la lista de profesores
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un profesor para eliminar.");
            }
        }

        // Método para limpiar los campos después de agregar, actualizar o eliminar
        private void LimpiarCampos()
        {
            txtNombre.Text = string.Empty;
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

        // Cuando se selecciona un profesor en el DataGridView, cargar su información en los campos
        private void dgvProfesores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProfesores.Rows[e.RowIndex];
                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
            }
        }
    }

}
