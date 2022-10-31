using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace Vista
{
    public partial class FRMClientes : Form
    {
        public FRMClientes()
        {
            InitializeComponent();
        }
        Principal principal = new Principal();
        private void button1_Click(object sender, EventArgs e)
        {
            FRMMenu irMenu = new FRMMenu();
            irMenu.Show();
            this.Hide();
        }

        private void FRMClientes_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = principal.ValidarCliente();
        }

        private void modifcliente_Click(object sender, EventArgs e)
        {
            FRMModificarCliente clienteModificado = new FRMModificarCliente();
            foreach (DataGridViewRow indice in dataGridView1.SelectedRows)
            {
                int idClienteModificado = Convert.ToInt32(indice.Cells[0].Value);

                clienteModificado.txtBIdM.Text = idClienteModificado.ToString();
                clienteModificado.txtBApellidoM.Text = indice.Cells[3].Value.ToString();
                clienteModificado.txtBNombreM.Text = indice.Cells[2].Value.ToString();
                clienteModificado.txtBTelefonoM.Text = indice.Cells[4].Value.ToString();
                clienteModificado.txtBDniM.Text = indice.Cells[1].Value.ToString();
            }
            clienteModificado.Show();
            this.Hide();

        }

        private void borrarcliente_Click(object sender, EventArgs e)
        {
            FRMBorrarCliente irBorrarCli = new FRMBorrarCliente();
            irBorrarCli.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        int idcliente;
        private void button3_Click(object sender, EventArgs e)
        {
            idcliente = int.Parse(textBoxConsulta.Text);
            dataGridView1.DataSource = principal.BuscarClientePorId(idcliente);
        }

        private void textBoxConsulta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
