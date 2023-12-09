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

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            LblUsuario.Text = Globales.ObjetosGlobales.MiUsuarioGlobal.Nombre + "(" +
                              Globales.ObjetosGlobales.MiUsuarioGlobal.MiUsuarioRol.Rol + ")";

            //ahora se debe ajustar los permisos de menus para que se muestren o no
            //dependiendo del tipo de rol

            switch (Globales.ObjetosGlobales.MiUsuarioGlobal.MiUsuarioRol.UsusarioRolID)
            {
                //adimn
                case 1:
                    //como admin tiene acceso a todo no es necesario ocultar opciones de menu 
                    break;
                case 2:
                    //ocultan los menus correspondientes
                    MnuGestionUsuarios.Enabled = false;
                    MnuGestionProductos.Enabled = false;
                    MnuGestionCategorias.Enabled = false;
                    break; 
               

                default:
                    break;
            }
        }

        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }



        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void entradasYSalidasDeInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Globales.ObjetosGlobales.MiFormularioMovimientos.Visible)
            {
                Globales.ObjetosGlobales.MiFormularioMovimientos = new FrmMovimientosInventario();
                Globales.ObjetosGlobales.MiFormularioMovimientos.Show();
            }
        }

        private void MnuGestionProductos_Click(object sender, EventArgs e)
        {
            //En este caso quiero la ventan se muestre solo una vez en la aplicacion
            //para esto hay que revisar si la ventana esta o no visible 

            if (!Globales.ObjetosGlobales.MiFormularioGestionDeProductos.Visible)
            {
                Globales.ObjetosGlobales.MiFormularioGestionDeProductos = new FrmProductosGestion();

                Globales.ObjetosGlobales.MiFormularioGestionDeProductos.Show();
            }
        }
    }
}
