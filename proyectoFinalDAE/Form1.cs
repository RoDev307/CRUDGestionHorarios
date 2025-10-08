using System.Runtime.InteropServices;
namespace proyectoFinalDAE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "CONTRASEÑA")
            {
                txtContraseña.Text = "";
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void ptrClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pcrMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Admin" && txtContraseña.Text == "wea123")
            {
                MessageBox.Show("¡Bienvenido al sistema!");
                this.Hide();
                Form2 mainMenu = new Form2();
                mainMenu.Show();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese usuario y contraseña válidos.");
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void pcrMinimize_MouseEnter(object sender, EventArgs e)
        {
            pcrMinimize.BackColor = Color.FromArgb(153, 153, 153);
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
    }
}
