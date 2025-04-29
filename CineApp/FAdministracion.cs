using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAD;
using CAD.DSCineTableAdapters;
using Negocio;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CineApp
{
    public partial class FAdministracion : Form
    {
        /**
         * Variables de la clase:
         * usuario - Usuario que se ha loggeado en la aplicación
         * editando - Dicta si el usuario está editando un registro o no
         * filaAnterior - Registro que se estaba editando antes de cambiar a otro (queriendo o sin querer)
         * restaurandoSeleccion - Dicta si se está restaurando la selección del registro que se estaba editando (filaAnterior)
         */
        private Usuario usuario;
        //private bool editando = false;
        private DataGridViewRow filaAnterior = null;
        private bool restaurandoSeleccion = false;

        /**
         * Constructor de la clase
         * _usuario - El usuario que se ha loggeado en la aplicación
         */
        public FAdministracion(Usuario _usuario)
        {
            InitializeComponent();

            //Se establece que el usuario que ha entrado con sus credenciales sea el usuario loggeado
            this.usuario = _usuario;
        }

        /**
         * Evento que se lanza al cargar el formulario
         */
        private void FAdministracion_Load(object sender, EventArgs e)
        {
            //Al iniciar el formulario se mostrará el nombre del usuario loggeado
            lblUsuarioLog.Text = "Usuario loggeado: "+usuario.Nombre;

            //Se cargan los datos del tabPage actual (solo para el primer tabPage que aparece al iniciar la aplicación)
            CargarTabPag();
        }

        /**
         * Evento que se lanza al cambiar de tabPage
         */
        private void tabCtrlDatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Se cargan los datos del tabPage actual (para el resto de tabPages)
            CargarTabPag();
        }

        /**
         * Método que carga los datos de la tabla correspondiente al tabPage actual
         */
        private void CargarTabPag()
        {
            //Diccionario que guarda el nombre del tabPage y su referente acción para cargar sus datos
            var cargaDatos = new Dictionary<string, Action>
            {
                { "tabPagAsientos", () => CargarAsientos() },
                { "tabPagEmpleados", () => CargarEmpleados() },
                { "tabPagEstadoAsientos", () => CargarEstadoAsientos() },
                { "tabPagEstadoEmpleados", () => CargarEstadoEmpleados() },
                { "tabPagEstadoPago", () => CargarEstadoPago() },
                { "tabPagGenero", () => CargarGenero() },
                { "tabPagSesiones", () => CargarSesiones() },
                { "tabPagSesionAsientos", () => CargarSesionAsientos() },
                { "tabPagPeliculas", () => CargarPeliculas() },
                { "tabPagPuestosTrabajo", () => CargarPuestosTrabajo() },
                { "tabPagReseñas", () => CargarReseñas() },
                { "tabPagReservas", () => CargarReservas() },
                { "tabPagSalas", () => CargarSalas() },
                { "tabPagUsuarios", () => CargarUsuarios() },
                { "tabPagCupones", () => CargarCupones() }
            };

            //Si el diccionario contiene el tabPage actual se llama al método asociado para cargar los datos
            if (cargaDatos.ContainsKey(tabCtrlDatos.SelectedTab.Name))
            {
                cargaDatos[tabCtrlDatos.SelectedTab.Name]();
            }
        }

        /**
         * Método que carga los datos de la tabla Asientos en su dataGridView y puebla los comboBox adyacentes con sus respectivas columnas
         */
        private void CargarAsientos()
        {
            //Se puebla el dataGridView con la tabla Asientos
            NAsientos.obtenerAsientos(dsCine1);

            //Si no hay registros en el dataSet se avisa al usuario
            if (dsCine1.Asientos.Rows.Count == 0)
            {
                MessageBox.Show("No se cargaron asientos en la tabla.");
            }

            //Se puebla el comboBox de SalaAsientos indicando que el origen sea su tabla (Salas)
            SalasTableAdapter taSalas = new SalasTableAdapter();
            taSalas.Fill(dsCine1.Salas);
            cmbSalaAsientos.DataSource = dsCine1.Salas;
            cmbSalaAsientos.DisplayMember = "Nombre";
            cmbSalaAsientos.ValueMember = "Id";
        }

        /**
         * Al dar clic sobre este botón se agregará un asiento a la tabla Asientos
         */
        private void btnAgregarAsientos_Click(object sender, EventArgs e)
        {
            GestorDatos.AgregarRegistro(bsAsientos, panCamposAsientos);
        }

        /**
         * Al dar clic sobre este botón se editarán los datos de un asiento de la tabla Asientos
         */
        private void btnEditarAsientos_Click(object sender, EventArgs e)
        {
            GestorDatos.EditarRegistro(dgvAsientos, panCamposAsientos);
        }

        /**
         * Al dar clic sobre este botón se eliminará un asiento de la tabla Asientos
         */
        private void btnEliminarAsientos_Click(object sender, EventArgs e)
        {
            GestorDatos.EliminarRegistro(bsAsientos, dgvAsientos, () => NAsientos.actualizarAsientos(dsCine1));
        }

        /**
         * Al dar clic sobre este botón se efectuará la acción que se esté haciendo
         */
        private void btnAceptarAsientos_Click(object sender, EventArgs e)
        {
            GestorDatos.AceptarCambios(bsAsientos, panCamposAsientos, () => NAsientos.actualizarAsientos(dsCine1));
        }

        /**
         * Al dar clic sobre este botón se cancelará la acción que se esté haciendo
         */
        private void btnCancelarAsientos_Click(object sender, EventArgs e)
        {
            GestorDatos.CancelarCambios(bsAsientos, panCamposAsientos);
        }

        /**
         * Evento que controla el cambio de selección de registros dentro del dataGridView
         */
        private void dgvAsientos_SelectionChanged(object sender, EventArgs e)
        {
            GestorDatos.CambioSeleccion(dgvAsientos, bsAsientos, panCamposAsientos, ref restaurandoSeleccion, ref filaAnterior);
        }

        /**
         * Método que carga los datos de la tabla Empleados en su dataGridView y puebla los comboBox adyacentes con sus respectivas columnas
         */
        private void CargarEmpleados()
        {
            //Se puebla el dataGridView con la tabla Empleados
            NEmpleados.obtenerEmpleados(dsCine1);

            //Si no hay registros en el dataSet se avisa al usuario
            if (dsCine1.Empleados.Rows.Count == 0)
            {
                MessageBox.Show("No se cargaron empleados en la tabla.");
            }

            //Se puebla el comboBox de PuestoTrabajoEmpleados indicando que el origen sea su tabla (PuestosTrabajo)
            PuestosTrabajoTableAdapter taPuestosTrabajo = new PuestosTrabajoTableAdapter();
            taPuestosTrabajo.Fill(dsCine1.PuestosTrabajo);
            cmbPuestoTrabajoEmpleados.DataSource = dsCine1.PuestosTrabajo;
            cmbPuestoTrabajoEmpleados.DisplayMember = "Puesto";
            cmbPuestoTrabajoEmpleados.ValueMember = "Id";

            //Se puebla el comboBox de EstadoEmpleadosEmpleados indicando que el origen sea su tabla (EstadoEmpleados)
            EstadoEmpleadosTableAdapter taEstadoEmpleados = new EstadoEmpleadosTableAdapter();
            taEstadoEmpleados.Fill(dsCine1.EstadoEmpleados);
            cmbEstadoEmpleadosEmpleados.DataSource = dsCine1.EstadoEmpleados;
            cmbEstadoEmpleadosEmpleados.DisplayMember = "Estado";
            cmbEstadoEmpleadosEmpleados.ValueMember = "Id";

            //Se puebla el comboBox de UsuariosEmpleados indicando que el origen sea su tabla (Usuarios)
            UsuariosTableAdapter taUsuarios = new UsuariosTableAdapter();
            taUsuarios.Fill(dsCine1.Usuarios);
            cmbUsuariosEmpleados.DataSource = dsCine1.Usuarios;
            cmbUsuariosEmpleados.DisplayMember = "Nombre";
            cmbUsuariosEmpleados.ValueMember = "Id";
        }

        /**
         * Al dar clic sobre este botón se agregará un empleado a la tabla Empleados
         */
        private void btnAgregarEmpleados_Click(object sender, EventArgs e)
        {
            GestorDatos.AgregarRegistro(bsEmpleados, panCamposEmpleados);
        }

        /**
         * Al dar clic sobre este botón se editarán los datos de un empleado a la tabla Empleados
         */
        private void btnEditarEmpleados_Click(object sender, EventArgs e)
        {
            GestorDatos.EditarRegistro(dgvEmpleados, panCamposEmpleados);
        }

        /**
         * Al dar clic sobre este botón se eliminará un empleado de la tabla Empleados
         */
        private void btnEliminarEmpleados_Click(object sender, EventArgs e)
        {
            GestorDatos.EliminarRegistro(bsEmpleados, dgvEmpleados, () => NEmpleados.actualizarEmpleados(dsCine1));
        }

        /**
         * Al dar clic sobre este botón se efectuará la acción que se esté haciendo
         */
        private void btnAceptarEmpleados_Click(object sender, EventArgs e)
        {
            GestorDatos.AceptarCambios(bsEmpleados, panCamposEmpleados, () => NEmpleados.actualizarEmpleados(dsCine1));
        }

        /**
         * Al dar clic sobre este botón se cancelará la acción que se esté haciendo
         */
        private void btnCancelarEmpleados_Click(object sender, EventArgs e)
        {
            GestorDatos.CancelarCambios(bsEmpleados, panCamposEmpleados);
        }

        /**
         * Evento que controla el cambio de selección de registros dentro del dataGridView
         */
        private void dgvEmpleados_SelectionChanged(object sender, EventArgs e)
        {
            GestorDatos.CambioSeleccion(dgvEmpleados, bsEmpleados, panCamposEmpleados, ref restaurandoSeleccion, ref filaAnterior);
        }

        /**
         * Método que carga los datos de la tabla EstadoAsientos en su dataGridView y puebla los comboBox adyacentes con sus respectivas columnas
         */
        private void CargarEstadoAsientos()
        {
            //Se puebla el dataGridView con la tabla EstadoAsientos
            NEstadoAsientos.obtenerEstadosAsientos(dsCine1);

            //Si no hay registros en el dataSet se avisa al usuario
            if (dsCine1.EstadoAsientos.Rows.Count == 0)
            {
                MessageBox.Show("No se cargaron los estados de los asientos en la tabla.");
            }
        }

        /**
         * Al dar clic sobre este botón se agregará un estado a la tabla EstadoAsientos
         */
        private void btnAgregarEstadoAsientos_Click(object sender, EventArgs e)
        {
            GestorDatos.AgregarRegistro(bsEstadoAsientos, panCamposEstadoAsientos);
        }

        /**
         * Al dar clic sobre este botón se editarán los datos de un estado de la tabla EStadoAsientos
         */
        private void btnEditarEstadoAsientos_Click(object sender, EventArgs e)
        {
            GestorDatos.EditarRegistro(dgvEstadoAsientos, panCamposEstadoAsientos);
        }

        /**
         * Al dar clic sobre este botón se eliminará un estado de la tabla EstadoAsientos
         */
        private void btnEliminarEstadoAsientos_Click(object sender, EventArgs e)
        {
            GestorDatos.EliminarRegistro(bsEstadoAsientos, dgvEstadoAsientos, () => NEstadoAsientos.actualizarEstadoAsientos(dsCine1));
        }

        /**
         * Al dar clic sobre este botón se efectuará la acción que se esté haciendo
         */
        private void btnAceptarEstadoAsientos_Click(object sender, EventArgs e)
        {
            GestorDatos.AceptarCambios(bsEstadoAsientos, panCamposEstadoAsientos, () => NEstadoAsientos.actualizarEstadoAsientos(dsCine1));
        }

        /**
         * Al dar clic sobre este botón se cancelará la acción que se esté haciendo
         */
        private void btnCancelarEstadoAsientos_Click(object sender, EventArgs e)
        {
            GestorDatos.CancelarCambios(bsEstadoAsientos, panCamposEstadoAsientos);
        }

        /**
         * Evento que controla el cambio de selección de registros dentro del dataGridView
         */
        private void dgvEstadoAsientos_SelectionChanged(object sender, EventArgs e)
        {
            GestorDatos.CambioSeleccion(dgvEstadoAsientos, bsEstadoAsientos, panCamposEstadoAsientos, ref restaurandoSeleccion, ref filaAnterior);
        }

        /**
         * Método que carga los datos de la tabla EstadoEmpleados en su dataGridView y puebla los comboBox adyacentes con sus respectivas columnas
         */
        private void CargarEstadoEmpleados()
        {
            //Se puebla el dataGridView con la tabla EstadoEmpleados
            NEstadoEmpleados.obtenerEstadosEmpleados(dsCine1);

            //Si no hay registros en el dataSet se avisa al usuario
            if (dsCine1.EstadoEmpleados.Rows.Count == 0)
            {
                MessageBox.Show("No se cargaron los estados de los empleados en la tabla.");
            }
        }

        /**
         * Al dar clic sobre este botón se agregará un estado a la tabla EstadoEmpleados
         */
        private void btnAgregarEstadoEmpleados_Click(object sender, EventArgs e)
        {
            GestorDatos.AgregarRegistro(bsEstadoEmpleados, panCamposEstadoEmpleados);
        }

        /**
         * Al dar clic sobre este botón se editarán los datos de un estado de la tabla EstadoEmpleados
         */
        private void btnEditarEstadoEmpleados_Click(object sender, EventArgs e)
        {
            GestorDatos.EditarRegistro(dgvEstadoEmpleados, panCamposEstadoEmpleados);
        }

        /**
         * Al dar clic sobre este botón se eliminará un estado de la tabla EstadoEmpleados
         */
        private void btnEliminarEstadoEmpleados_Click(object sender, EventArgs e)
        {
            GestorDatos.EliminarRegistro(bsEstadoEmpleados, dgvEstadoEmpleados, () => NEstadoEmpleados.actualizarEstadoEmpleados(dsCine1));
        }

        /**
         * Al dar clic sobre este botón se efectuará la acción que se esté haciendo
         */
        private void btnAceptarEstadoEmpleados_Click(object sender, EventArgs e)
        {
            GestorDatos.AceptarCambios(bsEstadoEmpleados, panCamposEstadoEmpleados, () => NEstadoEmpleados.actualizarEstadoEmpleados(dsCine1));
        }

        /**
         * Al dar clic sobre este botón se cancelará la acción que se esté haciendo
         */
        private void btnCancelarEstadoEmpleados_Click(object sender, EventArgs e)
        {
            GestorDatos.CancelarCambios(bsEstadoEmpleados, panCamposEstadoEmpleados);
        }

        /**
         * Evento que controla el cambio de selección de registros dentro del dataGridView
         */
        private void dgvEstadoEmpleados_SelectionChanged(object sender, EventArgs e)
        {
            GestorDatos.CambioSeleccion(dgvEstadoEmpleados, bsEstadoEmpleados, panCamposEstadoEmpleados, ref restaurandoSeleccion, ref filaAnterior);
        }

        /**
         * Método que carga los datos de la tabla EstadoPago en su dataGridView y puebla los comboBox adyacentes con sus respectivas columnas
         */
        private void CargarEstadoPago()
        {
            //Se puebla el dataGridView con la tabla EstadoPago
            NEstadoPago.obtenerEstadosPago(dsCine1);

            //Si no hay registros en el dataSet se avisa al usuario
            if (dsCine1.EstadoPago.Rows.Count == 0)
            {
                MessageBox.Show("No se cargaron los estados de los empleados en la tabla.");
            }
        }

        /**
         * Al dar clic sobre este botón se agregará un estado a la tabla EstadoPago
         */
        private void btnAgregarEstadoPago_Click(object sender, EventArgs e)
        {
            GestorDatos.AgregarRegistro(bsEstadoPago, panCamposEstadoPago);
        }

        /**
         * Al dar clic sobre este botón se editarán los datos de un estado de la tabla EstadoPago
         */
        private void btnEditarEstadoPago_Click(object sender, EventArgs e)
        {
            GestorDatos.EditarRegistro(dgvEstadoPago, panCamposEstadoPago);
        }

        /**
         * Al dar clic sobre este botón se eliminará un estado de la tabla EstadoPago
         */
        private void btnEliminarEstadoPago_Click(object sender, EventArgs e)
        {
            GestorDatos.EliminarRegistro(bsEstadoPago, dgvEstadoPago, () => NEstadoPago.actualizarEstadoPago(dsCine1));
        }

        /**
         * Al dar clic sobre este botón se efectuará la acción que se esté haciendo
         */
        private void btnAceptarEstadoPago_Click(object sender, EventArgs e)
        {
            GestorDatos.AceptarCambios(bsEstadoPago, panCamposEstadoPago, () => NEstadoPago.actualizarEstadoPago(dsCine1));
        }

        /**
         * Al dar clic sobre este botón se cancelará la acción que se esté haciendo
         */
        private void btnCancelarEstadoPago_Click(object sender, EventArgs e)
        {
            GestorDatos.CancelarCambios(bsEstadoPago, panCamposEstadoPago);
        }

        /**
         * Evento que controla el cambio de selección de registros dentro del dataGridView
         */
        private void dgvEstadoPago_SelectionChanged(object sender, EventArgs e)
        {
            GestorDatos.CambioSeleccion(dgvEstadoPago, bsEstadoPago, panCamposEstadoPago, ref restaurandoSeleccion, ref filaAnterior);
        }

        /**
         * Método que carga los datos de la tabla Genero en su dataGridView y puebla los comboBox adyacentes con sus respectivas columnas
         */
        private void CargarGenero()
        {
            //Se puebla el dataGridView con la tabla Genero
            NGenero.obtenerGeneros(dsCine1);

            //Si no hay registros en el dataSet se avisa al usuario
            if (dsCine1.Genero.Rows.Count == 0)
            {
                MessageBox.Show("No se cargaron los géneros en la tabla.");
            }
        }

        /**
         * Al dar clic sobre este botón se agregará un género a la tabla Genero
         */
        private void btnAgregarGenero_Click(object sender, EventArgs e)
        {
            GestorDatos.AgregarRegistro(bsGenero, panCamposGenero);
        }

        /**
         * Al dar clic sobre este botón se editarán los datos de un género de la tabla Genero
         */
        private void btnEditarGenero_Click(object sender, EventArgs e)
        {
            GestorDatos.EditarRegistro(dgvGenero, panCamposGenero);
        }

        /**
         * Al dar clic sobre este botón se eliminará un género de la tabla Genero
         */
        private void btnEliminarGenero_Click(object sender, EventArgs e)
        {
            GestorDatos.EliminarRegistro(bsGenero, dgvGenero, () => NGenero.actualizarGenero(dsCine1));
        }

        /**
         * Al dar clic sobre este botón se efectuará la acción que se esté haciendo
         */
        private void btnAceptarGenero_Click(object sender, EventArgs e)
        {
            GestorDatos.AceptarCambios(bsGenero, panCamposGenero, () => NGenero.actualizarGenero(dsCine1));
        }

        /**
         * Al dar clic sobre este botón se cancelará la acción que se esté haciendo
         */
        private void btnCancelarGenero_Click(object sender, EventArgs e)
        {
            GestorDatos.CancelarCambios(bsGenero, panCamposGenero);
        }

        /**
         * Evento que controla el cambio de selección de registros dentro del dataGridView
         */
        private void dgvGenero_SelectionChanged(object sender, EventArgs e)
        {
            GestorDatos.CambioSeleccion(dgvGenero, bsGenero, panCamposGenero, ref restaurandoSeleccion, ref filaAnterior);
        }

        /**
         * Método que carga los datos de la tabla Horarios en su dataGridView y puebla los comboBox adyacentes con sus respectivas columnas
         */
        private void CargarSesiones()
        {
            //Se puebla el dataGridView con la tabla Sesiones
            NSesiones.obtenerSesiones(dsCine1);

            //Si no hay registros en el dataSet se avisa al usuario
            if (dsCine1.Sesiones.Rows.Count == 0)
            {
                MessageBox.Show("No se cargaron sesiones en la tabla.");
            }

            //Se puebla el comboBox de PeliculasSesiones indicando que el origen sea su tabla (Peliculas)
            PeliculasTableAdapter taPeliculas = new PeliculasTableAdapter();
            taPeliculas.Fill(dsCine1.Peliculas);
            cmbPeliculasSesiones.DataSource = dsCine1.Peliculas;
            cmbPeliculasSesiones.DisplayMember = "Titulo";
            cmbPeliculasSesiones.ValueMember = "Id";

            //Se puebla el comboBox de SalasSesiones indicando que el origen sea su tabla (Salas)
            SalasTableAdapter taSalas = new SalasTableAdapter();
            taSalas.Fill(dsCine1.Salas);
            cmbSalasSesiones.DataSource = dsCine1.Salas;
            cmbSalasSesiones.DisplayMember = "Nombre";
            cmbSalasSesiones.ValueMember = "Id";
        }

        /**
         * Al dar clic sobre este botón se agregará una sesión a la tabla Sesiones
         */
        private void btnAgregarSesiones_Click(object sender, EventArgs e)
        {
            GestorDatos.AgregarRegistro(bsSesiones, panCamposSesiones);
        }

        /**
         * Al dar clic sobre este botón se editarán los datos de una sesión de la tabla Sesiones
         */
        private void btnEditarSesiones_Click(object sender, EventArgs e)
        {
            GestorDatos.EditarRegistro(dgvSesiones, panCamposSesiones);
        }

        /**
         * Al dar clic sobre este botón se eliminará una sesión de la tabla Sesiones
         */
        private void btnEliminarSesiones_Click(object sender, EventArgs e)
        {
            GestorDatos.EliminarRegistro(bsSesiones, dgvSesiones, () => NSesiones.actualizarSesiones(dsCine1));
        }

        /**
         * Al dar clic sobre este botón se efectuará la acción que se esté haciendo
         */
        private void btnAceptarSesiones_Click(object sender, EventArgs e)
        {
            GestorDatos.AceptarCambios(bsSesiones, panCamposSesiones, () => NSesiones.actualizarSesiones(dsCine1));
        }

        /**
         * Al dar clic sobre este botón se cancelará la acción que se esté haciendo
         */
        private void btnCancelarSesiones_Click(object sender, EventArgs e)
        {
            GestorDatos.CancelarCambios(bsSesiones, panCamposSesiones);
        }

        /**
         * Evento que controla el cambio de selección de registros dentro del dataGridView
         */
        private void dgvSesiones_SelectionChanged(object sender, EventArgs e)
        {
            GestorDatos.CambioSeleccion(dgvSesiones, bsSesiones, panCamposSesiones, ref restaurandoSeleccion, ref filaAnterior);
        }

        /**
         * Método que carga los datos de la tabla Horarios en su dataGridView y puebla los comboBox adyacentes con sus respectivas columnas
         */
        private void CargarSesionAsientos()
        {
            //Se puebla el dataGridView con la tabla SesionAsientos
            NSesionAsientos.obtenerSesionAsientos(dsCine1);

            //Si no hay registros en el dataSet se avisa al usuario
            if (dsCine1.SesionAsientos.Rows.Count == 0)
            {
                MessageBox.Show("No se cargaron los asientos de las sesiones en la tabla.");
            }

            //Se puebla el comboBox de SesionesSesionAsientos indicando que el origen sea su tabla (Sesiones)
            SesionesTableAdapter taSesiones = new SesionesTableAdapter();
            taSesiones.Fill(dsCine1.Sesiones);
            cmbSesionesSesionAsientos.DataSource = dsCine1.Sesiones;
            cmbSesionesSesionAsientos.DisplayMember = "Id";
            cmbSesionesSesionAsientos.ValueMember = "Id";

            //Se puebla el comboBox de AsientosSesionAsientos indicando que el origen sea su tabla (Asientos)
            AsientosTableAdapter taAsientos = new AsientosTableAdapter();
            taAsientos.Fill(dsCine1.Asientos);
            cmbAsientosSesionAsientos.DataSource = dsCine1.Asientos;
            cmbAsientosSesionAsientos.DisplayMember = "Id";
            cmbAsientosSesionAsientos.ValueMember = "Id";

            //Se puebla el comboBox de EstadoAsientosSesionAsientos indicando que el origen sea su tabla (EstadoAsientos)
            EstadoAsientosTableAdapter taEstadoAsientos = new EstadoAsientosTableAdapter();
            taEstadoAsientos.Fill(dsCine1.EstadoAsientos);
            cmbEstadoAsientosSesionAsientos.DataSource = dsCine1.EstadoAsientos;
            cmbEstadoAsientosSesionAsientos.DisplayMember = "Estado";
            cmbEstadoAsientosSesionAsientos.ValueMember = "Id";
        }

        /**
         * Al dar clic sobre este botón se agregará un asiento de una sesioón a la tabla SesionAsientos
         */
        private void btnAgregarSesionAsientos_Click(object sender, EventArgs e)
        {
            GestorDatos.AgregarRegistro(bsSesionAsientos, panCamposSesionAsientos);
        }

        /**
         * Al dar clic sobre este botón se editarán los datos de un asiento de una sesión de la tabla SesionAsientos
         */
        private void btnEditarSesionAsientos_Click(object sender, EventArgs e)
        {
            GestorDatos.EditarRegistro(dgvSesionAsientos, panCamposSesionAsientos);
        }

        /**
         * Al dar clic sobre este botón se eliminará un asiento de una sesión de la tabla SesionAsientos
         */
        private void btnEliminarSesionAsientos_Click(object sender, EventArgs e)
        {
            GestorDatos.EliminarRegistro(bsSesionAsientos, dgvSesionAsientos, () => NSesionAsientos.actualizarSesionAsientos(dsCine1));
        }

        /**
         * Al dar clic sobre este botón se efectuará la acción que se esté haciendo
         */
        private void btnAceptarSesionAsientos_Click(object sender, EventArgs e)
        {
            GestorDatos.AceptarCambios(bsSesionAsientos, panCamposSesionAsientos, () => NSesionAsientos.actualizarSesionAsientos(dsCine1));
        }

        /**
         * Al dar clic sobre este botón se cancelará la acción que se esté haciendo
         */
        private void btnCancelarSesionAsientos_Click(object sender, EventArgs e)
        {
            GestorDatos.CancelarCambios(bsSesionAsientos, panCamposSesionAsientos);
        }

        /**
         * Evento que controla el cambio de selección de registros dentro del dataGridView
         */
        private void dgvSesionAsientos_SelectionChanged(object sender, EventArgs e)
        {
            GestorDatos.CambioSeleccion(dgvSesionAsientos, bsSesionAsientos, panCamposSesionAsientos, ref restaurandoSeleccion, ref filaAnterior);
        }

        /**
         * Método que carga los datos de la tabla Peliculas en su dataGridView y puebla los comboBox adyacentes con sus respectivas columnas
         */
        private void CargarPeliculas()
        {
            //Se puebla el dataGridView con la tabla Peliculas
            NPeliculas.obtenerPeliculas(dsCine1);

            //Si no hay registros en el dataSet se avisa al usuario
            if (dsCine1.Peliculas.Rows.Count == 0)
            {
                MessageBox.Show("No se cargaron peliculas en la tabla.");
            }

            //Se puebla el comboBox de GeneroPeliculas indicando que el origen sea su tabla (Genero)
            GeneroTableAdapter taGenero = new GeneroTableAdapter();
            taGenero.Fill(dsCine1.Genero);
            cmbGeneroPeliculas.DataSource = dsCine1.Genero;
            cmbGeneroPeliculas.DisplayMember = "Genero";
            cmbGeneroPeliculas.ValueMember = "Id";
        }

        /**
         * Al dar clic sobre este botón se agregará una pelicula a la tabla Peliculas
         */
        private void btnAgregarPeliculas_Click(object sender, EventArgs e)
        {
            GestorDatos.AgregarRegistro(bsPeliculas, panCamposPeliculas);
        }

        /**
         * Al dar clic sobre este botón se editarán los datos de una pelicula de la tabla Peliculas
         */
        private void btnEditarPeliculas_Click(object sender, EventArgs e)
        {
            GestorDatos.EditarRegistro(dgvPeliculas, panCamposPeliculas);
        }

        /**
         * Al dar clic sobre este botón se eliminará una pelicula de la tabla Peliculas
         */
        private void btnEliminarPeliculas_Click(object sender, EventArgs e)
        {
            GestorDatos.EliminarRegistro(bsPeliculas, dgvPeliculas, () => NPeliculas.actualizarPeliculas(dsCine1));
        }

        /**
         * Al dar clic sobre este botón se efectuará la acción que se esté haciendo
         */
        private void btnAceptarPeliculas_Click(object sender, EventArgs e)
        {
            GestorDatos.AceptarCambios(bsPeliculas, panCamposPeliculas, () => NPeliculas.actualizarPeliculas(dsCine1));
        }

        /**
         * Al dar clic sobre este botón se cancelará la acción que se esté haciendo
         */
        private void btnCancelarPeliculas_Click(object sender, EventArgs e)
        {
            GestorDatos.CancelarCambios(bsPeliculas, panCamposPeliculas);
        }

        /**
         * Evento que controla el cambio de selección de registros dentro del dataGridView
         */
        private void dgvPeliculas_SelectionChanged(object sender, EventArgs e)
        {
            GestorDatos.CambioSeleccion(dgvPeliculas, bsPeliculas, panCamposPeliculas, ref restaurandoSeleccion, ref filaAnterior);
        }

        /**
         * Método que carga los datos de la tabla PuestosTrabajo en su dataGridView y puebla los comboBox adyacentes con sus respectivas columnas
         */
        private void CargarPuestosTrabajo()
        {
            //Se puebla el dataGridView con la tabla PuestosTrabajo
            NPuestosTrabajo.obtenerPuestosTrabajo(dsCine1);

            //Si no hay registros en el dataSet se avisa al usuario
            if (dsCine1.PuestosTrabajo.Rows.Count == 0)
            {
                MessageBox.Show("No se cargaron los puestos de trabajo en la tabla.");
            }
        }

        /**
         * Al dar clic sobre este botón se agregará un puesto a la tabla PuestosTrabajo
         */
        private void btnAgregarPuestosTrabajo_Click(object sender, EventArgs e)
        {
            GestorDatos.AgregarRegistro(bsPuestosTrabajo, panCamposPuestosTrabajo);
        }

        /**
         * Al dar clic sobre este botón se editarán los datos de un puesto de la tabla PuestosTrabajo
         */
        private void btnEditarPuestosTrabajo_Click(object sender, EventArgs e)
        {
            GestorDatos.EditarRegistro(dgvPuestosTrabajo, panCamposPuestosTrabajo);
        }

        /**
         * Al dar clic sobre este botón se eliminará un puesto de la tabla PuestosTrabajo
         */
        private void btnEliminarPuestosTrabajo_Click(object sender, EventArgs e)
        {
            GestorDatos.EliminarRegistro(bsPuestosTrabajo, dgvPuestosTrabajo, () => NPuestosTrabajo.actualizarPuestosTrabajo(dsCine1));
        }

        /**
         * Al dar clic sobre este botón se efectuará la acción que se esté haciendo
         */
        private void btnAceptarPuestosTrabajo_Click(object sender, EventArgs e)
        {
            GestorDatos.AceptarCambios(bsPuestosTrabajo, panCamposPuestosTrabajo, () => NPuestosTrabajo.actualizarPuestosTrabajo(dsCine1));
        }

        /**
         * Al dar clic sobre este botón se cancelará la acción que se esté haciendo
         */
        private void btnCancelarPuestosTrabajo_Click(object sender, EventArgs e)
        {
            GestorDatos.CancelarCambios(bsPuestosTrabajo, panCamposPuestosTrabajo);
        }

        /**
         * Evento que controla el cambio de selección de registros dentro del dataGridView
         */
        private void dgvPuestosTrabajo_SelectionChanged(object sender, EventArgs e)
        {
            GestorDatos.CambioSeleccion(dgvPuestosTrabajo, bsPuestosTrabajo, panCamposPuestosTrabajo, ref restaurandoSeleccion, ref filaAnterior);
        }

        /**
         * Método que carga los datos de la tabla Reseñas en su dataGridView y puebla los comboBox adyacentes con sus respectivas columnas
         */
        private void CargarReseñas()
        {
            //Se puebla el dataGridView con la tabla Asientos
            NReseñas.obtenerReseñas(dsCine1);

            //Si no hay registros en el dataSet se avisa al usuario
            if (dsCine1.Reseñas.Rows.Count == 0)
            {
                MessageBox.Show("No se cargaron reseñas en la tabla.");
            }

            //Se puebla el comboBox de PelwiculasReseñas indicando que el origen sea su tabla (Peliculas)
            PeliculasTableAdapter taPeliculas = new PeliculasTableAdapter();
            taPeliculas.Fill(dsCine1.Peliculas);
            cmbPeliculasReseñas.DataSource = dsCine1.Peliculas;
            cmbPeliculasReseñas.DisplayMember = "Titulo";
            cmbPeliculasReseñas.ValueMember = "Id";

            //Se puebla el comboBox de UsuariosReseñas indicando que el origen sea su tabla (Usuarios)
            UsuariosTableAdapter taSalas = new UsuariosTableAdapter();
            taSalas.Fill(dsCine1.Usuarios);
            cmbUsuariosReseñas.DataSource = dsCine1.Usuarios;
            cmbUsuariosReseñas.DisplayMember = "Nombre";
            cmbUsuariosReseñas.ValueMember = "Id";
        }

        /**
         * Al dar clic sobre este botón se agregará una reseña a la tabla Reseñas
         */
        private void btnAgregarReseñas_Click(object sender, EventArgs e)
        {
            GestorDatos.AgregarRegistro(bsReseñas, panCamposReseñas);
        }

        /**
         * Al dar clic sobre este botón se editarán los datos de una reseña de la tabla Reseñas
         */
        private void btnEditarReseñas_Click(object sender, EventArgs e)
        {
            GestorDatos.EditarRegistro(dgvReseñas, panCamposReseñas);
        }

        /**
         * Al dar clic sobre este botón se eliminará una reseña de la tabla Reseñas
         */
        private void btnEliminarReseñas_Click(object sender, EventArgs e)
        {
            GestorDatos.EliminarRegistro(bsReseñas, dgvReseñas, () => NReseñas.actualizarReseñas(dsCine1));
        }

        /**
         * Al dar clic sobre este botón se efectuará la acción que se esté haciendo
         */
        private void btnAceptarReseñas_Click(object sender, EventArgs e)
        {
            GestorDatos.AceptarCambios(bsReseñas, panCamposReseñas, () => NReseñas.actualizarReseñas(dsCine1));
        }

        /**
         * Al dar clic sobre este botón se cancelará la acción que se esté haciendo
         */
        private void btnCancelasReseñas_Click(object sender, EventArgs e)
        {
            GestorDatos.CancelarCambios(bsReseñas, panCamposReseñas);
        }

        /**
         * Evento que controla el cambio de selección de registros dentro del dataGridView
         */
        private void dgvReseñas_SelectionChanged(object sender, EventArgs e)
        {
            GestorDatos.CambioSeleccion(dgvReseñas, bsReseñas, panCamposReseñas, ref restaurandoSeleccion, ref filaAnterior);
        }

        /**
         * Método que carga los datos de la tabla Reservas en su dataGridView y puebla los comboBox adyacentes con sus respectivas columnas
         */
        private void CargarReservas()
        {
            //Se puebla el dataGridView con la tabla Asientos
            NReservas.obtenerReservas(dsCine1);

            //Si no hay registros en el dataSet se avisa al usuario
            if (dsCine1.Reservas.Rows.Count == 0)
            {
                MessageBox.Show("No se cargaron reservas en la tabla.");
            }

            //Se puebla el comboBox de UsuariosReservas indicando que el origen sea su tabla (Usuarios)
            UsuariosTableAdapter taUsuarios = new UsuariosTableAdapter();
            taUsuarios.Fill(dsCine1.Usuarios);
            cmbUsuariosReservas.DataSource = dsCine1.Usuarios;
            cmbUsuariosReservas.DisplayMember = "Nombre";
            cmbUsuariosReservas.ValueMember = "Id";

            //Se puebla el comboBox de SesionesReservas indicando que el origen sea su tabla (Sesiones)
            SesionesTableAdapter taHorarios = new SesionesTableAdapter();
            taHorarios.Fill(dsCine1.Sesiones);
            cmbSesionesReservas.DataSource = dsCine1.Sesiones;
            cmbSesionesReservas.DisplayMember = "Id";
            cmbSesionesReservas.ValueMember = "Id";

            //Se puebla el comboBox de AsientosReservas indicando que el origen sea su tabla (Asientos)
            AsientosTableAdapter taAsientos = new AsientosTableAdapter();
            taAsientos.Fill(dsCine1.Asientos);
            cmbAsientosReservas.DataSource = dsCine1.Asientos;
            cmbAsientosReservas.DisplayMember = "Id";
            cmbAsientosReservas.ValueMember = "Id";

            //Se puebla el comboBox de EstadoPagoReservas indicando que el origen sea su tabla (EstadoPago)
            EstadoPagoTableAdapter taEstadoPago = new EstadoPagoTableAdapter();
            taEstadoPago.Fill(dsCine1.EstadoPago);
            cmbEstadosPagoReservas.DataSource = dsCine1.EstadoPago;
            cmbEstadosPagoReservas.DisplayMember = "Estado";
            cmbEstadosPagoReservas.ValueMember = "Id";

            //Se puebla el comboBox de CuponReservas indicando que el origen sea su tabla (Cupones)
            CuponesTableAdapter taCupones = new CuponesTableAdapter();
            taCupones.Fill(dsCine1.Cupones);
            cmbCuponReserva.DataSource = dsCine1.Cupones;
            cmbCuponReserva.DisplayMember = "Descripcion";
            cmbCuponReserva.ValueMember = "Id";
        }

        /**
         * Al dar clic sobre este botón se agregará una reserva a la tabla Reservas
         */
        private void btnAgregarReservas_Click(object sender, EventArgs e)
        {
            GestorDatos.AgregarRegistro(bsReservas, panCamposReservas);
        }

        /**
         * Al dar clic sobre este botón se editarán los datos de una reserva de la tabla Reservas
         */
        private void btnEditarReservas_Click(object sender, EventArgs e)
        {
            GestorDatos.EditarRegistro(dgvReservas, panCamposReservas);
        }

        /**
         * Al dar clic sobre este botón se eliminará una reserva de la tabla Reservas
         */
        private void btnEliminarReservas_Click(object sender, EventArgs e)
        {
            GestorDatos.EliminarRegistro(bsReservas, dgvReservas, () => NReservas.actualizarReservas(dsCine1));
        }

        /**
         * Al dar clic sobre este botón se efectuará la acción que se esté haciendo
         */
        private void btnAceptarReservas_Click(object sender, EventArgs e)
        {
            GestorDatos.AceptarCambios(bsReservas, panCamposReservas, () => NReservas.actualizarReservas(dsCine1));
        }

        /**
         * Al dar clic sobre este botón se cancelará la acción que se esté haciendo
         */
        private void btnCancelarReservas_Click(object sender, EventArgs e)
        {
            GestorDatos.CancelarCambios(bsReservas, panCamposReservas);
        }

        /**
         * Evento que controla el cambio de selección de registros dentro del dataGridView
         */
        private void dgvReservas_SelectionChanged(object sender, EventArgs e)
        {
            GestorDatos.CambioSeleccion(dgvReservas, bsReservas, panCamposReservas, ref restaurandoSeleccion, ref filaAnterior);
        }

        /**
         * Método que carga los datos de la tabla Salas en su dataGridView y puebla los comboBox adyacentes con sus respectivas columnas
         */
        private void CargarSalas()
        {
            //Se puebla el dataGridView con la tabla Salas
            NPuestosTrabajo.obtenerPuestosTrabajo(dsCine1);

            //Si no hay registros en el dataSet se avisa al usuario
            if (dsCine1.Salas.Rows.Count == 0)
            {
                MessageBox.Show("No se cargaron las salas en la tabla.");
            }
        }

        /**
         * Al dar clic sobre este botón se agregará una sala a la tabla Salas
         */
        private void btnAgregarSalas_Click(object sender, EventArgs e)
        {
            GestorDatos.AgregarRegistro(bsSalas, panCamposSalas);
        }

        /**
         * Al dar clic sobre este botón se editarán los datos de una sala de la tabla Salas
         */
        private void btnEditarSalas_Click(object sender, EventArgs e)
        {
            GestorDatos.EditarRegistro(dgvSalas, panCamposSalas);
        }

        /**
         * Al dar clic sobre este botón se eliminará una sala de la tabla Salas
         */
        private void btnEliminarSalas_Click(object sender, EventArgs e)
        {
            GestorDatos.EliminarRegistro(bsSalas, dgvSalas, () => NSalas.actualizarSalas(dsCine1));
        }

        /**
         * Al dar clic sobre este botón se efectuará la acción que se esté haciendo
         */
        private void btnAceptarSalas_Click(object sender, EventArgs e)
        {
            GestorDatos.AceptarCambios(bsSalas, panCamposSalas, () => NSalas.actualizarSalas(dsCine1));
        }

        /**
         * Al dar clic sobre este botón se cancelará la acción que se esté haciendo
         */
        private void btnCancelarSalas_Click(object sender, EventArgs e)
        {
            GestorDatos.CancelarCambios(bsSalas, panCamposSalas);
        }

        /**
         * Evento que controla el cambio de selección de registros dentro del dataGridView
         */
        private void dgvSalas_SelectionChanged(object sender, EventArgs e)
        {
            GestorDatos.CambioSeleccion(dgvSalas, bsSalas, panCamposSalas, ref restaurandoSeleccion, ref filaAnterior);
        }

        /**
         * Método que carga los datos de la tabla Usuarios en su dataGridView y puebla los comboBox adyacentes con sus respectivas columnas
         */
        private void CargarUsuarios()
        {
            //Se puebla el dataGridView con la tabla Usuarios
            NUsuarios.obtenerUsuarios(dsCine1);

            //Si no hay registros en el dataSet se avisa al usuario
            if (dsCine1.Usuarios.Rows.Count == 0)
            {
                MessageBox.Show("No se cargaron los usuarios en la tabla.");
            }
        }

        /**
         * Al dar clic sobre este botón se agregará un usuario a la tabla Usuarios
         */
        private void btnAgregarUsuarios_Click(object sender, EventArgs e)
        {
            GestorDatos.AgregarRegistro(bsUsuarios, panCamposUsuarios);
        }

        /**
         * Al dar clic sobre este botón se editarán los datos de un usuario de la tabla Usuarios
         */
        private void btnEditarUsuarios_Click(object sender, EventArgs e)
        {
            GestorDatos.EditarRegistro(dgvUsuarios, panCamposUsuarios);
        }

        /**
         * Al dar clic sobre este botón se eliminará un usuario de la tabla Usuarios
         */
        private void btnEliminarUsuarios_Click(object sender, EventArgs e)
        {
            GestorDatos.EliminarRegistro(bsUsuarios, dgvUsuarios, () => NUsuarios.actualizarUsuarios(dsCine1));
        }

        /**
         * Al dar clic sobre este botón se efectuará la acción que se esté haciendo
         */
        private void btnAceptarUsuarios_Click(object sender, EventArgs e)
        {
            GestorDatos.AceptarCambios(bsUsuarios, panCamposUsuarios, () => NUsuarios.actualizarUsuarios(dsCine1));
        }

        /**
         * Al dar clic sobre este botón se cancelará la acción que se esté haciendo
         */
        private void btnCancelarUsuarios_Click(object sender, EventArgs e)
        {
            GestorDatos.CancelarCambios(bsUsuarios, panCamposUsuarios);
        }

        /**
         * Evento que controla el cambio de selección de registros dentro del dataGridView
         */
        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            GestorDatos.CambioSeleccion(dgvUsuarios, bsUsuarios, panCamposUsuarios, ref restaurandoSeleccion, ref filaAnterior);
        }

        /**
         * Método que carga los datos de la tabla Cupones en su dataGridView y puebla los comboBox adyacentes con sus respectivas columnas
         */
        private void CargarCupones()
        {
            //Se puebla el dataGridView con la tabla Cupones
            NCupones.obtenerCupones(dsCine1);

            //Si no hay registros en el dataSet se avisa al usuario
            if (dsCine1.Cupones.Rows.Count == 0)
            {
                MessageBox.Show("No se cargaron los cupones en la tabla.");
            }
        }

        /**
         * Al dar clic sobre este botón se agregará un cupón a la tabla Cupones
         */
        private void btnAgregarCupones_Click(object sender, EventArgs e)
        {
            GestorDatos.AgregarRegistro(bsCupones, panCamposCupones);
        }

        /**
         * Al dar clic sobre este botón se editarán los datos de un cupón de la tabla Cupones
         */
        private void btnEditarCupones_Click(object sender, EventArgs e)
        {
            GestorDatos.EditarRegistro(dgvCupones, panCamposCupones);
        }

        /**
         * Al dar clic sobre este botón se eliminará un cupón de la tabla Cupones
         */
        private void btnEliminarCupones_Click(object sender, EventArgs e)
        {
            GestorDatos.EliminarRegistro(bsCupones, dgvCupones, () => NCupones.actualizarCupones(dsCine1));
        }

        /**
         * Al dar clic sobre este botón se efectuará la acción que se esté haciendo
         */
        private void btnAceptarCupones_Click(object sender, EventArgs e)
        {
            GestorDatos.AceptarCambios(bsCupones, panCamposCupones, () => NCupones.actualizarCupones(dsCine1));
        }

        /**
         * Al dar clic sobre este botón se cancelará la acción que se esté haciendo
         */
        private void btnCancelarCupones_Click(object sender, EventArgs e)
        {
            GestorDatos.CancelarCambios(bsCupones, panCamposCupones);
        }

        /**
         * Evento que controla el cambio de selección de registros dentro del dataGridView
         */
        private void dgvCupones_SelectionChanged(object sender, EventArgs e)
        {
            GestorDatos.CambioSeleccion(dgvCupones, bsCupones, panCamposCupones, ref restaurandoSeleccion, ref filaAnterior);
        }
    }
}
