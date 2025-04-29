using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAD.DSCineTableAdapters;
using CAD;

namespace Negocio
{
    public class NUsuarios
    {
        /**
         * Método que obtiene todos los usuarios de la tabla Usuarios
         * ds - DataSet con las tablas de la base de datos
         */
        public static void obtenerUsuarios(DSCine ds)
        {
            try
            {
                UsuariosTableAdapter ta = new UsuariosTableAdapter();

                ta.Fill(ds.Usuarios);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /**
         * Método que obtiene un usuario de la tabla Usuarios mediante un nombre de usuario
         * ds - DataSet con las tablas de la base de datos
         * usuario - Nombre del usuario a obtener
         */
        public static void obtenerUsuarioNombre(DSCine ds, string usuario)
        {
            try
            {
                UsuariosTableAdapter ta = new UsuariosTableAdapter();

                //Si el nombre de usuario contiene este caracter se buscará por el correo, en caso contrario, por el nombre
                if (usuario.Contains("@"))
                {
                    ta.FillByCorreo(ds.Usuarios, usuario);
                }
                else
                {
                    ta.FillByNombre(ds.Usuarios, usuario);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /**
         * Método que obtiene un usuario de la tabla Usuarios mediante su id
         * ds - DataSet con las tablas de la base de datos
         * id - Id del usuario que se quiere obtener
         */
        public static Usuario obtenerUsuarioId(DSCine ds, int id)
        {
            try
            {
                UsuariosTableAdapter ta = new UsuariosTableAdapter();
                ta.FillById(ds.Usuarios, id);

                //Se recoge la primera fila que coincida
                var fila = ds.Usuarios.FirstOrDefault();

                if (fila != null)
                {
                    //Se crea un objeto Usuario para despues devolverlo
                    return new Usuario(
                        fila.Id,
                        fila.Nombre,
                        fila.Correo,
                        fila.Contraseña,
                        fila.Puntos
                    );
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener el usuario: " + ex.Message);
            }

            //En caso de no encontrar tal registro se devuelve null
            return null;
        }

        /**
         * Método que actualiza la tabla Usuarios con los datos de todos los registros
         * ds - DataSet con las tablas de la base de datos
         */
        public static void actualizarUsuarios(DSCine ds)
        {
            try
            {
                UsuariosTableAdapter ta = new UsuariosTableAdapter();

                ta.Update(ds.Usuarios);

                ds.Usuarios.AcceptChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
