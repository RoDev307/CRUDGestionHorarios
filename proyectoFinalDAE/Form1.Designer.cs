namespace proyectoFinalDAE
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            txtUsuario = new TextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            txtContraseña = new TextBox();
            label1 = new Label();
            btnAcceder = new Button();
            ptrClose = new PictureBox();
            pcrMinimize = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptrClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcrMinimize).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(38, 39, 39);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 330);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(62, 167);
            label2.Name = "label2";
            label2.Size = new Size(103, 31);
            label2.TabIndex = 7;
            label2.Text = "Tempo";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(62, 68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(96, 96);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(38, 39, 39);
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Liberation Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.ForeColor = Color.White;
            txtUsuario.Location = new Point(315, 89);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(410, 19);
            txtUsuario.TabIndex = 1;
            txtUsuario.Text = "USUARIO";
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Enabled = false;
            panel2.Location = new Point(316, 114);
            panel2.Name = "panel2";
            panel2.Size = new Size(410, 2);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.Enabled = false;
            panel3.Location = new Point(317, 204);
            panel3.Name = "panel3";
            panel3.Size = new Size(410, 2);
            panel3.TabIndex = 5;
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = Color.FromArgb(38, 39, 39);
            txtContraseña.BorderStyle = BorderStyle.None;
            txtContraseña.Font = new Font("Liberation Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContraseña.ForeColor = Color.White;
            txtContraseña.Location = new Point(316, 179);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(410, 19);
            txtContraseña.TabIndex = 4;
            txtContraseña.Text = "CONTRASEÑA";
            txtContraseña.Enter += txtContraseña_Enter;
            txtContraseña.Leave += txtContraseña_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(470, 9);
            label1.Name = "label1";
            label1.Size = new Size(85, 31);
            label1.TabIndex = 6;
            label1.Text = "Login";
            // 
            // btnAcceder
            // 
            btnAcceder.FlatAppearance.BorderSize = 0;
            btnAcceder.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            btnAcceder.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnAcceder.FlatStyle = FlatStyle.Flat;
            btnAcceder.Font = new Font("Liberation Mono", 12F);
            btnAcceder.ForeColor = Color.White;
            btnAcceder.Location = new Point(315, 238);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(412, 56);
            btnAcceder.TabIndex = 7;
            btnAcceder.Text = "ACCEDER";
            btnAcceder.UseVisualStyleBackColor = true;
            btnAcceder.Click += btnAcceder_Click;
            // 
            // ptrClose
            // 
            ptrClose.Image = Properties.Resources.icons8_close_window_50;
            ptrClose.Location = new Point(729, 0);
            ptrClose.Name = "ptrClose";
            ptrClose.Size = new Size(50, 50);
            ptrClose.SizeMode = PictureBoxSizeMode.AutoSize;
            ptrClose.TabIndex = 8;
            ptrClose.TabStop = false;
            ptrClose.Click += ptrClose_Click;
            ptrClose.MouseEnter += ptrClose_MouseEnter;
            ptrClose.MouseLeave += ptrClose_MouseLeave;
            // 
            // pcrMinimize
            // 
            pcrMinimize.Image = Properties.Resources.icons8_minimize_window_50;
            pcrMinimize.Location = new Point(680, 0);
            pcrMinimize.Name = "pcrMinimize";
            pcrMinimize.Size = new Size(50, 50);
            pcrMinimize.SizeMode = PictureBoxSizeMode.AutoSize;
            pcrMinimize.TabIndex = 9;
            pcrMinimize.TabStop = false;
            pcrMinimize.Click += pcrMinimize_Click;
            pcrMinimize.MouseEnter += pcrMinimize_MouseEnter;
            pcrMinimize.MouseLeave += pcrMinimize_MouseLeave;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(38, 39, 39);
            ClientSize = new Size(780, 330);
            Controls.Add(pcrMinimize);
            Controls.Add(ptrClose);
            Controls.Add(btnAcceder);
            Controls.Add(label1);
            Controls.Add(panel3);
            Controls.Add(txtContraseña);
            Controls.Add(panel2);
            Controls.Add(txtUsuario);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(780, 330);
            MinimumSize = new Size(780, 330);
            Name = "Form1";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            MouseDown += Form1_MouseDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptrClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcrMinimize).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txtUsuario;
        private Panel panel2;
        private Panel panel3;
        private TextBox txtContraseña;
        private Label label1;
        private Button btnAcceder;
        private PictureBox ptrClose;
        private PictureBox pcrMinimize;
        private PictureBox pictureBox1;
        private Label label2;
    }
}
