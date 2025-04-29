using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using CAD;

namespace CineApp
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
        }

        /**
         * Método que comprobará las credenciales introducidas en los campos de texto y creará un usuario dandole paso a la siguiente ventana correspondiente (Menú de usuarios o de empleados)
         */
        private void btnAcceder_Click(object sender, EventArgs e)
        {
            //Si ninguno de los campos está vacío se intentará recoger el usuario de la tabla Usuarios con esas credenciales
            if((!String.IsNullOrEmpty(txtUsuario.Text) && (!String.IsNullOrEmpty(txtContraseña.Text)))) 
            {
                NUsuarios.obtenerUsuarioNombre(dsCine1, txtUsuario.Text);

                //Si la busqueda devuelve 1 es que ha encontrado un usuario con dichas credenciales, si no, se abrirá un mensaje de error indicandolo
                if(bsUsuarios.Count == 1)
                {
                    //Si la contraseña no es correcta se abrirá un mensaje de error indicandolo 
                    if (((DataRowView)bsUsuarios.Current).Row["Contraseña"].ToString() != txtContraseña.Text)
                    {
                        MessageBox.Show("Las credenciales son incorrectas", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } else
                    {
                        //En caso contrario se crea el usuario y se cierra la ventana Login
                        Usuario _usuario = new Usuario((int)((DataRowView)bsUsuarios.Current).Row["id"], ((DataRowView)bsUsuarios.Current).Row["nombre"].ToString(), ((DataRowView)bsUsuarios.Current).Row["correo"].ToString(), ((DataRowView)bsUsuarios.Current).Row["contraseña"].ToString(), (int)((DataRowView)bsUsuarios.Current).Row["puntos"]);
                        Hide();

                        //Se busca si el usuario que se acaba de loggear es un empleado para mostrar o FEmpleados o FUsuarios
                        NEmpleados.obtenerEmpleadoByUsuario(dsCine1, _usuario.Id);

                        if(bsEmpleados.Count == 1 && ((DataRowView)bsEmpleados.Current).Row["idPuesto"].ToString().Equals("4"))
                        {
                            FAdministracion fEmpleados = new FAdministracion(_usuario);

                            //Al cerrar la ventana fEmpleados se volverá a mostrar fLogin
                            fEmpleados.FormClosed += (s, args) => Show();

                            fEmpleados.Show();
                        } else
                        {
                            FUsuarios fUsuarios = new FUsuarios(_usuario);

                            //Al cerrar la ventana fUsuarios se volverá a mostrar fLogin
                            fUsuarios.FormClosed += (s, args) => Show();

                            fUsuarios.Show();
                        }
                    }
                } else
                {
                    MessageBox.Show("El usuario no existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /**
         * Método que registra a un usuario nuevo, es decir, que no se encuentre en la tabla Usuarios
         */
        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            Hide();

            FRegistro fRegistro = new FRegistro();

            //Al cerrar la ventana fRegistro se volverá a mosatrar fLogin
            fRegistro.FormClosed += (s, args) => Show();

            fRegistro.Show();
        }
    }
}
