namespace Parcial_I
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxAlumno = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxTaller = new System.Windows.Forms.ComboBox();
            this.buttonIngresarDatos = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonReporte = new System.Windows.Forms.Button();
            this.buttonOrdenar = new System.Windows.Forms.Button();
            this.buttonCantidadEstudiantes = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCantidad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alumno:";
            // 
            // comboBoxAlumno
            // 
            this.comboBoxAlumno.FormattingEnabled = true;
            this.comboBoxAlumno.Items.AddRange(new object[] {
            "Douglas",
            "Angel",
            "Marc"});
            this.comboBoxAlumno.Location = new System.Drawing.Point(151, 56);
            this.comboBoxAlumno.Name = "comboBoxAlumno";
            this.comboBoxAlumno.Size = new System.Drawing.Size(121, 24);
            this.comboBoxAlumno.TabIndex = 1;
            this.comboBoxAlumno.SelectedIndexChanged += new System.EventHandler(this.comboBoxAlumno_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Taller:";
            // 
            // comboBoxTaller
            // 
            this.comboBoxTaller.FormattingEnabled = true;
            this.comboBoxTaller.Items.AddRange(new object[] {
            "Carpinteria",
            "Electronica",
            "Robotica"});
            this.comboBoxTaller.Location = new System.Drawing.Point(151, 106);
            this.comboBoxTaller.Name = "comboBoxTaller";
            this.comboBoxTaller.Size = new System.Drawing.Size(121, 24);
            this.comboBoxTaller.TabIndex = 3;
            this.comboBoxTaller.SelectedIndexChanged += new System.EventHandler(this.comboBoxTaller_SelectedIndexChanged);
            // 
            // buttonIngresarDatos
            // 
            this.buttonIngresarDatos.Location = new System.Drawing.Point(161, 160);
            this.buttonIngresarDatos.Name = "buttonIngresarDatos";
            this.buttonIngresarDatos.Size = new System.Drawing.Size(102, 46);
            this.buttonIngresarDatos.TabIndex = 4;
            this.buttonIngresarDatos.Text = "Ingresar Datos";
            this.buttonIngresarDatos.UseVisualStyleBackColor = true;
            this.buttonIngresarDatos.Click += new System.EventHandler(this.buttonIngresarDatos_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(329, 43);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(400, 291);
            this.dataGridView.TabIndex = 5;
            // 
            // buttonReporte
            // 
            this.buttonReporte.Location = new System.Drawing.Point(161, 234);
            this.buttonReporte.Name = "buttonReporte";
            this.buttonReporte.Size = new System.Drawing.Size(102, 38);
            this.buttonReporte.TabIndex = 6;
            this.buttonReporte.Text = "Reporte";
            this.buttonReporte.UseVisualStyleBackColor = true;
            this.buttonReporte.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonOrdenar
            // 
            this.buttonOrdenar.Location = new System.Drawing.Point(161, 297);
            this.buttonOrdenar.Name = "buttonOrdenar";
            this.buttonOrdenar.Size = new System.Drawing.Size(102, 37);
            this.buttonOrdenar.TabIndex = 7;
            this.buttonOrdenar.Text = "Ordenar";
            this.buttonOrdenar.UseVisualStyleBackColor = true;
            this.buttonOrdenar.Click += new System.EventHandler(this.buttonOrdenar_Click);
            // 
            // buttonCantidadEstudiantes
            // 
            this.buttonCantidadEstudiantes.Location = new System.Drawing.Point(161, 354);
            this.buttonCantidadEstudiantes.Name = "buttonCantidadEstudiantes";
            this.buttonCantidadEstudiantes.Size = new System.Drawing.Size(102, 43);
            this.buttonCantidadEstudiantes.TabIndex = 8;
            this.buttonCantidadEstudiantes.Text = "Cantidad Estudiantes";
            this.buttonCantidadEstudiantes.UseVisualStyleBackColor = true;
            this.buttonCantidadEstudiantes.Click += new System.EventHandler(this.buttonCantidadEstudiantes_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cantidad de estudiantes:";
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Location = new System.Drawing.Point(517, 381);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(44, 16);
            this.labelCantidad.TabIndex = 10;
            this.labelCantidad.Text = "label4";
            this.labelCantidad.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelCantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonCantidadEstudiantes);
            this.Controls.Add(this.buttonOrdenar);
            this.Controls.Add(this.buttonReporte);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.buttonIngresarDatos);
            this.Controls.Add(this.comboBoxTaller);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxAlumno);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxAlumno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxTaller;
        private System.Windows.Forms.Button buttonIngresarDatos;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonReporte;
        private System.Windows.Forms.Button buttonOrdenar;
        private System.Windows.Forms.Button buttonCantidadEstudiantes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelCantidad;
    }
}

