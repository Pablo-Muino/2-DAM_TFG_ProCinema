using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAD
{
    public class Asiento
    {
        private int id;
        private int idSala;
        private int numFila;
        private int numColumna;

        public Asiento(int id, int idSala, int numFila, int numColumna)
        {
            this.id = id;
            this.idSala = idSala;
            this.numFila = numFila;
            this.numColumna = numColumna;
        }

        public int Id { get => id; set => id = value; }
        public int IdSala { get => idSala; set => idSala = value; }
        public int NumFila { get => numFila; set => numFila = value; }
        public int NumColumna { get => numColumna; set => numColumna = value; }
    }
}
