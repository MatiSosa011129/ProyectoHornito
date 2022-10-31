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
    public partial class FRMBorrarPedido : Form
    {
        Principal principal = new Principal();
        int idpedido;
        public FRMBorrarPedido()
        {
            InitializeComponent();
        }

        private void bGuardarCliBorrado_Click(object sender, EventArgs e)
        {
            idpedido = int.Parse(txtBIdPedido.Text);
            principal.BajaPedidos(idpedido);

            FRMPedidosProceso irPedidos = new FRMPedidosProceso();
            irPedidos.Show();
            this.Hide();
        }
    }
}
