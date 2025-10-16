namespace proyectoFinalDAE
{
    partial class Form2
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
            Button btnInicio;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            pcrMinimize = new PictureBox();
            ptrClose = new PictureBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnCarrerasInicio = new Button();
            btnMateriaInicio = new Button();
            btnReporteInicio = new Button();
            btnAulaInicio = new Button();
            btnDocentes = new Button();
            btnAñadir = new Button();
            label1 = new Label();
            mainPanel = new Panel();
            label2 = new Label();
            btnInicio = new Button();
            ((System.ComponentModel.ISupportInitialize)pcrMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptrClose).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // btnInicio
            // 
            btnInicio.Anchor = AnchorStyles.None;
            btnInicio.BackColor = Color.FromArgb(206, 146, 18);
            btnInicio.BackgroundImageLayout = ImageLayout.Zoom;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatAppearance.MouseDownBackColor = Color.FromArgb(176, 41, 28);
            btnInicio.FlatAppearance.MouseOverBackColor = Color.FromArgb(176, 41, 28);
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Liberation Mono", 12F);
            btnInicio.ForeColor = Color.White;
            btnInicio.Location = new Point(3, 107);
            btnInicio.Margin = new Padding(3, 4, 3, 4);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(244, 75);
            btnInicio.TabIndex = 26;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // pcrMinimize
            // 
            pcrMinimize.Image = Properties.Resources.icons8_minimize_window_50;
            pcrMinimize.Location = new Point(1330, 0);
            pcrMinimize.Name = "pcrMinimize";
            pcrMinimize.Size = new Size(50, 50);
            pcrMinimize.SizeMode = PictureBoxSizeMode.AutoSize;
            pcrMinimize.TabIndex = 11;
            pcrMinimize.TabStop = false;
            pcrMinimize.Click += pcrMinimize_Click;
            pcrMinimize.MouseEnter += pcrMinimize_MouseEnter;
            pcrMinimize.MouseLeave += pcrMinimize_MouseLeave;
            pcrMinimize.MouseHover += pcrMinimize_MouseHover;
            // 
            // ptrClose
            // 
            ptrClose.Image = Properties.Resources.icons8_close_window_50;
            ptrClose.Location = new Point(1378, 0);
            ptrClose.Name = "ptrClose";
            ptrClose.Size = new Size(50, 50);
            ptrClose.SizeMode = PictureBoxSizeMode.AutoSize;
            ptrClose.TabIndex = 10;
            ptrClose.TabStop = false;
            ptrClose.Click += ptrClose_Click;
            ptrClose.MouseEnter += ptrClose_MouseEnter;
            ptrClose.MouseLeave += ptrClose_MouseLeave;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(206, 146, 18);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnCarrerasInicio);
            panel1.Controls.Add(btnMateriaInicio);
            panel1.Controls.Add(btnReporteInicio);
            panel1.Controls.Add(btnAulaInicio);
            panel1.Controls.Add(btnDocentes);
            panel1.Controls.Add(btnInicio);
            panel1.Controls.Add(btnAñadir);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 793);
            panel1.TabIndex = 12;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(241, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnCarrerasInicio
            // 
            btnCarrerasInicio.BackColor = Color.FromArgb(206, 146, 18);
            btnCarrerasInicio.FlatAppearance.BorderSize = 0;
            btnCarrerasInicio.FlatAppearance.MouseDownBackColor = Color.FromArgb(176, 41, 28);
            btnCarrerasInicio.FlatAppearance.MouseOverBackColor = Color.FromArgb(176, 41, 28);
            btnCarrerasInicio.FlatStyle = FlatStyle.Flat;
            btnCarrerasInicio.Font = new Font("Liberation Mono", 12F);
            btnCarrerasInicio.ForeColor = Color.White;
            btnCarrerasInicio.Location = new Point(3, 356);
            btnCarrerasInicio.Margin = new Padding(3, 4, 3, 4);
            btnCarrerasInicio.Name = "btnCarrerasInicio";
            btnCarrerasInicio.Size = new Size(244, 75);
            btnCarrerasInicio.TabIndex = 30;
            btnCarrerasInicio.Text = "Carreras";
            btnCarrerasInicio.UseVisualStyleBackColor = false;
            btnCarrerasInicio.Click += btnCarrerasInicio_Click;
            // 
            // btnMateriaInicio
            // 
            btnMateriaInicio.BackColor = Color.FromArgb(206, 146, 18);
            btnMateriaInicio.FlatAppearance.BorderSize = 0;
            btnMateriaInicio.FlatAppearance.MouseDownBackColor = Color.FromArgb(176, 41, 28);
            btnMateriaInicio.FlatAppearance.MouseOverBackColor = Color.FromArgb(176, 41, 28);
            btnMateriaInicio.FlatStyle = FlatStyle.Flat;
            btnMateriaInicio.Font = new Font("Liberation Mono", 12F);
            btnMateriaInicio.ForeColor = Color.White;
            btnMateriaInicio.Location = new Point(3, 273);
            btnMateriaInicio.Margin = new Padding(3, 4, 3, 4);
            btnMateriaInicio.Name = "btnMateriaInicio";
            btnMateriaInicio.Size = new Size(244, 75);
            btnMateriaInicio.TabIndex = 29;
            btnMateriaInicio.Text = "Materias";
            btnMateriaInicio.UseVisualStyleBackColor = false;
            btnMateriaInicio.Click += btnMateriaInicio_Click;
            // 
            // btnReporteInicio
            // 
            btnReporteInicio.BackColor = Color.FromArgb(206, 146, 18);
            btnReporteInicio.FlatAppearance.BorderSize = 0;
            btnReporteInicio.FlatAppearance.MouseDownBackColor = Color.FromArgb(176, 41, 28);
            btnReporteInicio.FlatAppearance.MouseOverBackColor = Color.FromArgb(176, 41, 28);
            btnReporteInicio.FlatStyle = FlatStyle.Flat;
            btnReporteInicio.Font = new Font("Liberation Mono", 12F);
            btnReporteInicio.ForeColor = Color.White;
            btnReporteInicio.Location = new Point(3, 603);
            btnReporteInicio.Margin = new Padding(3, 4, 3, 4);
            btnReporteInicio.Name = "btnReporteInicio";
            btnReporteInicio.Size = new Size(244, 75);
            btnReporteInicio.TabIndex = 28;
            btnReporteInicio.Text = "Reporte";
            btnReporteInicio.UseVisualStyleBackColor = false;
            btnReporteInicio.Click += btnReporteInicio_Click;
            // 
            // btnAulaInicio
            // 
            btnAulaInicio.BackColor = Color.FromArgb(206, 146, 18);
            btnAulaInicio.FlatAppearance.BorderSize = 0;
            btnAulaInicio.FlatAppearance.MouseDownBackColor = Color.FromArgb(176, 41, 28);
            btnAulaInicio.FlatAppearance.MouseOverBackColor = Color.FromArgb(176, 41, 28);
            btnAulaInicio.FlatStyle = FlatStyle.Flat;
            btnAulaInicio.Font = new Font("Liberation Mono", 12F);
            btnAulaInicio.ForeColor = Color.White;
            btnAulaInicio.Location = new Point(3, 520);
            btnAulaInicio.Margin = new Padding(3, 4, 3, 4);
            btnAulaInicio.Name = "btnAulaInicio";
            btnAulaInicio.Size = new Size(244, 75);
            btnAulaInicio.TabIndex = 28;
            btnAulaInicio.Text = "Aula";
            btnAulaInicio.UseVisualStyleBackColor = false;
            btnAulaInicio.Click += btnAulaInicio_Click;
            // 
            // btnDocentes
            // 
            btnDocentes.BackColor = Color.FromArgb(206, 146, 18);
            btnDocentes.FlatAppearance.BorderSize = 0;
            btnDocentes.FlatAppearance.MouseDownBackColor = Color.FromArgb(176, 41, 28);
            btnDocentes.FlatAppearance.MouseOverBackColor = Color.FromArgb(176, 41, 28);
            btnDocentes.FlatStyle = FlatStyle.Flat;
            btnDocentes.Font = new Font("Liberation Mono", 12F);
            btnDocentes.ForeColor = Color.White;
            btnDocentes.Location = new Point(3, 190);
            btnDocentes.Margin = new Padding(3, 4, 3, 4);
            btnDocentes.Name = "btnDocentes";
            btnDocentes.Size = new Size(244, 75);
            btnDocentes.TabIndex = 27;
            btnDocentes.Text = "Docentes";
            btnDocentes.UseVisualStyleBackColor = false;
            btnDocentes.Click += btnEliminar_Click;
            // 
            // btnAñadir
            // 
            btnAñadir.BackColor = Color.FromArgb(206, 146, 18);
            btnAñadir.FlatAppearance.BorderSize = 0;
            btnAñadir.FlatAppearance.MouseDownBackColor = Color.FromArgb(176, 41, 28);
            btnAñadir.FlatAppearance.MouseOverBackColor = Color.FromArgb(176, 41, 28);
            btnAñadir.FlatStyle = FlatStyle.Flat;
            btnAñadir.Font = new Font("Liberation Mono", 12F);
            btnAñadir.ForeColor = Color.White;
            btnAñadir.Location = new Point(3, 439);
            btnAñadir.Margin = new Padding(3, 4, 3, 4);
            btnAñadir.Name = "btnAñadir";
            btnAñadir.Size = new Size(244, 75);
            btnAñadir.TabIndex = 25;
            btnAñadir.Text = "Horario";
            btnAñadir.UseVisualStyleBackColor = false;
            btnAñadir.Click += btnAñadir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(686, 9);
            label1.Name = "label1";
            label1.Size = new Size(269, 31);
            label1.TabIndex = 7;
            label1.Text = "Gestión de horarios";
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.WhiteSmoke;
            mainPanel.Controls.Add(label2);
            mainPanel.Location = new Point(250, 56);
            mainPanel.MaximumSize = new Size(1178, 737);
            mainPanel.MinimumSize = new Size(1178, 737);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1178, 737);
            mainPanel.TabIndex = 13;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(324, 93);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(449, 31);
            label2.TabIndex = 31;
            label2.Text = "Aca se mostraran todos las forms";
            // 
            // Form2
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(235, 210, 153);
            ClientSize = new Size(1431, 793);
            Controls.Add(mainPanel);
            Controls.Add(ptrClose);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(pcrMinimize);
            Font = new Font("Liberation Mono", 12F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            MaximumSize = new Size(1431, 793);
            MinimumSize = new Size(1431, 793);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            MouseDown += Form2_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pcrMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptrClose).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcrMinimize;
        private PictureBox ptrClose;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnAulaInicio;
        private Button btnDocentes;
        private Button btnAñadir;
        private Panel mainPanel;
        private Button btnCarrerasInicio;
        private Button btnMateriaInicio;
        private Button btnReporteInicio;
        private Button button3;
        private Label label2;
    }
}