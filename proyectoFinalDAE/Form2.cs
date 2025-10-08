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
            pcrMinimize.BackColor = Color.FromArgb(51, 51, 51);
        }

        private void ptrClose_MouseEnter(object sender, EventArgs e)
        {
            ptrClose.BackColor = Color.FromArgb(153, 153, 153);
        }

        private void ptrClose_MouseLeave(object sender, EventArgs e)
        {
            ptrClose.BackColor = Color.FromArgb(51, 51, 51);
        }

        private void pcrMinimize_MouseEnter(object sender, EventArgs e)
        {
            pcrMinimize.BackColor = Color.FromArgb(153, 153, 153);
        }
    }
}
