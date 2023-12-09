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
    public partial class FrmProductosGestion : Form
    {
        private Logica.Models.Producto MiProductoLocal { get; set; }
        public FrmProductosGestion()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmProductosGestion_Load(object sender, EventArgs e)
        {
            MdiParent = Globales.ObjetosGlobales.MiFormularioPrincipal;
            CargarListaProductos(CbVerActivos.Checked);
            CargarComboRolesDeUsuario();
        }

        private void CargarComboRolesDeUsuario()
        {
            Logica.Models.ProductoCategoria MiCategoria = new Logica.Models.ProductoCategoria();

            DataTable dt = new DataTable();

            dt = MiCategoria.Listar();

            if (dt != null && dt.Rows.Count > 0)
            {
                CboxCategoria.ValueMember = "id";
                CboxCategoria.DisplayMember = "Descripcion";

                CboxCategoria.DataSource = dt;

                CboxCategoria.SelectedIndex = -1;

            }
        }

        private void CargarListaProductos(bool VerActivos, string FiltroBusqueda = "")
        {
            Logica.Models.Producto miProducto = new Logica.Models.Producto();

            DataTable lista = new DataTable();



            if (VerActivos)
            {
                //si se quieren ver los usuarios activos 
                lista = miProducto.ListarActivos(FiltroBusqueda);
                DgvListaProductos.DataSource = lista;
            }
            else
            {
                //si se quieren ver los usuarios inactivos 
                lista = miProducto.ListarInactivos(FiltroBusqueda);
                DgvListaProductos.DataSource = lista;

            }


        }

        private bool ValidarDatosRequeridos()
        {
            bool R = false;


            if (!string.IsNullOrEmpty(TxtCodigoBarras.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtNombreProducto.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtCantidadStock.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtPrecioUnitario.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtCosto.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtUtillidad.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtTasaImpuesto.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtSubTotal.Text.Trim()) &&
                CboxCategoria.SelectedIndex > -1
                )
            {
                R = true;
            
            }
            else
            {
                if (string.IsNullOrEmpty(TxtCodigoBarras.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar un Codigo de Barras", "Error de validacion", MessageBoxButtons.OK);
                    return false;
                }

                if (string.IsNullOrEmpty(TxtNombreProducto.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar el nombre", "Error de validacion", MessageBoxButtons.OK);
                    return false;
                }

                if (CboxCategoria.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar una categoria", "Error de validacion", MessageBoxButtons.OK);
                    return false;
                }

                if (string.IsNullOrEmpty(TxtCantidadStock.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar una Cantidad", "Error de validacion", MessageBoxButtons.OK);
                    return false;
                }

                if (string.IsNullOrEmpty(TxtPrecioUnitario.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar un precio", "Error de validacion", MessageBoxButtons.OK);
                    return false;
                }
                if (string.IsNullOrEmpty(TxtCosto.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar el costo", "Error de validacion", MessageBoxButtons.OK);
                    return false;
                }
                if (string.IsNullOrEmpty(TxtUtillidad.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar la utilidad", "Error de validacion", MessageBoxButtons.OK);
                    return false;
                }
                if (string.IsNullOrEmpty(TxtTasaImpuesto.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar la tasa de impuesto", "Error de validacion", MessageBoxButtons.OK);
                    return false;
                }
                if (string.IsNullOrEmpty(TxtSubTotal.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar un subtotal", "Error de validacion", MessageBoxButtons.OK);
                    return false;
                }

            }

           return R;

        }


        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosRequeridos())
            {
                MiProductoLocal = new Logica.Models.Producto();

                MiProductoLocal.CodigoBarras = TxtCodigoBarras.Text.Trim();
                MiProductoLocal.NombreProducto = TxtNombreProducto.Text.Trim();
                MiProductoLocal.CantidadStock = Convert.ToDecimal(TxtCantidadStock.Text.Trim());  
                MiProductoLocal.PrecioUnitario = Convert.ToDecimal(TxtPrecioUnitario.Text.Trim());
                MiProductoLocal.Costo = Convert.ToDecimal(TxtCosto.Text.Trim());
                MiProductoLocal.Utilidad = Convert.ToDecimal(TxtUtillidad.Text.Trim());
                MiProductoLocal.TasaImpuesto = Convert.ToDecimal(TxtTasaImpuesto.Text.Trim());
                MiProductoLocal.SubTotal = Convert.ToDecimal(TxtSubTotal.Text.Trim());
                MiProductoLocal.MiCategoria.ProductoCategoriaID = Convert.ToInt32(CboxCategoria.SelectedValue);
                

                bool CodBarrasOk = MiProductoLocal.ConsultarPorCodigoBarras(MiProductoLocal.CodigoBarras);

                bool IdOk = MiProductoLocal.ConsultarPorID();

                if (CodBarrasOk == false && IdOk == false)
                {
                    
                    string Pregunta = string.Format("¿Esta seguro de agregar el producto {0}?", MiProductoLocal.NombreProducto);

                    DialogResult respuesta = MessageBox.Show(Pregunta, "????", MessageBoxButtons.YesNo);


                    if (respuesta == DialogResult.Yes)
                    {
                        bool ok = MiProductoLocal.Agregar();

                        
                        if (ok)
                        {
                            MessageBox.Show("Producto ingresado correctamente!!", ":)", MessageBoxButtons.OK);

                            LimpiarForm();
                            CargarListaProductos(CbVerActivos.Checked);
                        }
                        else
                        {
                            MessageBox.Show("El Producto no se pudo agregar", ":(", MessageBoxButtons.OK);
                        }
                    }
                }
            }
        }

        private void LimpiarForm()
        {
            TxtCodigoBarras.Clear();
            TxtNombreProducto.Clear();
            TxtCosto.Clear();
            TxtUtillidad.Clear();
            TxtPrecioUnitario.Clear();
            TxtSubTotal.Clear();
            TxtCantidadStock.Clear();
            TxtTasaImpuesto.Clear();
            CboxCategoria.SelectedIndex = -1;
            CbActivo.Checked = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    
}
