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
    public partial class FRMMenu : Form
    {
        public FRMMenu()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bAltaPedidos_Click(object sender, EventArgs e)
        {
            FRMPedidosNuevo irPedidosNuevo = new FRMPedidosNuevo();
            irPedidosNuevo.Show();
            this.Hide();
        }

        private void bMoBPedidos_Click(object sender, EventArgs e)
        {
            FRMPedidosProceso irPedidosProceso = new FRMPedidosProceso();
            irPedidosProceso.Show();
            this.Hide();
        }

        private void bAltaClientes_Click(object sender, EventArgs e)
        {
            FRMClientesNuevo irClientesNuevo = new FRMClientesNuevo();
            irClientesNuevo.Show();
            this.Hide();
        }

        private void bMoBClientes_Click(object sender, EventArgs e)
        {
            FRMClientes irClientes = new FRMClientes();
            irClientes.Show();
            this.Hide();
        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void bAltaEmpanadas_Click(object sender, EventArgs e)
        {
            FRMAltaEmpanadas irEmpanadasNueva = new FRMAltaEmpanadas();
            irEmpanadasNueva.Show();
            this.Hide();
        }

        private void bMoBEmpanadas_Click(object sender, EventArgs e)
        {
            FRMEmpanada irEmpanada = new FRMEmpanada();
            irEmpanada.Show();
            this.Hide();
        }
    }
}
