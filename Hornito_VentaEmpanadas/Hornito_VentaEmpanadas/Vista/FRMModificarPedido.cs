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
    public partial class FRMModificarPedido : Form
    {
        public FRMModificarPedido()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bVolverDePedidoModificado_Click(object sender, EventArgs e)
        {
            FRMPedidosProceso irPedidosProceso = new FRMPedidosProceso();
            irPedidosProceso.Show();
            this.Hide();
        }

        private void bGuardarPedidoModificado_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Estas seguro que quieres modificar el pedido?", "Modificar pedido", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                Pedido pedidoModificado = new Pedido();
                pedidoModificado.formaPago = textBoxPagoM.Text;
                pedidoModificado.demora = int.Parse(textBoxDemoraM.Text);
                pedidoModificado.cantEmpanada = int.Parse(textBoxtotalEmpanadasM.Text);
                pedidoModificado.estado = textBoxEstadoM.Text;
                pedidoModificado.idPedido = int.Parse(textBoxIdM.Text);
                pedidoModificado.precioTotal = int.Parse(textBoxPrecioM.Text);
                Principal principal = new Principal();
                principal.RellenarListas();
                principal.ModificarPedido(pedidoModificado, int.Parse(textBoxIdM.Text));
                FRMPedidosProceso frmPedidos = new FRMPedidosProceso();

                frmPedidos.Show();
                this.Hide();
            }
        }
    }
}
