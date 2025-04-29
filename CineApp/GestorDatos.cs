using System;
using System.Data;
using System.Windows.Forms;
using CAD;
using Negocio;

/**
 * Clase que gestiona las operaciones CRUD referentes a las tablas del proyecto
 */
public class GestorDatos
{
    /**
     * Variables de la clase:
     * editando - Dicta si el usuario está editando un registro o no
     * filaAnterior - Registro que se estaba editando antes de cambiar a otro (queriendo o sin querer)
     */
    public static bool editando { get; private set; } = false;
    private static DataGridViewRow filaAnterior = null;

    /**
     * Método que agrega un nuevo registro en la tabla del bindingSource especificado
     * bs - BindingSource relacionado con la tabla a la que se quiere agregar un nuevo registro
     * pan - Panel donde se encuentran los campos referentes a la tabla del bindingSource
     */
    public static void AgregarRegistro(BindingSource bs, Panel pan)
    {
        //Si se está editando un registro no se podrá efectuar la operación
        if (editando)
        {
            MessageBox.Show("Termina o cancela la operación actual antes de agregar un nuevo registro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        //Se habilita el panel de campos para que el usuario introduzca los datos, se inicializa la creación del registro y se establace que se está editando
        pan.Enabled = true;
        bs.AddNew();
        editando = true;
    }

    /**
     * Método que edita un registro de la tabla del dataGridView especificado
     * dgv - DataGridView donde se estan mostrando todos los registros de la tabla actual
     * pan - Panel donde se encuentran los campos referentes a la tabla del dataGridView
     */
    public static void EditarRegistro(DataGridView dgv, Panel pan)
    {
        //Si no se ha seleccionado un registro aún se avisa al usuario
        if (dgv.CurrentRow == null)
        {
            MessageBox.Show("Selecciona un registro para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        //Si ya se estaba editando un registro no se podrá efectuar la operación
        if (editando)
        {
            MessageBox.Show("Termina o cancela la operación actual antes de editar otro registro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        //Se habilita el panel de campos, se guarda la fila que se está editando actualmente y se establece que se está editando
        pan.Enabled = true;
        filaAnterior = dgv.CurrentRow;
        editando = true;
    }

    /**
     * Método que elimina un registro de la tabla del bindingSource especificado
     * bs - BindingSource relacionado con la tabla a la que se quiere eliminar un nuevo registro
     * dgv - DataGridView donde se estan mostrando todos los registros de la tabla actual
     * actualizar - Método que actualiza la tabla actual y todos sus registros
     */
    public static void EliminarRegistro(BindingSource bs, DataGridView dgv, Action actualizar)
    {
        //Si no se ha seleccionado aún ningún registro se le informa al usuario
        if (dgv.CurrentRow == null)
        {
            MessageBox.Show("Selecciona un registro para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        //Se advierte al usuario de la operación que va a realizar
        DialogResult result = MessageBox.Show("¿Deseas eliminar este registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (result == DialogResult.Yes)
        {
            try
            {
                //Se elimina el registro y se actualiza la tabla ya con el registro eliminado
                bs.RemoveCurrent();
                actualizar();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error al eliminar el registro: " + err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    /**
     * Método que finaliza las operaciónes que se estan llevando a cabo (agregar o editar)
     * bs - BindingSource relacionado con la tabla a la que se quiere eliminar un nuevo registro
     * pan - Panel donde se encuentran los campos referentes a la tabla del dataGridView
     * actualizar - Método que actualiza la tabla actual y todos sus registros
     */
    public static void AceptarCambios(BindingSource bs, Panel pan, Action actualizar)
    {
        //Se vuelve a deshabilitar el panel de campos, se termina la operación de edición y se establece que ya no se está editando
        pan.Enabled = false;
        bs.EndEdit();
        editando = false;

        //Se actualiza la tabla ya con el registro agregado o editado
        actualizar();
    }

    /**
     * Método que cancela las operaciónes que se estan llevando a cabo (agregar o editar)
     * bs - BindingSource relacionado con la tabla a la que se quiere eliminar un nuevo registro
     * pan - Panel donde se encuentran los campos referentes a la tabla del dataGridView
     */
    public static void CancelarCambios(BindingSource bs, Panel pan)
    {
        //Se avisa al usuario de lo que va a hacer
        DialogResult result = MessageBox.Show("¿Deseas cancelar la operación? Se perderán los datos introducidos.", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (result == DialogResult.Yes)
        {
            //Se cancela la edición del registro, se vuelve a deshabilitar el panel de campos y se establece que ya no se está editando
            bs.CancelEdit();
            pan.Enabled = false;
            editando = false;
        }
    }

    /**
     * Método que controla el cambio de selección de registro (ya sea queriendo o sin querer)
     * dgv - DataGridView donde se estan mostrando todos los registros de la tabla actual
     * bs - BindingSource relacionado con la tabla a la que se quiere eliminar un nuevo registro
     * pan - Panel donde se encuentran los campos referentes a la tabla del dataGridView
     * restaurandoSeleccion - Referencia a la variable que dicta si se está restaurando la selección del registro que se estaba editando (filaAnterior)
     * filaAnterior - Referencia al registro que se estaba editando antes de cambiar a otro (queriendo o sin querer)
     */
    public static void CambioSeleccion(DataGridView dgv, BindingSource bs, Panel pan, ref bool restaurandoSeleccion, ref DataGridViewRow filaAnterior)
    {
        //Si se estaba restaurando una selección anterior no se hace nada para evitar recursividad
        if (restaurandoSeleccion)
        {
            return;
        }

        //Si se estaba editando un registro se avisa al usuario
        if (editando)
        {
            DialogResult result = MessageBox.Show("Tienes cambios sin guardar. ¿Deseas descartarlos?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                //Si la fila anterior (la que se estaba editando) no es null, ésta se recupera
                if (filaAnterior != null)
                {
                    //Se establece que se está restaurando la selección
                    restaurandoSeleccion = true;

                    //Se establece que la fila seleccionada en el dataGridView sea la anterior y ésta fila se selecciona
                    dgv.CurrentCell = null;
                    dgv.CurrentCell = filaAnterior.Cells[0];
                    filaAnterior.Selected = true;

                    //Se establece que ya no se está restaurando la selección
                    restaurandoSeleccion = false;
                }
            }
            else
            {
                //En caso contrario se descartan los cambios, se deshabilita el panel de campos y se establece que ya no se está editando
                bs.CancelEdit();
                pan.Enabled = false;
                editando = false;

                //Se establece que la filaAnterior sea la actual (a la que se acaba de cambiar)
                filaAnterior = dgv.CurrentRow;
            }

            return;
        }

        // Si no se está editando y la fila actual no es null, se establece que la filaAnterior sea la actual (a la que se acaba de cambiar)
        if (!editando && dgv.CurrentRow != null)
        {
            filaAnterior = dgv.CurrentRow;
        }
    }

}
