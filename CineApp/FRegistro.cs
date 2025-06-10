using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAD;
using Negocio;

namespace CineApp
{
    public partial class FRegistro : Form
    {
        public FRegistro()
        {
            InitializeComponent();
        }

        /**
         * Método que creará un nuevo usuario y lo añadirá a la tabla Usuarios
         */
        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            String nombre = txtNombre.Text;
            String correo = txtCorreo.Text;
            String contraseña = txtContraseña.Text;
            String confContraseña = txtConfContraseña.Text;

            //Si hay algun campo vacío se adevierte al usuario
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(correo) ||
                string.IsNullOrWhiteSpace(contraseña) || string.IsNullOrWhiteSpace(confContraseña))
            {
                MessageBox.Show("Debe rellenar todos los campos para continuar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Si las contraseñas no coinciden se abrirá un mensaje de error indicandolo
            if (contraseña != confContraseña)
            {
                MessageBox.Show("Las contraseñas no coinciden", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            NUsuarios.obtenerUsuarioNombre(dsCine1, correo);

            //Si se encuentra un usuario significa que ya hay un usuario creado con este correo, por lo que no se podrá crear
            if (bsUsuarios.Count == 1)
            {
                MessageBox.Show("Ya existe un usuario asociado a esa cuenta de correo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //En caso contrario se crea el nuevo usuario
            DataRowView nuevoUsuario = (DataRowView)bsUsuarios.AddNew();
            nuevoUsuario["Nombre"] = nombre;
            nuevoUsuario["Correo"] = correo;
            nuevoUsuario["Contraseña"] = contraseña;
            nuevoUsuario["Puntos"] = 0;

            //Se confirman los cambios y se actualiza la tabla Usuarios
            bsUsuarios.EndEdit();
            NUsuarios.actualizarUsuarios(dsCine1);

            //Se informa al usuario que la operación ha sido un éxito y se cierra la ventana
            MessageBox.Show("Usuario registrado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
