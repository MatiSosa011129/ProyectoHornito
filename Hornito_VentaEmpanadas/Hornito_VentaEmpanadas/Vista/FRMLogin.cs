using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace Vista
{
    public partial class FRMLogin : System.Windows.Forms.Form
    {
        public FRMLogin()
        {
            InitializeComponent();
        }
        private bool validarUsuario(string nombre, string clave)
        {
            //me voy a la base de usuarios a revisar para ese nombre y esa clave
            return (nombre == "mati") && (clave == "1234");
        }
        private void bIngresar_Click(object sender, EventArgs e)
        {
            //ir a la lista de usuario y rescatar el que tiene el mismo txt
            //validad password
            if (txtusuario.Text.Length > 0)
            {
                if (validarUsuario(txtusuario.Text.Trim(), txtcontra.Text.Trim()))
                {
                    FRMMenu irMenu = new FRMMenu();
                    irMenu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o clave incorrecta");
                }
            }
            else
            {
                MessageBox.Show("Acceso denegado, campos incompletos");
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void PantallaPrincipal_Load(object sender, EventArgs e)
        {
            PersistenciaDatos instanciaPersistencia = new PersistenciaDatos();
            instanciaPersistencia.InicializarArchivos();
            Principal instanciaPrincipal = new Principal();
            instanciaPrincipal.RellenarListas();
        }

        private void txtcontra_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
