using proyectoFinalDAE.Clases;
using proyectoFinalDAE.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoFinalDAE
{
    public partial class añadirDocente : Form
    {
        Gestor gest = new Gestor();
        public añadirDocente()
        {
            InitializeComponent();
        }

        private void btnAñadirMateria_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrWhiteSpace(txtNombreDocente.Text) || string.IsNullOrWhiteSpace(txtApellidos.Text) || 
                    string.IsNullOrWhiteSpace(txtDireccion.Text) || string.IsNullOrWhiteSpace(txtTelefono.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string nombres = txtNombreDocente.Text;
                string apellidos = txtApellidos.Text;
                string direccion = txtDireccion.Text;
                string telefono = txtTelefono.Text;
                string nivelAcademico = cmbNivelAcademico.Text;
                string tipo = cmbTipo.Text;
                string horariosDisp = cmbHorariosDisp.Text;
                Docente docente = new Docente()
                {
                    Nombres = nombres,
                    Apellidos = apellidos,
                    Direccion = direccion,
                    Telefono = telefono,
                    NivelAcademico = nivelAcademico,
                    TipoDocente = tipo,
                    HorariosDisponibles = horariosDisp,
                };
                gest.agregar(docente);
                MessageBox.Show("Docente agregado correctamente");
                CargarDatosDocentes();
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void añadirDocente_Load(object sender, EventArgs e)
        {
            CargarDatosDocentes();
        }
        public void CargarDatosDocentes()
        {
            dataGridViewDocentes.DataSource = null;
            dataGridViewDocentes.DataSource = gest.listarDocentes();
            dataGridViewDocentes.ClearSelection();
        }
    }
}
