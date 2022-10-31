using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FRMClientesNuevo : Form
    {
        public FRMClientesNuevo()
        {
            InitializeComponent();
        }
        Cliente clienteNuevo;
        Principal principal;
        private void FRMClientesNuevo_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
         {

        }

        private void bGuardarNuevoCli_Click(object sender, EventArgs e)
        {
            clienteNuevo = new Cliente();
            clienteNuevo.nombre = txtBNombre.Text;
            clienteNuevo.apellido = txtBApellido.Text;
            clienteNuevo.dni = int.Parse(txtBDni.Text);
            clienteNuevo.fechaNacimiento = dtpNacimiento.Text.ToString();
            clienteNuevo.telefono = int.Parse(txtBTelefono.Text);

            principal = new Principal();
            principal.RellenarListas();
            principal.AltaCliente(clienteNuevo);

            FRMMenu irmenu = new FRMMenu();
            irmenu.Show();
            this.Hide();
        }

        private void bVolverDeNuevoCli_Click(object sender, EventArgs e)
        {
            FRMMenu irMenu = new FRMMenu();
            irMenu.Show();
            this.Hide();
        }
    }
}
