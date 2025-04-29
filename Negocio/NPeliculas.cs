using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAD.DSCineTableAdapters;
using CAD;

namespace Negocio
{
    public class NPeliculas
    {
        /**
         * Método que obtiene todos las peliculas de la tabla Peliculas
         * ds - DataSet con las tablas de la base de datos
         */
        public static void obtenerPeliculas(DSCine ds)
        {
            try
            {
                PeliculasTableAdapter ta = new PeliculasTableAdapter();

                ta.Fill(ds.Peliculas);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /**
         * Método que obtiene todos las películas de la tabla Pelicula y las devuelve en forma de lista
         * ds - DataSet con las tablas de la base de datos
         */
        public static List<Pelicula> obtenerListaPeliculas(DSCine ds)
        {
            List<Pelicula> peliculas = new List<Pelicula>();

            try
            {
                PeliculasTableAdapter ta = new PeliculasTableAdapter();
                ta.Fill(ds.Peliculas);

                //Por cada registro encontrado se crea un objeto Pelicula y se añade a la lista
                foreach (var fila in ds.Peliculas)
                {
                    Pelicula pelicula = new Pelicula(
                        fila.Id,
                        fila.Titulo,
                        fila.IdGenero,
                        fila.Sinopsis,
                        fila.Duracion,
                        fila.IsCalificacionNull() ? 0.0 : (double)fila.Calificacion,
                        fila.Portada
                    );

                    peliculas.Add(pelicula);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //Se devuelve la lista con las Peliculas
            return peliculas;
        }

        /**
         * Método que obtiene una película de la tabla Peliculas mediante su id
         * ds - DataSet con las tablas de la base de datos
         * id - Id de la película que se quiere obtener
         */
        public static Pelicula obtenerPeliculaId(DSCine ds, int id)
        {
            try
            {
                PeliculasTableAdapter ta = new PeliculasTableAdapter();
                ta.FillById(ds.Peliculas, id);

                //Se recoge la primera fila que coincida
                var fila = ds.Peliculas.FirstOrDefault();

                if (fila != null)
                {
                    //Se crea un objeto Usuario para despues devolverlo
                    return new Pelicula(
                        fila.Id,
                        fila.Titulo,
                        fila.IdGenero,
                        fila.Sinopsis,
                        fila.Duracion,
                        fila.IsCalificacionNull() ? 0.0 : (double)fila.Calificacion,
                        fila.Portada
                    );
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener la película: " + ex.Message);
            }

            //En caso de no encontrar tal registro se devuelve null
            return null;
        }

        /**
         * Método que actualiza la tabla Peliculas con los datos de todos los registros
         * ds - DataSet con las tablas de la base de datos
         */
        public static void actualizarPeliculas(DSCine ds)
        {
            try
            {
                PeliculasTableAdapter ta = new PeliculasTableAdapter();

                ta.Update(ds.Peliculas);

                ds.Peliculas.AcceptChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
