namespace proyectoFinalDAE
{
    partial class añadirForm
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
            btnAñadirMateria = new Button();
            cmbMateria = new ComboBox();
            cmbCarrera = new ComboBox();
            cmbAula = new ComboBox();
            dataGridView1 = new DataGridView();
            cmbTipo = new ComboBox();
            dtpFechaInicio = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            dtpFechaFin = new DateTimePicker();
            cmbHorario = new ComboBox();
            cmbDia = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label1 = new Label();
            txtDocente = new ComboBox();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnAñadirMateria
            // 
            btnAñadirMateria.Anchor = AnchorStyles.None;
            btnAñadirMateria.FlatAppearance.BorderSize = 0;
            btnAñadirMateria.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            btnAñadirMateria.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnAñadirMateria.FlatStyle = FlatStyle.Flat;
            btnAñadirMateria.Font = new Font("Liberation Mono", 12F);
            btnAñadirMateria.ForeColor = Color.White;
            btnAñadirMateria.Location = new Point(809, 96);
            btnAñadirMateria.Margin = new Padding(3, 4, 3, 4);
            btnAñadirMateria.Name = "btnAñadirMateria";
            btnAñadirMateria.Size = new Size(333, 75);
            btnAñadirMateria.TabIndex = 26;
            btnAñadirMateria.Text = "Añadir";
            btnAñadirMateria.UseVisualStyleBackColor = true;
            btnAñadirMateria.Click += btnAñadirMateria_Click;
            // 
            // cmbMateria
            // 
            cmbMateria.Anchor = AnchorStyles.None;
            cmbMateria.BackColor = Color.FromArgb(51, 51, 51);
            cmbMateria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMateria.FlatStyle = FlatStyle.Flat;
            cmbMateria.ForeColor = Color.White;
            cmbMateria.FormattingEnabled = true;
            cmbMateria.Items.AddRange(new object[] { "Desarrollo de Lógica de Programación (Código: TDS1.1)", "Desarrollo de Páginas Web (Código: TDS1.2)", "Análisis y Diseño de Sistemas (Código: TDS1.3)", "Conversación en Inglés sobre Sistemas Informáticos y Desarrollo de Páginas Web (Código: TDS1.4)", "Diseño de Planes de Negocios en Asociatividad Cooperativa (Código: TDS1.5)", "Diseño de Base de Datos Relacionales (Código: TDS1.6)", "Gestión de herramientas web y contenido multimedia (Código: TDS1.7)", "Desarrollo de aplicaciones de escritorio (Código: TDS1.8)", "Configuración de redes informaticas (Código: TDS1.9)", "Conversación en Inglés sobre arquitectura de software (Código: TDS1.10)", "Puesta en marcha de la microempresa en asociatica cooperativa (Código: TDS1.11)" });
            cmbMateria.Location = new Point(25, 117);
            cmbMateria.Name = "cmbMateria";
            cmbMateria.Size = new Size(321, 26);
            cmbMateria.TabIndex = 29;
            // 
            // cmbCarrera
            // 
            cmbCarrera.Anchor = AnchorStyles.None;
            cmbCarrera.BackColor = Color.FromArgb(51, 51, 51);
            cmbCarrera.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCarrera.FlatStyle = FlatStyle.Flat;
            cmbCarrera.ForeColor = Color.White;
            cmbCarrera.FormattingEnabled = true;
            cmbCarrera.ImeMode = ImeMode.NoControl;
            cmbCarrera.Items.AddRange(new object[] { "Técnico en desarrollo de software", "Ingenieria en desarrollo de software" });
            cmbCarrera.Location = new Point(26, 59);
            cmbCarrera.Name = "cmbCarrera";
            cmbCarrera.Size = new Size(321, 26);
            cmbCarrera.TabIndex = 30;
            // 
            // cmbAula
            // 
            cmbAula.Anchor = AnchorStyles.None;
            cmbAula.BackColor = Color.FromArgb(51, 51, 51);
            cmbAula.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAula.FlatStyle = FlatStyle.Flat;
            cmbAula.ForeColor = Color.White;
            cmbAula.FormattingEnabled = true;
            cmbAula.Items.AddRange(new object[] { "NA", "AULA C101", "AULA C102", "AULA C103", "COMPUTO F101", "COMPUTO F102", "COMPUTO F103" });
            cmbAula.Location = new Point(25, 173);
            cmbAula.Name = "cmbAula";
            cmbAula.Size = new Size(321, 26);
            cmbAula.TabIndex = 31;
            // 
            // dataGridView1
            // 
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 344);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1129, 372);
            dataGridView1.TabIndex = 32;
            // 
            // cmbTipo
            // 
            cmbTipo.Anchor = AnchorStyles.None;
            cmbTipo.BackColor = Color.FromArgb(51, 51, 51);
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.FlatStyle = FlatStyle.Flat;
            cmbTipo.ForeColor = Color.White;
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "(TEO) TDS122 - GRP.UNICO", "(TEO) TDS122 - GRP.A", "(TEO) TDS122 - GRP.B", "(PRA) TDS122 - GRP.UNICO", "(PRA) TDS122 - GRP.B", "(PRA) TDS122 - GRP.A" });
            cmbTipo.Location = new Point(425, 59);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(321, 26);
            cmbTipo.TabIndex = 33;
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.CustomFormat = "";
            dtpFechaInicio.Format = DateTimePickerFormat.Short;
            dtpFechaInicio.Location = new Point(425, 117);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.RightToLeft = RightToLeft.No;
            dtpFechaInicio.Size = new Size(321, 26);
            dtpFechaInicio.TabIndex = 34;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(425, 94);
            label2.Name = "label2";
            label2.Size = new Size(128, 18);
            label2.TabIndex = 35;
            label2.Text = "Fecha inicio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(425, 152);
            label3.Name = "label3";
            label3.Size = new Size(98, 18);
            label3.TabIndex = 37;
            label3.Text = "Fecha fin";
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.CustomFormat = "";
            dtpFechaFin.Format = DateTimePickerFormat.Short;
            dtpFechaFin.Location = new Point(425, 173);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.RightToLeft = RightToLeft.No;
            dtpFechaFin.Size = new Size(321, 26);
            dtpFechaFin.TabIndex = 36;
            // 
            // cmbHorario
            // 
            cmbHorario.Anchor = AnchorStyles.None;
            cmbHorario.BackColor = Color.FromArgb(51, 51, 51);
            cmbHorario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbHorario.FlatStyle = FlatStyle.Flat;
            cmbHorario.ForeColor = Color.White;
            cmbHorario.FormattingEnabled = true;
            cmbHorario.Items.AddRange(new object[] { "7:00AM-7:50AM", "7:50AM-8:40AM", "7:00AM-10:40AM", "7:00AM-12:40PM", "9:50AM-10:40AM", "11:00AM-11:50AM", "11:00AM-2:50PM", "1:10PM-4:40PM", "1:10PM-2:50PM", "3:00PM-4:40PM", "3:00PM-5:30PM" });
            cmbHorario.Location = new Point(425, 233);
            cmbHorario.Name = "cmbHorario";
            cmbHorario.Size = new Size(321, 26);
            cmbHorario.TabIndex = 38;
            // 
            // cmbDia
            // 
            cmbDia.Anchor = AnchorStyles.None;
            cmbDia.BackColor = Color.FromArgb(51, 51, 51);
            cmbDia.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDia.FlatStyle = FlatStyle.Flat;
            cmbDia.ForeColor = Color.White;
            cmbDia.FormattingEnabled = true;
            cmbDia.Items.AddRange(new object[] { "LUN", "MAR", "MIE", "JUE", "VIE", "SAB", "DOM" });
            cmbDia.Location = new Point(26, 287);
            cmbDia.Name = "cmbDia";
            cmbDia.Size = new Size(321, 26);
            cmbDia.TabIndex = 39;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(25, 38);
            label4.Name = "label4";
            label4.Size = new Size(78, 18);
            label4.TabIndex = 40;
            label4.Text = "Carrera";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(25, 96);
            label5.Name = "label5";
            label5.Size = new Size(78, 18);
            label5.TabIndex = 41;
            label5.Text = "Materia";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(25, 152);
            label6.Name = "label6";
            label6.Size = new Size(48, 18);
            label6.TabIndex = 42;
            label6.Text = "Aula";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(425, 40);
            label7.Name = "label7";
            label7.Size = new Size(108, 18);
            label7.TabIndex = 43;
            label7.Text = "Grupo/Tipo";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(425, 212);
            label8.Name = "label8";
            label8.Size = new Size(78, 18);
            label8.TabIndex = 44;
            label8.Text = "Horario";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.White;
            label9.Location = new Point(26, 266);
            label9.Name = "label9";
            label9.Size = new Size(38, 18);
            label9.TabIndex = 45;
            label9.Text = "Dia";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(26, 212);
            label1.Name = "label1";
            label1.Size = new Size(78, 18);
            label1.TabIndex = 47;
            label1.Text = "Docente";
            // 
            // txtDocente
            // 
            txtDocente.Anchor = AnchorStyles.None;
            txtDocente.BackColor = Color.FromArgb(51, 51, 51);
            txtDocente.DropDownStyle = ComboBoxStyle.DropDownList;
            txtDocente.FlatStyle = FlatStyle.Flat;
            txtDocente.ForeColor = Color.White;
            txtDocente.FormattingEnabled = true;
            txtDocente.Items.AddRange(new object[] { "NA", "AULA C101", "AULA C102", "AULA C103", "COMPUTO F101", "COMPUTO F102", "COMPUTO F103" });
            txtDocente.Location = new Point(26, 233);
            txtDocente.Name = "txtDocente";
            txtDocente.Size = new Size(321, 26);
            txtDocente.TabIndex = 46;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            button2.FlatAppearance.MouseOverBackColor = Color.Silver;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Liberation Mono", 12F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(809, 262);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(333, 75);
            button2.TabIndex = 62;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            button1.FlatAppearance.MouseOverBackColor = Color.Silver;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Liberation Mono", 12F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(809, 179);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(333, 75);
            button1.TabIndex = 61;
            button1.Text = "Modificar";
            button1.UseVisualStyleBackColor = true;
            // 
            // añadirForm
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 51, 51);
            ClientSize = new Size(1178, 737);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(txtDocente);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(cmbDia);
            Controls.Add(cmbHorario);
            Controls.Add(label3);
            Controls.Add(dtpFechaFin);
            Controls.Add(label2);
            Controls.Add(dtpFechaInicio);
            Controls.Add(cmbTipo);
            Controls.Add(dataGridView1);
            Controls.Add(cmbAula);
            Controls.Add(cmbCarrera);
            Controls.Add(cmbMateria);
            Controls.Add(btnAñadirMateria);
            Font = new Font("Liberation Mono", 12F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "añadirForm";
            Text = "añadirForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAñadirMateria;
        private ComboBox cmbMateria;
        private ComboBox cmbCarrera;
        private ComboBox cmbAula;
        private DataGridView dataGridView1;
        private ComboBox cmbTipo;
        private DateTimePicker dtpFechaInicio;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpFechaFin;
        private ComboBox cmbHorario;
        private ComboBox cmbDia;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label1;
        private ComboBox txtDocente;
        private Button button2;
        private Button button1;
    }
}