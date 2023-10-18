using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Logica.Models
{
      public class Usuario
    {
        public Usuario()
        {
            MiUsuarioRol = new UsuarioRol();
                
        }

        public  int UsuarioId { get; set; }

        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }

        public string Contrasennia { get; set; }

        public string Telefono { get; set; }

        public string Direccion { get; set; }

        public bool Activo { get; set; }

        public UsuarioRol MiUsuarioRol { get; set; }

        //Funciones, metodos, operaciones etc 

        public bool Agregar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            //Ahorab agregamos los parametros que solicita el SP de agregar 

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Cedula", this.Cedula));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Nombre", this.Nombre));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Correo", this.Correo));
            //TODO: ENCRIPTAR LA CONTRASENiA 
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Contrasennia", this.Contrasennia));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Telefono", this.Telefono));          
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Direccion", this.Direccion));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@UsuarioRolID", this.MiUsuarioRol.UsusarioRolID));

            int resultado = MiCnn.EjecutarDML("SPUsuariosAgregar");

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



            return R;
        }

        public bool ConsultarPorCedula(string pCedula)
        {
            bool R = false;

            Conexion MiCnn= new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Cedula", pCedula));

            DataTable dt = new DataTable(); 

            dt = MiCnn.EjecutarSELECT("SPUsuariosConsultarPorCedula");

            if (dt != null && dt.Rows.Count > 0) R = true;
                
            return R;
        }

        public bool ConsultarPorCorreo(string pCorreo)
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Correo", pCorreo));

            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSELECT("SPUsuariosConsultarPorCorreo");

            if (dt != null && dt.Rows.Count > 0) R = true;

            return R;
        }

        public DataTable ListarActivos()
        {
            DataTable R = new DataTable();

            //Hacemoss unn a innstancia d ela clase conexion 
            Conexion MiCnn = new Conexion();
            //como el SP requiere un parametro para listar , hay que agregarlo a la lista 
            MiCnn.ListaDeParametros.Add(new SqlParameter("@VerActivos", true));

            R = MiCnn.EjecutarSELECT("SPUsuariosListar"); 

            return R;
        }

        public DataTable ListarInactivos()
        {
            DataTable R = new DataTable();

            return R;
        }


    }
}
