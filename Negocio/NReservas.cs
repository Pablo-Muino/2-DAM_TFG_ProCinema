using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAD.DSCineTableAdapters;
using CAD;
using System.Data;

namespace Negocio
{
    public class NReservas
    {
        /**
         * Método que obtiene todos las reservas de la tabla Reservas
         * ds - DataSet con las tablas de la base de datos
         */
        public static void obtenerReservas(DSCine ds)
        {
            try
            {
                ReservasTableAdapter ta = new ReservasTableAdapter();

                ta.Fill(ds.Reservas);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /**
         * Método que agrega una nueva reserva a la tabla Reservas
         */
        public static void agregarReserva(DSCine ds, Usuario usuario, Sesion sesion, Asiento asiento, Cupon cupon)
        {
            try
            {
                DataRow nuevaFila = ds.Reservas.NewRow();
                nuevaFila["IdUsuario"] = usuario.Id;
                nuevaFila["IdSesion"] = sesion.Id;
                nuevaFila["IdAsiento"] = asiento.Id;
                nuevaFila["FechaReserva"] = DateTime.Now;
                nuevaFila["IdEstadoPago"] = 2; // Pendiente de pago
                nuevaFila["IdCupon"] = (cupon?.Id);

                ds.Reservas.Rows.Add(nuevaFila);

                //Se guardan los cambios en la base de datos
                ReservasTableAdapter ta = new ReservasTableAdapter();
                ta.Update(ds.Reservas);
                ds.Reservas.AcceptChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al agregar reserva: " + ex.Message);
            }
        }

        /**
         * Método que actualiza la tabla Reservas con los datos de todos los registros
         * ds - DataSet con las tablas de la base de datos
         */
        public static void actualizarReservas(DSCine ds)
        {
            try
            {
                ReservasTableAdapter ta = new ReservasTableAdapter();

                ta.Update(ds.Reservas);

                ds.Reservas.AcceptChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
