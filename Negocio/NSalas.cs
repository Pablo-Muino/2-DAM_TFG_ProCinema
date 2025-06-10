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
         * Método que obtiene una sala de la tabla Salas mediante su id
         * ds - DataSet con las tablas de la base de datos
         * id - Id de la sala que se quiere obtener
         */
        public static Sala obtenerSalaId(DSCine ds, int id)
        {
            try
            {
                SalasTableAdapter ta = new SalasTableAdapter();
                ta.FillById(ds.Salas, id);

                //Se recoge la primera fila que coincida
                var fila = ds.Salas.FirstOrDefault();

                if (fila != null)
                {
                    //Se crea un objeto Sala para despues devolverlo
                    return new Sala(
                        fila.Nombre,
                        int.Parse(fila.Capacidad)
                    );
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener la sala: " + ex.Message);
            }

            //En caso de no encontrar tal registro se devuelve null
            return null;
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
