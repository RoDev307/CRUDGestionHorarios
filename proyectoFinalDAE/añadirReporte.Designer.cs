namespace proyectoFinalDAE
{
    partial class añadirReporte
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
            label4 = new Label();
            cmbCarrera = new ComboBox();
            label2 = new Label();
            dtpFechaInicio = new DateTimePicker();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            comboBox2 = new ComboBox();
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
            btnAñadirMateria.Location = new Point(436, 572);
            btnAñadirMateria.Margin = new Padding(3, 4, 3, 4);
            btnAñadirMateria.Name = "btnAñadirMateria";
            btnAñadirMateria.Size = new Size(333, 75);
            btnAñadirMateria.TabIndex = 54;
            btnAñadirMateria.Text = "Generar reporte";
            btnAñadirMateria.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(193, 170);
            label4.Name = "label4";
            label4.Size = new Size(158, 18);
            label4.TabIndex = 68;
            label4.Text = "Tipo de reporte";
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
            cmbCarrera.Location = new Point(194, 191);
            cmbCarrera.Name = "cmbCarrera";
            cmbCarrera.Size = new Size(765, 26);
            cmbCarrera.TabIndex = 67;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(193, 226);
            label2.Name = "label2";
            label2.Size = new Size(58, 18);
            label2.TabIndex = 70;
            label2.Text = "Desde";
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.CustomFormat = "";
            dtpFechaInicio.Format = DateTimePickerFormat.Short;
            dtpFechaInicio.Location = new Point(193, 249);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.RightToLeft = RightToLeft.No;
            dtpFechaInicio.Size = new Size(765, 26);
            dtpFechaInicio.TabIndex = 69;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(193, 286);
            label1.Name = "label1";
            label1.Size = new Size(68, 18);
            label1.TabIndex = 72;
            label1.Text = "Filtro";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.None;
            comboBox1.BackColor = Color.FromArgb(51, 51, 51);
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.ForeColor = Color.White;
            comboBox1.FormattingEnabled = true;
            comboBox1.ImeMode = ImeMode.NoControl;
            comboBox1.Items.AddRange(new object[] { "Técnico en desarrollo de software", "Ingenieria en desarrollo de software" });
            comboBox1.Location = new Point(194, 307);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(765, 26);
            comboBox1.TabIndex = 71;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(192, 348);
            label3.Name = "label3";
            label3.Size = new Size(78, 18);
            label3.TabIndex = 74;
            label3.Text = "Formato";
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.None;
            comboBox2.BackColor = Color.FromArgb(51, 51, 51);
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FlatStyle = FlatStyle.Flat;
            comboBox2.ForeColor = Color.White;
            comboBox2.FormattingEnabled = true;
            comboBox2.ImeMode = ImeMode.NoControl;
            comboBox2.Items.AddRange(new object[] { "Técnico en desarrollo de software", "Ingenieria en desarrollo de software" });
            comboBox2.Location = new Point(193, 369);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(765, 26);
            comboBox2.TabIndex = 73;
            // 
            // añadirReporte
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 51, 51);
            ClientSize = new Size(1178, 737);
            Controls.Add(label3);
            Controls.Add(comboBox2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(dtpFechaInicio);
            Controls.Add(label4);
            Controls.Add(cmbCarrera);
            Controls.Add(btnAñadirMateria);
            Font = new Font("Liberation Mono", 12F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
            Name = "añadirReporte";
            Text = "añadirReporte";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAñadirMateria;
        private Label label4;
        private ComboBox cmbCarrera;
        private Label label2;
        private DateTimePicker dtpFechaInicio;
        private Label label1;
        private ComboBox comboBox1;
        private Label label3;
        private ComboBox comboBox2;
    }
}