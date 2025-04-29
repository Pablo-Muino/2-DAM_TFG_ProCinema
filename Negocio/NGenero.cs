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
    public class NGenero
    {
        /**
         * Método que obtiene todos los generos de la tabla Genero
         * ds - DataSet con las tablas de la base de datos
         */
        public static void obtenerGeneros(DSCine ds)
        {
            try
            {
                GeneroTableAdapter ta = new GeneroTableAdapter();

                ta.Fill(ds.Genero);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /**
         * Método que obtiene el nombre de un género de la tabla Genero mediante su id
         * ds - DataSet con las tablas de la base de datos
         * id - Id con el que se buscará al empleado
         */
        public static string ObtenerNombreGeneroById(DSCine ds, int idGenero)
        {
            try
            {
                GeneroTableAdapter taGenero = new GeneroTableAdapter();
                taGenero.FillById(ds.Genero, idGenero);

                if (ds.Genero.Rows.Count > 0)
                {
                    return ds.Genero.Rows[0]["Genero"].ToString();
                }
                else
                {
                    return "Desconocido";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "Error: No se pudo obtener el nombre del género";
            }
        }

        /**
         * Método que actualiza la tabla Genero con los datos de todos los registros
         * ds - DataSet con las tablas de la base de datos
         */
        public static void actualizarGenero(DSCine ds)
        {
            try
            {
                GeneroTableAdapter ta = new GeneroTableAdapter();

                ta.Update(ds.Genero);

                ds.Genero.AcceptChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
