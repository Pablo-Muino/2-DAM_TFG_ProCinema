using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAD.DSCineTableAdapters;
using CAD;

namespace Negocio
{
    public class NSesiones
    {
        /**
         * Método que obtiene todos las sesiones de la tabla Sesiones
         * ds - DataSet con las tablas de la base de datos
         */
        public static void obtenerSesiones(DSCine ds)
        {
            try
            {
                SesionesTableAdapter ta = new SesionesTableAdapter();

                ta.Fill(ds.Sesiones);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /**
         * Método que obtiene todos las Sesiones de la tabla Sesion mediante el Id de la película y los devuelve en forma de lista
         * ds - DataSet con las tablas de la base de datos
         */
        public static List<Sesion> obtenerSesionesIdPelicula(DSCine ds, int idPelicula)
        {
            List<Sesion> sesiones = new List<Sesion>();

            try
            {
                SesionesTableAdapter ta = new SesionesTableAdapter();
                ta.FillByPelicula(ds.Sesiones, idPelicula);

                //Por cada registro encontrado se crea un objeto Pelicula y se añade a la lista
                foreach (var row in ds.Sesiones)
                {
                    Sesion sesion = new Sesion(
                        row.Id,
                        row.IdPelicula,
                        row.HoraInicio,
                        row.Fecha,
                        row.IdSala
                    );

                    sesiones.Add(sesion);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //Se devuelve la lista con las Sesiones
            return sesiones;
        }

        /**
         * Método que obtiene todos las Sesiones de la tabla Sesion mediante el Id de la película y la fecha, devolviéndolos en forma de lista
         * ds - DataSet con las tablas de la base de datos
         */
        public static List<Sesion> obtenerSesionesIdPeliculaFecha(DSCine ds, int idPelicula, DateTime fecha)
        {
            List<Sesion> sesiones = new List<Sesion>();

            try
            {
                SesionesTableAdapter ta = new SesionesTableAdapter();
                ta.FillByPeliculaFecha(ds.Sesiones, idPelicula, fecha);

                //Por cada registro encontrado se crea un objeto Pelicula y se añade a la lista
                foreach (var row in ds.Sesiones)
                {
                    Sesion sesion = new Sesion(
                        row.Id,
                        row.IdPelicula,
                        row.HoraInicio,
                        row.Fecha,
                        row.IdSala
                    );

                    sesiones.Add(sesion);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //Se devuelve la lista con las Sesiones
            return sesiones;
        }

        /**
         * Método que obtiene una sesion de la tabla Sesiones por su IdPelicula, su fecha y su hora de inicio
         * ds - DataSet con las tablas de la base de datos
         */
        public static Sesion obtenerSesionIdPeliculaFechaHoraInicio(DSCine ds, int idPelicula, DateTime fecha, TimeSpan horaInicio)
        {
            try
            {
                SesionesTableAdapter ta = new SesionesTableAdapter();
                ta.FillByPeliculaFechaHoraInicio(ds.Sesiones, idPelicula, fecha, horaInicio);

                //Se recoge la primera fila que coincida
                var fila = ds.Sesiones.FirstOrDefault();

                if (fila != null)
                {
                    //Se crea un objeto Sesion para despues devolverlo
                    return new Sesion(
                        fila.Id,
                        fila.IdPelicula,
                        fila.HoraInicio,
                        fila.Fecha,
                        fila.IdSala
                    );
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener sesión: " + ex.Message);
            }

            //En caso de no encontrar tal registro se devuelve null
            return null;
        }

        /**
         * Método que actualiza la tabla Sesiones con los datos de todos los registros
         * ds - DataSet con las tablas de la base de datos
         */
        public static void actualizarSesiones(DSCine ds)
        {
            try
            {
                SesionesTableAdapter ta = new SesionesTableAdapter();

                ta.Update(ds.Sesiones);

                ds.Sesiones.AcceptChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
