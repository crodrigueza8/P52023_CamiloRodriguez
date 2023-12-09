using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class ProductoCategoria
    {
        public int ProductoCategoriaID { get; set; }
        public string ProductoCategoriaDescripcion { get; set; }

        public DataTable Listar()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            R = MiCnn.EjecutarSELECT("SPProductosCategoriaListar");


            return R;
        }
    }
}
