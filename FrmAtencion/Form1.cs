namespace FrmAtencion
{
    using Consulta;
    using Persona;
    using PersonalMedico;
    using Paciente;
    public partial class FrmAtencion : Form
    {
        public FrmAtencion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmAtencion_Load(object sender, EventArgs e)
        {
            lstMedicos.Items.Add(new PersonalMedico("Gustavo", "Rivas", new DateTime(1999, 12, 12), false));
            lstMedicos.Items.Add(new PersonalMedico("Lautaro", "Galarza", new DateTime(1951, 11, 12), true));
            lstPacientes.Items.Add(new Paciente("Mathias", "Bustamante", new DateTime(1998, 6, 16), "Tigre"));
            lstPacientes.Items.Add(new Paciente("Lucas", "Ferrini", new DateTime(1989, 1, 21), "DF"));
            lstPacientes.Items.Add(new Paciente("Lucas", "Rodriguez", new DateTime(1912, 12, 12), "LaBoca"));
            lstPacientes.Items.Add(new Paciente("John Jairo", "Trelles", new DateTime(1978, 8, 30), "Medellin"));
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            PersonalMedico medico1 = lstMedicos.SelectedItem as PersonalMedico;
            Paciente paciente1 = lstPacientes.SelectedItem as Paciente;

            if (medico1 is null || paciente1 is null)
            {
                MessageBox.Show("Debe seleccionar un Medico y un Paciente para poder continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Consulta nuevaConsulta = medico1 + paciente1;
                MessageBox.Show(nuevaConsulta.ToString(), "Atención Finalizada", MessageBoxButtons.OK);
                lstMedicos.SelectedIndex = -1;
                lstPacientes.SelectedIndex = -1;
            }

        }

        private void FrmAtencion_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = MessageBox.Show("¿Está seguro de cerrar el programa?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            PersonalMedico medico1 = lstMedicos.SelectedItem as PersonalMedico;

            if (medico1 is not null)
            {
                rtbInfoMedico.Text = medico1.ObtenerFichaExtra;
            }

        }
    }
}
