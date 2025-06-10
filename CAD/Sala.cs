using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAD
{
    public class Sala
    {
        /**
         * Propiedades de una sala
         */
        private String nombre;
        private int capacidad;

        /**
         * Constructor de la clase
         * nombre - Nombre de la sala
         * capacidad - Capacidad de la sala
         */
        public Sala(string nombre, int capacidad)
        {
            this.nombre = nombre;
            this.capacidad = capacidad;
        }

        /**
         * Getters y Setters
         */
        public string Nombre { get => nombre; set => nombre = value; }
        public int Capacidad { get => capacidad; set => capacidad = value; }
    }
}
