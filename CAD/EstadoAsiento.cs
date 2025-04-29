using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAD
{
    public class EstadoAsiento
    {
        private int id;
        private string estado;

        public EstadoAsiento(int id, string estado)
        {
            this.id = id;
            this.estado = estado;
        }

        public int Id { get => id; set => id = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
