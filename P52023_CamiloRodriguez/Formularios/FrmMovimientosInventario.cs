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

        public Logica.Models.Movimiento MiMovimientoLocal { get; set; } 

        public DataTable DtListaDetalleProductos { get; set; }

        public FrmMovimientosInventario()
        {
            InitializeComponent();

            MiMovimientoLocal = new Logica.Models.Movimiento();

            DtListaDetalleProductos = new DataTable();
        }

        private void FrmMovimientosInventario_Load(object sender, EventArgs e)
        {
            MdiParent = Globales.ObjetosGlobales.MiFormularioPrincipal;

            CargarComboTipoMovimiento();

            LimpiarForm();
        }

        private void LimpiarForm()
        {
            DtpFecha.Value = DateTime.Now.Date;
            CboxTipo.SelectedIndex = -1;
            TxtAnotaciones.Clear();


            //En este caso particular el datatable que alimenta el DGV 
            //debe tener estructura pero no datos inicialmente
            //Considerando eso, llenaremos el datatable con el esquema
            //de la consulta del SPMovimientoCargarDetalle.

            //Esto permite tener el dt sin filas, pero con estructura,
            //que permite agregar filas posteriormente

            DtListaDetalleProductos = MiMovimientoLocal.AsignarEsquemaDelDetalle();

            DgvListaDetalle.DataSource = DtListaDetalleProductos;

            //Limpiamos totales

            LblTotalCosto.Text = "0";
            LblTotalGranTotal.Text = "0";
            LblTotalImpuesto.Text = "0";
            LblTotalSubTotal.Text = "0";
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

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            /* El formulario que muestra  la lista de items, se debe mostra
               en este caso particular en formato de dialogo ya que queremos cortar
               temporalmente el funcionamiento del form actual al ser algo en el 
               otro form y espear una respuesta 
            */

            Form FormDetalleProdcuto = new Formularios.FrmMovimientosInventarioDetalleProducto();
            
            DialogResult resp = FormDetalleProdcuto.ShowDialog();

            if (resp == DialogResult.OK) 
            {
                //TODO agregar la nueva linea de detalle 
            }
        }
    }
}
