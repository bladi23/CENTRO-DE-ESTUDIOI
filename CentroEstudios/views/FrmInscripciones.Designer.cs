namespace CentroEstudios.Views
{
    partial class FrmInscripciones
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
            label1 = new Label();
            cmbEstudiantes = new ComboBox();
            label2 = new Label();
            cmbCursos = new ComboBox();
            label3 = new Label();
            dtpFechaInscripcion = new DateTimePicker();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnSalir = new Button();  // Añadimos btnSalir
            btnRegresar = new Button();  // Añadimos btnRegresar
            dgvInscripciones = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvInscripciones).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 30);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 0;
            label1.Text = "Estudiante:";
            // 
            // cmbEstudiantes
            // 
            cmbEstudiantes.FormattingEnabled = true;
            cmbEstudiantes.Location = new Point(130, 27);
            cmbEstudiantes.Name = "cmbEstudiantes";
            cmbEstudiantes.Size = new Size(200, 28);
            cmbEstudiantes.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 70);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 2;
            label2.Text = "Curso:";
            // 
            // cmbCursos
            // 
            cmbCursos.FormattingEnabled = true;
            cmbCursos.Location = new Point(130, 67);
            cmbCursos.Name = "cmbCursos";
            cmbCursos.Size = new Size(200, 28);
            cmbCursos.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 110);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 4;
            label3.Text = "Fecha:";
            // 
            // dtpFechaInscripcion
            // 
            dtpFechaInscripcion.Location = new Point(130, 107);
            dtpFechaInscripcion.Name = "dtpFechaInscripcion";
            dtpFechaInscripcion.Size = new Size(200, 27);
            dtpFechaInscripcion.TabIndex = 5;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(30, 150);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(90, 30);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(130, 150);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(90, 30);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(30, 450);  // Posicionamos el botón Regresar
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(90, 30);
            btnRegresar.TabIndex = 9;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(130, 450);  // Posicionamos el botón Salir
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(90, 30);
            btnSalir.TabIndex = 10;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // dgvInscripciones
            // 
            dgvInscripciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInscripciones.BackgroundColor = SystemColors.ControlLightLight;
            dgvInscripciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInscripciones.Location = new Point(30, 186);
            dgvInscripciones.Name = "dgvInscripciones";
            dgvInscripciones.RowHeadersWidth = 51;
            dgvInscripciones.RowTemplate.Height = 25;
            dgvInscripciones.Size = new Size(400, 250);
            dgvInscripciones.TabIndex = 8;
            // 
            // FrmInscripciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(464, 497);
            Controls.Add(btnSalir);
            Controls.Add(btnRegresar);
            Controls.Add(dgvInscripciones);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(dtpFechaInscripcion);
            Controls.Add(label3);
            Controls.Add(cmbCursos);
            Controls.Add(label2);
            Controls.Add(cmbEstudiantes);
            Controls.Add(label1);
            Name = "FrmInscripciones";
            Text = "Gestión de Inscripciones";
            Load += FrmInscripciones_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInscripciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label label1;
        private ComboBox cmbEstudiantes;
        private Label label2;
        private ComboBox cmbCursos;
        private Label label3;
        private DateTimePicker dtpFechaInscripcion;
        private Button btnAgregar;
        private Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRegresar;
        private DataGridView dgvInscripciones;
    }
}
