using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAD.DSCineTableAdapters;
using CAD;

namespace Negocio
{
    public class NSalas
    {
        /**
         * Método que obtiene todos las salas de la tabla Salas
         * ds - DataSet con las tablas de la base de datos
         */
        public static void obtenerSalas(DSCine ds)
        {
            try
            {
                SalasTableAdapter ta = new SalasTableAdapter();

                ta.Fill(ds.Salas);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /**
         * Método que actualiza la tabla Salas con los datos de todos los registros
         * ds - DataSet con las tablas de la base de datos
         */
        public static void actualizarSalas(DSCine ds)
        {
            try
            {
                SalasTableAdapter ta = new SalasTableAdapter();

                ta.Update(ds.Salas);

                ds.Salas.AcceptChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
