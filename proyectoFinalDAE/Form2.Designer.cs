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
            Button btnModificar;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            pcrMinimize = new PictureBox();
            ptrClose = new PictureBox();
            panel1 = new Panel();
            btnReporte = new Button();
            btnEliminar = new Button();
            btnAñadir = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnModificar = new Button();
            ((System.ComponentModel.ISupportInitialize)pcrMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptrClose).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnModificar
            // 
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            btnModificar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Liberation Mono", 12F);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(3, 232);
            btnModificar.Margin = new Padding(3, 4, 3, 4);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(244, 75);
            btnModificar.TabIndex = 26;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // pcrMinimize
            // 
            pcrMinimize.Image = (Image)resources.GetObject("pcrMinimize.Image");
            pcrMinimize.Location = new Point(1324, 0);
            pcrMinimize.Name = "pcrMinimize";
            pcrMinimize.Size = new Size(50, 50);
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
            ptrClose.TabIndex = 10;
            ptrClose.TabStop = false;
            ptrClose.Click += ptrClose_Click;
            ptrClose.MouseEnter += ptrClose_MouseEnter;
            ptrClose.MouseLeave += ptrClose_MouseLeave;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(153, 153, 153);
            panel1.Controls.Add(btnReporte);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnModificar);
            panel1.Controls.Add(btnAñadir);
            panel1.Controls.Add(panel2);
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
            btnReporte.Location = new Point(3, 398);
            btnReporte.Margin = new Padding(3, 4, 3, 4);
            btnReporte.Name = "btnReporte";
            btnReporte.Size = new Size(244, 75);
            btnReporte.TabIndex = 28;
            btnReporte.Text = "Reporte";
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
            btnEliminar.Location = new Point(3, 315);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(244, 75);
            btnEliminar.TabIndex = 27;
            btnEliminar.Text = "Eliminar";
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
            btnAñadir.Location = new Point(3, 149);
            btnAñadir.Margin = new Padding(3, 4, 3, 4);
            btnAñadir.Name = "btnAñadir";
            btnAñadir.Size = new Size(244, 75);
            btnAñadir.TabIndex = 25;
            btnAñadir.Text = "Añadir";
            btnAñadir.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Enabled = false;
            panel2.Location = new Point(247, 110);
            panel2.Name = "panel2";
            panel2.Size = new Size(922, 2);
            panel2.TabIndex = 15;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(72, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(686, 9);
            label1.Name = "label1";
            label1.Size = new Size(332, 39);
            label1.TabIndex = 7;
            label1.Text = "Gestión de horarios";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 51, 51);
            ClientSize = new Size(1431, 793);
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
            MouseDown += Form2_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pcrMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptrClose).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcrMinimize;
        private PictureBox ptrClose;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button btnReporte;
        private Button btnEliminar;
        private Button btnAñadir;
    }
}