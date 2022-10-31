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
    public partial class FRMBorrarEmpanada : Form
    {
        Principal principal = new Principal();
        int idempanada;
        public FRMBorrarEmpanada()
        {
            InitializeComponent();
        }

        private void bGuardarCliBorrado_Click(object sender, EventArgs e)
        {
            idempanada = int.Parse(txtBIdEmpanada.Text);
            principal.BajaEmpanadas(idempanada);

            FRMEmpanada irEmpanada = new FRMEmpanada();
            irEmpanada.Show();
            this.Hide();
        }
    }
}
