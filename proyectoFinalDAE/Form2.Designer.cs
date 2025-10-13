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
            btnReporte = new Button();
            btnEliminar = new Button();
            btnAñadir = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            mainPanel = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
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
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            btnInicio.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Liberation Mono", 12F);
            btnInicio.ForeColor = Color.White;
            btnInicio.Location = new Point(3, 149);
            btnInicio.Margin = new Padding(3, 4, 3, 4);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(244, 75);
            btnInicio.TabIndex = 26;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = true;
            // 
            // pcrMinimize
            // 
            pcrMinimize.Image = (Image)resources.GetObject("pcrMinimize.Image");
            pcrMinimize.Location = new Point(1324, 0);
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
            ptrClose.Image = (Image)resources.GetObject("ptrClose.Image");
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
            panel1.BackColor = Color.FromArgb(38, 39, 39);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(btnReporte);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(btnInicio);
            panel1.Controls.Add(btnAñadir);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 793);
            panel1.TabIndex = 12;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // btnReporte
            // 
            btnReporte.FlatAppearance.BorderSize = 0;
            btnReporte.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            btnReporte.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnReporte.FlatStyle = FlatStyle.Flat;
            btnReporte.Font = new Font("Liberation Mono", 12F);
            btnReporte.ForeColor = Color.White;
            btnReporte.Location = new Point(3, 564);
            btnReporte.Margin = new Padding(3, 4, 3, 4);
            btnReporte.Name = "btnReporte";
            btnReporte.Size = new Size(244, 75);
            btnReporte.TabIndex = 28;
            btnReporte.Text = "Aula";
            btnReporte.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            btnEliminar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Liberation Mono", 12F);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(3, 232);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(244, 75);
            btnEliminar.TabIndex = 27;
            btnEliminar.Text = "Docentes";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnAñadir
            // 
            btnAñadir.FlatAppearance.BorderSize = 0;
            btnAñadir.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            btnAñadir.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnAñadir.FlatStyle = FlatStyle.Flat;
            btnAñadir.Font = new Font("Liberation Mono", 12F);
            btnAñadir.ForeColor = Color.White;
            btnAñadir.Location = new Point(3, 481);
            btnAñadir.Margin = new Padding(3, 4, 3, 4);
            btnAñadir.Name = "btnAñadir";
            btnAñadir.Size = new Size(244, 75);
            btnAñadir.TabIndex = 25;
            btnAñadir.Text = "Horario";
            btnAñadir.UseVisualStyleBackColor = true;
            btnAñadir.Click += btnAñadir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(73, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(686, 9);
            label1.Name = "label1";
            label1.Size = new Size(269, 31);
            label1.TabIndex = 7;
            label1.Text = "Gestión de horarios";
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(51, 51, 51);
            mainPanel.Controls.Add(label2);
            mainPanel.Location = new Point(250, 56);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1178, 737);
            mainPanel.TabIndex = 13;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            button1.FlatAppearance.MouseOverBackColor = Color.Silver;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Liberation Mono", 12F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(3, 315);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(244, 75);
            button1.TabIndex = 29;
            button1.Text = "Materias";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            button2.FlatAppearance.MouseOverBackColor = Color.Silver;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Liberation Mono", 12F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(3, 398);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(244, 75);
            button2.TabIndex = 30;
            button2.Text = "Carreras";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            button3.FlatAppearance.MouseOverBackColor = Color.Silver;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Liberation Mono", 12F);
            button3.ForeColor = Color.White;
            button3.Location = new Point(3, 562);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(244, 75);
            button3.TabIndex = 25;
            button3.Text = "Horario";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnAñadir_Click;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            button4.FlatAppearance.MouseOverBackColor = Color.Silver;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Liberation Mono", 12F);
            button4.ForeColor = Color.White;
            button4.Location = new Point(3, 645);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(244, 75);
            button4.TabIndex = 28;
            button4.Text = "Reporte";
            button4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(324, 93);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(449, 31);
            label2.TabIndex = 31;
            label2.Text = "Aca se mostraran todos las forms";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(38, 39, 39);
            ClientSize = new Size(1431, 793);
            Controls.Add(mainPanel);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(pcrMinimize);
            Controls.Add(ptrClose);
            Font = new Font("Liberation Mono", 12F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            MouseDown += Form2_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pcrMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptrClose).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Button btnReporte;
        private Button btnEliminar;
        private Button btnAñadir;
        private Panel mainPanel;
        private Button button2;
        private Button button1;
        private Button button4;
        private Button button3;
        private Label label2;
    }
}