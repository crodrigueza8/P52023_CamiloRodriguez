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
    public partial class FrmUsuariosGestion : Form
    {

        //objeto local de tipo usuario 

        private Logica.Models.Usuario MiUsuarioLocal { get; set; }

        public FrmUsuariosGestion()
        {
            InitializeComponent();

            MiUsuarioLocal = new Logica.Models.Usuario();
        }

        private void FrmUsuariosGestion_Load(object sender, EventArgs e)
        {
            MdiParent = Globales.ObjetosGlobales.MiFormularioPrincipal;

            CargarComboRolesDeUsuario();

            CargarListaUsuarios();
        }

        private void CargarComboRolesDeUsuario()
        {
            Logica.Models.UsuarioRol MiRol = new Logica.Models.UsuarioRol();

            DataTable dt = new DataTable();

            dt = MiRol.Listar();

            if (dt != null && dt.Rows.Count > 0)
            {
                //Una vez asegurado que dt tiene valores, los dibujo en el combobox
                CboxUsuarioTipoRol.ValueMember = "id";
                CboxUsuarioTipoRol.DisplayMember = "Descripcion";

                CboxUsuarioTipoRol.DataSource = dt;

                CboxUsuarioTipoRol.SelectedIndex = -1;

            }
        }

        //Encapsulo todas la funcionalidades especificas  y que se puedan realizar 

        private void CargarListaUsuarios()
        {
            Logica.Models.Usuario miusuario = new Logica.Models.Usuario();

            DataTable lista = new DataTable();

            lista = miusuario.ListarActivos();

            DgvListaUsuarios.DataSource = lista;
        }

        private bool ValidarDatosRequeridos()
        {
            bool R = false;

            //validar que se haya digitado valores en los campos obligatorios
            if (!string.IsNullOrEmpty(TxtUsuarioCedula.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtUsuarioNombre.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtUsuarioCorreo.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtUsuarioContrasennia.Text.Trim()) &&
                CboxUsuarioTipoRol.SelectedIndex > -1)
            {
                R = true;
            }
            else
            {
                //indicarle al usuario que validacion esta faltando 

                //cedula
                if (string.IsNullOrEmpty(TxtUsuarioCedula.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar la cedula", "Error de validacion", MessageBoxButtons.OK);
                    return false;
                }
                //nombre
                if (string.IsNullOrEmpty(TxtUsuarioNombre.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar el nombre", "Error de validacion", MessageBoxButtons.OK);
                    return false;
                }

                if (string.IsNullOrEmpty(TxtUsuarioCorreo.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar el correo", "Error de validacion", MessageBoxButtons.OK);
                    return false;
                }
                if (string.IsNullOrEmpty(TxtUsuarioContrasennia.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar la Contraseña", "Error de validacion", MessageBoxButtons.OK);
                    return false;
                }
                if (CboxUsuarioTipoRol.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar el tipo de usuario", "Error de validacion", MessageBoxButtons.OK);
                    return false;
                }

            }

            return R;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

            //lo primero que debemos hacer es validar los datos minimos requeridos
            //eso se hace para evitar que queden registroios sin datos a nivel de db
            //pero tambien porque si un campo de base de datos no acepta valores nulll
            //y se llama al insert, dará un error

            //Luego de esyp y tomando en consideracion el diagrame de casos de uso expandido 
            //de usuario, hay que hacer validar que no exista un usuario con la cedula y/o 
            //correo que se digitaron.(No se pueden repetir estos datos en distintas
            //filas en la tabla usuario

            //Si ambas validaciones son negativas entonces se procede a Agregar() el usuario

            //-------------------------------------------------------------------------------//

            //usaremos un objeto local de tipo usuario, que sera al que daremso forma para luego 
            //usar las funciones como agregar, actualizar, eliminar, ect

            if (ValidarDatosRequeridos())
            {



                MiUsuarioLocal = new Logica.Models.Usuario();

                MiUsuarioLocal.Cedula = TxtUsuarioCedula.Text.Trim();
                MiUsuarioLocal.Nombre = TxtUsuarioNombre.Text.Trim();
                MiUsuarioLocal.Correo = TxtUsuarioCorreo.Text.Trim();
                MiUsuarioLocal.Telefono = TxtUsuarioTelefono.Text.Trim();

                //toca extraer el valuemember seleccionado para el tipo de usu  ario 

                MiUsuarioLocal.MiUsuarioRol.UsusarioRolID = Convert.ToInt32(CboxUsuarioTipoRol.SelectedValue);
                MiUsuarioLocal.Contrasennia = TxtUsuarioContrasennia.Text.Trim();
                MiUsuarioLocal.Direccion = TxtUsuarioDireccion.Text.Trim();

                bool CedulaOk = MiUsuarioLocal.ConsultarPorCedula(MiUsuarioLocal.Cedula);

                bool CorreoOk = MiUsuarioLocal.ConsultarPorCorreo(MiUsuarioLocal.Correo);

                if (CedulaOk == false && CorreoOk == false)
                {
                    //se solicita confirmacion por parte del usuario 
                    string Pregunta = string.Format("¿Esta seguro de agregar al usuario {0}?", MiUsuarioLocal.Nombre);

                    DialogResult respuesta = MessageBox.Show(Pregunta, "????", MessageBoxButtons.YesNo);


                    if (respuesta == DialogResult.Yes)
                    {
                        bool ok = MiUsuarioLocal.Agregar();

                        //procedemos a agregar el usuario
                        if (ok)
                        {
                            MessageBox.Show("Usuario ingresado correctamente!!", ":)", MessageBoxButtons.OK);

                            LimpiarForm();
                            CargarListaUsuarios();
                        }
                        else
                        {
                            MessageBox.Show("El Usuario no se pudo agregar", ":(", MessageBoxButtons.OK);
                        }
                    }
                }
            }
        }

        private void LimpiarForm()
        {
            TxtUsuarioCodigo.Clear();
            TxtUsuarioCedula.Clear();
            TxtUsuarioNombre.Clear();
            TxtUsuarioCorreo.Clear();
            TxtUsuarioTelefono.Clear();
            TxtUsuarioContrasennia.Clear();
            TxtUsuarioDireccion.Clear();

            CboxUsuarioTipoRol.SelectedIndex = -1;

            CbUsuarioActivo.Checked = false;
        }



    }
}

