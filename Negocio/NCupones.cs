using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAD.DSCineTableAdapters;
using CAD;

namespace Negocio
{
    public class NCupones
    {
        /**
         * Método que obtiene todos los cupones de la tabla Cupones
         * ds - DataSet con las tablas de la base de datos
         */
        public static void obtenerCupones(DSCine ds)
        {
            try
            {
                CuponesTableAdapter ta = new CuponesTableAdapter();

                ta.Fill(ds.Cupones);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /**
         * Método que obtiene todos los cupones de la tabla Cupones y las devuelve en forma de lista
         * ds - DataSet con las tablas de la base de datos
         */
        public static List<Cupon> obtenerListaCupones(DSCine ds)
        {
            List<Cupon> cupones = new List<Cupon>();

            try
            {
                CuponesTableAdapter ta = new CuponesTableAdapter();
                ta.Fill(ds.Cupones);

                //Por cada registro encontrado se crea un objeto Cupon y se añade a la lista
                foreach (var fila in ds.Cupones)
                {
                    Cupon cupón = new Cupon(
                        fila.Id,
                        fila.Descripcion,
                        fila.Imagen,
                        fila.FechaInicio,
                        fila.FechaCaducidad,
                        fila.CostePuntos
                    );

                    cupones.Add(cupón);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //Se devuelve la lista con los cupones
            return cupones;
        }

        /**
         * Método que actualiza la tabla Cupones con los datos de todos los registros
         * ds - DataSet con las tablas de la base de datos
         */
        public static void actualizarCupones(DSCine ds)
        {
            try
            {
                CuponesTableAdapter ta = new CuponesTableAdapter();

                ta.Update(ds.Cupones);

                ds.Cupones.AcceptChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
