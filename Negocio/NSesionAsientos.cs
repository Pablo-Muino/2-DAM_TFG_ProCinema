using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAD.DSCineTableAdapters;
using CAD;

namespace Negocio
{
    public class NSesionAsientos
    {
        /**
         * Método que obtiene todos los asientos de todas las sesiones de la tabla SesionAsientos
         * ds - DataSet con las tablas de la base de datos
         */
        public static void obtenerSesionAsientos(DSCine ds)
        {
            try
            {
                SesionAsientosTableAdapter ta = new SesionAsientosTableAdapter();

                ta.Fill(ds.SesionAsientos);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /**
         * Método que obtiene un asiento de una sesión de la tabla SesionAsientos mediante el IdSesion e IdAsiento
         * ds - DataSet con las tablas de la base de datos
         * idSesion - Id de la sesión referente a la pelicu,a fecha y hroa de inicio seleccionados
         * idAsiento - Id del asiento seleccionado por el usuario
         */
        public static SesionAsiento obtenerSesionAsientosSesionAsiento(DSCine ds, int idSesion, int idAsiento)
        {
            try
            {
                SesionAsientosTableAdapter ta = new SesionAsientosTableAdapter();
                ta.FillBySesionAsiento(ds.SesionAsientos, idSesion, idAsiento);

                //Se recoge la primera fila que coincida
                var fila = ds.SesionAsientos.FirstOrDefault();

                if (fila != null)
                {
                    //Se crea un objeto SesionAsiento para despues devolverlo
                    return new SesionAsiento(
                        fila.Id,
                        fila.IdSesion,
                        fila.IdAsiento,
                        fila.IdEstado
                    );
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener el asiento de la sesión: " + ex.Message);
            }

            //En caso de no encontrar tal registro se devuelve null
            return null;
        }

        /**
         * Método que actualiza la tabla SesionAsientos con los datos de todos los registros
         * ds - DataSet con las tablas de la base de datos
         */
        public static int actualizarSesionAsientos(DSCine ds)
        {
            try
            {
                SesionAsientosTableAdapter ta = new SesionAsientosTableAdapter();

                int filasAfectadas = ta.Update(ds.SesionAsientos);

                ds.SesionAsientos.AcceptChanges();

                return filasAfectadas;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar la base de datos: " + ex.Message);
                return 0;
            }
        }
    }
}
