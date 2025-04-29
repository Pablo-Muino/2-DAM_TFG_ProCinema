using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAD.DSCineTableAdapters;
using CAD;

namespace Negocio
{
    public class NPuestosTrabajo
    {
        /**
         * Método que obtiene todos los puestos de trabajo de la tabla PuestosTrabajo
         * ds - DataSet con las tablas de la base de datos
         */
        public static void obtenerPuestosTrabajo(DSCine ds)
        {
            try
            {
                PuestosTrabajoTableAdapter ta = new PuestosTrabajoTableAdapter();

                ta.Fill(ds.PuestosTrabajo);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /**
         * Método que actualiza la tabla PuestosTrabajo con los datos de todos los registros
         * ds - DataSet con las tablas de la base de datos
         */
        public static void actualizarPuestosTrabajo(DSCine ds)
        {
            try
            {
                PuestosTrabajoTableAdapter ta = new PuestosTrabajoTableAdapter();

                ta.Update(ds.PuestosTrabajo);

                ds.PuestosTrabajo.AcceptChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
