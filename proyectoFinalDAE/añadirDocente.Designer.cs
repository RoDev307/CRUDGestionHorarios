namespace proyectoFinalDAE
{
    partial class añadirDocente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewDocentes = new DataGridView();
            panel2 = new Panel();
            txtNombreDocente = new TextBox();
            btnAñadirMateria = new Button();
            panel1 = new Panel();
            txtApellidos = new TextBox();
            button1 = new Button();
            button2 = new Button();
            panel3 = new Panel();
            txtDireccion = new TextBox();
            panel4 = new Panel();
            txtTelefono = new TextBox();
            label4 = new Label();
            cmbNivelAcademico = new ComboBox();
            label1 = new Label();
            cmbHorariosDisp = new ComboBox();
            label3 = new Label();
            cmbTipo = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDocentes).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewDocentes
            // 
            dataGridViewDocentes.BorderStyle = BorderStyle.None;
            dataGridViewDocentes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDocentes.Location = new Point(25, 302);
            dataGridViewDocentes.Name = "dataGridViewDocentes";
            dataGridViewDocentes.ReadOnly = true;
            dataGridViewDocentes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewDocentes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDocentes.Size = new Size(1129, 423);
            dataGridViewDocentes.TabIndex = 36;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.FromArgb(206, 146, 18);
            panel2.Enabled = false;
            panel2.Location = new Point(26, 62);
            panel2.Name = "panel2";
            panel2.Size = new Size(321, 2);
            panel2.TabIndex = 35;
            // 
            // txtNombreDocente
            // 
            txtNombreDocente.Anchor = AnchorStyles.None;
            txtNombreDocente.BackColor = Color.FromArgb(235, 210, 153);
            txtNombreDocente.BorderStyle = BorderStyle.None;
            txtNombreDocente.Font = new Font("Liberation Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreDocente.ForeColor = Color.Black;
            txtNombreDocente.Location = new Point(25, 37);
            txtNombreDocente.Name = "txtNombreDocente";
            txtNombreDocente.Size = new Size(321, 19);
            txtNombreDocente.TabIndex = 34;
            txtNombreDocente.Text = "Nombres";
            // 
            // btnAñadirMateria
            // 
            btnAñadirMateria.Anchor = AnchorStyles.None;
            btnAñadirMateria.FlatAppearance.BorderSize = 0;
            btnAñadirMateria.FlatAppearance.MouseDownBackColor = Color.FromArgb(176, 41, 28);
            btnAñadirMateria.FlatAppearance.MouseOverBackColor = Color.FromArgb(176, 41, 28);
            btnAñadirMateria.FlatStyle = FlatStyle.Flat;
            btnAñadirMateria.Font = new Font("Liberation Mono", 12F);
            btnAñadirMateria.ForeColor = Color.Black;
            btnAñadirMateria.Location = new Point(821, 37);
            btnAñadirMateria.Margin = new Padding(3, 4, 3, 4);
            btnAñadirMateria.Name = "btnAñadirMateria";
            btnAñadirMateria.Size = new Size(333, 75);
            btnAñadirMateria.TabIndex = 33;
            btnAñadirMateria.Text = "Añadir";
            btnAñadirMateria.UseVisualStyleBackColor = true;
            btnAñadirMateria.Click += btnAñadirMateria_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(206, 146, 18);
            panel1.Enabled = false;
            panel1.Location = new Point(448, 62);
            panel1.Name = "panel1";
            panel1.Size = new Size(321, 2);
            panel1.TabIndex = 38;
            // 
            // txtApellidos
            // 
            txtApellidos.Anchor = AnchorStyles.None;
            txtApellidos.BackColor = Color.FromArgb(235, 210, 153);
            txtApellidos.BorderStyle = BorderStyle.None;
            txtApellidos.Font = new Font("Liberation Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellidos.ForeColor = Color.Black;
            txtApellidos.Location = new Point(447, 37);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(321, 19);
            txtApellidos.TabIndex = 37;
            txtApellidos.Text = "Apellidos";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(176, 41, 28);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(176, 41, 28);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Liberation Mono", 12F);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(821, 120);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(333, 75);
            button1.TabIndex = 39;
            button1.Text = "Modificar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(176, 41, 28);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(176, 41, 28);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Liberation Mono", 12F);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(821, 203);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(333, 75);
            button2.TabIndex = 40;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = Color.FromArgb(206, 146, 18);
            panel3.Enabled = false;
            panel3.Location = new Point(27, 118);
            panel3.Name = "panel3";
            panel3.Size = new Size(321, 2);
            panel3.TabIndex = 42;
            // 
            // txtDireccion
            // 
            txtDireccion.Anchor = AnchorStyles.None;
            txtDireccion.BackColor = Color.FromArgb(235, 210, 153);
            txtDireccion.BorderStyle = BorderStyle.None;
            txtDireccion.Font = new Font("Liberation Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDireccion.ForeColor = Color.Black;
            txtDireccion.Location = new Point(26, 93);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(321, 19);
            txtDireccion.TabIndex = 41;
            txtDireccion.Text = "Dirección";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.BackColor = Color.FromArgb(206, 146, 18);
            panel4.Enabled = false;
            panel4.Location = new Point(448, 118);
            panel4.Name = "panel4";
            panel4.Size = new Size(321, 2);
            panel4.TabIndex = 44;
            // 
            // txtTelefono
            // 
            txtTelefono.Anchor = AnchorStyles.None;
            txtTelefono.BackColor = Color.FromArgb(235, 210, 153);
            txtTelefono.BorderStyle = BorderStyle.None;
            txtTelefono.Font = new Font("Liberation Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefono.ForeColor = Color.Black;
            txtTelefono.Location = new Point(447, 93);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(321, 19);
            txtTelefono.TabIndex = 43;
            txtTelefono.Text = "Telefóno";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(26, 128);
            label4.Name = "label4";
            label4.Size = new Size(158, 18);
            label4.TabIndex = 48;
            label4.Text = "Nivel academico";
            // 
            // cmbNivelAcademico
            // 
            cmbNivelAcademico.Anchor = AnchorStyles.None;
            cmbNivelAcademico.BackColor = Color.White;
            cmbNivelAcademico.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNivelAcademico.FlatStyle = FlatStyle.Flat;
            cmbNivelAcademico.ForeColor = Color.Black;
            cmbNivelAcademico.FormattingEnabled = true;
            cmbNivelAcademico.ImeMode = ImeMode.NoControl;
            cmbNivelAcademico.Items.AddRange(new object[] { "Ingeniería", "Técnico", "Licenciatura" });
            cmbNivelAcademico.Location = new Point(27, 149);
            cmbNivelAcademico.Name = "cmbNivelAcademico";
            cmbNivelAcademico.Size = new Size(321, 26);
            cmbNivelAcademico.TabIndex = 47;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(26, 182);
            label1.Name = "label1";
            label1.Size = new Size(208, 18);
            label1.TabIndex = 50;
            label1.Text = "Horarios disponibles";
            // 
            // cmbHorariosDisp
            // 
            cmbHorariosDisp.Anchor = AnchorStyles.None;
            cmbHorariosDisp.BackColor = Color.White;
            cmbHorariosDisp.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbHorariosDisp.FlatStyle = FlatStyle.Flat;
            cmbHorariosDisp.ForeColor = Color.Black;
            cmbHorariosDisp.FormattingEnabled = true;
            cmbHorariosDisp.ImeMode = ImeMode.NoControl;
            cmbHorariosDisp.Items.AddRange(new object[] { "Lunes a Viernes 7:00-15:00", "Lunes, Miércoles, Viernes 14:00-18:00", "Martes y Jueves 8:00-12:00" });
            cmbHorariosDisp.Location = new Point(27, 203);
            cmbHorariosDisp.Name = "cmbHorariosDisp";
            cmbHorariosDisp.Size = new Size(321, 26);
            cmbHorariosDisp.TabIndex = 49;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(447, 128);
            label3.Name = "label3";
            label3.Size = new Size(48, 18);
            label3.TabIndex = 54;
            label3.Text = "Tipo";
            // 
            // cmbTipo
            // 
            cmbTipo.Anchor = AnchorStyles.None;
            cmbTipo.BackColor = Color.White;
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.FlatStyle = FlatStyle.Flat;
            cmbTipo.ForeColor = Color.Black;
            cmbTipo.FormattingEnabled = true;
            cmbTipo.ImeMode = ImeMode.NoControl;
            cmbTipo.Items.AddRange(new object[] { "Tiempo completo", "Hora Clase", "Medio Tiempo" });
            cmbTipo.Location = new Point(448, 149);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(321, 26);
            cmbTipo.TabIndex = 53;
            // 
            // añadirDocente
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(235, 210, 153);
            ClientSize = new Size(1178, 737);
            Controls.Add(label3);
            Controls.Add(cmbTipo);
            Controls.Add(label1);
            Controls.Add(cmbHorariosDisp);
            Controls.Add(label4);
            Controls.Add(cmbNivelAcademico);
            Controls.Add(panel4);
            Controls.Add(txtTelefono);
            Controls.Add(panel3);
            Controls.Add(txtDireccion);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(txtApellidos);
            Controls.Add(dataGridViewDocentes);
            Controls.Add(panel2);
            Controls.Add(txtNombreDocente);
            Controls.Add(btnAñadirMateria);
            Font = new Font("Liberation Mono", 12F);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            MaximumSize = new Size(1178, 737);
            MinimumSize = new Size(1178, 737);
            Name = "añadirDocente";
            Text = "añadirDocente";
            Load += añadirDocente_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewDocentes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewDocentes;
        private Panel panel2;
        private TextBox txtNombreDocente;
        private Button btnAñadirMateria;
        private Panel panel1;
        private TextBox txtApellidos;
        private Button button1;
        private Button button2;
        private Panel panel3;
        private TextBox txtDireccion;
        private Panel panel4;
        private TextBox txtTelefono;
        private Label label4;
        private ComboBox cmbNivelAcademico;
        private Label label1;
        private ComboBox cmbHorariosDisp;
        private Label label3;
        private ComboBox cmbTipo;
    }
}