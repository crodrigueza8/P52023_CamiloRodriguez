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
    public partial class FrmMovimientosInventario : Form
    {
        public FrmMovimientosInventario()
        {
            InitializeComponent();
        }

        private void FrmMovimientosInventario_Load(object sender, EventArgs e)
        {
            MdiParent = Globales.ObjetosGlobales.MiFormularioPrincipal;
            CargarComboTipoMovimiento();
        }

        private void CargarComboTipoMovimiento()
        {
            Logica.Models.MovimientoTipo MiMovimientoTipo = new Logica.Models.MovimientoTipo();

            DataTable dt = new DataTable();

            dt = MiMovimientoTipo.Listar();

            if (dt != null && dt.Rows.Count > 0)
            {
                //Una vez asegurado que dt tiene valores, los dibujo en el combobox
                CboxTipo.ValueMember = "id";
                CboxTipo.DisplayMember = "Descripcion";

                CboxTipo.DataSource = dt;

                CboxTipo.SelectedIndex = -1;

            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void CboxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
      
        }
    }
}
