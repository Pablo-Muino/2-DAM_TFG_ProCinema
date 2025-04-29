using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAD
{
    public class SesionAsiento
    {
        private int id;
        private int idSesion;
        private int idAsiento;
        private int idEstado;

        public SesionAsiento(int id, int idSesion, int idAsiento, int idEstado)
        {
            this.id = id;
            this.idSesion = idSesion;
            this.idAsiento = idAsiento;
            this.idEstado = idEstado;
        }

        public int Id { get => id; set => id = value; }
        public int IdSesion { get => idSesion; set => idSesion = value; }
        public int IdAsiento { get => idAsiento; set => idAsiento = value; }
        public int IdEstado { get => idEstado; set => idEstado = value; }
    }
}
