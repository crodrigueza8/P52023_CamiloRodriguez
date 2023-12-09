using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Producto
    {
        

        public int ProductoId { get; set; }

        public string CodigoBarras { get; set; }

        public string NombreProducto { get; set; }

        public decimal Costo { get; set; }

        public decimal Utilidad { get; set; }

        public decimal SubTotal { get; set; }

        public decimal TasaImpuesto { get; set; }

        public decimal PrecioUnitario { get; set; }

        public decimal CantidadStock { get; set; }

        public bool Activo { get; set; }

        public ProductoCategoria MiCategoria {  get; set; }    


        public Producto()
        {
            MiCategoria = new ProductoCategoria();  

        }

        //Funciones 

        public bool Agregar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            //Ahora agregamos los parametros que solicita el SP de agregar 

            MiCnn.ListaDeParametros.Add(new SqlParameter("@CodigoBarras", this.CodigoBarras));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Nombre", this.NombreProducto));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Costo", this.Costo));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Utilidad", this.Utilidad));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@SubTotal", this.SubTotal));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@TasaImpuesto", this.TasaImpuesto));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@PrecioUnitario", this.PrecioUnitario));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@CantidadStock", this.CantidadStock));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Categoria", this.MiCategoria.ProductoCategoriaID));
            

            int resultado = MiCnn.EjecutarDML("SPProductosAgregar");

            if (resultado > 0) R = true;


            return R;
        }

        public bool Actualizar()
        {
            bool R = false;



            return R;
        }

        public bool Eliminar()
        {
            bool R = false;



            return R;
        }

        public bool ConsultarPorID()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.ProductoId));

            DataTable DatosUsuario = new DataTable();

            DatosUsuario = MiCnn.EjecutarSELECT("SPProductosConsultarPorID");

            if (DatosUsuario != null && DatosUsuario.Rows.Count > 0)

            {
                 
                R = true;

            }

            return R;
        }

        public bool ConsultarPorCodigoBarras(string pCodigoBarras)
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@CodigoBarras", pCodigoBarras));

            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSELECT("SPProductosConsultarPorCodigoBarras");

            if (dt != null && dt.Rows.Count > 0) R = true;

            return R;
        }

        public DataTable ListarActivos(string pFiltro = "")
        {
            DataTable R = new DataTable();

            
            Conexion MiCnn = new Conexion();
            
            MiCnn.ListaDeParametros.Add(new SqlParameter("@VerActivos", true));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Filtro", pFiltro));

            R = MiCnn.EjecutarSELECT("SPProductosListarTodos");

            return R;
        }

        public DataTable ListarInactivos(string pFiltro = "")
        {
            DataTable R = new DataTable();

            
            Conexion MiCnn = new Conexion();
            
            MiCnn.ListaDeParametros.Add(new SqlParameter("@VerActivos", false));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Filtro", pFiltro));

            R = MiCnn.EjecutarSELECT("SPProductosListarTodos");

            return R;
        }

        public DataTable ListarEnMovimientoDetalleProducto(bool VerActivos = true, string Filtro = "")
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@VerActivos", VerActivos));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Filtro", Filtro));

            R = MiCnn.EjecutarSELECT("SPProductosListar");

            return R;
        }

    }
}
