using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CAD
{
    public class Sesion
    {
        private int id;
        private int idPelicula;
        private TimeSpan horaInicio;
        private DateTime fecha;
        private int idSala;

        public Sesion(int id, int idPelicula, TimeSpan horaInicio, DateTime fecha, int idSala)
        {
            this.id = id;
            this.idPelicula = idPelicula;
            this.horaInicio = horaInicio;
            this.fecha = fecha;
            this.idSala = idSala;
        }

        public int Id { get => id; set => id = value; }
        public int IdPelicula { get => idPelicula; set => idPelicula = value; }
        public TimeSpan HoraInicio { get => horaInicio; set => horaInicio = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int IdSala { get => idSala; set => idSala = value; }
    }
}
