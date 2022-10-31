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
    public partial class FRMAltaEmpanadas : Form
    {
        public FRMAltaEmpanadas()
        {
            InitializeComponent();
        }
        Empanada empanadaNueva;
        Principal principal;
        private void bVolverDeNuevaEmpanada_Click(object sender, EventArgs e)
        {
            FRMMenu irMenu = new FRMMenu();
            irMenu.Show();
            this.Hide();
        }

        private void bGuardarNuevaEmpanada_Click(object sender, EventArgs e)
        {
            empanadaNueva = new Empanada();
            empanadaNueva.gustoEmpanada = txtBGustoEmpa.Text;
            empanadaNueva.precioEmpanada = int.Parse(textBPrecioEmpa.Text);

            principal = new Principal();
            principal.RellenarListas();
            principal.AltaEmpanadas(empanadaNueva);

            FRMMenu irmenu = new FRMMenu();
            irmenu.Show();
            this.Hide();
        }

        private void FRMAltaEmpanadas_Load(object sender, EventArgs e)
        {

        }
    }
}
