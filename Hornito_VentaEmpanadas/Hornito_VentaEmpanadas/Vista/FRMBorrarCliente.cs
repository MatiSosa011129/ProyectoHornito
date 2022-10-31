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
    public partial class FRMBorrarCliente : Form
    {
        Principal principal = new Principal();
        int idcliente;
        public FRMBorrarCliente()
        {
            InitializeComponent();
        }

        private void bGuardarCliBorrado_Click(object sender, EventArgs e)
        {
            idcliente = int.Parse(txtBIdCliente.Text);
            principal.BajaClientes(idcliente);

            FRMClientes irClientes = new FRMClientes();
            irClientes.Show();
            this.Hide();
        }
    }
}
