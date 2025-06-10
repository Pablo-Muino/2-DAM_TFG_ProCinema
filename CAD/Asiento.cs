using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAD
{
    public class Asiento
    {
        /**
         * Propiedades de un Asiento
         */
        private int id;
        private int idSala;
        private int numFila;
        private int numColumna;
        private bool inhabilitado;

        /**
         * Constructor de la clase
         * id - Identificador único del asiento
         * idSala - Identificador único de la sala donde se encuentra el asiento
         * numFila - Número de fila donde se encuentra el asiento
         * numColumna - Número de la columna donde se encuentra el asiento
         * inhabilitado - Dicta si el asiento está habilitado o no
         */
        public Asiento(int id, int idSala, int numFila, int numColumna, bool inhabilitado)
        {
            this.id = id;
            this.idSala = idSala;
            this.numFila = numFila;
            this.numColumna = numColumna;
            this.inhabilitado = inhabilitado;
        }

        /**
         * Getters y Setters
         */
        public int Id { get => id; set => id = value; }
        public int IdSala { get => idSala; set => idSala = value; }
        public int NumFila { get => numFila; set => numFila = value; }
        public int NumColumna { get => numColumna; set => numColumna = value; }
        public bool Inhabilitado { get => inhabilitado; set => inhabilitado = value; }
    }
}
