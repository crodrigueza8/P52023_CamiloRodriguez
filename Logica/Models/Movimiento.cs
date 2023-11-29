using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Movimiento
    {
        public Movimiento()
        {
            MiTipo = new MovimientoTipo();
            MiUsuario = new Usuario();
            Detalles = new List<MovimientoDetalle> ();
            
        }

        public int MovimientoID { get; set; }

        public DateTime Fecha { get; set; }

        public int NumeroMovimiento { get; set; }

        public string Anotaciones { get; set; }

        

        //Funciones

        public bool Agregar()
        {
            bool R = false;

            //Hacemos un insert en el encabezado y recolectamos el ID que se genera 
            //Esto es necesario ya que se necesita como FK en la tabla detalle.
           
            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Fecha", this.Fecha));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Anotaciones", this.Anotaciones));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@TipoMovimiento", this.MiTipo.MovimientoTipoID));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@UsuarioID", this.MiUsuario.UsuarioId));
            
            //Generico
            Object RetornoSPAgregar = MiCnn.EjecutarSELECTEscalar("SPMovimientosAgregarEncabezado");

            int IDMovimientoRecienCreado;

            if (RetornoSPAgregar != null)
            {
                //Especializado
                IDMovimientoRecienCreado = Convert.ToInt32(RetornoSPAgregar.ToString());

                foreach (MovimientoDetalle item in this.Detalles)
                {
                    //Por cada iteracion en la lista de detalles hacemos un insert en la tabla detalles 

                    Conexion MiCnnDetalle = new Conexion();
                    MiCnnDetalle.ListaDeParametros.Add(new SqlParameter("@IDMovimiento", IDMovimientoRecienCreado));
                    MiCnnDetalle.ListaDeParametros.Add(new SqlParameter("@IDProducto", item.MiProducto.ProductoId));
                    MiCnnDetalle.ListaDeParametros.Add(new SqlParameter("@Cantidad", item.CantidadMovimiento));
                    MiCnnDetalle.ListaDeParametros.Add(new SqlParameter("@Costo",item.Costo));
                    MiCnnDetalle.ListaDeParametros.Add(new SqlParameter("@Subtotal",item.SubTotal));
                    MiCnnDetalle.ListaDeParametros.Add(new SqlParameter("@TotalIVA",item.TotalIVA));
                    MiCnnDetalle.ListaDeParametros.Add(new SqlParameter("@PrecioUnitario",item.PrecioUnitario));

                    MiCnnDetalle.EjecutarDML("SPMovimientosAgregarDetalle");


                }

                R = true;
            }

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



            return R;
        }

        public DataTable Listar()
        {
            DataTable R= new DataTable();

            return R;   
        }

        public MovimientoTipo MiTipo { get; set; }

        public Usuario MiUsuario { get; set; }

        //en el caso del detalle, si analizamos el diagrama de clases
        //vemos que al llegar a la clase de dettale  termina en "muchos"
        //1* Eso significa que el atribute tiene multiplicidad o sea que se puede repetir n veces

        public List<MovimientoDetalle> Detalles { get; set; }

        public DataTable AsignarEsquemaDelDetalle()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            //Queremos cargar el esquema del data table, no los datos 
            R = MiCnn.EjecutarSELECT("SPMovimientoCargarDetalle", true);

            //Para evitar que el identity 1,1 , que esta originalmente en la tabla 
            //Me genere numeros unicos que impidan repetir registros
            R.PrimaryKey = null;

            return R;
        }
    }

}
