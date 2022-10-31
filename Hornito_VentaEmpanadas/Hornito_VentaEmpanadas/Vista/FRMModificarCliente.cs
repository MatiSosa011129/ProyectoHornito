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
    public partial class FRMModificarCliente : Form
    {
        public FRMModificarCliente()
        {
            InitializeComponent();
        }

        private void bGuardarCliModificado_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Estas seguro que quieres modificar el cliente?", "Modificar socio", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                Cliente clienteModificado = new Cliente();
                clienteModificado.telefono = int.Parse(txtBTelefonoM.Text);
                clienteModificado.idCliente = int.Parse(txtBIdM.Text);
                clienteModificado.dni = int.Parse(txtBDniM.Text);
                clienteModificado.apellido = txtBApellidoM.Text;
                clienteModificado.nombre = txtBNombreM.Text;
                clienteModificado.fechaNacimiento = dtpNacimientoM.Text;
                Principal principal = new Principal();
                principal.RellenarListas();
                principal.ModificarCliente(clienteModificado, int.Parse(txtBIdM.Text));
                FRMClientes frmClientes = new FRMClientes();

                frmClientes.Show();
                this.Hide();



            }
        }

        private void bVolverDeCliModificado_Click(object sender, EventArgs e)
        {
            FRMClientes irClientes = new FRMClientes();
            irClientes.Show();
            this.Hide();
        }
    }
}
