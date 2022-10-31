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
    public partial class FRMPedidosNuevo : Form
    {
        public FRMPedidosNuevo()
        {
            InitializeComponent();
        }
        Pedido pedidoNuevo;
        Principal principal;
        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void FRMPedidosNuevo_Load(object sender, EventArgs e)
        {

        }

        private void bVolverDePedidoNuevo_Click(object sender, EventArgs e)
        {
            FRMMenu irMenu = new FRMMenu();
            irMenu.Show();
            this.Hide();
        }

        private void bGuardarPedidoNuevo_Click(object sender, EventArgs e)
        {
            pedidoNuevo = new Pedido();
            pedidoNuevo.cantEmpanada = int.Parse(textBoxtotalEmpanadas.Text);
            pedidoNuevo.nomCliente = textBoxCliente.Text;
            pedidoNuevo.precioTotal = int.Parse(textBoxPrecio.Text);
            pedidoNuevo.formaPago = textBoxPago.Text;
            pedidoNuevo.estado = textBoxEstado.Text;
            pedidoNuevo.demora = int.Parse(textBoxDemora.Text);

            principal = new Principal();
            principal.RellenarListas();
            principal.AltaPedidos(pedidoNuevo);

            FRMMenu irmenu = new FRMMenu();
            irmenu.Show();
            this.Hide();
        }
    }
}
