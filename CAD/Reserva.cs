using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAD
{
    public class Reserva
    {
        private int idUsuario;
        private int idSesion;
        private int idAsiento;
        private DateTime fechaReserva;
        private int idEstadoPago;

        public Reserva(int idUsuario, int idSesion, int idAsiento, DateTime fechaReserva, int idEstadoPago)
        {
            this.idUsuario = idUsuario;
            this.idSesion = idSesion;
            this.idAsiento = idAsiento;
            this.fechaReserva = fechaReserva;
            this.idEstadoPago = idEstadoPago;
        }

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public int IdSesion { get => idSesion; set => idSesion = value; }
        public int IdAsiento { get => idAsiento; set => idAsiento = value; }
        public DateTime FechaReserva { get => fechaReserva; set => fechaReserva = value; }
        public int IdEstadoPago { get => idEstadoPago; set => idEstadoPago = value; }
    }
}
