using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class UsuarioRol
    {
        //Digitamos las propiedades de la clase 

        public int UsusarioRolID { get; set; }
        //Esta propiedad es auto implementada, es mas sencilla
        //pero se pierde control en las funciones de get y set 

        public string Rol {  get; set; }

        //luego de digitar las propiedades se digitan las funciones

        public DataTable Listar()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            R = MiCnn.EjecutarSELECT("SPUsuariosRolListar");

            //aca va la progra funcional para realizar el Listar

            return R;
        }

    }
}
