using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAD.DSCineTableAdapters;
using CAD;

namespace Negocio
{
    public class NEstadoAsientos
    {
        /**
         * Método que obtiene todos los estados de los asientos de la tabla EstadoAsientos
         * ds - DataSet con las tablas de la base de datos
         */
        public static void obtenerEstadosAsientos(DSCine ds)
        {
            try
            {
                EstadoAsientosTableAdapter ta = new EstadoAsientosTableAdapter();

                ta.Fill(ds.EstadoAsientos);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /**
         * Método que obtiene el estado correspondiente al Id que se pasa como argumento
         * ds - DataSet con las tablas de la base de datos
         * id - Id del estado qeu se está buscando
         */
        public static EstadoAsiento obtenerEstadosAsientoId(DSCine ds, int id)
        {
            try
            {
                EstadoAsientosTableAdapter ta = new EstadoAsientosTableAdapter();
                ta.FillById(ds.EstadoAsientos, id);

                //Se recoge la primera fila que coincida
                var fila = ds.EstadoAsientos.FirstOrDefault();

                if (fila != null)
                {
                    //Se crea un objeto EstadoAsiento para despues devolverlo
                    return new EstadoAsiento(
                        fila.Id,
                        fila.Estado
                    );
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener el estado del asiento: " + ex.Message);
            }

            //En caso de no encontrar tal registro se devuelve null
            return null;
        }

        /**
         * Método que obtiene el estado correspondiente al nombre que se pasa como argumento
         * ds - DataSet con las tablas de la base de datos
         * nombre - Nombre del estado que se está buscando
         */
        public static EstadoAsiento obtenerEstadosAsientoNombre(DSCine ds, String nombre)
        {
            try
            {
                EstadoAsientosTableAdapter ta = new EstadoAsientosTableAdapter();
                ta.FillByNombre(ds.EstadoAsientos, nombre);

                //Se recoge la primera fila que coincida
                var fila = ds.EstadoAsientos.FirstOrDefault();

                if (fila != null)
                {
                    //Se crea un objeto EstadoAsiento para despues devolverlo
                    return new EstadoAsiento(
                        fila.Id,
                        fila.Estado
                    );
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener el estado del asiento: " + ex.Message);
            }

            //En caso de no encontrar tal registro se devuelve null
            return null;
        }

        /**
         * Método que actualiza la tabla EstadoAsientos con los datos de todos los registros
         * ds - DataSet con las tablas de la base de datos
         */
        public static void actualizarEstadoAsientos(DSCine ds)
        {
            try
            {
                EstadoAsientosTableAdapter ta = new EstadoAsientosTableAdapter();

                ta.Update(ds.EstadoAsientos);

                ds.EstadoAsientos.AcceptChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
