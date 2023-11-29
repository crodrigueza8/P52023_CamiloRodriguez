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
                DgvListaDetalle.DataSource = DtListaDetalleProductos;

                Totalizar();
            }

        }

        private void Totalizar()
        {
            decimal TotalCosto = 0;
            decimal TotalSubTotal = 0;
            decimal TotalImpuestos = 0;
            decimal Total = 0;

            if (DtListaDetalleProductos != null && DtListaDetalleProductos.Rows.Count > 0)
            {

                foreach ( DataRow item in DtListaDetalleProductos.Rows)
                {
                    decimal Cantidad = Convert.ToDecimal(item["CantidadMovimiento"]);
                    
                    TotalCosto += Convert.ToDecimal(item["Costo"]) * Cantidad;

                    TotalSubTotal += Convert.ToDecimal(item["SubTotal"]) * Cantidad;

                    TotalImpuestos += Convert.ToDecimal(item["TotalIVA"]) * Cantidad;

                    Total += TotalSubTotal + TotalImpuestos;

                }

            }

            LblTotalCosto.Text = string.Format("{0:C2}", TotalCosto);
            LblTotalSubTotal.Text = string.Format("{0:C2}", TotalSubTotal);
            LblTotalImpuesto.Text = string.Format("{0:C2}", TotalImpuestos);
            LblTotalGranTotal.Text = string.Format("{0:C2}", Total);


        }

        private void BtnAplicar_Click(object sender, EventArgs e)
        {
            //Debemos validar que estén los datos minimos necesarios

            if (ValidarMovimiento())
            {
                //una vez que tenemos los requisitos completos, se procede a dar forma
                //al objeto de movimiento local

                //primero los atributos simples y compuestos del encabezado.
                //luego  a asignacion de los detalles 
                MiMovimientoLocal.Fecha = DtpFecha.Value.Date;
                MiMovimientoLocal.Anotaciones = TxtAnotaciones.Text.Trim();

                MiMovimientoLocal.MiTipo.MovimientoTipoID = Convert.ToInt32(CboxTipo.SelectedValue);
                //A nivel de funcionalidad solo necesitamos el FK o sea el ID del tipo 
                //La parte del texto no es necesario

                MiMovimientoLocal.MiUsuario = Globales.ObjetosGlobales.MiUsuarioGlobal;

                //llenar la lista de detalle en el objeto local a partir de las filas
                //del data table de detalles 
                TrasladarDetalles();


                //Procedemos a agregar el movimiento 
                if (MiMovimientoLocal.Agregar())
                {
                    MessageBox.Show("EL Movimiento ha sido agregado exitosamente","Movimiento creado", MessageBoxButtons.OK);
                    //TODO generar un reporte visial en crystal reports 
                    //Se hara en clase de reposicion sabado 2-dic 

                }

            }
        }

        private void TrasladarDetalles()
        {
            foreach (DataRow item in DtListaDetalleProductos.Rows)
            {
                //En cada itereacion creamos un nuevo objeto de movimiento detalle, que luego será agregado 
                //a la lista detalle del objeto local 

                Logica.Models.MovimientoDetalle NuevoDetalle = new Logica.Models.MovimientoDetalle();

                NuevoDetalle.CantidadMovimiento = Convert.ToDecimal(item["CantidadMovimiento"]);

                NuevoDetalle.Costo = Convert.ToDecimal(item["Costo"]);

                NuevoDetalle.PrecioUnitario = Convert.ToDecimal(item["PrecioUnitario"]);

                NuevoDetalle.SubTotal = Convert.ToDecimal(item["SubTotal"]);

                NuevoDetalle.TotalIVA = Convert.ToDecimal(item["TotalIVA"]);

                //Atributo Compuesto
                NuevoDetalle.MiProducto.ProductoId = Convert.ToInt32(item["ProductoID"]);

                //Asignamos o agregamos el detalle nuevo al objeto de la lista local

                MiMovimientoLocal.Detalles.Add(NuevoDetalle); 
               
            }
        }

        private bool ValidarMovimiento()
        {
            bool R = false;

            if (DtpFecha.Value.Date <= DateTime.Now.Date &&
                CboxTipo.SelectedIndex > -1 &&
                DtListaDetalleProductos.Rows.Count > 0)
            {
                R= true;
            }
            else
            {
                if (DtpFecha.Value.Date > DateTime.Now.Date)
                {
                    MessageBox.Show("La fecha del movimiento no puede " +
                        "ser superior a la fecha actual", "Error de validación",
                        MessageBoxButtons.OK);
                    return false;
                }

                if (CboxTipo.SelectedIndex == -1)
                {
                    MessageBox.Show("Debeseleccionar un tipo de movimiento",
                        "Error de validación", MessageBoxButtons.OK);
                    return false;
                }

                if (DtListaDetalleProductos == null || DtListaDetalleProductos.Rows.Count == 0)
                {
                    MessageBox.Show("No se puede procesar un movimiento sin detalles",
                        "Error de validación", MessageBoxButtons.OK);
                    return false;
                }
            }

            return R;
        }
    }
}
