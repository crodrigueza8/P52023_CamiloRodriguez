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

            //Ahora agregamos los parametros que solicita el SP de agregar 

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Cedula", this.Cedula));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Nombre", this.Nombre));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Correo", this.Correo));
            Tools.Crypto MiEncriptador = new Tools.Crypto();
            string ContrasenniaEncriptada = MiEncriptador.EncriptarEnUnSentido(this.Contrasennia);
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Contrasennia", ContrasenniaEncriptada));
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

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Cedula", this.Cedula));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Nombre", this.Nombre));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Correo", this.Correo));
            Tools.Crypto MiEncriptador = new Tools.Crypto();
            string ContrasenniaEncriptada = MiEncriptador.EncriptarEnUnSentido(this.Contrasennia);
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Contrasennia", ContrasenniaEncriptada));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Telefono", this.Telefono));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Direccion", this.Direccion));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@UsuarioRolID", this.MiUsuarioRol.UsusarioRolID));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.UsuarioId));
            int resultado = MiCnn.EjecutarDML("SPUsuariosActualizar");

            if (resultado > 0) R = true;

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

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.UsuarioId));

            DataTable DatosUsuario = new DataTable();

            DatosUsuario = MiCnn.EjecutarSELECT("SPUsuariosConsultarPorID");

            if (DatosUsuario != null && DatosUsuario.Rows.Count > 0)

            {
                //el usuario existe 
                R = true;  

            }
            
            return R;
        }

        public Usuario ConsultarPorID(int IdUsuario)
        {
            Usuario R = new Usuario();

            //Esta funcion retorna un obejto de tipo Usuario con datos en los atributos.
            //Es una variedad de consultar por ID que nos permite manipular el obejto y no 
            //solo saber si el usuario existe o no a traves de un bool.

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add (new SqlParameter("@ID", IdUsuario));

            DataTable DatosUsuario = new DataTable();

            DatosUsuario = MiCnn.EjecutarSELECT("SPUsuariosConsultarPorID");

            if (DatosUsuario != null && DatosUsuario.Rows.Count > 0)

                //como tenemos que llenar un objeto compuesto (por el rol del usuario)
                //debemos extraer los datos de la consulta y llenar los atributos
                //correspondientes del objeto de tipo Usuario R.
            {
                //acá capturamos los datos de la fila 0 del resultado 
                DataRow MiFila = DatosUsuario.Rows[0];

                R.UsuarioId = Convert.ToInt32(MiFila["UsuarioID"]);
                R.Nombre = Convert.ToString(MiFila["Nombre"]);
                R.Cedula = Convert.ToString(MiFila["Cedula"]);
                R.Correo = Convert.ToString(MiFila["Correo"]);
                R.Telefono = Convert.ToString(MiFila["Telefono"]);
                R.Contrasennia = Convert.ToString(MiFila["Contrasennia"]);
                R.Direccion = Convert.ToString(MiFila["Direccion"]);
                R.MiUsuarioRol.UsusarioRolID = Convert.ToInt32(MiFila["UsuarioRolID"]);
                R.MiUsuarioRol.Rol = Convert.ToString(MiFila["Rol"]);
                R.Activo = Convert.ToBoolean(MiFila["Activo"]);
        
            }        


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
