using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAD.DSCineTableAdapters;
using CAD;

namespace Negocio
{
    public class NEstadoEmpleados
    {
        /**
         * Método que obtiene todos los estados de los empleados de la tabla EstadoEmpleados
         * ds - DataSet con las tablas de la base de datos
         */
        public static void obtenerEstadosEmpleados(DSCine ds)
        {
            try
            {
                EstadoEmpleadosTableAdapter ta = new EstadoEmpleadosTableAdapter();

                ta.Fill(ds.EstadoEmpleados);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /**
         * Método que actualiza la tabla EstadoEmpleados con los datos de todos los registros
         * ds - DataSet con las tablas de la base de datos
         */
        public static void actualizarEstadoEmpleados(DSCine ds)
        {
            try
            {
                EstadoEmpleadosTableAdapter ta = new EstadoEmpleadosTableAdapter();

                ta.Update(ds.EstadoEmpleados);

                ds.EstadoEmpleados.AcceptChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
