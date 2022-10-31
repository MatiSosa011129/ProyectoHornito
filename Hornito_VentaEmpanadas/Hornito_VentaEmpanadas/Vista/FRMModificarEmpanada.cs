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
    public partial class FRMModificarEmpanada : Form
    {
        public FRMModificarEmpanada()
        {
            InitializeComponent();
        }
        Empanada empanadaNueva;
        Principal principal;
        private void bVolverDeEmpanadaModificada_Click(object sender, EventArgs e)
        {
            FRMEmpanada irEmpanada = new FRMEmpanada();
            irEmpanada.Show();
            this.Hide();
        }

        private void bGuardarEmpanadaModificada_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Estas seguro que quieres modificar la empanada?", "Modificar empanada", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                Empanada empanadaModificada = new Empanada();
                empanadaModificada.idEmpanada = int.Parse(textBIdEmpaM.Text);
                empanadaModificada.gustoEmpanada = txtBGustoEmpaM.Text;
                empanadaModificada.precioEmpanada = int.Parse(textBPrecioEmpaM.Text);
                Principal principal = new Principal();
                principal.RellenarListas();
                principal.ModificarEmpanada(empanadaModificada, int.Parse(textBIdEmpaM.Text));
                FRMEmpanada frmEmpanada = new FRMEmpanada();

                frmEmpanada.Show();
                this.Hide();
            }
        }
    }
}
