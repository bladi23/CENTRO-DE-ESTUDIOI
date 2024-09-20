namespace CentroEstudios.Views
{
    partial class FrmCursos
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
            txtIdioma = new TextBox();
            cmbProfesores = new ComboBox();
            label2 = new Label();
            btnAgregar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnRegresar = new Button();  // Declaración del botón Regresar
            btnSalir = new Button();  // Declaración del botón Salir
            dgvCursos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)(dgvCursos)).BeginInit();
            SuspendLayout();

            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 40);
            label1.Name = "label1";
            label1.Size = new Size(125, 20);
            label1.TabIndex = 0;
            label1.Text = "Idioma del Curso:";

            // 
            // txtIdioma
            // 
            txtIdioma.Location = new Point(140, 37);
            txtIdioma.Name = "txtIdioma";
            txtIdioma.Size = new Size(200, 27);
            txtIdioma.TabIndex = 1;

            // 
            // cmbProfesores
            // 
            cmbProfesores.FormattingEnabled = true;
            cmbProfesores.Location = new Point(140, 77);
            cmbProfesores.Name = "cmbProfesores";
            cmbProfesores.Size = new Size(200, 28);
            cmbProfesores.TabIndex = 3;

            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 80);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 2;
            label2.Text = "Profesor:";

            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(30, 120);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(90, 30);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;

            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(140, 120);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(90, 30);
            btnActualizar.TabIndex = 5;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;

            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(250, 120);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(90, 30);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;

            // 
            // dgvCursos
            // 
            dgvCursos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCursos.Location = new Point(30, 160);
            dgvCursos.Name = "dgvCursos";
            dgvCursos.RowHeadersWidth = 51;
            dgvCursos.RowTemplate.Height = 25;
            dgvCursos.Size = new Size(400, 250);
            dgvCursos.TabIndex = 7;
            dgvCursos.CellClick += dgvCursos_CellClick;

            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(93, 420);  // Posicionamos el botón Regresar
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(120, 30);
            btnRegresar.TabIndex = 8;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;

            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(273, 420);  // Posicionamos el botón Salir
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(120, 30);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;

            // 
            // FrmCursos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 480);
            Controls.Add(dgvCursos);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            Controls.Add(cmbProfesores);
            Controls.Add(label2);
            Controls.Add(txtIdioma);
            Controls.Add(label1);
            Controls.Add(btnRegresar);  // Añadimos el botón Regresar
            Controls.Add(btnSalir);  // Añadimos el botón Salir
            Name = "FrmCursos";
            Text = "Gestión de Cursos";
            Load += FrmCursos_Load;
            ((System.ComponentModel.ISupportInitialize)(dgvCursos)).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdioma;
        private System.Windows.Forms.ComboBox cmbProfesores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.DataGridView dgvCursos;
    }
}
