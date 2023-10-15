using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P52023_CamiloRodriguez.Formularios
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void gestionDeCateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void gestiónDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //En este caso quiero la ventan se muestre solo una vez en la aplicacion
            //para esto hay que revisar si la ventana esta o no visible 

            if (!Globales.ObjetosGlobales.MiFormularioDeGestionDeUsuarios.Visible)
            {
                Globales.ObjetosGlobales.MiFormularioDeGestionDeUsuarios = new FrmUsuariosGestion();

                Globales.ObjetosGlobales.MiFormularioDeGestionDeUsuarios.Show();    
            }

        }

        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
