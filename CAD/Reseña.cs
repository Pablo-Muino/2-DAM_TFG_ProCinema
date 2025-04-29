using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAD
{
    public class Reseña
    {
        private int idPelicula;
        private int idUsuario;
        private int calificacion;
        private String comentario;
        private DateTime fecha;

        /**
         * Constructor de la clase
         * idPelicula - Id referente a la película de la reseña
         * idUsuario - Id referente al usuario que hace la reseña
         * calificacion - Calificación que se le ha dado a la película
         * comentario - Opinión que el usuario ha escrito sobre la película
         * fecha - Fecha de la creación de la reseña
         */
        public Reseña(int idPelicula, int idUsuario, int calificacion, string comentario, DateTime fecha)
        {
            this.idPelicula = idPelicula;
            this.idUsuario = idUsuario;
            this.calificacion = calificacion;
            this.comentario = comentario;
            this.fecha = fecha;
        }

        public int IdPelicula { get => idPelicula; set => idPelicula = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public int Calificacion { get => calificacion; set => calificacion = value; }
        public string Comentario { get => comentario; set => comentario = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
    }
}
