using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FRMEmpanada : Form
    {
        Principal principal = new Principal();
        public FRMEmpanada()
        {
            InitializeComponent();
        }

        private void FRMEmpanada_Load(object sender, EventArgs e)
        {
            dataGridViewEmpanada.DataSource = null;
            dataGridViewEmpanada.DataSource = principal.ValidarEmpanada();
        }

        private void modifempanada_Click(object sender, EventArgs e)
        {
            FRMModificarEmpanada empanadaModificada = new FRMModificarEmpanada();
            foreach (DataGridViewRow indice in dataGridViewEmpanada.SelectedRows)
            {
                int idEmpanadaModificada = Convert.ToInt32(indice.Cells[0].Value);

                empanadaModificada.textBIdEmpaM.Text = idEmpanadaModificada.ToString();
                empanadaModificada.textBPrecioEmpaM.Text = indice.Cells[1].Value.ToString();
                empanadaModificada.txtBGustoEmpaM.Text = indice.Cells [2].Value.ToString();

            }
            empanadaModificada.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRMMenu irMenu = new FRMMenu();
            irMenu.Show();
            this.Hide();
        }

        private void borrarempanada_Click(object sender, EventArgs e)
        {
            FRMBorrarEmpanada irBorrarEmpanada = new FRMBorrarEmpanada();
            irBorrarEmpanada.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int idempanada = int.Parse(textBoxConsulta.Text);
            dataGridViewEmpanada.DataSource = principal.BuscarEmpanadaPorId(idempanada);
        }
    }
}
