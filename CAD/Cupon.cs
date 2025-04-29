using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAD
{
    public class Cupon
    {
        /**
         * Propiedades de una cupón
         */
        private int id;
        private String descripcion;
        private String imagen;
        private DateTime fechaInicio;
        private DateTime fechaCaducidad;
        private int costePuntos;

        /**
         * Constructor de la clase
         * descripcion - Descripción del cupón
         * imagen - Url a la imagen representativa del cupón
         * fechaInicio - Fecha en la que se puso vigente este cupón
         * fechaCaducidad - Fecha en la que caduca el cupón
         * costePuntos - Coste de puntos para canjear este cupón
         */
        public Cupon(int id, string descripcion, string imagen, DateTime fechaInicio, DateTime fechaCaducidad, int costePuntos)
        {
            this.id = id;
            this.descripcion = descripcion;
            this.imagen = imagen;
            this.fechaInicio = fechaInicio;
            this.fechaCaducidad = fechaCaducidad;
            this.costePuntos = costePuntos;
        }

        /**
         * Getters y Setters
         */
        public int Id { get => id; set => id = value; }
        public String Descripcion { get => descripcion; set => descripcion = value; }
        public String Imagen { get => imagen; set => imagen = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaCaducidad { get => fechaCaducidad; set => fechaCaducidad = value; }
        public int CostePuntos { get => costePuntos; set => costePuntos = value; }
    }
}
