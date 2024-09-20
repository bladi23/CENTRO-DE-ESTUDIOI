using System;
using System.Windows.Forms;

namespace CentroEstudios.Views
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        // Abrir el formulario de estudiantes
        private void btnEstudiantes_Click(object sender, EventArgs e)
        {
            FrmEstudiantes frmEstudiantes = new FrmEstudiantes();
            this.Hide();  // Ocultamos el formulario principal
            frmEstudiantes.ShowDialog();  // Usamos ShowDialog para abrir el formulario como modal
            this.Show();  // Mostramos nuevamente el formulario principal cuando se cierra el formulario secundario
        }


        // Abrir el formulario de profesores
        private void btnProfesores_Click(object sender, EventArgs e)
        {
            FrmProfesores frmProfesores = new FrmProfesores();
            this.Hide();
            frmProfesores.ShowDialog();
            this.Show();
        }

        // Abrir el formulario de cursos
        private void btnCursos_Click(object sender, EventArgs e)
        {
            FrmCursos frmCursos = new FrmCursos();
            this.Hide();
            frmCursos.ShowDialog();
            this.Show();
        }

        // Abrir el formulario de inscripciones
        private void btnInscripciones_Click(object sender, EventArgs e)
        {
            FrmInscripciones frmInscripciones = new FrmInscripciones();
            this.Hide();
            frmInscripciones.ShowDialog();
            this.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
