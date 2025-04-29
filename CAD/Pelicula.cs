using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAD
{
    public class Pelicula
    {
        /**
         * Propiedades de una pelicula
         */
        private int id;
        private String titulo;
        private int idGenero;
        private String sinopsis;
        private int duracion;
        private double calificacion;
        private String portada;

        /**
         * Constructor de la clase
         * titulo - Título de la película
         * idGenero - Id referente al género de la película
         * duracion - Duración de la película
         * calificacion - Media de las calificaciónes que se le han dado a la película
         * portada - Link a la imágen de portada de la película
         */
        public Pelicula(int id, string titulo, int idGenero, string sinopsis, int duracion, double calificacion, string portada)
        {
            this.id = id;
            this.titulo = titulo;
            this.idGenero = idGenero;
            this.sinopsis = sinopsis;
            this.duracion = duracion;
            this.calificacion = calificacion;
            this.portada = portada;
        }

        /**
         * Getters y Setters
         */
        public int Id { get => id; set => id = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public int IdGenero { get => idGenero; set => idGenero = value; }
        public string Sinopsis { get => sinopsis; set => sinopsis = value; }
        public int Duracion { get => duracion; set => duracion = value; }
        public double Calificacion { get => calificacion; set => calificacion = value; }
        public string Portada { get => portada; set => portada = value; }
    }
}
