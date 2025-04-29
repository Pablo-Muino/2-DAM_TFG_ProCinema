using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAD
{
    public class Genero
    {
        /**
         * Propiedades de un usuario
         */
        private int id;
        private string nombreGenero;

        /**
         * Constructor de la clase
         * id - Identificador único del usuario
         * nombreGenero - Nombre del género
         */
        public Genero(int id, string nombreGenero)
        {
            this.id = id;
            this.nombreGenero = nombreGenero;
        }

        /**
         * Getters y Setters
         */
        public int Id { get => id; set => id = value; }
        public string NombreGenero { get => nombreGenero; set => nombreGenero = value; }
    }
}
