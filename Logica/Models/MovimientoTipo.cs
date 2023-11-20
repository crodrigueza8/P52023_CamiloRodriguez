using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class MovimientoTipo
    {
        public int MovimientoTipoID { get; set; }
        public string MovimientoTipoDescripcion { get; set; }

        public DataTable Listar()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            R = MiCnn.EjecutarSELECT("SPMovimientosTiposListar");

            //aca va la progra funcional para realizar el Listar

            return R;
        }
    }
}
