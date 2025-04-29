using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAD.DSCineTableAdapters;
using CAD;

namespace Negocio
{
    public class NEmpleados
    {
        /**
         * Método que obtiene todos los empleados de la tabla Empleado
         * ds - DataSet con las tablas de la base de datos
         */
        public static void obtenerEmpleados(DSCine ds)
        {
            try
            {
                EmpleadosTableAdapter ta = new EmpleadosTableAdapter();

                ta.Fill(ds.Empleados);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /**
         * Método que obtiene un empleado de la tabla Empleados mediante su id de usuario
         * ds - DataSet con las tablas de la base de datos
         * id_usuario - Id con el que se buscará al empleado
         */
        public static void obtenerEmpleadoByUsuario(DSCine ds, int id_usuario)
        {
            try
            {
                EmpleadosTableAdapter ta = new EmpleadosTableAdapter();

                ta.FillByUsuario(ds.Empleados, id_usuario);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /**
         * Método que actualiza la tabla Empleados con los datos de todos los registros
         * ds - DataSet con las tablas de la base de datos
         */
        public static void actualizarEmpleados(DSCine ds)
        {
            try
            {
                EmpleadosTableAdapter ta = new EmpleadosTableAdapter();

                ta.Update(ds.Empleados);

                ds.Empleados.AcceptChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
