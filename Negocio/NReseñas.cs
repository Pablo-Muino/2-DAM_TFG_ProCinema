using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAD.DSCineTableAdapters;
using CAD;
using System.Diagnostics;

namespace Negocio
{
    public class NReseñas
    {
        /**
         * Método que obtiene todos las reseñas de la tabla Reseñas
         * ds - DataSet con las tablas de la base de datos
         */
        public static void obtenerReseñas(DSCine ds)
        {
            try
            {
                ReseñasTableAdapter ta = new ReseñasTableAdapter();

                ta.Fill(ds.Reseñas);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /**
         * Método que obtiene todos las reseñas de la tabla Reseñas y las devuelve en forma de lista
         * ds - DataSet con las tablas de la base de datos
         */
        public static List<Reseña> obtenerListaReseñas(DSCine ds)
        {
            List<Reseña> reseñas = new List<Reseña>();

            try
            {
                ReseñasTableAdapter ta = new ReseñasTableAdapter();
                ta.Fill(ds.Reseñas);

                //Por cada registro encontrado se crea un objeto Reseña y se añade a la lista
                foreach (var fila in ds.Reseñas)
                {
                    Reseña reseña = new Reseña(
                        fila.IdPelicula,
                        fila.IdUsuario,
                        fila.Calificacion,
                        fila.Comentario,
                        fila.Fecha
                    );

                    reseñas.Add(reseña);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //Se devuelve la lista con las reseñas
            return reseñas;
        }

        /**
         * Método que obtiene todos las reseñas de la tabla Reseñas cuya película coincide con la dada como argumento y las devuelve en forma de lista
         * ds - DataSet con las tablas de la base de datos
         * idPelicula - Id de la película que se utilizará como filtro en las reseñas
         */
        public static List<Reseña> obtenerListaReseñasIdPelicula(DSCine ds, int idPelicula)
        {
            List<Reseña> reseñas = new List<Reseña>();

            try
            {
                ReseñasTableAdapter ta = new ReseñasTableAdapter();

                ta.Fill(ds.Reseñas);

                //Por cada registro encontrado se crea un objeto Reseña y se añade a la lista
                foreach (var fila in ds.Reseñas)
                {
                    if (fila.IdPelicula == idPelicula)
                    {
                        Reseña reseña = new Reseña(
                            fila.IdPelicula,
                            fila.IdUsuario,
                            fila.Calificacion,
                            fila.Comentario,
                            fila.Fecha
                        );
                        reseñas.Add(reseña);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //Se devuelve la lista con las reseñas
            return reseñas;
        }

        /**
         * Método que actualiza la tabla Reseñas con los datos de todos los registros
         * ds - DataSet con las tablas de la base de datos
         */
        public static void actualizarReseñas(DSCine ds)
        {
            try
            {
                ReseñasTableAdapter ta = new ReseñasTableAdapter();

                ta.Update(ds.Reseñas);

                ds.Reseñas.AcceptChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /**
         * Método que inserta una nueva reseña a la tabla Reseñas
         * ds - DataSet con las tablas de la abase de datos
         * reseña - La reseña que se quiere insertar
         */
        public static void insertarReseña(DSCine ds, Reseña reseña)
        {
            ReseñasTableAdapter taReseñas = new ReseñasTableAdapter();

            taReseñas.Insert(
                reseña.IdPelicula,
                reseña.IdUsuario,
                reseña.Comentario,
                reseña.Fecha,
                reseña.Calificacion
            );

            // Recarga la tabla después de insertar
            taReseñas.Fill(ds.Reseñas);
        }
    }
}
