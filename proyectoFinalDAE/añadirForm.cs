using proyectoFinalDAE.Clases;
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
    public partial class añadirForm : Form
    {
        List<Materia> listaMaterias = new List<Materia>();
        public añadirForm()
        {
            InitializeComponent();
        }

        private void btnAñadirMateria_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(cmbAula.Text) || string.IsNullOrWhiteSpace(cmbCarrera.Text) || string.IsNullOrWhiteSpace(cmbDocente.Text)
                    || string.IsNullOrWhiteSpace(cmbTipo.Text) || string.IsNullOrWhiteSpace(cmbHorario.Text) || string.IsNullOrWhiteSpace(cmbMateria.Text)
                    || string.IsNullOrWhiteSpace(cmbDia.Text) || string.IsNullOrWhiteSpace(dtpFechaInicio.Text) || string.IsNullOrWhiteSpace(dtpFechaFin.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Campos incompletos",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string carrera = cmbCarrera.Text;
                string materia = cmbMateria.Text;
                string aula = cmbAula.Text;
                string docente = cmbDocente.Text;
                string grupo = cmbTipo.Text;
                string fechaInicio = dtpFechaInicio.Text;
                string fechaFin = dtpFechaFin.Text;
                string horario = cmbHorario.Text;
                string dia = cmbDia.Text;
                Materia nuevaMateria = new Materia(materia, carrera, grupo, docente, fechaInicio, fechaFin, dia, horario, aula);
                listaMaterias.Add(nuevaMateria);
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = listaMaterias;
                MessageBox.Show("Materia añadida correctamente.", "ÉXITO",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbCarrera.SelectedIndex = -1;
                cmbMateria.SelectedIndex = -1;
                cmbAula.SelectedIndex = -1;
                cmbDocente.SelectedIndex = -1;
                cmbTipo.SelectedIndex = -1;
                dtpFechaInicio.Value = DateTime.Now;
                dtpFechaFin.Value = DateTime.Now;
                cmbHorario.SelectedIndex = -1;
                cmbDia.SelectedIndex = -1;
                cmbAula.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void añadirForm_Load(object sender, EventArgs e)
        {

        }
    }
}
