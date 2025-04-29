using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAD
{
    public class Usuario
    {
        /**
         * Propiedades de un usuario
         */
        private int id;
        private string nombre;
        private string correo;
        private string contraseña;
        private int puntos;

        /**
         * Constructor de la clase
         * id - Identificador único del usuario
         * nombre - Nombre del usuario
         * correo - Correo electrónico asociado al usuario
         * contraseña - Contraseña del usuario
         * puntos - Puntos que ha obtenido el usuario por reservar en la aplicación
         */
        public Usuario(int id, string nombre, string correo, string contraseña, int puntos)
        {
            this.id = id;
            this.nombre = nombre;
            this.correo = correo;
            this.contraseña = contraseña;
            this.puntos = puntos;
        }

        /**
         * Getters y Setters
         */
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public int Puntos { get => puntos; set => puntos = value; }
    }
}
