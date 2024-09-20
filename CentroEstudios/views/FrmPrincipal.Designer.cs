using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CentroEstudios.Views
{
    partial class FrmPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            btnEstudiantes = new Button();
            btnProfesores = new Button();
            btnCursos = new Button();
            btnInscripciones = new Button();
            SuspendLayout();
            // 
            // btnEstudiantes
            // 
            btnEstudiantes.Location = new Point(352, 238);
            btnEstudiantes.Name = "btnEstudiantes";
            btnEstudiantes.Size = new Size(120, 30);
            btnEstudiantes.TabIndex = 0;
            btnEstudiantes.Text = "Estudiantes";
            btnEstudiantes.UseVisualStyleBackColor = true;
            btnEstudiantes.Click += btnEstudiantes_Click;
            // 
            // btnProfesores
            // 
            btnProfesores.Location = new Point(30, 238);
            btnProfesores.Name = "btnProfesores";
            btnProfesores.Size = new Size(120, 30);
            btnProfesores.TabIndex = 1;
            btnProfesores.Text = "Profesores";
            btnProfesores.UseVisualStyleBackColor = true;
            btnProfesores.Click += btnProfesores_Click;
            // 
            // btnCursos
            // 
            btnCursos.Location = new Point(30, 130);
            btnCursos.Name = "btnCursos";
            btnCursos.Size = new Size(120, 30);
            btnCursos.TabIndex = 2;
            btnCursos.Text = "Cursos";
            btnCursos.UseVisualStyleBackColor = true;
            btnCursos.Click += btnCursos_Click;
            // 
            // btnInscripciones
            // 
            btnInscripciones.Location = new Point(352, 130);
            btnInscripciones.Name = "btnInscripciones";
            btnInscripciones.Size = new Size(120, 30);
            btnInscripciones.TabIndex = 3;
            btnInscripciones.Text = "Inscripciones";
            btnInscripciones.UseVisualStyleBackColor = true;
            btnInscripciones.Click += btnInscripciones_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(518, 344);
            Controls.Add(btnInscripciones);
            Controls.Add(btnCursos);
            Controls.Add(btnProfesores);
            Controls.Add(btnEstudiantes);
            Name = "FrmPrincipal";
            Text = "Centro de Estudios";
            Load += FrmPrincipal_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnEstudiantes;
        private Button btnProfesores;
        private Button btnCursos;
        private Button btnInscripciones;
    }
}
