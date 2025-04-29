using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAD.DSCineTableAdapters;
using CAD;

namespace Negocio
{
    public class NEstadoPago
    {
        /**
         * Método que obtiene todos los estados del pago de la tabla EstadoPago
         * ds - DataSet con las tablas de la base de datos
         */
        public static void obtenerEstadosPago(DSCine ds)
        {
            try
            {
                EstadoPagoTableAdapter ta = new EstadoPagoTableAdapter();

                ta.Fill(ds.EstadoPago);

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
        public static void actualizarEstadoPago(DSCine ds)
        {
            try
            {
                EstadoPagoTableAdapter ta = new EstadoPagoTableAdapter();

                ta.Update(ds.EstadoPago);

                ds.EstadoPago.AcceptChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
