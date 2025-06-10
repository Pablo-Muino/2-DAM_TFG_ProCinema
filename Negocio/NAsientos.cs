using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAD;
using CAD.DSCineTableAdapters;

namespace Negocio
{
    public class NAsientos
    {
        /**
         * Método que obtiene todos los asientos de la tabla Asientos
         * ds - DataSet con las tablas de la base de datos
         */
        public static void obtenerAsientos(DSCine ds)
        {
            try
            {
                AsientosTableAdapter ta = new AsientosTableAdapter();

                ta.Fill(ds.Asientos);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /**
         * Método que obtiene todos los asientos de la tabla Asientos mediante el Id de la sala y los devuelve en forma de lista
         * ds - DataSet con las tablas de la base de datos
         * idSala - Id de la sala de los asientos
         */
        public static List<Asiento> obtenerListaAsientosSala(DSCine ds, int idSala)
        {
            List<Asiento> asientos = new List<Asiento>();

            try
            {
                AsientosTableAdapter ta = new AsientosTableAdapter();
                ta.FillBySala(ds.Asientos, idSala);

                //Por cada registro encontrado se crea un objeto Asiento y se añade a la lista
                foreach (var row in ds.Asientos)
                {
                    Asiento asiento = new Asiento(
                        row.Id,
                        row.IdSala,
                        row.NumFila,
                        row.NumColumna,
                        row.Inhabilitado
                    );

                    asientos.Add(asiento);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //Se devuelve la lista con los Asientos
            return asientos;
        }

        /**
         * Método que actualiza la tabla Asientos con los datos de todos los registros
         * ds - DataSet con las tablas de la base de datos
         */
        public static void actualizarAsientos(DSCine ds)
        {
            try
            {
                AsientosTableAdapter ta = new AsientosTableAdapter();

                ta.Update(ds.Asientos);

                ds.Asientos.AcceptChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
