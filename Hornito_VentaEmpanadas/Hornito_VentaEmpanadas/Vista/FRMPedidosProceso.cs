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
    public partial class FRMPedidosProceso : Form
    {
        Principal principal;
        public FRMPedidosProceso()
        {
            InitializeComponent();
        }

        private void bVolverDePedidosBoM_Click(object sender, EventArgs e)
        {
            FRMMenu irMenu = new FRMMenu();
            irMenu.Show();
            this.Hide();
        }

        private void bGuardarPedidoBoM_Click(object sender, EventArgs e)
        {

        }

        private void modifpedido_Click(object sender, EventArgs e)
        {
            FRMModificarPedido pedidoModificado = new FRMModificarPedido();
            foreach (DataGridViewRow indice in dataGridPedidos.SelectedRows)
            {
                int idPedidoModificado = Convert.ToInt32(indice.Cells[0].Value);

                pedidoModificado.textBoxIdM.Text = idPedidoModificado.ToString();
                pedidoModificado.textBoxEstadoM.Text = indice.Cells[3].Value.ToString();
                pedidoModificado.textBoxPagoM.Text = indice.Cells[1].Value.ToString();
                pedidoModificado.textBoxtotalEmpanadasM.Text = indice.Cells[2].Value.ToString();
                pedidoModificado.textBoxPrecioM.Text = indice.Cells[4].Value.ToString();
                pedidoModificado.textBoxDemoraM.Text = indice.Cells[5].Value.ToString();

            }
            pedidoModificado.Show();
            this.Hide();
        }

        private void FRMPedidosProceso_Load(object sender, EventArgs e)
        {
            principal = new Principal();    
            dataGridPedidos.DataSource = null;
            dataGridPedidos.DataSource = principal.ValidarPedido();
        }

        private void dataGridPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void borrarpedido_Click(object sender, EventArgs e)
        {
            FRMBorrarPedido irBorrarPedido = new FRMBorrarPedido();
            irBorrarPedido.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int idpedido = int.Parse(textBoxConsulta.Text);
            dataGridPedidos.DataSource = principal.BuscarPedidoPorId(idpedido);
        }
    }
}
