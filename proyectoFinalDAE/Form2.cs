using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace proyectoFinalDAE
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void ptrClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pcrMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pcrMinimize_MouseHover(object sender, EventArgs e)
        {

        }

        private void pcrMinimize_MouseLeave(object sender, EventArgs e)
        {
            pcrMinimize.BackColor = Color.FromArgb(38, 39, 39);
        }

        private void ptrClose_MouseEnter(object sender, EventArgs e)
        {
            ptrClose.BackColor = Color.FromArgb(51, 51, 51);
        }

        private void ptrClose_MouseLeave(object sender, EventArgs e)
        {
            ptrClose.BackColor = Color.FromArgb(38, 39, 39);
        }

        private void pcrMinimize_MouseEnter(object sender, EventArgs e)
        {
            pcrMinimize.BackColor = Color.FromArgb(51, 51, 51);
        }
        public void loadForm(object Form)
        {
            if (this.mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.RemoveAt(0);
            Form fh = Form as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(fh);
            this.mainPanel.Tag = fh;
            fh.Show();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            loadForm(new añadirForm());
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            loadForm(new formInicio());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            loadForm(new formInicio());
        }
    }
}
