namespace CineApp
{
    partial class FAdministracion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblUsuarioLog = new System.Windows.Forms.Label();
            this.tabPagUsuarios = new System.Windows.Forms.TabPage();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contraseñaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puntosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsUsuarios = new System.Windows.Forms.BindingSource(this.components);
            this.dsCine1 = new CAD.DSCine();
            this.gbUsuarios = new System.Windows.Forms.GroupBox();
            this.btnCancelarUsuarios = new System.Windows.Forms.Button();
            this.btnAceptarUsuarios = new System.Windows.Forms.Button();
            this.btnEliminarUsuarios = new System.Windows.Forms.Button();
            this.btnEditarUsuarios = new System.Windows.Forms.Button();
            this.btnAgregarUsuarios = new System.Windows.Forms.Button();
            this.panCamposUsuarios = new System.Windows.Forms.Panel();
            this.txtPuntos = new System.Windows.Forms.TextBox();
            this.lblPuntos = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.lblCorreoUsuario = new System.Windows.Forms.Label();
            this.txtCorreoUsuario = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.tabPagSalas = new System.Windows.Forms.TabPage();
            this.dgvSalas = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsSalas = new System.Windows.Forms.BindingSource(this.components);
            this.gbSalas = new System.Windows.Forms.GroupBox();
            this.panCamposSalas = new System.Windows.Forms.Panel();
            this.txtCapacidad = new System.Windows.Forms.TextBox();
            this.lblNombreSala = new System.Windows.Forms.Label();
            this.txtNombreSala = new System.Windows.Forms.TextBox();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.btnCancelarSalas = new System.Windows.Forms.Button();
            this.btnAceptarSalas = new System.Windows.Forms.Button();
            this.btnEliminarSalas = new System.Windows.Forms.Button();
            this.btnEditarSalas = new System.Windows.Forms.Button();
            this.btnAgregarSalas = new System.Windows.Forms.Button();
            this.tabPagReservas = new System.Windows.Forms.TabPage();
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUsuarioDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.idAsientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bsAsientos = new System.Windows.Forms.BindingSource(this.components);
            this.fechaReservaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEstadoPagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bsEstadoPago = new System.Windows.Forms.BindingSource(this.components);
            this.idSesionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bsSesiones = new System.Windows.Forms.BindingSource(this.components);
            this.idCuponDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bsCupones = new System.Windows.Forms.BindingSource(this.components);
            this.bsReservas = new System.Windows.Forms.BindingSource(this.components);
            this.gbReservas = new System.Windows.Forms.GroupBox();
            this.btnCancelarReservas = new System.Windows.Forms.Button();
            this.btnAceptarReservas = new System.Windows.Forms.Button();
            this.btnEliminarReservas = new System.Windows.Forms.Button();
            this.btnEditarReservas = new System.Windows.Forms.Button();
            this.btnAgregarReservas = new System.Windows.Forms.Button();
            this.panCamposReservas = new System.Windows.Forms.Panel();
            this.cmbCuponReserva = new System.Windows.Forms.ComboBox();
            this.lblCuponReserva = new System.Windows.Forms.Label();
            this.txtFechaReservas = new System.Windows.Forms.TextBox();
            this.cmbEstadosPagoReservas = new System.Windows.Forms.ComboBox();
            this.lblFechaReservas = new System.Windows.Forms.Label();
            this.lblEstadoReserva = new System.Windows.Forms.Label();
            this.cmbSesionesReservas = new System.Windows.Forms.ComboBox();
            this.lblNombreUsuarioReserva = new System.Windows.Forms.Label();
            this.cmbAsientosReservas = new System.Windows.Forms.ComboBox();
            this.lblHorariosReserva = new System.Windows.Forms.Label();
            this.lblAsientosReservas = new System.Windows.Forms.Label();
            this.cmbUsuariosReservas = new System.Windows.Forms.ComboBox();
            this.tabPagReseñas = new System.Windows.Forms.TabPage();
            this.dgvReseñas = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPeliculaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bsPeliculas = new System.Windows.Forms.BindingSource(this.components);
            this.idUsuarioDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.comentarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calificacionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsReseñas = new System.Windows.Forms.BindingSource(this.components);
            this.gbReseñas = new System.Windows.Forms.GroupBox();
            this.btnCancelasReseñas = new System.Windows.Forms.Button();
            this.btnAceptarReseñas = new System.Windows.Forms.Button();
            this.btnEliminarReseñas = new System.Windows.Forms.Button();
            this.btnEditarReseñas = new System.Windows.Forms.Button();
            this.btnAgregarReseñas = new System.Windows.Forms.Button();
            this.panCamposReseñas = new System.Windows.Forms.Panel();
            this.cmbUsuariosReseñas = new System.Windows.Forms.ComboBox();
            this.cmbPeliculasReseñas = new System.Windows.Forms.ComboBox();
            this.lblTituloPeliculaReseñas = new System.Windows.Forms.Label();
            this.txtCalificacion = new System.Windows.Forms.TextBox();
            this.lblComentario = new System.Windows.Forms.Label();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.lblCalificacion = new System.Windows.Forms.Label();
            this.lblNombreUsuarioReseñas = new System.Windows.Forms.Label();
            this.tabPagPuestosTrabajo = new System.Windows.Forms.TabPage();
            this.dgvPuestosTrabajo = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puestoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsPuestosTrabajo = new System.Windows.Forms.BindingSource(this.components);
            this.gbPuestosTrabajo = new System.Windows.Forms.GroupBox();
            this.btnCancelarPuestosTrabajo = new System.Windows.Forms.Button();
            this.btnAceptarPuestosTrabajo = new System.Windows.Forms.Button();
            this.btnEliminarPuestosTrabajo = new System.Windows.Forms.Button();
            this.btnEditarPuestosTrabajo = new System.Windows.Forms.Button();
            this.btnAgregarPuestosTrabajo = new System.Windows.Forms.Button();
            this.panCamposPuestosTrabajo = new System.Windows.Forms.Panel();
            this.txtPuestoTrabajo = new System.Windows.Forms.TextBox();
            this.lblPuestoTrabajo = new System.Windows.Forms.Label();
            this.tabPagPeliculas = new System.Windows.Forms.TabPage();
            this.dgvPeliculas = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idGeneroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinopsisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calificacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.portadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbPeliculas = new System.Windows.Forms.GroupBox();
            this.btnCancelarPeliculas = new System.Windows.Forms.Button();
            this.btnAceptarPeliculas = new System.Windows.Forms.Button();
            this.btnEliminarPeliculas = new System.Windows.Forms.Button();
            this.btnEditarPeliculas = new System.Windows.Forms.Button();
            this.btnAgregarPeliculas = new System.Windows.Forms.Button();
            this.panCamposPeliculas = new System.Windows.Forms.Panel();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtPortada = new System.Windows.Forms.TextBox();
            this.cmbGeneroPeliculas = new System.Windows.Forms.ComboBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblGeneroPelicula = new System.Windows.Forms.Label();
            this.lblSinopsis = new System.Windows.Forms.Label();
            this.txtSinposis = new System.Windows.Forms.TextBox();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.lblPortada = new System.Windows.Forms.Label();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.txtCalificacionPelicula = new System.Windows.Forms.TextBox();
            this.lblCalificacionPelicula = new System.Windows.Forms.Label();
            this.bsGenero = new System.Windows.Forms.BindingSource(this.components);
            this.tabPagSesiones = new System.Windows.Forms.TabPage();
            this.dgvSesiones = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPeliculaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.horaInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSalaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.gbSesiones = new System.Windows.Forms.GroupBox();
            this.btnCancelarSesiones = new System.Windows.Forms.Button();
            this.btnAceptarSesiones = new System.Windows.Forms.Button();
            this.btnEliminarSesiones = new System.Windows.Forms.Button();
            this.btnEditarSesiones = new System.Windows.Forms.Button();
            this.btnAgregarSesiones = new System.Windows.Forms.Button();
            this.panCamposSesiones = new System.Windows.Forms.Panel();
            this.txtFechaSesiones = new System.Windows.Forms.TextBox();
            this.lblFechaSesiones = new System.Windows.Forms.Label();
            this.txtHoraInicio = new System.Windows.Forms.TextBox();
            this.cmbPeliculasSesiones = new System.Windows.Forms.ComboBox();
            this.lblTituloPeliculaSesiones = new System.Windows.Forms.Label();
            this.cmbSalasSesiones = new System.Windows.Forms.ComboBox();
            this.lblNombreSalaSesiones = new System.Windows.Forms.Label();
            this.lblHoraInicio = new System.Windows.Forms.Label();
            this.tabPagGenero = new System.Windows.Forms.TabPage();
            this.dgvGenero = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbGenero = new System.Windows.Forms.GroupBox();
            this.btnCancelarGenero = new System.Windows.Forms.Button();
            this.btnAceptarGenero = new System.Windows.Forms.Button();
            this.btnEliminarGenero = new System.Windows.Forms.Button();
            this.btnEditarGenero = new System.Windows.Forms.Button();
            this.btnAgregarGenero = new System.Windows.Forms.Button();
            this.panCamposGenero = new System.Windows.Forms.Panel();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.tabPagEstadoPago = new System.Windows.Forms.TabPage();
            this.dgvEstadoPago = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbEstadoPago = new System.Windows.Forms.GroupBox();
            this.btnCancelarEstadoPago = new System.Windows.Forms.Button();
            this.btnAceptarEstadoPago = new System.Windows.Forms.Button();
            this.btnEliminarEstadoPago = new System.Windows.Forms.Button();
            this.btnEditarEstadoPago = new System.Windows.Forms.Button();
            this.btnAgregarEstadoPago = new System.Windows.Forms.Button();
            this.panCamposEstadoPago = new System.Windows.Forms.Panel();
            this.txtEstadoPago = new System.Windows.Forms.TextBox();
            this.lblEstadoPago = new System.Windows.Forms.Label();
            this.tabPagEstadoEmpleados = new System.Windows.Forms.TabPage();
            this.dgvEstadoEmpleados = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsEstadoEmpleados = new System.Windows.Forms.BindingSource(this.components);
            this.gbEstadoEmpleados = new System.Windows.Forms.GroupBox();
            this.btnCancelarEstadoEmpleados = new System.Windows.Forms.Button();
            this.btnAceptarEstadoEmpleados = new System.Windows.Forms.Button();
            this.btnEliminarEstadoEmpleados = new System.Windows.Forms.Button();
            this.btnEditarEstadoEmpleados = new System.Windows.Forms.Button();
            this.btnAgregarEstadoEmpleados = new System.Windows.Forms.Button();
            this.panCamposEstadoEmpleados = new System.Windows.Forms.Panel();
            this.txtEstadoEmpleados = new System.Windows.Forms.TextBox();
            this.lblEstadoEmpleados = new System.Windows.Forms.Label();
            this.tabPagEstadoAsientos = new System.Windows.Forms.TabPage();
            this.dgvEstadoAsientos = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsEstadoAsientos = new System.Windows.Forms.BindingSource(this.components);
            this.gbEstadoAsientos = new System.Windows.Forms.GroupBox();
            this.panCamposEstadoAsientos = new System.Windows.Forms.Panel();
            this.txtEstadoAsientos = new System.Windows.Forms.TextBox();
            this.lblEstadoAsientos = new System.Windows.Forms.Label();
            this.btnCancelarEstadoAsientos = new System.Windows.Forms.Button();
            this.btnAceptarEstadoAsientos = new System.Windows.Forms.Button();
            this.btnEliminarEstadoAsientos = new System.Windows.Forms.Button();
            this.btnEditarEstadoAsientos = new System.Windows.Forms.Button();
            this.btnAgregarEstadoAsientos = new System.Windows.Forms.Button();
            this.tabPagEmpleados = new System.Windows.Forms.TabPage();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPuestoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.idUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bsEmpleados = new System.Windows.Forms.BindingSource(this.components);
            this.gbEmpleados = new System.Windows.Forms.GroupBox();
            this.panCamposEmpleados = new System.Windows.Forms.Panel();
            this.cmbUsuariosEmpleados = new System.Windows.Forms.ComboBox();
            this.cmbEstadoEmpleadosEmpleados = new System.Windows.Forms.ComboBox();
            this.cmbPuestoTrabajoEmpleados = new System.Windows.Forms.ComboBox();
            this.lblNombreUsuarioEmpleados = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblEstadoEmpleadosEmpleados = new System.Windows.Forms.Label();
            this.lblPuestoTrabajoEmpleados = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnCancelarEmpleados = new System.Windows.Forms.Button();
            this.btnAceptarEmpleados = new System.Windows.Forms.Button();
            this.btnEliminarEmpleados = new System.Windows.Forms.Button();
            this.btnEditarEmpleados = new System.Windows.Forms.Button();
            this.btnAgregarEmpleados = new System.Windows.Forms.Button();
            this.tabPagAsientos = new System.Windows.Forms.TabPage();
            this.dgvAsientos = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSalaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.numFilaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numColumnaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbAsientos = new System.Windows.Forms.GroupBox();
            this.btnCancelarAsientos = new System.Windows.Forms.Button();
            this.panCamposAsientos = new System.Windows.Forms.Panel();
            this.lblSalaEmpleados = new System.Windows.Forms.Label();
            this.lblNumFila = new System.Windows.Forms.Label();
            this.cmbSalaAsientos = new System.Windows.Forms.ComboBox();
            this.txtNumFila = new System.Windows.Forms.TextBox();
            this.lblNumColumna = new System.Windows.Forms.Label();
            this.txtNumColumna = new System.Windows.Forms.TextBox();
            this.btnAceptarAsientos = new System.Windows.Forms.Button();
            this.btnEliminarAsientos = new System.Windows.Forms.Button();
            this.btnEditarAsientos = new System.Windows.Forms.Button();
            this.btnAgregarAsientos = new System.Windows.Forms.Button();
            this.tabCtrlDatos = new System.Windows.Forms.TabControl();
            this.tabPagSesionAsientos = new System.Windows.Forms.TabPage();
            this.dgvSesionAsientos = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSesionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.idAsientoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bsSesionAsientos = new System.Windows.Forms.BindingSource(this.components);
            this.gbSesionAsientos = new System.Windows.Forms.GroupBox();
            this.btnCancelarSesionAsientos = new System.Windows.Forms.Button();
            this.btnAceptarSesionAsientos = new System.Windows.Forms.Button();
            this.btnEliminarSesionAsientos = new System.Windows.Forms.Button();
            this.btnEditarSesionAsientos = new System.Windows.Forms.Button();
            this.btnAgregarSesionAsientos = new System.Windows.Forms.Button();
            this.panCamposSesionAsientos = new System.Windows.Forms.Panel();
            this.cmbSesionesSesionAsientos = new System.Windows.Forms.ComboBox();
            this.lblSesionesSesionAsientos = new System.Windows.Forms.Label();
            this.cmbAsientosSesionAsientos = new System.Windows.Forms.ComboBox();
            this.lblAsientosSesionAsientos = new System.Windows.Forms.Label();
            this.cmbEstadoAsientosSesionAsientos = new System.Windows.Forms.ComboBox();
            this.lblEstadoAsientosSesionAsientos = new System.Windows.Forms.Label();
            this.tabPagCupones = new System.Windows.Forms.TabPage();
            this.dgvCupones = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCaducidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costePuntosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbCupones = new System.Windows.Forms.GroupBox();
            this.btnCancelarCupones = new System.Windows.Forms.Button();
            this.panCamposCupones = new System.Windows.Forms.Panel();
            this.txtFechaCaducidadCupones = new System.Windows.Forms.TextBox();
            this.lblFechaCaducidadCupones = new System.Windows.Forms.Label();
            this.lblCosteCupones = new System.Windows.Forms.Label();
            this.txtCostePuntos = new System.Windows.Forms.TextBox();
            this.txtDescripcionCupones = new System.Windows.Forms.TextBox();
            this.lblDescripcionCupones = new System.Windows.Forms.Label();
            this.lblImagenCupones = new System.Windows.Forms.Label();
            this.txtImagenCupones = new System.Windows.Forms.TextBox();
            this.lblFechaInicioCupones = new System.Windows.Forms.Label();
            this.txtFechaInicioCupones = new System.Windows.Forms.TextBox();
            this.btnAceptarCupones = new System.Windows.Forms.Button();
            this.btnEliminarCupones = new System.Windows.Forms.Button();
            this.btnEditarCupones = new System.Windows.Forms.Button();
            this.btnAgregarCupones = new System.Windows.Forms.Button();
            this.tabPagUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCine1)).BeginInit();
            this.gbUsuarios.SuspendLayout();
            this.panCamposUsuarios.SuspendLayout();
            this.tabPagSalas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSalas)).BeginInit();
            this.gbSalas.SuspendLayout();
            this.panCamposSalas.SuspendLayout();
            this.tabPagReservas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAsientos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEstadoPago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSesiones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCupones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsReservas)).BeginInit();
            this.gbReservas.SuspendLayout();
            this.panCamposReservas.SuspendLayout();
            this.tabPagReseñas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReseñas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPeliculas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsReseñas)).BeginInit();
            this.gbReseñas.SuspendLayout();
            this.panCamposReseñas.SuspendLayout();
            this.tabPagPuestosTrabajo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuestosTrabajo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPuestosTrabajo)).BeginInit();
            this.gbPuestosTrabajo.SuspendLayout();
            this.panCamposPuestosTrabajo.SuspendLayout();
            this.tabPagPeliculas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).BeginInit();
            this.gbPeliculas.SuspendLayout();
            this.panCamposPeliculas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsGenero)).BeginInit();
            this.tabPagSesiones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSesiones)).BeginInit();
            this.gbSesiones.SuspendLayout();
            this.panCamposSesiones.SuspendLayout();
            this.tabPagGenero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenero)).BeginInit();
            this.gbGenero.SuspendLayout();
            this.panCamposGenero.SuspendLayout();
            this.tabPagEstadoPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadoPago)).BeginInit();
            this.gbEstadoPago.SuspendLayout();
            this.panCamposEstadoPago.SuspendLayout();
            this.tabPagEstadoEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadoEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEstadoEmpleados)).BeginInit();
            this.gbEstadoEmpleados.SuspendLayout();
            this.panCamposEstadoEmpleados.SuspendLayout();
            this.tabPagEstadoAsientos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadoAsientos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEstadoAsientos)).BeginInit();
            this.gbEstadoAsientos.SuspendLayout();
            this.panCamposEstadoAsientos.SuspendLayout();
            this.tabPagEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEmpleados)).BeginInit();
            this.gbEmpleados.SuspendLayout();
            this.panCamposEmpleados.SuspendLayout();
            this.tabPagAsientos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsientos)).BeginInit();
            this.gbAsientos.SuspendLayout();
            this.panCamposAsientos.SuspendLayout();
            this.tabCtrlDatos.SuspendLayout();
            this.tabPagSesionAsientos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSesionAsientos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSesionAsientos)).BeginInit();
            this.gbSesionAsientos.SuspendLayout();
            this.panCamposSesionAsientos.SuspendLayout();
            this.tabPagCupones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCupones)).BeginInit();
            this.gbCupones.SuspendLayout();
            this.panCamposCupones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsuarioLog
            // 
            this.lblUsuarioLog.AutoSize = true;
            this.lblUsuarioLog.Location = new System.Drawing.Point(12, 669);
            this.lblUsuarioLog.Name = "lblUsuarioLog";
            this.lblUsuarioLog.Size = new System.Drawing.Size(119, 16);
            this.lblUsuarioLog.TabIndex = 1;
            this.lblUsuarioLog.Text = "Usuario loggeado:";
            // 
            // tabPagUsuarios
            // 
            this.tabPagUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPagUsuarios.Controls.Add(this.dgvUsuarios);
            this.tabPagUsuarios.Controls.Add(this.gbUsuarios);
            this.tabPagUsuarios.Location = new System.Drawing.Point(4, 25);
            this.tabPagUsuarios.Name = "tabPagUsuarios";
            this.tabPagUsuarios.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagUsuarios.Size = new System.Drawing.Size(1147, 511);
            this.tabPagUsuarios.TabIndex = 13;
            this.tabPagUsuarios.Text = "Usuarios";
            this.tabPagUsuarios.UseVisualStyleBackColor = true;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AutoGenerateColumns = false;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn5,
            this.nombreDataGridViewTextBoxColumn2,
            this.correoDataGridViewTextBoxColumn1,
            this.contraseñaDataGridViewTextBoxColumn,
            this.puntosDataGridViewTextBoxColumn});
            this.dgvUsuarios.DataSource = this.bsUsuarios;
            this.dgvUsuarios.Location = new System.Drawing.Point(18, 21);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.RowTemplate.Height = 24;
            this.dgvUsuarios.Size = new System.Drawing.Size(737, 465);
            this.dgvUsuarios.TabIndex = 1;
            this.dgvUsuarios.SelectionChanged += new System.EventHandler(this.dgvUsuarios_SelectionChanged);
            // 
            // idDataGridViewTextBoxColumn5
            // 
            this.idDataGridViewTextBoxColumn5.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn5.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn5.Name = "idDataGridViewTextBoxColumn5";
            this.idDataGridViewTextBoxColumn5.ReadOnly = true;
            this.idDataGridViewTextBoxColumn5.Width = 125;
            // 
            // nombreDataGridViewTextBoxColumn2
            // 
            this.nombreDataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn2.Name = "nombreDataGridViewTextBoxColumn2";
            this.nombreDataGridViewTextBoxColumn2.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn2.Width = 125;
            // 
            // correoDataGridViewTextBoxColumn1
            // 
            this.correoDataGridViewTextBoxColumn1.DataPropertyName = "Correo";
            this.correoDataGridViewTextBoxColumn1.HeaderText = "Correo";
            this.correoDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.correoDataGridViewTextBoxColumn1.Name = "correoDataGridViewTextBoxColumn1";
            this.correoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.correoDataGridViewTextBoxColumn1.Width = 125;
            // 
            // contraseñaDataGridViewTextBoxColumn
            // 
            this.contraseñaDataGridViewTextBoxColumn.DataPropertyName = "Contraseña";
            this.contraseñaDataGridViewTextBoxColumn.HeaderText = "Contraseña";
            this.contraseñaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contraseñaDataGridViewTextBoxColumn.Name = "contraseñaDataGridViewTextBoxColumn";
            this.contraseñaDataGridViewTextBoxColumn.ReadOnly = true;
            this.contraseñaDataGridViewTextBoxColumn.Width = 125;
            // 
            // puntosDataGridViewTextBoxColumn
            // 
            this.puntosDataGridViewTextBoxColumn.DataPropertyName = "Puntos";
            this.puntosDataGridViewTextBoxColumn.HeaderText = "Puntos";
            this.puntosDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.puntosDataGridViewTextBoxColumn.Name = "puntosDataGridViewTextBoxColumn";
            this.puntosDataGridViewTextBoxColumn.ReadOnly = true;
            this.puntosDataGridViewTextBoxColumn.Width = 125;
            // 
            // bsUsuarios
            // 
            this.bsUsuarios.DataMember = "Usuarios";
            this.bsUsuarios.DataSource = this.dsCine1;
            // 
            // dsCine1
            // 
            this.dsCine1.DataSetName = "DSCine";
            this.dsCine1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbUsuarios
            // 
            this.gbUsuarios.Controls.Add(this.btnCancelarUsuarios);
            this.gbUsuarios.Controls.Add(this.btnAceptarUsuarios);
            this.gbUsuarios.Controls.Add(this.btnEliminarUsuarios);
            this.gbUsuarios.Controls.Add(this.btnEditarUsuarios);
            this.gbUsuarios.Controls.Add(this.btnAgregarUsuarios);
            this.gbUsuarios.Controls.Add(this.panCamposUsuarios);
            this.gbUsuarios.Location = new System.Drawing.Point(783, 21);
            this.gbUsuarios.Name = "gbUsuarios";
            this.gbUsuarios.Size = new System.Drawing.Size(341, 465);
            this.gbUsuarios.TabIndex = 0;
            this.gbUsuarios.TabStop = false;
            this.gbUsuarios.Text = "Opciones comunes";
            // 
            // btnCancelarUsuarios
            // 
            this.btnCancelarUsuarios.Image = global::CineApp.Properties.Resources.Cancelar;
            this.btnCancelarUsuarios.Location = new System.Drawing.Point(294, 408);
            this.btnCancelarUsuarios.Name = "btnCancelarUsuarios";
            this.btnCancelarUsuarios.Size = new System.Drawing.Size(30, 32);
            this.btnCancelarUsuarios.TabIndex = 72;
            this.btnCancelarUsuarios.UseVisualStyleBackColor = true;
            this.btnCancelarUsuarios.Click += new System.EventHandler(this.btnCancelarUsuarios_Click);
            // 
            // btnAceptarUsuarios
            // 
            this.btnAceptarUsuarios.Image = global::CineApp.Properties.Resources.Aceptar;
            this.btnAceptarUsuarios.Location = new System.Drawing.Point(255, 408);
            this.btnAceptarUsuarios.Name = "btnAceptarUsuarios";
            this.btnAceptarUsuarios.Size = new System.Drawing.Size(30, 32);
            this.btnAceptarUsuarios.TabIndex = 71;
            this.btnAceptarUsuarios.UseVisualStyleBackColor = true;
            this.btnAceptarUsuarios.Click += new System.EventHandler(this.btnAceptarUsuarios_Click);
            // 
            // btnEliminarUsuarios
            // 
            this.btnEliminarUsuarios.Location = new System.Drawing.Point(174, 408);
            this.btnEliminarUsuarios.Name = "btnEliminarUsuarios";
            this.btnEliminarUsuarios.Size = new System.Drawing.Size(73, 33);
            this.btnEliminarUsuarios.TabIndex = 70;
            this.btnEliminarUsuarios.Text = "Eliminar";
            this.btnEliminarUsuarios.UseVisualStyleBackColor = true;
            this.btnEliminarUsuarios.Click += new System.EventHandler(this.btnEliminarUsuarios_Click);
            // 
            // btnEditarUsuarios
            // 
            this.btnEditarUsuarios.Location = new System.Drawing.Point(93, 408);
            this.btnEditarUsuarios.Name = "btnEditarUsuarios";
            this.btnEditarUsuarios.Size = new System.Drawing.Size(73, 33);
            this.btnEditarUsuarios.TabIndex = 69;
            this.btnEditarUsuarios.Text = "Editar";
            this.btnEditarUsuarios.UseVisualStyleBackColor = true;
            this.btnEditarUsuarios.Click += new System.EventHandler(this.btnEditarUsuarios_Click);
            // 
            // btnAgregarUsuarios
            // 
            this.btnAgregarUsuarios.Location = new System.Drawing.Point(12, 408);
            this.btnAgregarUsuarios.Name = "btnAgregarUsuarios";
            this.btnAgregarUsuarios.Size = new System.Drawing.Size(73, 33);
            this.btnAgregarUsuarios.TabIndex = 68;
            this.btnAgregarUsuarios.Text = "Agregar";
            this.btnAgregarUsuarios.UseVisualStyleBackColor = true;
            this.btnAgregarUsuarios.Click += new System.EventHandler(this.btnAgregarUsuarios_Click);
            // 
            // panCamposUsuarios
            // 
            this.panCamposUsuarios.Controls.Add(this.txtPuntos);
            this.panCamposUsuarios.Controls.Add(this.lblPuntos);
            this.panCamposUsuarios.Controls.Add(this.txtContraseña);
            this.panCamposUsuarios.Controls.Add(this.lblNombreUsuario);
            this.panCamposUsuarios.Controls.Add(this.txtNombreUsuario);
            this.panCamposUsuarios.Controls.Add(this.lblCorreoUsuario);
            this.panCamposUsuarios.Controls.Add(this.txtCorreoUsuario);
            this.panCamposUsuarios.Controls.Add(this.lblContraseña);
            this.panCamposUsuarios.Enabled = false;
            this.panCamposUsuarios.Location = new System.Drawing.Point(6, 21);
            this.panCamposUsuarios.Name = "panCamposUsuarios";
            this.panCamposUsuarios.Size = new System.Drawing.Size(319, 212);
            this.panCamposUsuarios.TabIndex = 17;
            // 
            // txtPuntos
            // 
            this.txtPuntos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsuarios, "Puntos", true));
            this.txtPuntos.Location = new System.Drawing.Point(6, 177);
            this.txtPuntos.Name = "txtPuntos";
            this.txtPuntos.Size = new System.Drawing.Size(310, 22);
            this.txtPuntos.TabIndex = 7;
            // 
            // lblPuntos
            // 
            this.lblPuntos.AutoSize = true;
            this.lblPuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntos.Location = new System.Drawing.Point(3, 158);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(58, 16);
            this.lblPuntos.TabIndex = 6;
            this.lblPuntos.Text = "Puntos:";
            // 
            // txtContraseña
            // 
            this.txtContraseña.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsuarios, "Contraseña", true));
            this.txtContraseña.Location = new System.Drawing.Point(6, 125);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(310, 22);
            this.txtContraseña.TabIndex = 5;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.Location = new System.Drawing.Point(3, 5);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(143, 16);
            this.lblNombreUsuario.TabIndex = 0;
            this.lblNombreUsuario.Text = "Nombre de usuario:";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsuarios, "Nombre", true));
            this.txtNombreUsuario.Location = new System.Drawing.Point(6, 24);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(310, 22);
            this.txtNombreUsuario.TabIndex = 1;
            // 
            // lblCorreoUsuario
            // 
            this.lblCorreoUsuario.AutoSize = true;
            this.lblCorreoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreoUsuario.Location = new System.Drawing.Point(3, 55);
            this.lblCorreoUsuario.Name = "lblCorreoUsuario";
            this.lblCorreoUsuario.Size = new System.Drawing.Size(139, 16);
            this.lblCorreoUsuario.TabIndex = 2;
            this.lblCorreoUsuario.Text = "Correo electrónico:";
            // 
            // txtCorreoUsuario
            // 
            this.txtCorreoUsuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsuarios, "Correo", true));
            this.txtCorreoUsuario.Location = new System.Drawing.Point(6, 74);
            this.txtCorreoUsuario.Name = "txtCorreoUsuario";
            this.txtCorreoUsuario.Size = new System.Drawing.Size(310, 22);
            this.txtCorreoUsuario.TabIndex = 3;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(3, 106);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(90, 16);
            this.lblContraseña.TabIndex = 4;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // tabPagSalas
            // 
            this.tabPagSalas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPagSalas.Controls.Add(this.dgvSalas);
            this.tabPagSalas.Controls.Add(this.gbSalas);
            this.tabPagSalas.Location = new System.Drawing.Point(4, 25);
            this.tabPagSalas.Name = "tabPagSalas";
            this.tabPagSalas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagSalas.Size = new System.Drawing.Size(1147, 511);
            this.tabPagSalas.TabIndex = 12;
            this.tabPagSalas.Text = "Salas";
            this.tabPagSalas.UseVisualStyleBackColor = true;
            // 
            // dgvSalas
            // 
            this.dgvSalas.AllowUserToAddRows = false;
            this.dgvSalas.AllowUserToDeleteRows = false;
            this.dgvSalas.AutoGenerateColumns = false;
            this.dgvSalas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nombreDataGridViewTextBoxColumn,
            this.capacidadDataGridViewTextBoxColumn});
            this.dgvSalas.DataSource = this.bsSalas;
            this.dgvSalas.Location = new System.Drawing.Point(18, 21);
            this.dgvSalas.Name = "dgvSalas";
            this.dgvSalas.ReadOnly = true;
            this.dgvSalas.RowHeadersWidth = 51;
            this.dgvSalas.RowTemplate.Height = 24;
            this.dgvSalas.Size = new System.Drawing.Size(737, 465);
            this.dgvSalas.TabIndex = 1;
            this.dgvSalas.SelectionChanged += new System.EventHandler(this.dgvSalas_SelectionChanged);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Width = 125;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 125;
            // 
            // capacidadDataGridViewTextBoxColumn
            // 
            this.capacidadDataGridViewTextBoxColumn.DataPropertyName = "Capacidad";
            this.capacidadDataGridViewTextBoxColumn.HeaderText = "Capacidad";
            this.capacidadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.capacidadDataGridViewTextBoxColumn.Name = "capacidadDataGridViewTextBoxColumn";
            this.capacidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.capacidadDataGridViewTextBoxColumn.Width = 125;
            // 
            // bsSalas
            // 
            this.bsSalas.DataMember = "Salas";
            this.bsSalas.DataSource = this.dsCine1;
            // 
            // gbSalas
            // 
            this.gbSalas.Controls.Add(this.panCamposSalas);
            this.gbSalas.Controls.Add(this.btnCancelarSalas);
            this.gbSalas.Controls.Add(this.btnAceptarSalas);
            this.gbSalas.Controls.Add(this.btnEliminarSalas);
            this.gbSalas.Controls.Add(this.btnEditarSalas);
            this.gbSalas.Controls.Add(this.btnAgregarSalas);
            this.gbSalas.Location = new System.Drawing.Point(783, 21);
            this.gbSalas.Name = "gbSalas";
            this.gbSalas.Size = new System.Drawing.Size(341, 465);
            this.gbSalas.TabIndex = 0;
            this.gbSalas.TabStop = false;
            this.gbSalas.Text = "Opciones comunes";
            // 
            // panCamposSalas
            // 
            this.panCamposSalas.Controls.Add(this.txtCapacidad);
            this.panCamposSalas.Controls.Add(this.lblNombreSala);
            this.panCamposSalas.Controls.Add(this.txtNombreSala);
            this.panCamposSalas.Controls.Add(this.lblCapacidad);
            this.panCamposSalas.Enabled = false;
            this.panCamposSalas.Location = new System.Drawing.Point(10, 21);
            this.panCamposSalas.Name = "panCamposSalas";
            this.panCamposSalas.Size = new System.Drawing.Size(319, 111);
            this.panCamposSalas.TabIndex = 68;
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSalas, "Capacidad", true));
            this.txtCapacidad.Location = new System.Drawing.Point(6, 75);
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(308, 22);
            this.txtCapacidad.TabIndex = 3;
            // 
            // lblNombreSala
            // 
            this.lblNombreSala.AutoSize = true;
            this.lblNombreSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreSala.Location = new System.Drawing.Point(3, 6);
            this.lblNombreSala.Name = "lblNombreSala";
            this.lblNombreSala.Size = new System.Drawing.Size(66, 16);
            this.lblNombreSala.TabIndex = 0;
            this.lblNombreSala.Text = "Nombre:";
            // 
            // txtNombreSala
            // 
            this.txtNombreSala.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSalas, "Nombre", true));
            this.txtNombreSala.Location = new System.Drawing.Point(6, 25);
            this.txtNombreSala.Name = "txtNombreSala";
            this.txtNombreSala.Size = new System.Drawing.Size(308, 22);
            this.txtNombreSala.TabIndex = 1;
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacidad.Location = new System.Drawing.Point(3, 56);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(87, 16);
            this.lblCapacidad.TabIndex = 2;
            this.lblCapacidad.Text = "Capacidad:";
            // 
            // btnCancelarSalas
            // 
            this.btnCancelarSalas.Image = global::CineApp.Properties.Resources.Cancelar;
            this.btnCancelarSalas.Location = new System.Drawing.Point(294, 408);
            this.btnCancelarSalas.Name = "btnCancelarSalas";
            this.btnCancelarSalas.Size = new System.Drawing.Size(32, 32);
            this.btnCancelarSalas.TabIndex = 67;
            this.btnCancelarSalas.UseVisualStyleBackColor = true;
            this.btnCancelarSalas.Click += new System.EventHandler(this.btnCancelarSalas_Click);
            // 
            // btnAceptarSalas
            // 
            this.btnAceptarSalas.Image = global::CineApp.Properties.Resources.Aceptar;
            this.btnAceptarSalas.Location = new System.Drawing.Point(255, 408);
            this.btnAceptarSalas.Name = "btnAceptarSalas";
            this.btnAceptarSalas.Size = new System.Drawing.Size(32, 32);
            this.btnAceptarSalas.TabIndex = 66;
            this.btnAceptarSalas.UseVisualStyleBackColor = true;
            this.btnAceptarSalas.Click += new System.EventHandler(this.btnAceptarSalas_Click);
            // 
            // btnEliminarSalas
            // 
            this.btnEliminarSalas.Location = new System.Drawing.Point(174, 408);
            this.btnEliminarSalas.Name = "btnEliminarSalas";
            this.btnEliminarSalas.Size = new System.Drawing.Size(75, 33);
            this.btnEliminarSalas.TabIndex = 65;
            this.btnEliminarSalas.Text = "Eliminar";
            this.btnEliminarSalas.UseVisualStyleBackColor = true;
            this.btnEliminarSalas.Click += new System.EventHandler(this.btnEliminarSalas_Click);
            // 
            // btnEditarSalas
            // 
            this.btnEditarSalas.Location = new System.Drawing.Point(93, 408);
            this.btnEditarSalas.Name = "btnEditarSalas";
            this.btnEditarSalas.Size = new System.Drawing.Size(75, 33);
            this.btnEditarSalas.TabIndex = 64;
            this.btnEditarSalas.Text = "Editar";
            this.btnEditarSalas.UseVisualStyleBackColor = true;
            this.btnEditarSalas.Click += new System.EventHandler(this.btnEditarSalas_Click);
            // 
            // btnAgregarSalas
            // 
            this.btnAgregarSalas.Location = new System.Drawing.Point(12, 408);
            this.btnAgregarSalas.Name = "btnAgregarSalas";
            this.btnAgregarSalas.Size = new System.Drawing.Size(75, 33);
            this.btnAgregarSalas.TabIndex = 63;
            this.btnAgregarSalas.Text = "Agregar";
            this.btnAgregarSalas.UseVisualStyleBackColor = true;
            this.btnAgregarSalas.Click += new System.EventHandler(this.btnAgregarSalas_Click);
            // 
            // tabPagReservas
            // 
            this.tabPagReservas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPagReservas.Controls.Add(this.dgvReservas);
            this.tabPagReservas.Controls.Add(this.gbReservas);
            this.tabPagReservas.Location = new System.Drawing.Point(4, 25);
            this.tabPagReservas.Name = "tabPagReservas";
            this.tabPagReservas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagReservas.Size = new System.Drawing.Size(1147, 511);
            this.tabPagReservas.TabIndex = 11;
            this.tabPagReservas.Text = "Reservas";
            this.tabPagReservas.UseVisualStyleBackColor = true;
            // 
            // dgvReservas
            // 
            this.dgvReservas.AllowUserToAddRows = false;
            this.dgvReservas.AllowUserToDeleteRows = false;
            this.dgvReservas.AutoGenerateColumns = false;
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn12,
            this.idUsuarioDataGridViewTextBoxColumn2,
            this.idAsientoDataGridViewTextBoxColumn,
            this.fechaReservaDataGridViewTextBoxColumn,
            this.idEstadoPagoDataGridViewTextBoxColumn,
            this.idSesionDataGridViewTextBoxColumn,
            this.idCuponDataGridViewTextBoxColumn});
            this.dgvReservas.DataSource = this.bsReservas;
            this.dgvReservas.Location = new System.Drawing.Point(18, 21);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.ReadOnly = true;
            this.dgvReservas.RowHeadersWidth = 51;
            this.dgvReservas.RowTemplate.Height = 24;
            this.dgvReservas.Size = new System.Drawing.Size(737, 465);
            this.dgvReservas.TabIndex = 1;
            this.dgvReservas.SelectionChanged += new System.EventHandler(this.dgvReservas_SelectionChanged);
            // 
            // idDataGridViewTextBoxColumn12
            // 
            this.idDataGridViewTextBoxColumn12.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn12.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn12.Name = "idDataGridViewTextBoxColumn12";
            this.idDataGridViewTextBoxColumn12.ReadOnly = true;
            this.idDataGridViewTextBoxColumn12.Width = 125;
            // 
            // idUsuarioDataGridViewTextBoxColumn2
            // 
            this.idUsuarioDataGridViewTextBoxColumn2.DataPropertyName = "IdUsuario";
            this.idUsuarioDataGridViewTextBoxColumn2.DataSource = this.bsUsuarios;
            this.idUsuarioDataGridViewTextBoxColumn2.DisplayMember = "Nombre";
            this.idUsuarioDataGridViewTextBoxColumn2.HeaderText = "IdUsuario";
            this.idUsuarioDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.idUsuarioDataGridViewTextBoxColumn2.Name = "idUsuarioDataGridViewTextBoxColumn2";
            this.idUsuarioDataGridViewTextBoxColumn2.ReadOnly = true;
            this.idUsuarioDataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idUsuarioDataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idUsuarioDataGridViewTextBoxColumn2.ValueMember = "Id";
            this.idUsuarioDataGridViewTextBoxColumn2.Width = 125;
            // 
            // idAsientoDataGridViewTextBoxColumn
            // 
            this.idAsientoDataGridViewTextBoxColumn.DataPropertyName = "IdAsiento";
            this.idAsientoDataGridViewTextBoxColumn.DataSource = this.bsAsientos;
            this.idAsientoDataGridViewTextBoxColumn.DisplayMember = "Id";
            this.idAsientoDataGridViewTextBoxColumn.HeaderText = "IdAsiento";
            this.idAsientoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idAsientoDataGridViewTextBoxColumn.Name = "idAsientoDataGridViewTextBoxColumn";
            this.idAsientoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idAsientoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idAsientoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idAsientoDataGridViewTextBoxColumn.ValueMember = "Id";
            this.idAsientoDataGridViewTextBoxColumn.Width = 125;
            // 
            // bsAsientos
            // 
            this.bsAsientos.DataMember = "Asientos";
            this.bsAsientos.DataSource = this.dsCine1;
            // 
            // fechaReservaDataGridViewTextBoxColumn
            // 
            this.fechaReservaDataGridViewTextBoxColumn.DataPropertyName = "FechaReserva";
            this.fechaReservaDataGridViewTextBoxColumn.HeaderText = "FechaReserva";
            this.fechaReservaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaReservaDataGridViewTextBoxColumn.Name = "fechaReservaDataGridViewTextBoxColumn";
            this.fechaReservaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaReservaDataGridViewTextBoxColumn.Width = 125;
            // 
            // idEstadoPagoDataGridViewTextBoxColumn
            // 
            this.idEstadoPagoDataGridViewTextBoxColumn.DataPropertyName = "IdEstadoPago";
            this.idEstadoPagoDataGridViewTextBoxColumn.DataSource = this.bsEstadoPago;
            this.idEstadoPagoDataGridViewTextBoxColumn.DisplayMember = "Estado";
            this.idEstadoPagoDataGridViewTextBoxColumn.HeaderText = "IdEstadoPago";
            this.idEstadoPagoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idEstadoPagoDataGridViewTextBoxColumn.Name = "idEstadoPagoDataGridViewTextBoxColumn";
            this.idEstadoPagoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idEstadoPagoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idEstadoPagoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idEstadoPagoDataGridViewTextBoxColumn.ValueMember = "Id";
            this.idEstadoPagoDataGridViewTextBoxColumn.Width = 125;
            // 
            // bsEstadoPago
            // 
            this.bsEstadoPago.DataMember = "EstadoPago";
            this.bsEstadoPago.DataSource = this.dsCine1;
            // 
            // idSesionDataGridViewTextBoxColumn
            // 
            this.idSesionDataGridViewTextBoxColumn.DataPropertyName = "IdSesion";
            this.idSesionDataGridViewTextBoxColumn.DataSource = this.bsSesiones;
            this.idSesionDataGridViewTextBoxColumn.DisplayMember = "Id";
            this.idSesionDataGridViewTextBoxColumn.HeaderText = "IdSesion";
            this.idSesionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idSesionDataGridViewTextBoxColumn.Name = "idSesionDataGridViewTextBoxColumn";
            this.idSesionDataGridViewTextBoxColumn.ReadOnly = true;
            this.idSesionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idSesionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idSesionDataGridViewTextBoxColumn.ValueMember = "Id";
            this.idSesionDataGridViewTextBoxColumn.Width = 125;
            // 
            // bsSesiones
            // 
            this.bsSesiones.DataMember = "Sesiones";
            this.bsSesiones.DataSource = this.dsCine1;
            // 
            // idCuponDataGridViewTextBoxColumn
            // 
            this.idCuponDataGridViewTextBoxColumn.DataPropertyName = "IdCupon";
            this.idCuponDataGridViewTextBoxColumn.DataSource = this.bsCupones;
            this.idCuponDataGridViewTextBoxColumn.DisplayMember = "Descripcion";
            this.idCuponDataGridViewTextBoxColumn.HeaderText = "IdCupon";
            this.idCuponDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idCuponDataGridViewTextBoxColumn.Name = "idCuponDataGridViewTextBoxColumn";
            this.idCuponDataGridViewTextBoxColumn.ReadOnly = true;
            this.idCuponDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idCuponDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idCuponDataGridViewTextBoxColumn.ValueMember = "Id";
            this.idCuponDataGridViewTextBoxColumn.Width = 125;
            // 
            // bsCupones
            // 
            this.bsCupones.DataMember = "Cupones";
            this.bsCupones.DataSource = this.dsCine1;
            // 
            // bsReservas
            // 
            this.bsReservas.DataMember = "Reservas";
            this.bsReservas.DataSource = this.dsCine1;
            // 
            // gbReservas
            // 
            this.gbReservas.Controls.Add(this.btnCancelarReservas);
            this.gbReservas.Controls.Add(this.btnAceptarReservas);
            this.gbReservas.Controls.Add(this.btnEliminarReservas);
            this.gbReservas.Controls.Add(this.btnEditarReservas);
            this.gbReservas.Controls.Add(this.btnAgregarReservas);
            this.gbReservas.Controls.Add(this.panCamposReservas);
            this.gbReservas.Location = new System.Drawing.Point(783, 21);
            this.gbReservas.Name = "gbReservas";
            this.gbReservas.Size = new System.Drawing.Size(341, 465);
            this.gbReservas.TabIndex = 0;
            this.gbReservas.TabStop = false;
            this.gbReservas.Text = "Opciones comunes";
            // 
            // btnCancelarReservas
            // 
            this.btnCancelarReservas.Image = global::CineApp.Properties.Resources.Cancelar;
            this.btnCancelarReservas.Location = new System.Drawing.Point(300, 409);
            this.btnCancelarReservas.Name = "btnCancelarReservas";
            this.btnCancelarReservas.Size = new System.Drawing.Size(32, 32);
            this.btnCancelarReservas.TabIndex = 62;
            this.btnCancelarReservas.UseVisualStyleBackColor = true;
            this.btnCancelarReservas.Click += new System.EventHandler(this.btnCancelarReservas_Click);
            // 
            // btnAceptarReservas
            // 
            this.btnAceptarReservas.Image = global::CineApp.Properties.Resources.Aceptar;
            this.btnAceptarReservas.Location = new System.Drawing.Point(261, 409);
            this.btnAceptarReservas.Name = "btnAceptarReservas";
            this.btnAceptarReservas.Size = new System.Drawing.Size(32, 32);
            this.btnAceptarReservas.TabIndex = 61;
            this.btnAceptarReservas.UseVisualStyleBackColor = true;
            this.btnAceptarReservas.Click += new System.EventHandler(this.btnAceptarReservas_Click);
            // 
            // btnEliminarReservas
            // 
            this.btnEliminarReservas.Location = new System.Drawing.Point(180, 409);
            this.btnEliminarReservas.Name = "btnEliminarReservas";
            this.btnEliminarReservas.Size = new System.Drawing.Size(75, 33);
            this.btnEliminarReservas.TabIndex = 60;
            this.btnEliminarReservas.Text = "Eliminar";
            this.btnEliminarReservas.UseVisualStyleBackColor = true;
            this.btnEliminarReservas.Click += new System.EventHandler(this.btnEliminarReservas_Click);
            // 
            // btnEditarReservas
            // 
            this.btnEditarReservas.Location = new System.Drawing.Point(99, 409);
            this.btnEditarReservas.Name = "btnEditarReservas";
            this.btnEditarReservas.Size = new System.Drawing.Size(75, 33);
            this.btnEditarReservas.TabIndex = 59;
            this.btnEditarReservas.Text = "Editar";
            this.btnEditarReservas.UseVisualStyleBackColor = true;
            this.btnEditarReservas.Click += new System.EventHandler(this.btnEditarReservas_Click);
            // 
            // btnAgregarReservas
            // 
            this.btnAgregarReservas.Location = new System.Drawing.Point(18, 409);
            this.btnAgregarReservas.Name = "btnAgregarReservas";
            this.btnAgregarReservas.Size = new System.Drawing.Size(75, 33);
            this.btnAgregarReservas.TabIndex = 58;
            this.btnAgregarReservas.Text = "Agregar";
            this.btnAgregarReservas.UseVisualStyleBackColor = true;
            this.btnAgregarReservas.Click += new System.EventHandler(this.btnAgregarReservas_Click);
            // 
            // panCamposReservas
            // 
            this.panCamposReservas.Controls.Add(this.cmbCuponReserva);
            this.panCamposReservas.Controls.Add(this.lblCuponReserva);
            this.panCamposReservas.Controls.Add(this.txtFechaReservas);
            this.panCamposReservas.Controls.Add(this.cmbEstadosPagoReservas);
            this.panCamposReservas.Controls.Add(this.lblFechaReservas);
            this.panCamposReservas.Controls.Add(this.lblEstadoReserva);
            this.panCamposReservas.Controls.Add(this.cmbSesionesReservas);
            this.panCamposReservas.Controls.Add(this.lblNombreUsuarioReserva);
            this.panCamposReservas.Controls.Add(this.cmbAsientosReservas);
            this.panCamposReservas.Controls.Add(this.lblHorariosReserva);
            this.panCamposReservas.Controls.Add(this.lblAsientosReservas);
            this.panCamposReservas.Controls.Add(this.cmbUsuariosReservas);
            this.panCamposReservas.Enabled = false;
            this.panCamposReservas.Location = new System.Drawing.Point(6, 21);
            this.panCamposReservas.Name = "panCamposReservas";
            this.panCamposReservas.Size = new System.Drawing.Size(329, 330);
            this.panCamposReservas.TabIndex = 2;
            // 
            // cmbCuponReserva
            // 
            this.cmbCuponReserva.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsReservas, "IdEstadoPago", true));
            this.cmbCuponReserva.FormattingEnabled = true;
            this.cmbCuponReserva.Location = new System.Drawing.Point(7, 294);
            this.cmbCuponReserva.Name = "cmbCuponReserva";
            this.cmbCuponReserva.Size = new System.Drawing.Size(319, 24);
            this.cmbCuponReserva.TabIndex = 29;
            // 
            // lblCuponReserva
            // 
            this.lblCuponReserva.AutoSize = true;
            this.lblCuponReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuponReserva.Location = new System.Drawing.Point(4, 275);
            this.lblCuponReserva.Name = "lblCuponReserva";
            this.lblCuponReserva.Size = new System.Drawing.Size(124, 16);
            this.lblCuponReserva.TabIndex = 28;
            this.lblCuponReserva.Text = "Cupón canjeado:";
            // 
            // txtFechaReservas
            // 
            this.txtFechaReservas.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsReservas, "FechaReserva", true));
            this.txtFechaReservas.Location = new System.Drawing.Point(7, 185);
            this.txtFechaReservas.Name = "txtFechaReservas";
            this.txtFechaReservas.Size = new System.Drawing.Size(319, 22);
            this.txtFechaReservas.TabIndex = 27;
            // 
            // cmbEstadosPagoReservas
            // 
            this.cmbEstadosPagoReservas.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsReservas, "IdEstadoPago", true));
            this.cmbEstadosPagoReservas.FormattingEnabled = true;
            this.cmbEstadosPagoReservas.Location = new System.Drawing.Point(7, 239);
            this.cmbEstadosPagoReservas.Name = "cmbEstadosPagoReservas";
            this.cmbEstadosPagoReservas.Size = new System.Drawing.Size(319, 24);
            this.cmbEstadosPagoReservas.TabIndex = 20;
            // 
            // lblFechaReservas
            // 
            this.lblFechaReservas.AutoSize = true;
            this.lblFechaReservas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaReservas.Location = new System.Drawing.Point(4, 165);
            this.lblFechaReservas.Name = "lblFechaReservas";
            this.lblFechaReservas.Size = new System.Drawing.Size(133, 16);
            this.lblFechaReservas.TabIndex = 26;
            this.lblFechaReservas.Text = "Fecha de reserva:";
            // 
            // lblEstadoReserva
            // 
            this.lblEstadoReserva.AutoSize = true;
            this.lblEstadoReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoReserva.Location = new System.Drawing.Point(4, 220);
            this.lblEstadoReserva.Name = "lblEstadoReserva";
            this.lblEstadoReserva.Size = new System.Drawing.Size(126, 16);
            this.lblEstadoReserva.TabIndex = 2;
            this.lblEstadoReserva.Text = "Estado del pago:";
            // 
            // cmbSesionesReservas
            // 
            this.cmbSesionesReservas.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsReservas, "IdSesion", true));
            this.cmbSesionesReservas.FormattingEnabled = true;
            this.cmbSesionesReservas.Location = new System.Drawing.Point(7, 76);
            this.cmbSesionesReservas.Name = "cmbSesionesReservas";
            this.cmbSesionesReservas.Size = new System.Drawing.Size(319, 24);
            this.cmbSesionesReservas.TabIndex = 25;
            // 
            // lblNombreUsuarioReserva
            // 
            this.lblNombreUsuarioReserva.AutoSize = true;
            this.lblNombreUsuarioReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuarioReserva.Location = new System.Drawing.Point(4, 3);
            this.lblNombreUsuarioReserva.Name = "lblNombreUsuarioReserva";
            this.lblNombreUsuarioReserva.Size = new System.Drawing.Size(143, 16);
            this.lblNombreUsuarioReserva.TabIndex = 4;
            this.lblNombreUsuarioReserva.Text = "Nombre de usuario:";
            // 
            // cmbAsientosReservas
            // 
            this.cmbAsientosReservas.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsReservas, "IdAsiento", true));
            this.cmbAsientosReservas.FormattingEnabled = true;
            this.cmbAsientosReservas.Location = new System.Drawing.Point(7, 130);
            this.cmbAsientosReservas.Name = "cmbAsientosReservas";
            this.cmbAsientosReservas.Size = new System.Drawing.Size(319, 24);
            this.cmbAsientosReservas.TabIndex = 24;
            // 
            // lblHorariosReserva
            // 
            this.lblHorariosReserva.AutoSize = true;
            this.lblHorariosReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorariosReserva.Location = new System.Drawing.Point(4, 57);
            this.lblHorariosReserva.Name = "lblHorariosReserva";
            this.lblHorariosReserva.Size = new System.Drawing.Size(59, 16);
            this.lblHorariosReserva.TabIndex = 8;
            this.lblHorariosReserva.Text = "Sesión:";
            // 
            // lblAsientosReservas
            // 
            this.lblAsientosReservas.AutoSize = true;
            this.lblAsientosReservas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsientosReservas.Location = new System.Drawing.Point(4, 111);
            this.lblAsientosReservas.Name = "lblAsientosReservas";
            this.lblAsientosReservas.Size = new System.Drawing.Size(63, 16);
            this.lblAsientosReservas.TabIndex = 22;
            this.lblAsientosReservas.Text = "Asiento:";
            // 
            // cmbUsuariosReservas
            // 
            this.cmbUsuariosReservas.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsReservas, "IdUsuario", true));
            this.cmbUsuariosReservas.FormattingEnabled = true;
            this.cmbUsuariosReservas.Location = new System.Drawing.Point(7, 22);
            this.cmbUsuariosReservas.Name = "cmbUsuariosReservas";
            this.cmbUsuariosReservas.Size = new System.Drawing.Size(319, 24);
            this.cmbUsuariosReservas.TabIndex = 21;
            // 
            // tabPagReseñas
            // 
            this.tabPagReseñas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPagReseñas.Controls.Add(this.dgvReseñas);
            this.tabPagReseñas.Controls.Add(this.gbReseñas);
            this.tabPagReseñas.Location = new System.Drawing.Point(4, 25);
            this.tabPagReseñas.Name = "tabPagReseñas";
            this.tabPagReseñas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagReseñas.Size = new System.Drawing.Size(1147, 511);
            this.tabPagReseñas.TabIndex = 10;
            this.tabPagReseñas.Text = "Reseñas";
            this.tabPagReseñas.UseVisualStyleBackColor = true;
            // 
            // dgvReseñas
            // 
            this.dgvReseñas.AllowUserToAddRows = false;
            this.dgvReseñas.AllowUserToDeleteRows = false;
            this.dgvReseñas.AutoGenerateColumns = false;
            this.dgvReseñas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReseñas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn11,
            this.idPeliculaDataGridViewTextBoxColumn1,
            this.idUsuarioDataGridViewTextBoxColumn1,
            this.comentarioDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn1,
            this.calificacionDataGridViewTextBoxColumn1});
            this.dgvReseñas.DataSource = this.bsReseñas;
            this.dgvReseñas.Location = new System.Drawing.Point(18, 21);
            this.dgvReseñas.Name = "dgvReseñas";
            this.dgvReseñas.ReadOnly = true;
            this.dgvReseñas.RowHeadersWidth = 51;
            this.dgvReseñas.RowTemplate.Height = 24;
            this.dgvReseñas.Size = new System.Drawing.Size(737, 465);
            this.dgvReseñas.TabIndex = 1;
            this.dgvReseñas.SelectionChanged += new System.EventHandler(this.dgvReseñas_SelectionChanged);
            // 
            // idDataGridViewTextBoxColumn11
            // 
            this.idDataGridViewTextBoxColumn11.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn11.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn11.Name = "idDataGridViewTextBoxColumn11";
            this.idDataGridViewTextBoxColumn11.ReadOnly = true;
            this.idDataGridViewTextBoxColumn11.Width = 125;
            // 
            // idPeliculaDataGridViewTextBoxColumn1
            // 
            this.idPeliculaDataGridViewTextBoxColumn1.DataPropertyName = "IdPelicula";
            this.idPeliculaDataGridViewTextBoxColumn1.DataSource = this.bsPeliculas;
            this.idPeliculaDataGridViewTextBoxColumn1.DisplayMember = "Titulo";
            this.idPeliculaDataGridViewTextBoxColumn1.HeaderText = "IdPelicula";
            this.idPeliculaDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idPeliculaDataGridViewTextBoxColumn1.Name = "idPeliculaDataGridViewTextBoxColumn1";
            this.idPeliculaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idPeliculaDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idPeliculaDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idPeliculaDataGridViewTextBoxColumn1.ValueMember = "Id";
            this.idPeliculaDataGridViewTextBoxColumn1.Width = 125;
            // 
            // bsPeliculas
            // 
            this.bsPeliculas.DataMember = "Peliculas";
            this.bsPeliculas.DataSource = this.dsCine1;
            // 
            // idUsuarioDataGridViewTextBoxColumn1
            // 
            this.idUsuarioDataGridViewTextBoxColumn1.DataPropertyName = "IdUsuario";
            this.idUsuarioDataGridViewTextBoxColumn1.DataSource = this.bsUsuarios;
            this.idUsuarioDataGridViewTextBoxColumn1.DisplayMember = "Nombre";
            this.idUsuarioDataGridViewTextBoxColumn1.HeaderText = "IdUsuario";
            this.idUsuarioDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idUsuarioDataGridViewTextBoxColumn1.Name = "idUsuarioDataGridViewTextBoxColumn1";
            this.idUsuarioDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idUsuarioDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idUsuarioDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idUsuarioDataGridViewTextBoxColumn1.ValueMember = "Id";
            this.idUsuarioDataGridViewTextBoxColumn1.Width = 125;
            // 
            // comentarioDataGridViewTextBoxColumn
            // 
            this.comentarioDataGridViewTextBoxColumn.DataPropertyName = "Comentario";
            this.comentarioDataGridViewTextBoxColumn.HeaderText = "Comentario";
            this.comentarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.comentarioDataGridViewTextBoxColumn.Name = "comentarioDataGridViewTextBoxColumn";
            this.comentarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.comentarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaDataGridViewTextBoxColumn1
            // 
            this.fechaDataGridViewTextBoxColumn1.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn1.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.fechaDataGridViewTextBoxColumn1.Name = "fechaDataGridViewTextBoxColumn1";
            this.fechaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.fechaDataGridViewTextBoxColumn1.Width = 125;
            // 
            // calificacionDataGridViewTextBoxColumn1
            // 
            this.calificacionDataGridViewTextBoxColumn1.DataPropertyName = "Calificacion";
            this.calificacionDataGridViewTextBoxColumn1.HeaderText = "Calificacion";
            this.calificacionDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.calificacionDataGridViewTextBoxColumn1.Name = "calificacionDataGridViewTextBoxColumn1";
            this.calificacionDataGridViewTextBoxColumn1.ReadOnly = true;
            this.calificacionDataGridViewTextBoxColumn1.Width = 125;
            // 
            // bsReseñas
            // 
            this.bsReseñas.DataMember = "Reseñas";
            this.bsReseñas.DataSource = this.dsCine1;
            // 
            // gbReseñas
            // 
            this.gbReseñas.Controls.Add(this.btnCancelasReseñas);
            this.gbReseñas.Controls.Add(this.btnAceptarReseñas);
            this.gbReseñas.Controls.Add(this.btnEliminarReseñas);
            this.gbReseñas.Controls.Add(this.btnEditarReseñas);
            this.gbReseñas.Controls.Add(this.btnAgregarReseñas);
            this.gbReseñas.Controls.Add(this.panCamposReseñas);
            this.gbReseñas.Location = new System.Drawing.Point(783, 21);
            this.gbReseñas.Name = "gbReseñas";
            this.gbReseñas.Size = new System.Drawing.Size(341, 465);
            this.gbReseñas.TabIndex = 0;
            this.gbReseñas.TabStop = false;
            this.gbReseñas.Text = "Opciones comunes";
            // 
            // btnCancelasReseñas
            // 
            this.btnCancelasReseñas.Image = global::CineApp.Properties.Resources.Cancelar;
            this.btnCancelasReseñas.Location = new System.Drawing.Point(296, 408);
            this.btnCancelasReseñas.Name = "btnCancelasReseñas";
            this.btnCancelasReseñas.Size = new System.Drawing.Size(32, 32);
            this.btnCancelasReseñas.TabIndex = 57;
            this.btnCancelasReseñas.UseVisualStyleBackColor = true;
            this.btnCancelasReseñas.Click += new System.EventHandler(this.btnCancelasReseñas_Click);
            // 
            // btnAceptarReseñas
            // 
            this.btnAceptarReseñas.Image = global::CineApp.Properties.Resources.Aceptar;
            this.btnAceptarReseñas.Location = new System.Drawing.Point(257, 408);
            this.btnAceptarReseñas.Name = "btnAceptarReseñas";
            this.btnAceptarReseñas.Size = new System.Drawing.Size(32, 32);
            this.btnAceptarReseñas.TabIndex = 56;
            this.btnAceptarReseñas.UseVisualStyleBackColor = true;
            this.btnAceptarReseñas.Click += new System.EventHandler(this.btnAceptarReseñas_Click);
            // 
            // btnEliminarReseñas
            // 
            this.btnEliminarReseñas.Location = new System.Drawing.Point(176, 408);
            this.btnEliminarReseñas.Name = "btnEliminarReseñas";
            this.btnEliminarReseñas.Size = new System.Drawing.Size(75, 33);
            this.btnEliminarReseñas.TabIndex = 55;
            this.btnEliminarReseñas.Text = "Eliminar";
            this.btnEliminarReseñas.UseVisualStyleBackColor = true;
            this.btnEliminarReseñas.Click += new System.EventHandler(this.btnEliminarReseñas_Click);
            // 
            // btnEditarReseñas
            // 
            this.btnEditarReseñas.Location = new System.Drawing.Point(95, 408);
            this.btnEditarReseñas.Name = "btnEditarReseñas";
            this.btnEditarReseñas.Size = new System.Drawing.Size(75, 33);
            this.btnEditarReseñas.TabIndex = 54;
            this.btnEditarReseñas.Text = "Editar";
            this.btnEditarReseñas.UseVisualStyleBackColor = true;
            this.btnEditarReseñas.Click += new System.EventHandler(this.btnEditarReseñas_Click);
            // 
            // btnAgregarReseñas
            // 
            this.btnAgregarReseñas.Location = new System.Drawing.Point(14, 408);
            this.btnAgregarReseñas.Name = "btnAgregarReseñas";
            this.btnAgregarReseñas.Size = new System.Drawing.Size(75, 33);
            this.btnAgregarReseñas.TabIndex = 53;
            this.btnAgregarReseñas.Text = "Agregar";
            this.btnAgregarReseñas.UseVisualStyleBackColor = true;
            this.btnAgregarReseñas.Click += new System.EventHandler(this.btnAgregarReseñas_Click);
            // 
            // panCamposReseñas
            // 
            this.panCamposReseñas.Controls.Add(this.cmbUsuariosReseñas);
            this.panCamposReseñas.Controls.Add(this.cmbPeliculasReseñas);
            this.panCamposReseñas.Controls.Add(this.lblTituloPeliculaReseñas);
            this.panCamposReseñas.Controls.Add(this.txtCalificacion);
            this.panCamposReseñas.Controls.Add(this.lblComentario);
            this.panCamposReseñas.Controls.Add(this.txtComentario);
            this.panCamposReseñas.Controls.Add(this.lblFecha);
            this.panCamposReseñas.Controls.Add(this.txtFecha);
            this.panCamposReseñas.Controls.Add(this.lblCalificacion);
            this.panCamposReseñas.Controls.Add(this.lblNombreUsuarioReseñas);
            this.panCamposReseñas.Enabled = false;
            this.panCamposReseñas.Location = new System.Drawing.Point(12, 21);
            this.panCamposReseñas.Name = "panCamposReseñas";
            this.panCamposReseñas.Size = new System.Drawing.Size(323, 271);
            this.panCamposReseñas.TabIndex = 2;
            // 
            // cmbUsuariosReseñas
            // 
            this.cmbUsuariosReseñas.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsReseñas, "IdUsuario", true));
            this.cmbUsuariosReseñas.FormattingEnabled = true;
            this.cmbUsuariosReseñas.Location = new System.Drawing.Point(4, 76);
            this.cmbUsuariosReseñas.Name = "cmbUsuariosReseñas";
            this.cmbUsuariosReseñas.Size = new System.Drawing.Size(316, 24);
            this.cmbUsuariosReseñas.TabIndex = 20;
            // 
            // cmbPeliculasReseñas
            // 
            this.cmbPeliculasReseñas.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsReseñas, "IdPelicula", true));
            this.cmbPeliculasReseñas.FormattingEnabled = true;
            this.cmbPeliculasReseñas.Location = new System.Drawing.Point(4, 23);
            this.cmbPeliculasReseñas.Name = "cmbPeliculasReseñas";
            this.cmbPeliculasReseñas.Size = new System.Drawing.Size(316, 24);
            this.cmbPeliculasReseñas.TabIndex = 19;
            // 
            // lblTituloPeliculaReseñas
            // 
            this.lblTituloPeliculaReseñas.AutoSize = true;
            this.lblTituloPeliculaReseñas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPeliculaReseñas.Location = new System.Drawing.Point(1, 4);
            this.lblTituloPeliculaReseñas.Name = "lblTituloPeliculaReseñas";
            this.lblTituloPeliculaReseñas.Size = new System.Drawing.Size(50, 16);
            this.lblTituloPeliculaReseñas.TabIndex = 0;
            this.lblTituloPeliculaReseñas.Text = "Título:";
            // 
            // txtCalificacion
            // 
            this.txtCalificacion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsReseñas, "Calificacion", true));
            this.txtCalificacion.Location = new System.Drawing.Point(4, 128);
            this.txtCalificacion.Name = "txtCalificacion";
            this.txtCalificacion.Size = new System.Drawing.Size(316, 22);
            this.txtCalificacion.TabIndex = 9;
            // 
            // lblComentario
            // 
            this.lblComentario.AutoSize = true;
            this.lblComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComentario.Location = new System.Drawing.Point(1, 161);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(90, 16);
            this.lblComentario.TabIndex = 2;
            this.lblComentario.Text = "Comentario:";
            // 
            // txtComentario
            // 
            this.txtComentario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsReseñas, "Comentario", true));
            this.txtComentario.Location = new System.Drawing.Point(4, 180);
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(316, 22);
            this.txtComentario.TabIndex = 3;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(1, 212);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(54, 16);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha:";
            // 
            // txtFecha
            // 
            this.txtFecha.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsReseñas, "Fecha", true));
            this.txtFecha.Location = new System.Drawing.Point(4, 231);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(316, 22);
            this.txtFecha.TabIndex = 5;
            // 
            // lblCalificacion
            // 
            this.lblCalificacion.AutoSize = true;
            this.lblCalificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalificacion.Location = new System.Drawing.Point(1, 109);
            this.lblCalificacion.Name = "lblCalificacion";
            this.lblCalificacion.Size = new System.Drawing.Size(127, 16);
            this.lblCalificacion.TabIndex = 8;
            this.lblCalificacion.Text = "Calificación (1-5):";
            // 
            // lblNombreUsuarioReseñas
            // 
            this.lblNombreUsuarioReseñas.AutoSize = true;
            this.lblNombreUsuarioReseñas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuarioReseñas.Location = new System.Drawing.Point(1, 57);
            this.lblNombreUsuarioReseñas.Name = "lblNombreUsuarioReseñas";
            this.lblNombreUsuarioReseñas.Size = new System.Drawing.Size(143, 16);
            this.lblNombreUsuarioReseñas.TabIndex = 6;
            this.lblNombreUsuarioReseñas.Text = "Nombre de usuario:";
            // 
            // tabPagPuestosTrabajo
            // 
            this.tabPagPuestosTrabajo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPagPuestosTrabajo.Controls.Add(this.dgvPuestosTrabajo);
            this.tabPagPuestosTrabajo.Controls.Add(this.gbPuestosTrabajo);
            this.tabPagPuestosTrabajo.Location = new System.Drawing.Point(4, 25);
            this.tabPagPuestosTrabajo.Name = "tabPagPuestosTrabajo";
            this.tabPagPuestosTrabajo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagPuestosTrabajo.Size = new System.Drawing.Size(1147, 511);
            this.tabPagPuestosTrabajo.TabIndex = 9;
            this.tabPagPuestosTrabajo.Text = "Puestos de trabajo";
            this.tabPagPuestosTrabajo.UseVisualStyleBackColor = true;
            // 
            // dgvPuestosTrabajo
            // 
            this.dgvPuestosTrabajo.AllowUserToAddRows = false;
            this.dgvPuestosTrabajo.AllowUserToDeleteRows = false;
            this.dgvPuestosTrabajo.AutoGenerateColumns = false;
            this.dgvPuestosTrabajo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPuestosTrabajo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn3,
            this.puestoDataGridViewTextBoxColumn});
            this.dgvPuestosTrabajo.DataSource = this.bsPuestosTrabajo;
            this.dgvPuestosTrabajo.Location = new System.Drawing.Point(18, 21);
            this.dgvPuestosTrabajo.Name = "dgvPuestosTrabajo";
            this.dgvPuestosTrabajo.ReadOnly = true;
            this.dgvPuestosTrabajo.RowHeadersWidth = 51;
            this.dgvPuestosTrabajo.RowTemplate.Height = 24;
            this.dgvPuestosTrabajo.Size = new System.Drawing.Size(737, 465);
            this.dgvPuestosTrabajo.TabIndex = 1;
            this.dgvPuestosTrabajo.SelectionChanged += new System.EventHandler(this.dgvPuestosTrabajo_SelectionChanged);
            // 
            // idDataGridViewTextBoxColumn3
            // 
            this.idDataGridViewTextBoxColumn3.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn3.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn3.Name = "idDataGridViewTextBoxColumn3";
            this.idDataGridViewTextBoxColumn3.ReadOnly = true;
            this.idDataGridViewTextBoxColumn3.Width = 125;
            // 
            // puestoDataGridViewTextBoxColumn
            // 
            this.puestoDataGridViewTextBoxColumn.DataPropertyName = "Puesto";
            this.puestoDataGridViewTextBoxColumn.HeaderText = "Puesto";
            this.puestoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.puestoDataGridViewTextBoxColumn.Name = "puestoDataGridViewTextBoxColumn";
            this.puestoDataGridViewTextBoxColumn.ReadOnly = true;
            this.puestoDataGridViewTextBoxColumn.Width = 125;
            // 
            // bsPuestosTrabajo
            // 
            this.bsPuestosTrabajo.DataMember = "PuestosTrabajo";
            this.bsPuestosTrabajo.DataSource = this.dsCine1;
            // 
            // gbPuestosTrabajo
            // 
            this.gbPuestosTrabajo.Controls.Add(this.btnCancelarPuestosTrabajo);
            this.gbPuestosTrabajo.Controls.Add(this.btnAceptarPuestosTrabajo);
            this.gbPuestosTrabajo.Controls.Add(this.btnEliminarPuestosTrabajo);
            this.gbPuestosTrabajo.Controls.Add(this.btnEditarPuestosTrabajo);
            this.gbPuestosTrabajo.Controls.Add(this.btnAgregarPuestosTrabajo);
            this.gbPuestosTrabajo.Controls.Add(this.panCamposPuestosTrabajo);
            this.gbPuestosTrabajo.Location = new System.Drawing.Point(783, 21);
            this.gbPuestosTrabajo.Name = "gbPuestosTrabajo";
            this.gbPuestosTrabajo.Size = new System.Drawing.Size(341, 465);
            this.gbPuestosTrabajo.TabIndex = 0;
            this.gbPuestosTrabajo.TabStop = false;
            this.gbPuestosTrabajo.Text = "Opciones comunes";
            // 
            // btnCancelarPuestosTrabajo
            // 
            this.btnCancelarPuestosTrabajo.Image = global::CineApp.Properties.Resources.Cancelar;
            this.btnCancelarPuestosTrabajo.Location = new System.Drawing.Point(292, 409);
            this.btnCancelarPuestosTrabajo.Name = "btnCancelarPuestosTrabajo";
            this.btnCancelarPuestosTrabajo.Size = new System.Drawing.Size(32, 32);
            this.btnCancelarPuestosTrabajo.TabIndex = 52;
            this.btnCancelarPuestosTrabajo.UseVisualStyleBackColor = true;
            this.btnCancelarPuestosTrabajo.Click += new System.EventHandler(this.btnCancelarPuestosTrabajo_Click);
            // 
            // btnAceptarPuestosTrabajo
            // 
            this.btnAceptarPuestosTrabajo.Image = global::CineApp.Properties.Resources.Aceptar;
            this.btnAceptarPuestosTrabajo.Location = new System.Drawing.Point(253, 409);
            this.btnAceptarPuestosTrabajo.Name = "btnAceptarPuestosTrabajo";
            this.btnAceptarPuestosTrabajo.Size = new System.Drawing.Size(32, 32);
            this.btnAceptarPuestosTrabajo.TabIndex = 51;
            this.btnAceptarPuestosTrabajo.UseVisualStyleBackColor = true;
            this.btnAceptarPuestosTrabajo.Click += new System.EventHandler(this.btnAceptarPuestosTrabajo_Click);
            // 
            // btnEliminarPuestosTrabajo
            // 
            this.btnEliminarPuestosTrabajo.Location = new System.Drawing.Point(172, 409);
            this.btnEliminarPuestosTrabajo.Name = "btnEliminarPuestosTrabajo";
            this.btnEliminarPuestosTrabajo.Size = new System.Drawing.Size(75, 33);
            this.btnEliminarPuestosTrabajo.TabIndex = 50;
            this.btnEliminarPuestosTrabajo.Text = "Eliminar";
            this.btnEliminarPuestosTrabajo.UseVisualStyleBackColor = true;
            this.btnEliminarPuestosTrabajo.Click += new System.EventHandler(this.btnEliminarPuestosTrabajo_Click);
            // 
            // btnEditarPuestosTrabajo
            // 
            this.btnEditarPuestosTrabajo.Location = new System.Drawing.Point(91, 409);
            this.btnEditarPuestosTrabajo.Name = "btnEditarPuestosTrabajo";
            this.btnEditarPuestosTrabajo.Size = new System.Drawing.Size(75, 33);
            this.btnEditarPuestosTrabajo.TabIndex = 49;
            this.btnEditarPuestosTrabajo.Text = "Editar";
            this.btnEditarPuestosTrabajo.UseVisualStyleBackColor = true;
            this.btnEditarPuestosTrabajo.Click += new System.EventHandler(this.btnEditarPuestosTrabajo_Click);
            // 
            // btnAgregarPuestosTrabajo
            // 
            this.btnAgregarPuestosTrabajo.Location = new System.Drawing.Point(10, 409);
            this.btnAgregarPuestosTrabajo.Name = "btnAgregarPuestosTrabajo";
            this.btnAgregarPuestosTrabajo.Size = new System.Drawing.Size(75, 33);
            this.btnAgregarPuestosTrabajo.TabIndex = 48;
            this.btnAgregarPuestosTrabajo.Text = "Agregar";
            this.btnAgregarPuestosTrabajo.UseVisualStyleBackColor = true;
            this.btnAgregarPuestosTrabajo.Click += new System.EventHandler(this.btnAgregarPuestosTrabajo_Click);
            // 
            // panCamposPuestosTrabajo
            // 
            this.panCamposPuestosTrabajo.Controls.Add(this.txtPuestoTrabajo);
            this.panCamposPuestosTrabajo.Controls.Add(this.lblPuestoTrabajo);
            this.panCamposPuestosTrabajo.Enabled = false;
            this.panCamposPuestosTrabajo.Location = new System.Drawing.Point(8, 18);
            this.panCamposPuestosTrabajo.Name = "panCamposPuestosTrabajo";
            this.panCamposPuestosTrabajo.Size = new System.Drawing.Size(319, 59);
            this.panCamposPuestosTrabajo.TabIndex = 47;
            // 
            // txtPuestoTrabajo
            // 
            this.txtPuestoTrabajo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPuestosTrabajo, "Puesto", true));
            this.txtPuestoTrabajo.Location = new System.Drawing.Point(3, 24);
            this.txtPuestoTrabajo.Name = "txtPuestoTrabajo";
            this.txtPuestoTrabajo.Size = new System.Drawing.Size(313, 22);
            this.txtPuestoTrabajo.TabIndex = 1;
            // 
            // lblPuestoTrabajo
            // 
            this.lblPuestoTrabajo.AutoSize = true;
            this.lblPuestoTrabajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuestoTrabajo.Location = new System.Drawing.Point(0, 5);
            this.lblPuestoTrabajo.Name = "lblPuestoTrabajo";
            this.lblPuestoTrabajo.Size = new System.Drawing.Size(134, 16);
            this.lblPuestoTrabajo.TabIndex = 0;
            this.lblPuestoTrabajo.Text = "Puesto de trabajo:";
            // 
            // tabPagPeliculas
            // 
            this.tabPagPeliculas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPagPeliculas.Controls.Add(this.dgvPeliculas);
            this.tabPagPeliculas.Controls.Add(this.gbPeliculas);
            this.tabPagPeliculas.Location = new System.Drawing.Point(4, 25);
            this.tabPagPeliculas.Name = "tabPagPeliculas";
            this.tabPagPeliculas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagPeliculas.Size = new System.Drawing.Size(1147, 511);
            this.tabPagPeliculas.TabIndex = 8;
            this.tabPagPeliculas.Text = "Peliculas";
            this.tabPagPeliculas.UseVisualStyleBackColor = true;
            // 
            // dgvPeliculas
            // 
            this.dgvPeliculas.AllowUserToAddRows = false;
            this.dgvPeliculas.AllowUserToDeleteRows = false;
            this.dgvPeliculas.AutoGenerateColumns = false;
            this.dgvPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeliculas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn10,
            this.tituloDataGridViewTextBoxColumn,
            this.idGeneroDataGridViewTextBoxColumn,
            this.sinopsisDataGridViewTextBoxColumn,
            this.duracionDataGridViewTextBoxColumn,
            this.calificacionDataGridViewTextBoxColumn,
            this.portadaDataGridViewTextBoxColumn});
            this.dgvPeliculas.DataSource = this.bsPeliculas;
            this.dgvPeliculas.Location = new System.Drawing.Point(18, 21);
            this.dgvPeliculas.Name = "dgvPeliculas";
            this.dgvPeliculas.ReadOnly = true;
            this.dgvPeliculas.RowHeadersWidth = 51;
            this.dgvPeliculas.RowTemplate.Height = 24;
            this.dgvPeliculas.Size = new System.Drawing.Size(737, 465);
            this.dgvPeliculas.TabIndex = 1;
            this.dgvPeliculas.SelectionChanged += new System.EventHandler(this.dgvPeliculas_SelectionChanged);
            // 
            // idDataGridViewTextBoxColumn10
            // 
            this.idDataGridViewTextBoxColumn10.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn10.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn10.Name = "idDataGridViewTextBoxColumn10";
            this.idDataGridViewTextBoxColumn10.ReadOnly = true;
            this.idDataGridViewTextBoxColumn10.Width = 125;
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "Titulo";
            this.tituloDataGridViewTextBoxColumn.HeaderText = "Titulo";
            this.tituloDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            this.tituloDataGridViewTextBoxColumn.ReadOnly = true;
            this.tituloDataGridViewTextBoxColumn.Width = 125;
            // 
            // idGeneroDataGridViewTextBoxColumn
            // 
            this.idGeneroDataGridViewTextBoxColumn.DataPropertyName = "IdGenero";
            this.idGeneroDataGridViewTextBoxColumn.HeaderText = "IdGenero";
            this.idGeneroDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idGeneroDataGridViewTextBoxColumn.Name = "idGeneroDataGridViewTextBoxColumn";
            this.idGeneroDataGridViewTextBoxColumn.ReadOnly = true;
            this.idGeneroDataGridViewTextBoxColumn.Width = 125;
            // 
            // sinopsisDataGridViewTextBoxColumn
            // 
            this.sinopsisDataGridViewTextBoxColumn.DataPropertyName = "Sinopsis";
            this.sinopsisDataGridViewTextBoxColumn.HeaderText = "Sinopsis";
            this.sinopsisDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sinopsisDataGridViewTextBoxColumn.Name = "sinopsisDataGridViewTextBoxColumn";
            this.sinopsisDataGridViewTextBoxColumn.ReadOnly = true;
            this.sinopsisDataGridViewTextBoxColumn.Width = 125;
            // 
            // duracionDataGridViewTextBoxColumn
            // 
            this.duracionDataGridViewTextBoxColumn.DataPropertyName = "Duracion";
            this.duracionDataGridViewTextBoxColumn.HeaderText = "Duracion";
            this.duracionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.duracionDataGridViewTextBoxColumn.Name = "duracionDataGridViewTextBoxColumn";
            this.duracionDataGridViewTextBoxColumn.ReadOnly = true;
            this.duracionDataGridViewTextBoxColumn.Width = 125;
            // 
            // calificacionDataGridViewTextBoxColumn
            // 
            this.calificacionDataGridViewTextBoxColumn.DataPropertyName = "Calificacion";
            this.calificacionDataGridViewTextBoxColumn.HeaderText = "Calificacion";
            this.calificacionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.calificacionDataGridViewTextBoxColumn.Name = "calificacionDataGridViewTextBoxColumn";
            this.calificacionDataGridViewTextBoxColumn.ReadOnly = true;
            this.calificacionDataGridViewTextBoxColumn.Width = 125;
            // 
            // portadaDataGridViewTextBoxColumn
            // 
            this.portadaDataGridViewTextBoxColumn.DataPropertyName = "Portada";
            this.portadaDataGridViewTextBoxColumn.HeaderText = "Portada";
            this.portadaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.portadaDataGridViewTextBoxColumn.Name = "portadaDataGridViewTextBoxColumn";
            this.portadaDataGridViewTextBoxColumn.ReadOnly = true;
            this.portadaDataGridViewTextBoxColumn.Width = 125;
            // 
            // gbPeliculas
            // 
            this.gbPeliculas.Controls.Add(this.btnCancelarPeliculas);
            this.gbPeliculas.Controls.Add(this.btnAceptarPeliculas);
            this.gbPeliculas.Controls.Add(this.btnEliminarPeliculas);
            this.gbPeliculas.Controls.Add(this.btnEditarPeliculas);
            this.gbPeliculas.Controls.Add(this.btnAgregarPeliculas);
            this.gbPeliculas.Controls.Add(this.panCamposPeliculas);
            this.gbPeliculas.Location = new System.Drawing.Point(783, 21);
            this.gbPeliculas.Name = "gbPeliculas";
            this.gbPeliculas.Size = new System.Drawing.Size(341, 465);
            this.gbPeliculas.TabIndex = 0;
            this.gbPeliculas.TabStop = false;
            this.gbPeliculas.Text = "Opciones comunes";
            // 
            // btnCancelarPeliculas
            // 
            this.btnCancelarPeliculas.Image = global::CineApp.Properties.Resources.Cancelar;
            this.btnCancelarPeliculas.Location = new System.Drawing.Point(300, 409);
            this.btnCancelarPeliculas.Name = "btnCancelarPeliculas";
            this.btnCancelarPeliculas.Size = new System.Drawing.Size(32, 32);
            this.btnCancelarPeliculas.TabIndex = 56;
            this.btnCancelarPeliculas.UseVisualStyleBackColor = true;
            this.btnCancelarPeliculas.Click += new System.EventHandler(this.btnCancelarPeliculas_Click);
            // 
            // btnAceptarPeliculas
            // 
            this.btnAceptarPeliculas.Image = global::CineApp.Properties.Resources.Aceptar;
            this.btnAceptarPeliculas.Location = new System.Drawing.Point(261, 409);
            this.btnAceptarPeliculas.Name = "btnAceptarPeliculas";
            this.btnAceptarPeliculas.Size = new System.Drawing.Size(32, 32);
            this.btnAceptarPeliculas.TabIndex = 55;
            this.btnAceptarPeliculas.UseVisualStyleBackColor = true;
            this.btnAceptarPeliculas.Click += new System.EventHandler(this.btnAceptarPeliculas_Click);
            // 
            // btnEliminarPeliculas
            // 
            this.btnEliminarPeliculas.Location = new System.Drawing.Point(180, 409);
            this.btnEliminarPeliculas.Name = "btnEliminarPeliculas";
            this.btnEliminarPeliculas.Size = new System.Drawing.Size(75, 33);
            this.btnEliminarPeliculas.TabIndex = 54;
            this.btnEliminarPeliculas.Text = "Eliminar";
            this.btnEliminarPeliculas.UseVisualStyleBackColor = true;
            this.btnEliminarPeliculas.Click += new System.EventHandler(this.btnEliminarPeliculas_Click);
            // 
            // btnEditarPeliculas
            // 
            this.btnEditarPeliculas.Location = new System.Drawing.Point(99, 409);
            this.btnEditarPeliculas.Name = "btnEditarPeliculas";
            this.btnEditarPeliculas.Size = new System.Drawing.Size(75, 33);
            this.btnEditarPeliculas.TabIndex = 53;
            this.btnEditarPeliculas.Text = "Editar";
            this.btnEditarPeliculas.UseVisualStyleBackColor = true;
            this.btnEditarPeliculas.Click += new System.EventHandler(this.btnEditarPeliculas_Click);
            // 
            // btnAgregarPeliculas
            // 
            this.btnAgregarPeliculas.Location = new System.Drawing.Point(18, 409);
            this.btnAgregarPeliculas.Name = "btnAgregarPeliculas";
            this.btnAgregarPeliculas.Size = new System.Drawing.Size(75, 33);
            this.btnAgregarPeliculas.TabIndex = 52;
            this.btnAgregarPeliculas.Text = "Agregar";
            this.btnAgregarPeliculas.UseVisualStyleBackColor = true;
            this.btnAgregarPeliculas.Click += new System.EventHandler(this.btnAgregarPeliculas_Click);
            // 
            // panCamposPeliculas
            // 
            this.panCamposPeliculas.Controls.Add(this.txtTitulo);
            this.panCamposPeliculas.Controls.Add(this.txtPortada);
            this.panCamposPeliculas.Controls.Add(this.cmbGeneroPeliculas);
            this.panCamposPeliculas.Controls.Add(this.lblTitulo);
            this.panCamposPeliculas.Controls.Add(this.lblGeneroPelicula);
            this.panCamposPeliculas.Controls.Add(this.lblSinopsis);
            this.panCamposPeliculas.Controls.Add(this.txtSinposis);
            this.panCamposPeliculas.Controls.Add(this.lblDuracion);
            this.panCamposPeliculas.Controls.Add(this.lblPortada);
            this.panCamposPeliculas.Controls.Add(this.txtDuracion);
            this.panCamposPeliculas.Controls.Add(this.txtCalificacionPelicula);
            this.panCamposPeliculas.Controls.Add(this.lblCalificacionPelicula);
            this.panCamposPeliculas.Enabled = false;
            this.panCamposPeliculas.Location = new System.Drawing.Point(12, 21);
            this.panCamposPeliculas.Name = "panCamposPeliculas";
            this.panCamposPeliculas.Size = new System.Drawing.Size(323, 318);
            this.panCamposPeliculas.TabIndex = 2;
            // 
            // txtTitulo
            // 
            this.txtTitulo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPeliculas, "Titulo", true));
            this.txtTitulo.Location = new System.Drawing.Point(4, 24);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(316, 22);
            this.txtTitulo.TabIndex = 21;
            // 
            // txtPortada
            // 
            this.txtPortada.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPeliculas, "Portada", true));
            this.txtPortada.Location = new System.Drawing.Point(4, 281);
            this.txtPortada.Name = "txtPortada";
            this.txtPortada.Size = new System.Drawing.Size(316, 22);
            this.txtPortada.TabIndex = 11;
            // 
            // cmbGeneroPeliculas
            // 
            this.cmbGeneroPeliculas.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsPeliculas, "IdGenero", true));
            this.cmbGeneroPeliculas.FormattingEnabled = true;
            this.cmbGeneroPeliculas.Location = new System.Drawing.Point(4, 74);
            this.cmbGeneroPeliculas.Name = "cmbGeneroPeliculas";
            this.cmbGeneroPeliculas.Size = new System.Drawing.Size(316, 24);
            this.cmbGeneroPeliculas.TabIndex = 20;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(1, 5);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(50, 16);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Título:";
            // 
            // lblGeneroPelicula
            // 
            this.lblGeneroPelicula.AutoSize = true;
            this.lblGeneroPelicula.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneroPelicula.Location = new System.Drawing.Point(1, 55);
            this.lblGeneroPelicula.Name = "lblGeneroPelicula";
            this.lblGeneroPelicula.Size = new System.Drawing.Size(62, 16);
            this.lblGeneroPelicula.TabIndex = 2;
            this.lblGeneroPelicula.Text = "Género:";
            // 
            // lblSinopsis
            // 
            this.lblSinopsis.AutoSize = true;
            this.lblSinopsis.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinopsis.Location = new System.Drawing.Point(1, 106);
            this.lblSinopsis.Name = "lblSinopsis";
            this.lblSinopsis.Size = new System.Drawing.Size(71, 16);
            this.lblSinopsis.TabIndex = 4;
            this.lblSinopsis.Text = "Sinopsis:";
            // 
            // txtSinposis
            // 
            this.txtSinposis.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPeliculas, "Sinopsis", true));
            this.txtSinposis.Location = new System.Drawing.Point(4, 125);
            this.txtSinposis.Name = "txtSinposis";
            this.txtSinposis.Size = new System.Drawing.Size(316, 22);
            this.txtSinposis.TabIndex = 5;
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuracion.Location = new System.Drawing.Point(1, 157);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(73, 16);
            this.lblDuracion.TabIndex = 6;
            this.lblDuracion.Text = "Duración:";
            // 
            // lblPortada
            // 
            this.lblPortada.AutoSize = true;
            this.lblPortada.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPortada.Location = new System.Drawing.Point(1, 262);
            this.lblPortada.Name = "lblPortada";
            this.lblPortada.Size = new System.Drawing.Size(136, 16);
            this.lblPortada.TabIndex = 10;
            this.lblPortada.Text = "Link de la portada:";
            // 
            // txtDuracion
            // 
            this.txtDuracion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPeliculas, "Duracion", true));
            this.txtDuracion.Location = new System.Drawing.Point(4, 176);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(316, 22);
            this.txtDuracion.TabIndex = 7;
            // 
            // txtCalificacionPelicula
            // 
            this.txtCalificacionPelicula.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPeliculas, "Calificacion", true));
            this.txtCalificacionPelicula.Location = new System.Drawing.Point(4, 228);
            this.txtCalificacionPelicula.Name = "txtCalificacionPelicula";
            this.txtCalificacionPelicula.Size = new System.Drawing.Size(316, 22);
            this.txtCalificacionPelicula.TabIndex = 9;
            // 
            // lblCalificacionPelicula
            // 
            this.lblCalificacionPelicula.AutoSize = true;
            this.lblCalificacionPelicula.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalificacionPelicula.Location = new System.Drawing.Point(1, 209);
            this.lblCalificacionPelicula.Name = "lblCalificacionPelicula";
            this.lblCalificacionPelicula.Size = new System.Drawing.Size(92, 16);
            this.lblCalificacionPelicula.TabIndex = 8;
            this.lblCalificacionPelicula.Text = "Calificación:";
            // 
            // bsGenero
            // 
            this.bsGenero.DataMember = "Genero";
            this.bsGenero.DataSource = this.dsCine1;
            // 
            // tabPagSesiones
            // 
            this.tabPagSesiones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPagSesiones.Controls.Add(this.dgvSesiones);
            this.tabPagSesiones.Controls.Add(this.gbSesiones);
            this.tabPagSesiones.Location = new System.Drawing.Point(4, 25);
            this.tabPagSesiones.Name = "tabPagSesiones";
            this.tabPagSesiones.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagSesiones.Size = new System.Drawing.Size(1147, 511);
            this.tabPagSesiones.TabIndex = 7;
            this.tabPagSesiones.Text = "Sesiones";
            this.tabPagSesiones.UseVisualStyleBackColor = true;
            // 
            // dgvSesiones
            // 
            this.dgvSesiones.AllowUserToAddRows = false;
            this.dgvSesiones.AllowUserToDeleteRows = false;
            this.dgvSesiones.AutoGenerateColumns = false;
            this.dgvSesiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSesiones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn9,
            this.fechaDataGridViewTextBoxColumn,
            this.idPeliculaDataGridViewTextBoxColumn,
            this.horaInicioDataGridViewTextBoxColumn,
            this.idSalaDataGridViewTextBoxColumn1});
            this.dgvSesiones.DataSource = this.bsSesiones;
            this.dgvSesiones.Location = new System.Drawing.Point(18, 21);
            this.dgvSesiones.Name = "dgvSesiones";
            this.dgvSesiones.ReadOnly = true;
            this.dgvSesiones.RowHeadersWidth = 51;
            this.dgvSesiones.RowTemplate.Height = 24;
            this.dgvSesiones.Size = new System.Drawing.Size(737, 465);
            this.dgvSesiones.TabIndex = 1;
            this.dgvSesiones.SelectionChanged += new System.EventHandler(this.dgvSesiones_SelectionChanged);
            // 
            // idDataGridViewTextBoxColumn9
            // 
            this.idDataGridViewTextBoxColumn9.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn9.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn9.Name = "idDataGridViewTextBoxColumn9";
            this.idDataGridViewTextBoxColumn9.ReadOnly = true;
            this.idDataGridViewTextBoxColumn9.Width = 125;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaDataGridViewTextBoxColumn.Width = 125;
            // 
            // idPeliculaDataGridViewTextBoxColumn
            // 
            this.idPeliculaDataGridViewTextBoxColumn.DataPropertyName = "IdPelicula";
            this.idPeliculaDataGridViewTextBoxColumn.DataSource = this.bsPeliculas;
            this.idPeliculaDataGridViewTextBoxColumn.DisplayMember = "Titulo";
            this.idPeliculaDataGridViewTextBoxColumn.HeaderText = "IdPelicula";
            this.idPeliculaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idPeliculaDataGridViewTextBoxColumn.Name = "idPeliculaDataGridViewTextBoxColumn";
            this.idPeliculaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPeliculaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idPeliculaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idPeliculaDataGridViewTextBoxColumn.ValueMember = "Id";
            this.idPeliculaDataGridViewTextBoxColumn.Width = 125;
            // 
            // horaInicioDataGridViewTextBoxColumn
            // 
            this.horaInicioDataGridViewTextBoxColumn.DataPropertyName = "HoraInicio";
            this.horaInicioDataGridViewTextBoxColumn.HeaderText = "HoraInicio";
            this.horaInicioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.horaInicioDataGridViewTextBoxColumn.Name = "horaInicioDataGridViewTextBoxColumn";
            this.horaInicioDataGridViewTextBoxColumn.ReadOnly = true;
            this.horaInicioDataGridViewTextBoxColumn.Width = 125;
            // 
            // idSalaDataGridViewTextBoxColumn1
            // 
            this.idSalaDataGridViewTextBoxColumn1.DataPropertyName = "IdSala";
            this.idSalaDataGridViewTextBoxColumn1.DataSource = this.bsSalas;
            this.idSalaDataGridViewTextBoxColumn1.DisplayMember = "Nombre";
            this.idSalaDataGridViewTextBoxColumn1.HeaderText = "IdSala";
            this.idSalaDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idSalaDataGridViewTextBoxColumn1.Name = "idSalaDataGridViewTextBoxColumn1";
            this.idSalaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idSalaDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idSalaDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idSalaDataGridViewTextBoxColumn1.ValueMember = "Id";
            this.idSalaDataGridViewTextBoxColumn1.Width = 125;
            // 
            // gbSesiones
            // 
            this.gbSesiones.Controls.Add(this.btnCancelarSesiones);
            this.gbSesiones.Controls.Add(this.btnAceptarSesiones);
            this.gbSesiones.Controls.Add(this.btnEliminarSesiones);
            this.gbSesiones.Controls.Add(this.btnEditarSesiones);
            this.gbSesiones.Controls.Add(this.btnAgregarSesiones);
            this.gbSesiones.Controls.Add(this.panCamposSesiones);
            this.gbSesiones.Location = new System.Drawing.Point(783, 21);
            this.gbSesiones.Name = "gbSesiones";
            this.gbSesiones.Size = new System.Drawing.Size(341, 465);
            this.gbSesiones.TabIndex = 0;
            this.gbSesiones.TabStop = false;
            this.gbSesiones.Text = "Opciones comunes";
            // 
            // btnCancelarSesiones
            // 
            this.btnCancelarSesiones.Image = global::CineApp.Properties.Resources.Cancelar;
            this.btnCancelarSesiones.Location = new System.Drawing.Point(293, 409);
            this.btnCancelarSesiones.Name = "btnCancelarSesiones";
            this.btnCancelarSesiones.Size = new System.Drawing.Size(32, 32);
            this.btnCancelarSesiones.TabIndex = 51;
            this.btnCancelarSesiones.UseVisualStyleBackColor = true;
            this.btnCancelarSesiones.Click += new System.EventHandler(this.btnCancelarSesiones_Click);
            // 
            // btnAceptarSesiones
            // 
            this.btnAceptarSesiones.Image = global::CineApp.Properties.Resources.Aceptar;
            this.btnAceptarSesiones.Location = new System.Drawing.Point(254, 409);
            this.btnAceptarSesiones.Name = "btnAceptarSesiones";
            this.btnAceptarSesiones.Size = new System.Drawing.Size(32, 32);
            this.btnAceptarSesiones.TabIndex = 50;
            this.btnAceptarSesiones.UseVisualStyleBackColor = true;
            this.btnAceptarSesiones.Click += new System.EventHandler(this.btnAceptarSesiones_Click);
            // 
            // btnEliminarSesiones
            // 
            this.btnEliminarSesiones.Location = new System.Drawing.Point(173, 409);
            this.btnEliminarSesiones.Name = "btnEliminarSesiones";
            this.btnEliminarSesiones.Size = new System.Drawing.Size(75, 33);
            this.btnEliminarSesiones.TabIndex = 49;
            this.btnEliminarSesiones.Text = "Eliminar";
            this.btnEliminarSesiones.UseVisualStyleBackColor = true;
            this.btnEliminarSesiones.Click += new System.EventHandler(this.btnEliminarSesiones_Click);
            // 
            // btnEditarSesiones
            // 
            this.btnEditarSesiones.Location = new System.Drawing.Point(92, 409);
            this.btnEditarSesiones.Name = "btnEditarSesiones";
            this.btnEditarSesiones.Size = new System.Drawing.Size(75, 33);
            this.btnEditarSesiones.TabIndex = 48;
            this.btnEditarSesiones.Text = "Editar";
            this.btnEditarSesiones.UseVisualStyleBackColor = true;
            this.btnEditarSesiones.Click += new System.EventHandler(this.btnEditarSesiones_Click);
            // 
            // btnAgregarSesiones
            // 
            this.btnAgregarSesiones.Location = new System.Drawing.Point(11, 409);
            this.btnAgregarSesiones.Name = "btnAgregarSesiones";
            this.btnAgregarSesiones.Size = new System.Drawing.Size(75, 33);
            this.btnAgregarSesiones.TabIndex = 47;
            this.btnAgregarSesiones.Text = "Agregar";
            this.btnAgregarSesiones.UseVisualStyleBackColor = true;
            this.btnAgregarSesiones.Click += new System.EventHandler(this.btnAgregarSesiones_Click);
            // 
            // panCamposSesiones
            // 
            this.panCamposSesiones.Controls.Add(this.txtFechaSesiones);
            this.panCamposSesiones.Controls.Add(this.lblFechaSesiones);
            this.panCamposSesiones.Controls.Add(this.txtHoraInicio);
            this.panCamposSesiones.Controls.Add(this.cmbPeliculasSesiones);
            this.panCamposSesiones.Controls.Add(this.lblTituloPeliculaSesiones);
            this.panCamposSesiones.Controls.Add(this.cmbSalasSesiones);
            this.panCamposSesiones.Controls.Add(this.lblNombreSalaSesiones);
            this.panCamposSesiones.Controls.Add(this.lblHoraInicio);
            this.panCamposSesiones.Enabled = false;
            this.panCamposSesiones.Location = new System.Drawing.Point(6, 21);
            this.panCamposSesiones.Name = "panCamposSesiones";
            this.panCamposSesiones.Size = new System.Drawing.Size(319, 222);
            this.panCamposSesiones.TabIndex = 19;
            // 
            // txtFechaSesiones
            // 
            this.txtFechaSesiones.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSesiones, "Fecha", true));
            this.txtFechaSesiones.Location = new System.Drawing.Point(6, 28);
            this.txtFechaSesiones.Name = "txtFechaSesiones";
            this.txtFechaSesiones.Size = new System.Drawing.Size(310, 22);
            this.txtFechaSesiones.TabIndex = 20;
            // 
            // lblFechaSesiones
            // 
            this.lblFechaSesiones.AutoSize = true;
            this.lblFechaSesiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaSesiones.Location = new System.Drawing.Point(3, 9);
            this.lblFechaSesiones.Name = "lblFechaSesiones";
            this.lblFechaSesiones.Size = new System.Drawing.Size(54, 16);
            this.lblFechaSesiones.TabIndex = 19;
            this.lblFechaSesiones.Text = "Fecha:";
            // 
            // txtHoraInicio
            // 
            this.txtHoraInicio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSesiones, "HoraInicio", true));
            this.txtHoraInicio.Location = new System.Drawing.Point(6, 131);
            this.txtHoraInicio.Name = "txtHoraInicio";
            this.txtHoraInicio.Size = new System.Drawing.Size(310, 22);
            this.txtHoraInicio.TabIndex = 5;
            // 
            // cmbPeliculasSesiones
            // 
            this.cmbPeliculasSesiones.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsSesiones, "IdPelicula", true));
            this.cmbPeliculasSesiones.FormattingEnabled = true;
            this.cmbPeliculasSesiones.Location = new System.Drawing.Point(6, 75);
            this.cmbPeliculasSesiones.Name = "cmbPeliculasSesiones";
            this.cmbPeliculasSesiones.Size = new System.Drawing.Size(310, 24);
            this.cmbPeliculasSesiones.TabIndex = 18;
            // 
            // lblTituloPeliculaSesiones
            // 
            this.lblTituloPeliculaSesiones.AutoSize = true;
            this.lblTituloPeliculaSesiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPeliculaSesiones.Location = new System.Drawing.Point(3, 56);
            this.lblTituloPeliculaSesiones.Name = "lblTituloPeliculaSesiones";
            this.lblTituloPeliculaSesiones.Size = new System.Drawing.Size(148, 16);
            this.lblTituloPeliculaSesiones.TabIndex = 0;
            this.lblTituloPeliculaSesiones.Text = "Título de la película:";
            // 
            // cmbSalasSesiones
            // 
            this.cmbSalasSesiones.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsSesiones, "IdSala", true));
            this.cmbSalasSesiones.FormattingEnabled = true;
            this.cmbSalasSesiones.Location = new System.Drawing.Point(6, 186);
            this.cmbSalasSesiones.Name = "cmbSalasSesiones";
            this.cmbSalasSesiones.Size = new System.Drawing.Size(310, 24);
            this.cmbSalasSesiones.TabIndex = 17;
            // 
            // lblNombreSalaSesiones
            // 
            this.lblNombreSalaSesiones.AutoSize = true;
            this.lblNombreSalaSesiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreSalaSesiones.Location = new System.Drawing.Point(3, 166);
            this.lblNombreSalaSesiones.Name = "lblNombreSalaSesiones";
            this.lblNombreSalaSesiones.Size = new System.Drawing.Size(139, 16);
            this.lblNombreSalaSesiones.TabIndex = 2;
            this.lblNombreSalaSesiones.Text = "Nombre de la sala:";
            // 
            // lblHoraInicio
            // 
            this.lblHoraInicio.AutoSize = true;
            this.lblHoraInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraInicio.Location = new System.Drawing.Point(3, 112);
            this.lblHoraInicio.Name = "lblHoraInicio";
            this.lblHoraInicio.Size = new System.Drawing.Size(108, 16);
            this.lblHoraInicio.TabIndex = 4;
            this.lblHoraInicio.Text = "Hora de inicio:";
            // 
            // tabPagGenero
            // 
            this.tabPagGenero.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPagGenero.Controls.Add(this.dgvGenero);
            this.tabPagGenero.Controls.Add(this.gbGenero);
            this.tabPagGenero.Location = new System.Drawing.Point(4, 25);
            this.tabPagGenero.Name = "tabPagGenero";
            this.tabPagGenero.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagGenero.Size = new System.Drawing.Size(1147, 511);
            this.tabPagGenero.TabIndex = 6;
            this.tabPagGenero.Text = "Géneros";
            this.tabPagGenero.UseVisualStyleBackColor = true;
            // 
            // dgvGenero
            // 
            this.dgvGenero.AllowUserToAddRows = false;
            this.dgvGenero.AllowUserToDeleteRows = false;
            this.dgvGenero.AutoGenerateColumns = false;
            this.dgvGenero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGenero.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn8,
            this.generoDataGridViewTextBoxColumn});
            this.dgvGenero.DataSource = this.bsGenero;
            this.dgvGenero.Location = new System.Drawing.Point(18, 21);
            this.dgvGenero.Name = "dgvGenero";
            this.dgvGenero.ReadOnly = true;
            this.dgvGenero.RowHeadersWidth = 51;
            this.dgvGenero.RowTemplate.Height = 24;
            this.dgvGenero.Size = new System.Drawing.Size(737, 465);
            this.dgvGenero.TabIndex = 1;
            this.dgvGenero.SelectionChanged += new System.EventHandler(this.dgvGenero_SelectionChanged);
            // 
            // idDataGridViewTextBoxColumn8
            // 
            this.idDataGridViewTextBoxColumn8.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn8.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn8.Name = "idDataGridViewTextBoxColumn8";
            this.idDataGridViewTextBoxColumn8.ReadOnly = true;
            this.idDataGridViewTextBoxColumn8.Width = 125;
            // 
            // generoDataGridViewTextBoxColumn
            // 
            this.generoDataGridViewTextBoxColumn.DataPropertyName = "Genero";
            this.generoDataGridViewTextBoxColumn.HeaderText = "Genero";
            this.generoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.generoDataGridViewTextBoxColumn.Name = "generoDataGridViewTextBoxColumn";
            this.generoDataGridViewTextBoxColumn.ReadOnly = true;
            this.generoDataGridViewTextBoxColumn.Width = 125;
            // 
            // gbGenero
            // 
            this.gbGenero.Controls.Add(this.btnCancelarGenero);
            this.gbGenero.Controls.Add(this.btnAceptarGenero);
            this.gbGenero.Controls.Add(this.btnEliminarGenero);
            this.gbGenero.Controls.Add(this.btnEditarGenero);
            this.gbGenero.Controls.Add(this.btnAgregarGenero);
            this.gbGenero.Controls.Add(this.panCamposGenero);
            this.gbGenero.Location = new System.Drawing.Point(783, 21);
            this.gbGenero.Name = "gbGenero";
            this.gbGenero.Size = new System.Drawing.Size(341, 465);
            this.gbGenero.TabIndex = 0;
            this.gbGenero.TabStop = false;
            this.gbGenero.Text = "Opciones comunes";
            // 
            // btnCancelarGenero
            // 
            this.btnCancelarGenero.Image = global::CineApp.Properties.Resources.Cancelar;
            this.btnCancelarGenero.Location = new System.Drawing.Point(296, 408);
            this.btnCancelarGenero.Name = "btnCancelarGenero";
            this.btnCancelarGenero.Size = new System.Drawing.Size(32, 32);
            this.btnCancelarGenero.TabIndex = 46;
            this.btnCancelarGenero.UseVisualStyleBackColor = true;
            this.btnCancelarGenero.Click += new System.EventHandler(this.btnCancelarGenero_Click);
            // 
            // btnAceptarGenero
            // 
            this.btnAceptarGenero.Image = global::CineApp.Properties.Resources.Aceptar;
            this.btnAceptarGenero.Location = new System.Drawing.Point(257, 408);
            this.btnAceptarGenero.Name = "btnAceptarGenero";
            this.btnAceptarGenero.Size = new System.Drawing.Size(32, 32);
            this.btnAceptarGenero.TabIndex = 45;
            this.btnAceptarGenero.UseVisualStyleBackColor = true;
            this.btnAceptarGenero.Click += new System.EventHandler(this.btnAceptarGenero_Click);
            // 
            // btnEliminarGenero
            // 
            this.btnEliminarGenero.Location = new System.Drawing.Point(176, 408);
            this.btnEliminarGenero.Name = "btnEliminarGenero";
            this.btnEliminarGenero.Size = new System.Drawing.Size(75, 33);
            this.btnEliminarGenero.TabIndex = 44;
            this.btnEliminarGenero.Text = "Eliminar";
            this.btnEliminarGenero.UseVisualStyleBackColor = true;
            this.btnEliminarGenero.Click += new System.EventHandler(this.btnEliminarGenero_Click);
            // 
            // btnEditarGenero
            // 
            this.btnEditarGenero.Location = new System.Drawing.Point(95, 408);
            this.btnEditarGenero.Name = "btnEditarGenero";
            this.btnEditarGenero.Size = new System.Drawing.Size(75, 33);
            this.btnEditarGenero.TabIndex = 43;
            this.btnEditarGenero.Text = "Editar";
            this.btnEditarGenero.UseVisualStyleBackColor = true;
            this.btnEditarGenero.Click += new System.EventHandler(this.btnEditarGenero_Click);
            // 
            // btnAgregarGenero
            // 
            this.btnAgregarGenero.Location = new System.Drawing.Point(14, 408);
            this.btnAgregarGenero.Name = "btnAgregarGenero";
            this.btnAgregarGenero.Size = new System.Drawing.Size(75, 33);
            this.btnAgregarGenero.TabIndex = 42;
            this.btnAgregarGenero.Text = "Agregar";
            this.btnAgregarGenero.UseVisualStyleBackColor = true;
            this.btnAgregarGenero.Click += new System.EventHandler(this.btnAgregarGenero_Click);
            // 
            // panCamposGenero
            // 
            this.panCamposGenero.Controls.Add(this.txtGenero);
            this.panCamposGenero.Controls.Add(this.lblGenero);
            this.panCamposGenero.Enabled = false;
            this.panCamposGenero.Location = new System.Drawing.Point(8, 18);
            this.panCamposGenero.Name = "panCamposGenero";
            this.panCamposGenero.Size = new System.Drawing.Size(319, 59);
            this.panCamposGenero.TabIndex = 41;
            // 
            // txtGenero
            // 
            this.txtGenero.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsGenero, "Genero", true));
            this.txtGenero.Location = new System.Drawing.Point(3, 24);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(313, 22);
            this.txtGenero.TabIndex = 1;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(0, 5);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(62, 16);
            this.lblGenero.TabIndex = 0;
            this.lblGenero.Text = "Género:";
            // 
            // tabPagEstadoPago
            // 
            this.tabPagEstadoPago.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPagEstadoPago.Controls.Add(this.dgvEstadoPago);
            this.tabPagEstadoPago.Controls.Add(this.gbEstadoPago);
            this.tabPagEstadoPago.Location = new System.Drawing.Point(4, 25);
            this.tabPagEstadoPago.Name = "tabPagEstadoPago";
            this.tabPagEstadoPago.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagEstadoPago.Size = new System.Drawing.Size(1147, 511);
            this.tabPagEstadoPago.TabIndex = 5;
            this.tabPagEstadoPago.Text = "Estados de pago";
            this.tabPagEstadoPago.UseVisualStyleBackColor = true;
            // 
            // dgvEstadoPago
            // 
            this.dgvEstadoPago.AllowUserToAddRows = false;
            this.dgvEstadoPago.AllowUserToDeleteRows = false;
            this.dgvEstadoPago.AutoGenerateColumns = false;
            this.dgvEstadoPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstadoPago.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn7,
            this.estadoDataGridViewTextBoxColumn2});
            this.dgvEstadoPago.DataSource = this.bsEstadoPago;
            this.dgvEstadoPago.Location = new System.Drawing.Point(18, 21);
            this.dgvEstadoPago.Name = "dgvEstadoPago";
            this.dgvEstadoPago.ReadOnly = true;
            this.dgvEstadoPago.RowHeadersWidth = 51;
            this.dgvEstadoPago.RowTemplate.Height = 24;
            this.dgvEstadoPago.Size = new System.Drawing.Size(737, 465);
            this.dgvEstadoPago.TabIndex = 1;
            this.dgvEstadoPago.SelectionChanged += new System.EventHandler(this.dgvEstadoPago_SelectionChanged);
            // 
            // idDataGridViewTextBoxColumn7
            // 
            this.idDataGridViewTextBoxColumn7.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn7.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn7.Name = "idDataGridViewTextBoxColumn7";
            this.idDataGridViewTextBoxColumn7.ReadOnly = true;
            this.idDataGridViewTextBoxColumn7.Width = 125;
            // 
            // estadoDataGridViewTextBoxColumn2
            // 
            this.estadoDataGridViewTextBoxColumn2.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn2.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.estadoDataGridViewTextBoxColumn2.Name = "estadoDataGridViewTextBoxColumn2";
            this.estadoDataGridViewTextBoxColumn2.ReadOnly = true;
            this.estadoDataGridViewTextBoxColumn2.Width = 125;
            // 
            // gbEstadoPago
            // 
            this.gbEstadoPago.Controls.Add(this.btnCancelarEstadoPago);
            this.gbEstadoPago.Controls.Add(this.btnAceptarEstadoPago);
            this.gbEstadoPago.Controls.Add(this.btnEliminarEstadoPago);
            this.gbEstadoPago.Controls.Add(this.btnEditarEstadoPago);
            this.gbEstadoPago.Controls.Add(this.btnAgregarEstadoPago);
            this.gbEstadoPago.Controls.Add(this.panCamposEstadoPago);
            this.gbEstadoPago.Location = new System.Drawing.Point(783, 21);
            this.gbEstadoPago.Name = "gbEstadoPago";
            this.gbEstadoPago.Size = new System.Drawing.Size(341, 465);
            this.gbEstadoPago.TabIndex = 0;
            this.gbEstadoPago.TabStop = false;
            this.gbEstadoPago.Text = "Opciones comunes";
            // 
            // btnCancelarEstadoPago
            // 
            this.btnCancelarEstadoPago.Image = global::CineApp.Properties.Resources.Cancelar;
            this.btnCancelarEstadoPago.Location = new System.Drawing.Point(293, 409);
            this.btnCancelarEstadoPago.Name = "btnCancelarEstadoPago";
            this.btnCancelarEstadoPago.Size = new System.Drawing.Size(32, 32);
            this.btnCancelarEstadoPago.TabIndex = 40;
            this.btnCancelarEstadoPago.UseVisualStyleBackColor = true;
            this.btnCancelarEstadoPago.Click += new System.EventHandler(this.btnCancelarEstadoPago_Click);
            // 
            // btnAceptarEstadoPago
            // 
            this.btnAceptarEstadoPago.Image = global::CineApp.Properties.Resources.Aceptar;
            this.btnAceptarEstadoPago.Location = new System.Drawing.Point(254, 409);
            this.btnAceptarEstadoPago.Name = "btnAceptarEstadoPago";
            this.btnAceptarEstadoPago.Size = new System.Drawing.Size(32, 32);
            this.btnAceptarEstadoPago.TabIndex = 39;
            this.btnAceptarEstadoPago.UseVisualStyleBackColor = true;
            this.btnAceptarEstadoPago.Click += new System.EventHandler(this.btnAceptarEstadoPago_Click);
            // 
            // btnEliminarEstadoPago
            // 
            this.btnEliminarEstadoPago.Location = new System.Drawing.Point(173, 409);
            this.btnEliminarEstadoPago.Name = "btnEliminarEstadoPago";
            this.btnEliminarEstadoPago.Size = new System.Drawing.Size(75, 33);
            this.btnEliminarEstadoPago.TabIndex = 38;
            this.btnEliminarEstadoPago.Text = "Eliminar";
            this.btnEliminarEstadoPago.UseVisualStyleBackColor = true;
            this.btnEliminarEstadoPago.Click += new System.EventHandler(this.btnEliminarEstadoPago_Click);
            // 
            // btnEditarEstadoPago
            // 
            this.btnEditarEstadoPago.Location = new System.Drawing.Point(92, 409);
            this.btnEditarEstadoPago.Name = "btnEditarEstadoPago";
            this.btnEditarEstadoPago.Size = new System.Drawing.Size(75, 33);
            this.btnEditarEstadoPago.TabIndex = 37;
            this.btnEditarEstadoPago.Text = "Editar";
            this.btnEditarEstadoPago.UseVisualStyleBackColor = true;
            this.btnEditarEstadoPago.Click += new System.EventHandler(this.btnEditarEstadoPago_Click);
            // 
            // btnAgregarEstadoPago
            // 
            this.btnAgregarEstadoPago.Location = new System.Drawing.Point(11, 409);
            this.btnAgregarEstadoPago.Name = "btnAgregarEstadoPago";
            this.btnAgregarEstadoPago.Size = new System.Drawing.Size(75, 33);
            this.btnAgregarEstadoPago.TabIndex = 36;
            this.btnAgregarEstadoPago.Text = "Agregar";
            this.btnAgregarEstadoPago.UseVisualStyleBackColor = true;
            this.btnAgregarEstadoPago.Click += new System.EventHandler(this.btnAgregarEstadoPago_Click);
            // 
            // panCamposEstadoPago
            // 
            this.panCamposEstadoPago.Controls.Add(this.txtEstadoPago);
            this.panCamposEstadoPago.Controls.Add(this.lblEstadoPago);
            this.panCamposEstadoPago.Enabled = false;
            this.panCamposEstadoPago.Location = new System.Drawing.Point(6, 21);
            this.panCamposEstadoPago.Name = "panCamposEstadoPago";
            this.panCamposEstadoPago.Size = new System.Drawing.Size(319, 59);
            this.panCamposEstadoPago.TabIndex = 18;
            // 
            // txtEstadoPago
            // 
            this.txtEstadoPago.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsEstadoPago, "Estado", true));
            this.txtEstadoPago.Location = new System.Drawing.Point(3, 24);
            this.txtEstadoPago.Name = "txtEstadoPago";
            this.txtEstadoPago.Size = new System.Drawing.Size(313, 22);
            this.txtEstadoPago.TabIndex = 1;
            // 
            // lblEstadoPago
            // 
            this.lblEstadoPago.AutoSize = true;
            this.lblEstadoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoPago.Location = new System.Drawing.Point(0, 5);
            this.lblEstadoPago.Name = "lblEstadoPago";
            this.lblEstadoPago.Size = new System.Drawing.Size(60, 16);
            this.lblEstadoPago.TabIndex = 0;
            this.lblEstadoPago.Text = "Estado:";
            // 
            // tabPagEstadoEmpleados
            // 
            this.tabPagEstadoEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPagEstadoEmpleados.Controls.Add(this.dgvEstadoEmpleados);
            this.tabPagEstadoEmpleados.Controls.Add(this.gbEstadoEmpleados);
            this.tabPagEstadoEmpleados.Location = new System.Drawing.Point(4, 25);
            this.tabPagEstadoEmpleados.Name = "tabPagEstadoEmpleados";
            this.tabPagEstadoEmpleados.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagEstadoEmpleados.Size = new System.Drawing.Size(1147, 511);
            this.tabPagEstadoEmpleados.TabIndex = 3;
            this.tabPagEstadoEmpleados.Text = "Estado de los empleados";
            this.tabPagEstadoEmpleados.UseVisualStyleBackColor = true;
            // 
            // dgvEstadoEmpleados
            // 
            this.dgvEstadoEmpleados.AllowUserToAddRows = false;
            this.dgvEstadoEmpleados.AllowUserToDeleteRows = false;
            this.dgvEstadoEmpleados.AutoGenerateColumns = false;
            this.dgvEstadoEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstadoEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn4,
            this.estadoDataGridViewTextBoxColumn});
            this.dgvEstadoEmpleados.DataSource = this.bsEstadoEmpleados;
            this.dgvEstadoEmpleados.Location = new System.Drawing.Point(18, 21);
            this.dgvEstadoEmpleados.Name = "dgvEstadoEmpleados";
            this.dgvEstadoEmpleados.ReadOnly = true;
            this.dgvEstadoEmpleados.RowHeadersWidth = 51;
            this.dgvEstadoEmpleados.RowTemplate.Height = 24;
            this.dgvEstadoEmpleados.Size = new System.Drawing.Size(737, 465);
            this.dgvEstadoEmpleados.TabIndex = 1;
            this.dgvEstadoEmpleados.SelectionChanged += new System.EventHandler(this.dgvEstadoEmpleados_SelectionChanged);
            // 
            // idDataGridViewTextBoxColumn4
            // 
            this.idDataGridViewTextBoxColumn4.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn4.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn4.Name = "idDataGridViewTextBoxColumn4";
            this.idDataGridViewTextBoxColumn4.ReadOnly = true;
            this.idDataGridViewTextBoxColumn4.Width = 125;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoDataGridViewTextBoxColumn.Width = 125;
            // 
            // bsEstadoEmpleados
            // 
            this.bsEstadoEmpleados.DataMember = "EstadoEmpleados";
            this.bsEstadoEmpleados.DataSource = this.dsCine1;
            // 
            // gbEstadoEmpleados
            // 
            this.gbEstadoEmpleados.Controls.Add(this.btnCancelarEstadoEmpleados);
            this.gbEstadoEmpleados.Controls.Add(this.btnAceptarEstadoEmpleados);
            this.gbEstadoEmpleados.Controls.Add(this.btnEliminarEstadoEmpleados);
            this.gbEstadoEmpleados.Controls.Add(this.btnEditarEstadoEmpleados);
            this.gbEstadoEmpleados.Controls.Add(this.btnAgregarEstadoEmpleados);
            this.gbEstadoEmpleados.Controls.Add(this.panCamposEstadoEmpleados);
            this.gbEstadoEmpleados.Location = new System.Drawing.Point(783, 21);
            this.gbEstadoEmpleados.Name = "gbEstadoEmpleados";
            this.gbEstadoEmpleados.Size = new System.Drawing.Size(341, 465);
            this.gbEstadoEmpleados.TabIndex = 0;
            this.gbEstadoEmpleados.TabStop = false;
            this.gbEstadoEmpleados.Text = "Opciones comunes";
            // 
            // btnCancelarEstadoEmpleados
            // 
            this.btnCancelarEstadoEmpleados.Image = global::CineApp.Properties.Resources.Cancelar;
            this.btnCancelarEstadoEmpleados.Location = new System.Drawing.Point(294, 409);
            this.btnCancelarEstadoEmpleados.Name = "btnCancelarEstadoEmpleados";
            this.btnCancelarEstadoEmpleados.Size = new System.Drawing.Size(32, 32);
            this.btnCancelarEstadoEmpleados.TabIndex = 35;
            this.btnCancelarEstadoEmpleados.UseVisualStyleBackColor = true;
            this.btnCancelarEstadoEmpleados.Click += new System.EventHandler(this.btnCancelarEstadoEmpleados_Click);
            // 
            // btnAceptarEstadoEmpleados
            // 
            this.btnAceptarEstadoEmpleados.Image = global::CineApp.Properties.Resources.Aceptar;
            this.btnAceptarEstadoEmpleados.Location = new System.Drawing.Point(255, 409);
            this.btnAceptarEstadoEmpleados.Name = "btnAceptarEstadoEmpleados";
            this.btnAceptarEstadoEmpleados.Size = new System.Drawing.Size(32, 32);
            this.btnAceptarEstadoEmpleados.TabIndex = 34;
            this.btnAceptarEstadoEmpleados.UseVisualStyleBackColor = true;
            this.btnAceptarEstadoEmpleados.Click += new System.EventHandler(this.btnAceptarEstadoEmpleados_Click);
            // 
            // btnEliminarEstadoEmpleados
            // 
            this.btnEliminarEstadoEmpleados.Location = new System.Drawing.Point(174, 409);
            this.btnEliminarEstadoEmpleados.Name = "btnEliminarEstadoEmpleados";
            this.btnEliminarEstadoEmpleados.Size = new System.Drawing.Size(75, 33);
            this.btnEliminarEstadoEmpleados.TabIndex = 33;
            this.btnEliminarEstadoEmpleados.Text = "Eliminar";
            this.btnEliminarEstadoEmpleados.UseVisualStyleBackColor = true;
            this.btnEliminarEstadoEmpleados.Click += new System.EventHandler(this.btnEliminarEstadoEmpleados_Click);
            // 
            // btnEditarEstadoEmpleados
            // 
            this.btnEditarEstadoEmpleados.Location = new System.Drawing.Point(93, 409);
            this.btnEditarEstadoEmpleados.Name = "btnEditarEstadoEmpleados";
            this.btnEditarEstadoEmpleados.Size = new System.Drawing.Size(75, 33);
            this.btnEditarEstadoEmpleados.TabIndex = 32;
            this.btnEditarEstadoEmpleados.Text = "Editar";
            this.btnEditarEstadoEmpleados.UseVisualStyleBackColor = true;
            this.btnEditarEstadoEmpleados.Click += new System.EventHandler(this.btnEditarEstadoEmpleados_Click);
            // 
            // btnAgregarEstadoEmpleados
            // 
            this.btnAgregarEstadoEmpleados.Location = new System.Drawing.Point(12, 409);
            this.btnAgregarEstadoEmpleados.Name = "btnAgregarEstadoEmpleados";
            this.btnAgregarEstadoEmpleados.Size = new System.Drawing.Size(75, 33);
            this.btnAgregarEstadoEmpleados.TabIndex = 31;
            this.btnAgregarEstadoEmpleados.Text = "Agregar";
            this.btnAgregarEstadoEmpleados.UseVisualStyleBackColor = true;
            this.btnAgregarEstadoEmpleados.Click += new System.EventHandler(this.btnAgregarEstadoEmpleados_Click);
            // 
            // panCamposEstadoEmpleados
            // 
            this.panCamposEstadoEmpleados.Controls.Add(this.txtEstadoEmpleados);
            this.panCamposEstadoEmpleados.Controls.Add(this.lblEstadoEmpleados);
            this.panCamposEstadoEmpleados.Enabled = false;
            this.panCamposEstadoEmpleados.Location = new System.Drawing.Point(10, 21);
            this.panCamposEstadoEmpleados.Name = "panCamposEstadoEmpleados";
            this.panCamposEstadoEmpleados.Size = new System.Drawing.Size(319, 59);
            this.panCamposEstadoEmpleados.TabIndex = 17;
            // 
            // txtEstadoEmpleados
            // 
            this.txtEstadoEmpleados.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsEstadoEmpleados, "Estado", true));
            this.txtEstadoEmpleados.Location = new System.Drawing.Point(3, 24);
            this.txtEstadoEmpleados.Name = "txtEstadoEmpleados";
            this.txtEstadoEmpleados.Size = new System.Drawing.Size(313, 22);
            this.txtEstadoEmpleados.TabIndex = 1;
            // 
            // lblEstadoEmpleados
            // 
            this.lblEstadoEmpleados.AutoSize = true;
            this.lblEstadoEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoEmpleados.Location = new System.Drawing.Point(0, 5);
            this.lblEstadoEmpleados.Name = "lblEstadoEmpleados";
            this.lblEstadoEmpleados.Size = new System.Drawing.Size(60, 16);
            this.lblEstadoEmpleados.TabIndex = 0;
            this.lblEstadoEmpleados.Text = "Estado:";
            // 
            // tabPagEstadoAsientos
            // 
            this.tabPagEstadoAsientos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPagEstadoAsientos.Controls.Add(this.dgvEstadoAsientos);
            this.tabPagEstadoAsientos.Controls.Add(this.gbEstadoAsientos);
            this.tabPagEstadoAsientos.Location = new System.Drawing.Point(4, 25);
            this.tabPagEstadoAsientos.Name = "tabPagEstadoAsientos";
            this.tabPagEstadoAsientos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagEstadoAsientos.Size = new System.Drawing.Size(1147, 511);
            this.tabPagEstadoAsientos.TabIndex = 4;
            this.tabPagEstadoAsientos.Text = "Estado de los asientos";
            this.tabPagEstadoAsientos.UseVisualStyleBackColor = true;
            // 
            // dgvEstadoAsientos
            // 
            this.dgvEstadoAsientos.AllowUserToAddRows = false;
            this.dgvEstadoAsientos.AllowUserToDeleteRows = false;
            this.dgvEstadoAsientos.AutoGenerateColumns = false;
            this.dgvEstadoAsientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstadoAsientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn6,
            this.estadoDataGridViewTextBoxColumn1});
            this.dgvEstadoAsientos.DataSource = this.bsEstadoAsientos;
            this.dgvEstadoAsientos.Location = new System.Drawing.Point(18, 21);
            this.dgvEstadoAsientos.Name = "dgvEstadoAsientos";
            this.dgvEstadoAsientos.ReadOnly = true;
            this.dgvEstadoAsientos.RowHeadersWidth = 51;
            this.dgvEstadoAsientos.RowTemplate.Height = 24;
            this.dgvEstadoAsientos.Size = new System.Drawing.Size(737, 465);
            this.dgvEstadoAsientos.TabIndex = 1;
            this.dgvEstadoAsientos.SelectionChanged += new System.EventHandler(this.dgvEstadoAsientos_SelectionChanged);
            // 
            // idDataGridViewTextBoxColumn6
            // 
            this.idDataGridViewTextBoxColumn6.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn6.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn6.Name = "idDataGridViewTextBoxColumn6";
            this.idDataGridViewTextBoxColumn6.ReadOnly = true;
            this.idDataGridViewTextBoxColumn6.Width = 125;
            // 
            // estadoDataGridViewTextBoxColumn1
            // 
            this.estadoDataGridViewTextBoxColumn1.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn1.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.estadoDataGridViewTextBoxColumn1.Name = "estadoDataGridViewTextBoxColumn1";
            this.estadoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.estadoDataGridViewTextBoxColumn1.Width = 125;
            // 
            // bsEstadoAsientos
            // 
            this.bsEstadoAsientos.DataMember = "EstadoAsientos";
            this.bsEstadoAsientos.DataSource = this.dsCine1;
            // 
            // gbEstadoAsientos
            // 
            this.gbEstadoAsientos.Controls.Add(this.panCamposEstadoAsientos);
            this.gbEstadoAsientos.Controls.Add(this.btnCancelarEstadoAsientos);
            this.gbEstadoAsientos.Controls.Add(this.btnAceptarEstadoAsientos);
            this.gbEstadoAsientos.Controls.Add(this.btnEliminarEstadoAsientos);
            this.gbEstadoAsientos.Controls.Add(this.btnEditarEstadoAsientos);
            this.gbEstadoAsientos.Controls.Add(this.btnAgregarEstadoAsientos);
            this.gbEstadoAsientos.Location = new System.Drawing.Point(783, 21);
            this.gbEstadoAsientos.Name = "gbEstadoAsientos";
            this.gbEstadoAsientos.Size = new System.Drawing.Size(341, 465);
            this.gbEstadoAsientos.TabIndex = 0;
            this.gbEstadoAsientos.TabStop = false;
            this.gbEstadoAsientos.Text = "Opciones comunes";
            // 
            // panCamposEstadoAsientos
            // 
            this.panCamposEstadoAsientos.Controls.Add(this.txtEstadoAsientos);
            this.panCamposEstadoAsientos.Controls.Add(this.lblEstadoAsientos);
            this.panCamposEstadoAsientos.Enabled = false;
            this.panCamposEstadoAsientos.Location = new System.Drawing.Point(10, 21);
            this.panCamposEstadoAsientos.Name = "panCamposEstadoAsientos";
            this.panCamposEstadoAsientos.Size = new System.Drawing.Size(319, 60);
            this.panCamposEstadoAsientos.TabIndex = 31;
            // 
            // txtEstadoAsientos
            // 
            this.txtEstadoAsientos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsEstadoAsientos, "Estado", true));
            this.txtEstadoAsientos.Location = new System.Drawing.Point(6, 26);
            this.txtEstadoAsientos.Name = "txtEstadoAsientos";
            this.txtEstadoAsientos.Size = new System.Drawing.Size(308, 22);
            this.txtEstadoAsientos.TabIndex = 17;
            // 
            // lblEstadoAsientos
            // 
            this.lblEstadoAsientos.AutoSize = true;
            this.lblEstadoAsientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoAsientos.Location = new System.Drawing.Point(3, 7);
            this.lblEstadoAsientos.Name = "lblEstadoAsientos";
            this.lblEstadoAsientos.Size = new System.Drawing.Size(60, 16);
            this.lblEstadoAsientos.TabIndex = 0;
            this.lblEstadoAsientos.Text = "Estado:";
            // 
            // btnCancelarEstadoAsientos
            // 
            this.btnCancelarEstadoAsientos.Image = global::CineApp.Properties.Resources.Cancelar;
            this.btnCancelarEstadoAsientos.Location = new System.Drawing.Point(292, 409);
            this.btnCancelarEstadoAsientos.Name = "btnCancelarEstadoAsientos";
            this.btnCancelarEstadoAsientos.Size = new System.Drawing.Size(32, 32);
            this.btnCancelarEstadoAsientos.TabIndex = 30;
            this.btnCancelarEstadoAsientos.UseVisualStyleBackColor = true;
            this.btnCancelarEstadoAsientos.Click += new System.EventHandler(this.btnCancelarEstadoAsientos_Click);
            // 
            // btnAceptarEstadoAsientos
            // 
            this.btnAceptarEstadoAsientos.Image = global::CineApp.Properties.Resources.Aceptar;
            this.btnAceptarEstadoAsientos.Location = new System.Drawing.Point(253, 409);
            this.btnAceptarEstadoAsientos.Name = "btnAceptarEstadoAsientos";
            this.btnAceptarEstadoAsientos.Size = new System.Drawing.Size(32, 32);
            this.btnAceptarEstadoAsientos.TabIndex = 29;
            this.btnAceptarEstadoAsientos.UseVisualStyleBackColor = true;
            this.btnAceptarEstadoAsientos.Click += new System.EventHandler(this.btnAceptarEstadoAsientos_Click);
            // 
            // btnEliminarEstadoAsientos
            // 
            this.btnEliminarEstadoAsientos.Location = new System.Drawing.Point(172, 409);
            this.btnEliminarEstadoAsientos.Name = "btnEliminarEstadoAsientos";
            this.btnEliminarEstadoAsientos.Size = new System.Drawing.Size(75, 33);
            this.btnEliminarEstadoAsientos.TabIndex = 28;
            this.btnEliminarEstadoAsientos.Text = "Eliminar";
            this.btnEliminarEstadoAsientos.UseVisualStyleBackColor = true;
            this.btnEliminarEstadoAsientos.Click += new System.EventHandler(this.btnEliminarEstadoAsientos_Click);
            // 
            // btnEditarEstadoAsientos
            // 
            this.btnEditarEstadoAsientos.Location = new System.Drawing.Point(91, 409);
            this.btnEditarEstadoAsientos.Name = "btnEditarEstadoAsientos";
            this.btnEditarEstadoAsientos.Size = new System.Drawing.Size(75, 33);
            this.btnEditarEstadoAsientos.TabIndex = 27;
            this.btnEditarEstadoAsientos.Text = "Editar";
            this.btnEditarEstadoAsientos.UseVisualStyleBackColor = true;
            this.btnEditarEstadoAsientos.Click += new System.EventHandler(this.btnEditarEstadoAsientos_Click);
            // 
            // btnAgregarEstadoAsientos
            // 
            this.btnAgregarEstadoAsientos.Location = new System.Drawing.Point(10, 409);
            this.btnAgregarEstadoAsientos.Name = "btnAgregarEstadoAsientos";
            this.btnAgregarEstadoAsientos.Size = new System.Drawing.Size(75, 33);
            this.btnAgregarEstadoAsientos.TabIndex = 26;
            this.btnAgregarEstadoAsientos.Text = "Agregar";
            this.btnAgregarEstadoAsientos.UseVisualStyleBackColor = true;
            this.btnAgregarEstadoAsientos.Click += new System.EventHandler(this.btnAgregarEstadoAsientos_Click);
            // 
            // tabPagEmpleados
            // 
            this.tabPagEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPagEmpleados.Controls.Add(this.dgvEmpleados);
            this.tabPagEmpleados.Controls.Add(this.gbEmpleados);
            this.tabPagEmpleados.Location = new System.Drawing.Point(4, 25);
            this.tabPagEmpleados.Name = "tabPagEmpleados";
            this.tabPagEmpleados.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagEmpleados.Size = new System.Drawing.Size(1147, 511);
            this.tabPagEmpleados.TabIndex = 2;
            this.tabPagEmpleados.Text = "Empleados";
            this.tabPagEmpleados.UseVisualStyleBackColor = true;
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AllowUserToDeleteRows = false;
            this.dgvEmpleados.AutoGenerateColumns = false;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.nombreDataGridViewTextBoxColumn1,
            this.apellidosDataGridViewTextBoxColumn,
            this.correoDataGridViewTextBoxColumn,
            this.idPuestoDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.idUsuarioDataGridViewTextBoxColumn});
            this.dgvEmpleados.DataSource = this.bsEmpleados;
            this.dgvEmpleados.Location = new System.Drawing.Point(18, 21);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.RowHeadersWidth = 51;
            this.dgvEmpleados.RowTemplate.Height = 24;
            this.dgvEmpleados.Size = new System.Drawing.Size(737, 465);
            this.dgvEmpleados.TabIndex = 1;
            this.dgvEmpleados.SelectionChanged += new System.EventHandler(this.dgvEmpleados_SelectionChanged);
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.ReadOnly = true;
            this.idDataGridViewTextBoxColumn2.Width = 125;
            // 
            // nombreDataGridViewTextBoxColumn1
            // 
            this.nombreDataGridViewTextBoxColumn1.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn1.Name = "nombreDataGridViewTextBoxColumn1";
            this.nombreDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn1.Width = 125;
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            this.apellidosDataGridViewTextBoxColumn.DataPropertyName = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            this.apellidosDataGridViewTextBoxColumn.ReadOnly = true;
            this.apellidosDataGridViewTextBoxColumn.Width = 125;
            // 
            // correoDataGridViewTextBoxColumn
            // 
            this.correoDataGridViewTextBoxColumn.DataPropertyName = "Correo";
            this.correoDataGridViewTextBoxColumn.HeaderText = "Correo";
            this.correoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            this.correoDataGridViewTextBoxColumn.ReadOnly = true;
            this.correoDataGridViewTextBoxColumn.Width = 125;
            // 
            // idPuestoDataGridViewTextBoxColumn
            // 
            this.idPuestoDataGridViewTextBoxColumn.DataPropertyName = "IdPuesto";
            this.idPuestoDataGridViewTextBoxColumn.DataSource = this.bsPuestosTrabajo;
            this.idPuestoDataGridViewTextBoxColumn.DisplayMember = "Puesto";
            this.idPuestoDataGridViewTextBoxColumn.HeaderText = "IdPuesto";
            this.idPuestoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idPuestoDataGridViewTextBoxColumn.Name = "idPuestoDataGridViewTextBoxColumn";
            this.idPuestoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPuestoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idPuestoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idPuestoDataGridViewTextBoxColumn.ValueMember = "Id";
            this.idPuestoDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdEstado";
            this.dataGridViewTextBoxColumn1.DataSource = this.bsEstadoEmpleados;
            this.dataGridViewTextBoxColumn1.DisplayMember = "Estado";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdEstado";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn1.ValueMember = "Id";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // idUsuarioDataGridViewTextBoxColumn
            // 
            this.idUsuarioDataGridViewTextBoxColumn.DataPropertyName = "IdUsuario";
            this.idUsuarioDataGridViewTextBoxColumn.DataSource = this.bsUsuarios;
            this.idUsuarioDataGridViewTextBoxColumn.DisplayMember = "Nombre";
            this.idUsuarioDataGridViewTextBoxColumn.HeaderText = "IdUsuario";
            this.idUsuarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idUsuarioDataGridViewTextBoxColumn.Name = "idUsuarioDataGridViewTextBoxColumn";
            this.idUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.idUsuarioDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idUsuarioDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idUsuarioDataGridViewTextBoxColumn.ValueMember = "Id";
            this.idUsuarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // bsEmpleados
            // 
            this.bsEmpleados.DataMember = "Empleados";
            this.bsEmpleados.DataSource = this.dsCine1;
            // 
            // gbEmpleados
            // 
            this.gbEmpleados.Controls.Add(this.panCamposEmpleados);
            this.gbEmpleados.Controls.Add(this.btnCancelarEmpleados);
            this.gbEmpleados.Controls.Add(this.btnAceptarEmpleados);
            this.gbEmpleados.Controls.Add(this.btnEliminarEmpleados);
            this.gbEmpleados.Controls.Add(this.btnEditarEmpleados);
            this.gbEmpleados.Controls.Add(this.btnAgregarEmpleados);
            this.gbEmpleados.Location = new System.Drawing.Point(783, 21);
            this.gbEmpleados.Name = "gbEmpleados";
            this.gbEmpleados.Size = new System.Drawing.Size(341, 465);
            this.gbEmpleados.TabIndex = 0;
            this.gbEmpleados.TabStop = false;
            this.gbEmpleados.Text = "Opciones comunes";
            // 
            // panCamposEmpleados
            // 
            this.panCamposEmpleados.Controls.Add(this.cmbUsuariosEmpleados);
            this.panCamposEmpleados.Controls.Add(this.cmbEstadoEmpleadosEmpleados);
            this.panCamposEmpleados.Controls.Add(this.cmbPuestoTrabajoEmpleados);
            this.panCamposEmpleados.Controls.Add(this.lblNombreUsuarioEmpleados);
            this.panCamposEmpleados.Controls.Add(this.txtCorreo);
            this.panCamposEmpleados.Controls.Add(this.lblCorreo);
            this.panCamposEmpleados.Controls.Add(this.lblEstadoEmpleadosEmpleados);
            this.panCamposEmpleados.Controls.Add(this.lblPuestoTrabajoEmpleados);
            this.panCamposEmpleados.Controls.Add(this.txtApellidos);
            this.panCamposEmpleados.Controls.Add(this.lblApellidos);
            this.panCamposEmpleados.Controls.Add(this.txtNombre);
            this.panCamposEmpleados.Controls.Add(this.lblNombre);
            this.panCamposEmpleados.Enabled = false;
            this.panCamposEmpleados.Location = new System.Drawing.Point(6, 21);
            this.panCamposEmpleados.Name = "panCamposEmpleados";
            this.panCamposEmpleados.Size = new System.Drawing.Size(319, 335);
            this.panCamposEmpleados.TabIndex = 26;
            // 
            // cmbUsuariosEmpleados
            // 
            this.cmbUsuariosEmpleados.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsEmpleados, "IdUsuario", true));
            this.cmbUsuariosEmpleados.DisplayMember = "Id";
            this.cmbUsuariosEmpleados.FormattingEnabled = true;
            this.cmbUsuariosEmpleados.Location = new System.Drawing.Point(5, 301);
            this.cmbUsuariosEmpleados.Name = "cmbUsuariosEmpleados";
            this.cmbUsuariosEmpleados.Size = new System.Drawing.Size(300, 24);
            this.cmbUsuariosEmpleados.TabIndex = 31;
            this.cmbUsuariosEmpleados.ValueMember = "Id";
            // 
            // cmbEstadoEmpleadosEmpleados
            // 
            this.cmbEstadoEmpleadosEmpleados.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsEmpleados, "IdEstado", true));
            this.cmbEstadoEmpleadosEmpleados.DisplayMember = "Id";
            this.cmbEstadoEmpleadosEmpleados.FormattingEnabled = true;
            this.cmbEstadoEmpleadosEmpleados.Location = new System.Drawing.Point(6, 243);
            this.cmbEstadoEmpleadosEmpleados.Name = "cmbEstadoEmpleadosEmpleados";
            this.cmbEstadoEmpleadosEmpleados.Size = new System.Drawing.Size(300, 24);
            this.cmbEstadoEmpleadosEmpleados.TabIndex = 30;
            this.cmbEstadoEmpleadosEmpleados.ValueMember = "Id";
            // 
            // cmbPuestoTrabajoEmpleados
            // 
            this.cmbPuestoTrabajoEmpleados.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsEmpleados, "IdPuesto", true));
            this.cmbPuestoTrabajoEmpleados.FormattingEnabled = true;
            this.cmbPuestoTrabajoEmpleados.Location = new System.Drawing.Point(6, 186);
            this.cmbPuestoTrabajoEmpleados.Name = "cmbPuestoTrabajoEmpleados";
            this.cmbPuestoTrabajoEmpleados.Size = new System.Drawing.Size(300, 24);
            this.cmbPuestoTrabajoEmpleados.TabIndex = 29;
            // 
            // lblNombreUsuarioEmpleados
            // 
            this.lblNombreUsuarioEmpleados.AutoSize = true;
            this.lblNombreUsuarioEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuarioEmpleados.Location = new System.Drawing.Point(3, 282);
            this.lblNombreUsuarioEmpleados.Name = "lblNombreUsuarioEmpleados";
            this.lblNombreUsuarioEmpleados.Size = new System.Drawing.Size(143, 16);
            this.lblNombreUsuarioEmpleados.TabIndex = 27;
            this.lblNombreUsuarioEmpleados.Text = "Nombre de usuario:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsEmpleados, "Correo", true));
            this.txtCorreo.Location = new System.Drawing.Point(6, 132);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(300, 22);
            this.txtCorreo.TabIndex = 26;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(3, 113);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(139, 16);
            this.lblCorreo.TabIndex = 25;
            this.lblCorreo.Text = "Correo electrónico:";
            // 
            // lblEstadoEmpleadosEmpleados
            // 
            this.lblEstadoEmpleadosEmpleados.AutoSize = true;
            this.lblEstadoEmpleadosEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoEmpleadosEmpleados.Location = new System.Drawing.Point(3, 224);
            this.lblEstadoEmpleadosEmpleados.Name = "lblEstadoEmpleadosEmpleados";
            this.lblEstadoEmpleadosEmpleados.Size = new System.Drawing.Size(160, 16);
            this.lblEstadoEmpleadosEmpleados.TabIndex = 24;
            this.lblEstadoEmpleadosEmpleados.Text = "Estado del empleado:";
            // 
            // lblPuestoTrabajoEmpleados
            // 
            this.lblPuestoTrabajoEmpleados.AutoSize = true;
            this.lblPuestoTrabajoEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuestoTrabajoEmpleados.Location = new System.Drawing.Point(3, 166);
            this.lblPuestoTrabajoEmpleados.Name = "lblPuestoTrabajoEmpleados";
            this.lblPuestoTrabajoEmpleados.Size = new System.Drawing.Size(134, 16);
            this.lblPuestoTrabajoEmpleados.TabIndex = 23;
            this.lblPuestoTrabajoEmpleados.Text = "Puesto de trabajo:";
            // 
            // txtApellidos
            // 
            this.txtApellidos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsEmpleados, "Apellidos", true));
            this.txtApellidos.Location = new System.Drawing.Point(6, 79);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(300, 22);
            this.txtApellidos.TabIndex = 22;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.Location = new System.Drawing.Point(3, 60);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(77, 16);
            this.lblApellidos.TabIndex = 21;
            this.lblApellidos.Text = "Apellidos:";
            // 
            // txtNombre
            // 
            this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsEmpleados, "Nombre", true));
            this.txtNombre.Location = new System.Drawing.Point(6, 29);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(300, 22);
            this.txtNombre.TabIndex = 20;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(3, 10);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(66, 16);
            this.lblNombre.TabIndex = 19;
            this.lblNombre.Text = "Nombre:";
            // 
            // btnCancelarEmpleados
            // 
            this.btnCancelarEmpleados.Image = global::CineApp.Properties.Resources.Cancelar;
            this.btnCancelarEmpleados.Location = new System.Drawing.Point(293, 409);
            this.btnCancelarEmpleados.Name = "btnCancelarEmpleados";
            this.btnCancelarEmpleados.Size = new System.Drawing.Size(32, 32);
            this.btnCancelarEmpleados.TabIndex = 25;
            this.btnCancelarEmpleados.UseVisualStyleBackColor = true;
            this.btnCancelarEmpleados.Click += new System.EventHandler(this.btnCancelarEmpleados_Click);
            // 
            // btnAceptarEmpleados
            // 
            this.btnAceptarEmpleados.Image = global::CineApp.Properties.Resources.Aceptar;
            this.btnAceptarEmpleados.Location = new System.Drawing.Point(254, 409);
            this.btnAceptarEmpleados.Name = "btnAceptarEmpleados";
            this.btnAceptarEmpleados.Size = new System.Drawing.Size(32, 32);
            this.btnAceptarEmpleados.TabIndex = 24;
            this.btnAceptarEmpleados.UseVisualStyleBackColor = true;
            this.btnAceptarEmpleados.Click += new System.EventHandler(this.btnAceptarEmpleados_Click);
            // 
            // btnEliminarEmpleados
            // 
            this.btnEliminarEmpleados.Location = new System.Drawing.Point(173, 409);
            this.btnEliminarEmpleados.Name = "btnEliminarEmpleados";
            this.btnEliminarEmpleados.Size = new System.Drawing.Size(75, 33);
            this.btnEliminarEmpleados.TabIndex = 23;
            this.btnEliminarEmpleados.Text = "Eliminar";
            this.btnEliminarEmpleados.UseVisualStyleBackColor = true;
            this.btnEliminarEmpleados.Click += new System.EventHandler(this.btnEliminarEmpleados_Click);
            // 
            // btnEditarEmpleados
            // 
            this.btnEditarEmpleados.Location = new System.Drawing.Point(92, 409);
            this.btnEditarEmpleados.Name = "btnEditarEmpleados";
            this.btnEditarEmpleados.Size = new System.Drawing.Size(75, 33);
            this.btnEditarEmpleados.TabIndex = 22;
            this.btnEditarEmpleados.Text = "Editar";
            this.btnEditarEmpleados.UseVisualStyleBackColor = true;
            this.btnEditarEmpleados.Click += new System.EventHandler(this.btnEditarEmpleados_Click);
            // 
            // btnAgregarEmpleados
            // 
            this.btnAgregarEmpleados.Location = new System.Drawing.Point(11, 409);
            this.btnAgregarEmpleados.Name = "btnAgregarEmpleados";
            this.btnAgregarEmpleados.Size = new System.Drawing.Size(75, 33);
            this.btnAgregarEmpleados.TabIndex = 21;
            this.btnAgregarEmpleados.Text = "Agregar";
            this.btnAgregarEmpleados.UseVisualStyleBackColor = true;
            this.btnAgregarEmpleados.Click += new System.EventHandler(this.btnAgregarEmpleados_Click);
            // 
            // tabPagAsientos
            // 
            this.tabPagAsientos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPagAsientos.Controls.Add(this.dgvAsientos);
            this.tabPagAsientos.Controls.Add(this.gbAsientos);
            this.tabPagAsientos.Location = new System.Drawing.Point(4, 25);
            this.tabPagAsientos.Name = "tabPagAsientos";
            this.tabPagAsientos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagAsientos.Size = new System.Drawing.Size(1147, 511);
            this.tabPagAsientos.TabIndex = 0;
            this.tabPagAsientos.Text = "Asientos";
            this.tabPagAsientos.UseVisualStyleBackColor = true;
            // 
            // dgvAsientos
            // 
            this.dgvAsientos.AllowUserToAddRows = false;
            this.dgvAsientos.AllowUserToDeleteRows = false;
            this.dgvAsientos.AutoGenerateColumns = false;
            this.dgvAsientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idSalaDataGridViewTextBoxColumn,
            this.numFilaDataGridViewTextBoxColumn,
            this.numColumnaDataGridViewTextBoxColumn});
            this.dgvAsientos.DataSource = this.bsAsientos;
            this.dgvAsientos.Location = new System.Drawing.Point(18, 21);
            this.dgvAsientos.Name = "dgvAsientos";
            this.dgvAsientos.ReadOnly = true;
            this.dgvAsientos.RowHeadersWidth = 51;
            this.dgvAsientos.RowTemplate.Height = 24;
            this.dgvAsientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAsientos.Size = new System.Drawing.Size(737, 465);
            this.dgvAsientos.TabIndex = 1;
            this.dgvAsientos.SelectionChanged += new System.EventHandler(this.dgvAsientos_SelectionChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // idSalaDataGridViewTextBoxColumn
            // 
            this.idSalaDataGridViewTextBoxColumn.DataPropertyName = "IdSala";
            this.idSalaDataGridViewTextBoxColumn.DataSource = this.bsSalas;
            this.idSalaDataGridViewTextBoxColumn.DisplayMember = "Nombre";
            this.idSalaDataGridViewTextBoxColumn.HeaderText = "IdSala";
            this.idSalaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idSalaDataGridViewTextBoxColumn.Name = "idSalaDataGridViewTextBoxColumn";
            this.idSalaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idSalaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idSalaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idSalaDataGridViewTextBoxColumn.ValueMember = "Id";
            this.idSalaDataGridViewTextBoxColumn.Width = 125;
            // 
            // numFilaDataGridViewTextBoxColumn
            // 
            this.numFilaDataGridViewTextBoxColumn.DataPropertyName = "NumFila";
            this.numFilaDataGridViewTextBoxColumn.HeaderText = "NumFila";
            this.numFilaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numFilaDataGridViewTextBoxColumn.Name = "numFilaDataGridViewTextBoxColumn";
            this.numFilaDataGridViewTextBoxColumn.ReadOnly = true;
            this.numFilaDataGridViewTextBoxColumn.Width = 125;
            // 
            // numColumnaDataGridViewTextBoxColumn
            // 
            this.numColumnaDataGridViewTextBoxColumn.DataPropertyName = "NumColumna";
            this.numColumnaDataGridViewTextBoxColumn.HeaderText = "NumColumna";
            this.numColumnaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numColumnaDataGridViewTextBoxColumn.Name = "numColumnaDataGridViewTextBoxColumn";
            this.numColumnaDataGridViewTextBoxColumn.ReadOnly = true;
            this.numColumnaDataGridViewTextBoxColumn.Width = 125;
            // 
            // gbAsientos
            // 
            this.gbAsientos.Controls.Add(this.btnCancelarAsientos);
            this.gbAsientos.Controls.Add(this.panCamposAsientos);
            this.gbAsientos.Controls.Add(this.btnAceptarAsientos);
            this.gbAsientos.Controls.Add(this.btnEliminarAsientos);
            this.gbAsientos.Controls.Add(this.btnEditarAsientos);
            this.gbAsientos.Controls.Add(this.btnAgregarAsientos);
            this.gbAsientos.Location = new System.Drawing.Point(783, 21);
            this.gbAsientos.Name = "gbAsientos";
            this.gbAsientos.Size = new System.Drawing.Size(341, 465);
            this.gbAsientos.TabIndex = 0;
            this.gbAsientos.TabStop = false;
            this.gbAsientos.Text = "Opciones comunes";
            // 
            // btnCancelarAsientos
            // 
            this.btnCancelarAsientos.Image = global::CineApp.Properties.Resources.Cancelar;
            this.btnCancelarAsientos.Location = new System.Drawing.Point(294, 416);
            this.btnCancelarAsientos.Name = "btnCancelarAsientos";
            this.btnCancelarAsientos.Size = new System.Drawing.Size(32, 32);
            this.btnCancelarAsientos.TabIndex = 20;
            this.btnCancelarAsientos.UseVisualStyleBackColor = true;
            this.btnCancelarAsientos.Click += new System.EventHandler(this.btnCancelarAsientos_Click);
            // 
            // panCamposAsientos
            // 
            this.panCamposAsientos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panCamposAsientos.Controls.Add(this.lblSalaEmpleados);
            this.panCamposAsientos.Controls.Add(this.lblNumFila);
            this.panCamposAsientos.Controls.Add(this.cmbSalaAsientos);
            this.panCamposAsientos.Controls.Add(this.txtNumFila);
            this.panCamposAsientos.Controls.Add(this.lblNumColumna);
            this.panCamposAsientos.Controls.Add(this.txtNumColumna);
            this.panCamposAsientos.Enabled = false;
            this.panCamposAsientos.Location = new System.Drawing.Point(6, 21);
            this.panCamposAsientos.Name = "panCamposAsientos";
            this.panCamposAsientos.Size = new System.Drawing.Size(323, 155);
            this.panCamposAsientos.TabIndex = 5;
            // 
            // lblSalaEmpleados
            // 
            this.lblSalaEmpleados.AutoSize = true;
            this.lblSalaEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalaEmpleados.Location = new System.Drawing.Point(3, 6);
            this.lblSalaEmpleados.Name = "lblSalaEmpleados";
            this.lblSalaEmpleados.Size = new System.Drawing.Size(141, 16);
            this.lblSalaEmpleados.TabIndex = 0;
            this.lblSalaEmpleados.Text = "Nombre de la Sala:";
            // 
            // lblNumFila
            // 
            this.lblNumFila.AutoSize = true;
            this.lblNumFila.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumFila.Location = new System.Drawing.Point(3, 56);
            this.lblNumFila.Name = "lblNumFila";
            this.lblNumFila.Size = new System.Drawing.Size(112, 16);
            this.lblNumFila.TabIndex = 2;
            this.lblNumFila.Text = "Número de fila:";
            // 
            // cmbSalaAsientos
            // 
            this.cmbSalaAsientos.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsAsientos, "IdSala", true));
            this.cmbSalaAsientos.DisplayMember = "Id";
            this.cmbSalaAsientos.Location = new System.Drawing.Point(6, 26);
            this.cmbSalaAsientos.Name = "cmbSalaAsientos";
            this.cmbSalaAsientos.Size = new System.Drawing.Size(314, 24);
            this.cmbSalaAsientos.TabIndex = 17;
            this.cmbSalaAsientos.ValueMember = "Id";
            // 
            // txtNumFila
            // 
            this.txtNumFila.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAsientos, "NumFila", true));
            this.txtNumFila.Location = new System.Drawing.Point(6, 75);
            this.txtNumFila.Name = "txtNumFila";
            this.txtNumFila.Size = new System.Drawing.Size(314, 22);
            this.txtNumFila.TabIndex = 3;
            // 
            // lblNumColumna
            // 
            this.lblNumColumna.AutoSize = true;
            this.lblNumColumna.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumColumna.Location = new System.Drawing.Point(3, 107);
            this.lblNumColumna.Name = "lblNumColumna";
            this.lblNumColumna.Size = new System.Drawing.Size(149, 16);
            this.lblNumColumna.TabIndex = 4;
            this.lblNumColumna.Text = "Número de columna:";
            // 
            // txtNumColumna
            // 
            this.txtNumColumna.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAsientos, "NumColumna", true));
            this.txtNumColumna.Location = new System.Drawing.Point(6, 126);
            this.txtNumColumna.Name = "txtNumColumna";
            this.txtNumColumna.Size = new System.Drawing.Size(314, 22);
            this.txtNumColumna.TabIndex = 5;
            // 
            // btnAceptarAsientos
            // 
            this.btnAceptarAsientos.Image = global::CineApp.Properties.Resources.Aceptar;
            this.btnAceptarAsientos.Location = new System.Drawing.Point(255, 416);
            this.btnAceptarAsientos.Name = "btnAceptarAsientos";
            this.btnAceptarAsientos.Size = new System.Drawing.Size(32, 32);
            this.btnAceptarAsientos.TabIndex = 19;
            this.btnAceptarAsientos.UseVisualStyleBackColor = true;
            this.btnAceptarAsientos.Click += new System.EventHandler(this.btnAceptarAsientos_Click);
            // 
            // btnEliminarAsientos
            // 
            this.btnEliminarAsientos.Location = new System.Drawing.Point(174, 416);
            this.btnEliminarAsientos.Name = "btnEliminarAsientos";
            this.btnEliminarAsientos.Size = new System.Drawing.Size(75, 33);
            this.btnEliminarAsientos.TabIndex = 16;
            this.btnEliminarAsientos.Text = "Eliminar";
            this.btnEliminarAsientos.UseVisualStyleBackColor = true;
            this.btnEliminarAsientos.Click += new System.EventHandler(this.btnEliminarAsientos_Click);
            // 
            // btnEditarAsientos
            // 
            this.btnEditarAsientos.Location = new System.Drawing.Point(93, 416);
            this.btnEditarAsientos.Name = "btnEditarAsientos";
            this.btnEditarAsientos.Size = new System.Drawing.Size(75, 33);
            this.btnEditarAsientos.TabIndex = 15;
            this.btnEditarAsientos.Text = "Editar";
            this.btnEditarAsientos.UseVisualStyleBackColor = true;
            this.btnEditarAsientos.Click += new System.EventHandler(this.btnEditarAsientos_Click);
            // 
            // btnAgregarAsientos
            // 
            this.btnAgregarAsientos.Location = new System.Drawing.Point(12, 416);
            this.btnAgregarAsientos.Name = "btnAgregarAsientos";
            this.btnAgregarAsientos.Size = new System.Drawing.Size(75, 33);
            this.btnAgregarAsientos.TabIndex = 14;
            this.btnAgregarAsientos.Text = "Agregar";
            this.btnAgregarAsientos.UseVisualStyleBackColor = true;
            this.btnAgregarAsientos.Click += new System.EventHandler(this.btnAgregarAsientos_Click);
            // 
            // tabCtrlDatos
            // 
            this.tabCtrlDatos.Controls.Add(this.tabPagAsientos);
            this.tabCtrlDatos.Controls.Add(this.tabPagEmpleados);
            this.tabCtrlDatos.Controls.Add(this.tabPagEstadoAsientos);
            this.tabCtrlDatos.Controls.Add(this.tabPagEstadoEmpleados);
            this.tabCtrlDatos.Controls.Add(this.tabPagEstadoPago);
            this.tabCtrlDatos.Controls.Add(this.tabPagGenero);
            this.tabCtrlDatos.Controls.Add(this.tabPagSesiones);
            this.tabCtrlDatos.Controls.Add(this.tabPagSesionAsientos);
            this.tabCtrlDatos.Controls.Add(this.tabPagPeliculas);
            this.tabCtrlDatos.Controls.Add(this.tabPagPuestosTrabajo);
            this.tabCtrlDatos.Controls.Add(this.tabPagReseñas);
            this.tabCtrlDatos.Controls.Add(this.tabPagReservas);
            this.tabCtrlDatos.Controls.Add(this.tabPagSalas);
            this.tabCtrlDatos.Controls.Add(this.tabPagUsuarios);
            this.tabCtrlDatos.Controls.Add(this.tabPagCupones);
            this.tabCtrlDatos.Location = new System.Drawing.Point(11, 113);
            this.tabCtrlDatos.Name = "tabCtrlDatos";
            this.tabCtrlDatos.SelectedIndex = 0;
            this.tabCtrlDatos.Size = new System.Drawing.Size(1155, 540);
            this.tabCtrlDatos.TabIndex = 4;
            this.tabCtrlDatos.SelectedIndexChanged += new System.EventHandler(this.tabCtrlDatos_SelectedIndexChanged);
            // 
            // tabPagSesionAsientos
            // 
            this.tabPagSesionAsientos.Controls.Add(this.dgvSesionAsientos);
            this.tabPagSesionAsientos.Controls.Add(this.gbSesionAsientos);
            this.tabPagSesionAsientos.Location = new System.Drawing.Point(4, 25);
            this.tabPagSesionAsientos.Name = "tabPagSesionAsientos";
            this.tabPagSesionAsientos.Size = new System.Drawing.Size(1147, 511);
            this.tabPagSesionAsientos.TabIndex = 14;
            this.tabPagSesionAsientos.Text = "Asientos de las sesiones";
            this.tabPagSesionAsientos.UseVisualStyleBackColor = true;
            // 
            // dgvSesionAsientos
            // 
            this.dgvSesionAsientos.AllowUserToAddRows = false;
            this.dgvSesionAsientos.AllowUserToDeleteRows = false;
            this.dgvSesionAsientos.AutoGenerateColumns = false;
            this.dgvSesionAsientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSesionAsientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn13,
            this.idSesionDataGridViewTextBoxColumn1,
            this.idAsientoDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvSesionAsientos.DataSource = this.bsSesionAsientos;
            this.dgvSesionAsientos.Location = new System.Drawing.Point(17, 20);
            this.dgvSesionAsientos.Name = "dgvSesionAsientos";
            this.dgvSesionAsientos.ReadOnly = true;
            this.dgvSesionAsientos.RowHeadersWidth = 51;
            this.dgvSesionAsientos.RowTemplate.Height = 24;
            this.dgvSesionAsientos.Size = new System.Drawing.Size(737, 465);
            this.dgvSesionAsientos.TabIndex = 3;
            this.dgvSesionAsientos.SelectionChanged += new System.EventHandler(this.dgvSesionAsientos_SelectionChanged);
            // 
            // idDataGridViewTextBoxColumn13
            // 
            this.idDataGridViewTextBoxColumn13.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn13.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn13.Name = "idDataGridViewTextBoxColumn13";
            this.idDataGridViewTextBoxColumn13.ReadOnly = true;
            this.idDataGridViewTextBoxColumn13.Width = 125;
            // 
            // idSesionDataGridViewTextBoxColumn1
            // 
            this.idSesionDataGridViewTextBoxColumn1.DataPropertyName = "IdSesion";
            this.idSesionDataGridViewTextBoxColumn1.DataSource = this.bsSesiones;
            this.idSesionDataGridViewTextBoxColumn1.DisplayMember = "Id";
            this.idSesionDataGridViewTextBoxColumn1.HeaderText = "IdSesion";
            this.idSesionDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idSesionDataGridViewTextBoxColumn1.Name = "idSesionDataGridViewTextBoxColumn1";
            this.idSesionDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idSesionDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idSesionDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idSesionDataGridViewTextBoxColumn1.ValueMember = "Id";
            this.idSesionDataGridViewTextBoxColumn1.Width = 125;
            // 
            // idAsientoDataGridViewTextBoxColumn1
            // 
            this.idAsientoDataGridViewTextBoxColumn1.DataPropertyName = "IdAsiento";
            this.idAsientoDataGridViewTextBoxColumn1.DataSource = this.bsAsientos;
            this.idAsientoDataGridViewTextBoxColumn1.DisplayMember = "Id";
            this.idAsientoDataGridViewTextBoxColumn1.HeaderText = "IdAsiento";
            this.idAsientoDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idAsientoDataGridViewTextBoxColumn1.Name = "idAsientoDataGridViewTextBoxColumn1";
            this.idAsientoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idAsientoDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idAsientoDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idAsientoDataGridViewTextBoxColumn1.ValueMember = "Id";
            this.idAsientoDataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdEstado";
            this.dataGridViewTextBoxColumn2.DataSource = this.bsEstadoAsientos;
            this.dataGridViewTextBoxColumn2.DisplayMember = "Estado";
            this.dataGridViewTextBoxColumn2.HeaderText = "IdEstado";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "Id";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // bsSesionAsientos
            // 
            this.bsSesionAsientos.DataMember = "SesionAsientos";
            this.bsSesionAsientos.DataSource = this.dsCine1;
            // 
            // gbSesionAsientos
            // 
            this.gbSesionAsientos.Controls.Add(this.btnCancelarSesionAsientos);
            this.gbSesionAsientos.Controls.Add(this.btnAceptarSesionAsientos);
            this.gbSesionAsientos.Controls.Add(this.btnEliminarSesionAsientos);
            this.gbSesionAsientos.Controls.Add(this.btnEditarSesionAsientos);
            this.gbSesionAsientos.Controls.Add(this.btnAgregarSesionAsientos);
            this.gbSesionAsientos.Controls.Add(this.panCamposSesionAsientos);
            this.gbSesionAsientos.Location = new System.Drawing.Point(783, 21);
            this.gbSesionAsientos.Name = "gbSesionAsientos";
            this.gbSesionAsientos.Size = new System.Drawing.Size(341, 465);
            this.gbSesionAsientos.TabIndex = 2;
            this.gbSesionAsientos.TabStop = false;
            this.gbSesionAsientos.Text = "Opciones comunes";
            // 
            // btnCancelarSesionAsientos
            // 
            this.btnCancelarSesionAsientos.Image = global::CineApp.Properties.Resources.Cancelar;
            this.btnCancelarSesionAsientos.Location = new System.Drawing.Point(293, 408);
            this.btnCancelarSesionAsientos.Name = "btnCancelarSesionAsientos";
            this.btnCancelarSesionAsientos.Size = new System.Drawing.Size(32, 32);
            this.btnCancelarSesionAsientos.TabIndex = 51;
            this.btnCancelarSesionAsientos.UseVisualStyleBackColor = true;
            this.btnCancelarSesionAsientos.Click += new System.EventHandler(this.btnCancelarSesionAsientos_Click);
            // 
            // btnAceptarSesionAsientos
            // 
            this.btnAceptarSesionAsientos.Image = global::CineApp.Properties.Resources.Aceptar;
            this.btnAceptarSesionAsientos.Location = new System.Drawing.Point(254, 408);
            this.btnAceptarSesionAsientos.Name = "btnAceptarSesionAsientos";
            this.btnAceptarSesionAsientos.Size = new System.Drawing.Size(32, 32);
            this.btnAceptarSesionAsientos.TabIndex = 50;
            this.btnAceptarSesionAsientos.UseVisualStyleBackColor = true;
            this.btnAceptarSesionAsientos.Click += new System.EventHandler(this.btnAceptarSesionAsientos_Click);
            // 
            // btnEliminarSesionAsientos
            // 
            this.btnEliminarSesionAsientos.Location = new System.Drawing.Point(173, 408);
            this.btnEliminarSesionAsientos.Name = "btnEliminarSesionAsientos";
            this.btnEliminarSesionAsientos.Size = new System.Drawing.Size(75, 33);
            this.btnEliminarSesionAsientos.TabIndex = 49;
            this.btnEliminarSesionAsientos.Text = "Eliminar";
            this.btnEliminarSesionAsientos.UseVisualStyleBackColor = true;
            this.btnEliminarSesionAsientos.Click += new System.EventHandler(this.btnEliminarSesionAsientos_Click);
            // 
            // btnEditarSesionAsientos
            // 
            this.btnEditarSesionAsientos.Location = new System.Drawing.Point(92, 408);
            this.btnEditarSesionAsientos.Name = "btnEditarSesionAsientos";
            this.btnEditarSesionAsientos.Size = new System.Drawing.Size(75, 33);
            this.btnEditarSesionAsientos.TabIndex = 48;
            this.btnEditarSesionAsientos.Text = "Editar";
            this.btnEditarSesionAsientos.UseVisualStyleBackColor = true;
            this.btnEditarSesionAsientos.Click += new System.EventHandler(this.btnEditarSesionAsientos_Click);
            // 
            // btnAgregarSesionAsientos
            // 
            this.btnAgregarSesionAsientos.Location = new System.Drawing.Point(11, 408);
            this.btnAgregarSesionAsientos.Name = "btnAgregarSesionAsientos";
            this.btnAgregarSesionAsientos.Size = new System.Drawing.Size(75, 33);
            this.btnAgregarSesionAsientos.TabIndex = 47;
            this.btnAgregarSesionAsientos.Text = "Agregar";
            this.btnAgregarSesionAsientos.UseVisualStyleBackColor = true;
            this.btnAgregarSesionAsientos.Click += new System.EventHandler(this.btnAgregarSesionAsientos_Click);
            // 
            // panCamposSesionAsientos
            // 
            this.panCamposSesionAsientos.Controls.Add(this.cmbSesionesSesionAsientos);
            this.panCamposSesionAsientos.Controls.Add(this.lblSesionesSesionAsientos);
            this.panCamposSesionAsientos.Controls.Add(this.cmbAsientosSesionAsientos);
            this.panCamposSesionAsientos.Controls.Add(this.lblAsientosSesionAsientos);
            this.panCamposSesionAsientos.Controls.Add(this.cmbEstadoAsientosSesionAsientos);
            this.panCamposSesionAsientos.Controls.Add(this.lblEstadoAsientosSesionAsientos);
            this.panCamposSesionAsientos.Enabled = false;
            this.panCamposSesionAsientos.Location = new System.Drawing.Point(6, 21);
            this.panCamposSesionAsientos.Name = "panCamposSesionAsientos";
            this.panCamposSesionAsientos.Size = new System.Drawing.Size(319, 170);
            this.panCamposSesionAsientos.TabIndex = 19;
            // 
            // cmbSesionesSesionAsientos
            // 
            this.cmbSesionesSesionAsientos.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsSesionAsientos, "IdSesion", true));
            this.cmbSesionesSesionAsientos.FormattingEnabled = true;
            this.cmbSesionesSesionAsientos.Location = new System.Drawing.Point(6, 29);
            this.cmbSesionesSesionAsientos.Name = "cmbSesionesSesionAsientos";
            this.cmbSesionesSesionAsientos.Size = new System.Drawing.Size(310, 24);
            this.cmbSesionesSesionAsientos.TabIndex = 20;
            // 
            // lblSesionesSesionAsientos
            // 
            this.lblSesionesSesionAsientos.AutoSize = true;
            this.lblSesionesSesionAsientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSesionesSesionAsientos.Location = new System.Drawing.Point(3, 10);
            this.lblSesionesSesionAsientos.Name = "lblSesionesSesionAsientos";
            this.lblSesionesSesionAsientos.Size = new System.Drawing.Size(59, 16);
            this.lblSesionesSesionAsientos.TabIndex = 19;
            this.lblSesionesSesionAsientos.Text = "Sesión:";
            // 
            // cmbAsientosSesionAsientos
            // 
            this.cmbAsientosSesionAsientos.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsSesionAsientos, "IdAsiento", true));
            this.cmbAsientosSesionAsientos.FormattingEnabled = true;
            this.cmbAsientosSesionAsientos.Location = new System.Drawing.Point(6, 82);
            this.cmbAsientosSesionAsientos.Name = "cmbAsientosSesionAsientos";
            this.cmbAsientosSesionAsientos.Size = new System.Drawing.Size(310, 24);
            this.cmbAsientosSesionAsientos.TabIndex = 18;
            // 
            // lblAsientosSesionAsientos
            // 
            this.lblAsientosSesionAsientos.AutoSize = true;
            this.lblAsientosSesionAsientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsientosSesionAsientos.Location = new System.Drawing.Point(3, 63);
            this.lblAsientosSesionAsientos.Name = "lblAsientosSesionAsientos";
            this.lblAsientosSesionAsientos.Size = new System.Drawing.Size(63, 16);
            this.lblAsientosSesionAsientos.TabIndex = 0;
            this.lblAsientosSesionAsientos.Text = "Asiento:";
            // 
            // cmbEstadoAsientosSesionAsientos
            // 
            this.cmbEstadoAsientosSesionAsientos.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsSesionAsientos, "IdEstado", true));
            this.cmbEstadoAsientosSesionAsientos.FormattingEnabled = true;
            this.cmbEstadoAsientosSesionAsientos.Location = new System.Drawing.Point(7, 134);
            this.cmbEstadoAsientosSesionAsientos.Name = "cmbEstadoAsientosSesionAsientos";
            this.cmbEstadoAsientosSesionAsientos.Size = new System.Drawing.Size(310, 24);
            this.cmbEstadoAsientosSesionAsientos.TabIndex = 17;
            // 
            // lblEstadoAsientosSesionAsientos
            // 
            this.lblEstadoAsientosSesionAsientos.AutoSize = true;
            this.lblEstadoAsientosSesionAsientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoAsientosSesionAsientos.Location = new System.Drawing.Point(4, 114);
            this.lblEstadoAsientosSesionAsientos.Name = "lblEstadoAsientosSesionAsientos";
            this.lblEstadoAsientosSesionAsientos.Size = new System.Drawing.Size(141, 16);
            this.lblEstadoAsientosSesionAsientos.TabIndex = 2;
            this.lblEstadoAsientosSesionAsientos.Text = "Estado del asiento:";
            // 
            // tabPagCupones
            // 
            this.tabPagCupones.Controls.Add(this.dgvCupones);
            this.tabPagCupones.Controls.Add(this.gbCupones);
            this.tabPagCupones.Location = new System.Drawing.Point(4, 25);
            this.tabPagCupones.Name = "tabPagCupones";
            this.tabPagCupones.Size = new System.Drawing.Size(1147, 511);
            this.tabPagCupones.TabIndex = 15;
            this.tabPagCupones.Text = "Cupones";
            this.tabPagCupones.UseVisualStyleBackColor = true;
            // 
            // dgvCupones
            // 
            this.dgvCupones.AllowUserToAddRows = false;
            this.dgvCupones.AllowUserToDeleteRows = false;
            this.dgvCupones.AutoGenerateColumns = false;
            this.dgvCupones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCupones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn14,
            this.descripcionDataGridViewTextBoxColumn,
            this.imagenDataGridViewTextBoxColumn,
            this.fechaInicioDataGridViewTextBoxColumn,
            this.fechaCaducidadDataGridViewTextBoxColumn,
            this.costePuntosDataGridViewTextBoxColumn});
            this.dgvCupones.DataSource = this.bsCupones;
            this.dgvCupones.Location = new System.Drawing.Point(20, 23);
            this.dgvCupones.Name = "dgvCupones";
            this.dgvCupones.ReadOnly = true;
            this.dgvCupones.RowHeadersWidth = 51;
            this.dgvCupones.RowTemplate.Height = 24;
            this.dgvCupones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCupones.Size = new System.Drawing.Size(737, 465);
            this.dgvCupones.TabIndex = 3;
            this.dgvCupones.SelectionChanged += new System.EventHandler(this.dgvCupones_SelectionChanged);
            // 
            // idDataGridViewTextBoxColumn14
            // 
            this.idDataGridViewTextBoxColumn14.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn14.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn14.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn14.Name = "idDataGridViewTextBoxColumn14";
            this.idDataGridViewTextBoxColumn14.ReadOnly = true;
            this.idDataGridViewTextBoxColumn14.Width = 125;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcionDataGridViewTextBoxColumn.Width = 125;
            // 
            // imagenDataGridViewTextBoxColumn
            // 
            this.imagenDataGridViewTextBoxColumn.DataPropertyName = "Imagen";
            this.imagenDataGridViewTextBoxColumn.HeaderText = "Imagen";
            this.imagenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.imagenDataGridViewTextBoxColumn.Name = "imagenDataGridViewTextBoxColumn";
            this.imagenDataGridViewTextBoxColumn.ReadOnly = true;
            this.imagenDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaInicioDataGridViewTextBoxColumn
            // 
            this.fechaInicioDataGridViewTextBoxColumn.DataPropertyName = "FechaInicio";
            this.fechaInicioDataGridViewTextBoxColumn.HeaderText = "FechaInicio";
            this.fechaInicioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaInicioDataGridViewTextBoxColumn.Name = "fechaInicioDataGridViewTextBoxColumn";
            this.fechaInicioDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaInicioDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaCaducidadDataGridViewTextBoxColumn
            // 
            this.fechaCaducidadDataGridViewTextBoxColumn.DataPropertyName = "FechaCaducidad";
            this.fechaCaducidadDataGridViewTextBoxColumn.HeaderText = "FechaCaducidad";
            this.fechaCaducidadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaCaducidadDataGridViewTextBoxColumn.Name = "fechaCaducidadDataGridViewTextBoxColumn";
            this.fechaCaducidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaCaducidadDataGridViewTextBoxColumn.Width = 125;
            // 
            // costePuntosDataGridViewTextBoxColumn
            // 
            this.costePuntosDataGridViewTextBoxColumn.DataPropertyName = "CostePuntos";
            this.costePuntosDataGridViewTextBoxColumn.HeaderText = "CostePuntos";
            this.costePuntosDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.costePuntosDataGridViewTextBoxColumn.Name = "costePuntosDataGridViewTextBoxColumn";
            this.costePuntosDataGridViewTextBoxColumn.ReadOnly = true;
            this.costePuntosDataGridViewTextBoxColumn.Width = 125;
            // 
            // gbCupones
            // 
            this.gbCupones.Controls.Add(this.btnCancelarCupones);
            this.gbCupones.Controls.Add(this.panCamposCupones);
            this.gbCupones.Controls.Add(this.btnAceptarCupones);
            this.gbCupones.Controls.Add(this.btnEliminarCupones);
            this.gbCupones.Controls.Add(this.btnEditarCupones);
            this.gbCupones.Controls.Add(this.btnAgregarCupones);
            this.gbCupones.Location = new System.Drawing.Point(785, 23);
            this.gbCupones.Name = "gbCupones";
            this.gbCupones.Size = new System.Drawing.Size(341, 465);
            this.gbCupones.TabIndex = 2;
            this.gbCupones.TabStop = false;
            this.gbCupones.Text = "Opciones comunes";
            // 
            // btnCancelarCupones
            // 
            this.btnCancelarCupones.Image = global::CineApp.Properties.Resources.Cancelar;
            this.btnCancelarCupones.Location = new System.Drawing.Point(294, 416);
            this.btnCancelarCupones.Name = "btnCancelarCupones";
            this.btnCancelarCupones.Size = new System.Drawing.Size(32, 32);
            this.btnCancelarCupones.TabIndex = 20;
            this.btnCancelarCupones.UseVisualStyleBackColor = true;
            this.btnCancelarCupones.Click += new System.EventHandler(this.btnCancelarCupones_Click);
            // 
            // panCamposCupones
            // 
            this.panCamposCupones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panCamposCupones.Controls.Add(this.txtFechaCaducidadCupones);
            this.panCamposCupones.Controls.Add(this.lblFechaCaducidadCupones);
            this.panCamposCupones.Controls.Add(this.lblCosteCupones);
            this.panCamposCupones.Controls.Add(this.txtCostePuntos);
            this.panCamposCupones.Controls.Add(this.txtDescripcionCupones);
            this.panCamposCupones.Controls.Add(this.lblDescripcionCupones);
            this.panCamposCupones.Controls.Add(this.lblImagenCupones);
            this.panCamposCupones.Controls.Add(this.txtImagenCupones);
            this.panCamposCupones.Controls.Add(this.lblFechaInicioCupones);
            this.panCamposCupones.Controls.Add(this.txtFechaInicioCupones);
            this.panCamposCupones.Enabled = false;
            this.panCamposCupones.Location = new System.Drawing.Point(6, 21);
            this.panCamposCupones.Name = "panCamposCupones";
            this.panCamposCupones.Size = new System.Drawing.Size(323, 268);
            this.panCamposCupones.TabIndex = 5;
            // 
            // txtFechaCaducidadCupones
            // 
            this.txtFechaCaducidadCupones.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCupones, "FechaCaducidad", true));
            this.txtFechaCaducidadCupones.Location = new System.Drawing.Point(6, 181);
            this.txtFechaCaducidadCupones.Name = "txtFechaCaducidadCupones";
            this.txtFechaCaducidadCupones.Size = new System.Drawing.Size(314, 22);
            this.txtFechaCaducidadCupones.TabIndex = 12;
            // 
            // lblFechaCaducidadCupones
            // 
            this.lblFechaCaducidadCupones.AutoSize = true;
            this.lblFechaCaducidadCupones.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCaducidadCupones.Location = new System.Drawing.Point(3, 162);
            this.lblFechaCaducidadCupones.Name = "lblFechaCaducidadCupones";
            this.lblFechaCaducidadCupones.Size = new System.Drawing.Size(153, 16);
            this.lblFechaCaducidadCupones.TabIndex = 7;
            this.lblFechaCaducidadCupones.Text = "Fecha de caducidad.";
            // 
            // lblCosteCupones
            // 
            this.lblCosteCupones.AutoSize = true;
            this.lblCosteCupones.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosteCupones.Location = new System.Drawing.Point(3, 212);
            this.lblCosteCupones.Name = "lblCosteCupones";
            this.lblCosteCupones.Size = new System.Drawing.Size(123, 16);
            this.lblCosteCupones.TabIndex = 8;
            this.lblCosteCupones.Text = "Coste de puntos:";
            // 
            // txtCostePuntos
            // 
            this.txtCostePuntos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCupones, "CostePuntos", true));
            this.txtCostePuntos.Location = new System.Drawing.Point(6, 231);
            this.txtCostePuntos.Name = "txtCostePuntos";
            this.txtCostePuntos.Size = new System.Drawing.Size(314, 22);
            this.txtCostePuntos.TabIndex = 9;
            // 
            // txtDescripcionCupones
            // 
            this.txtDescripcionCupones.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCupones, "Descripcion", true));
            this.txtDescripcionCupones.Location = new System.Drawing.Point(6, 25);
            this.txtDescripcionCupones.Name = "txtDescripcionCupones";
            this.txtDescripcionCupones.Size = new System.Drawing.Size(314, 22);
            this.txtDescripcionCupones.TabIndex = 6;
            // 
            // lblDescripcionCupones
            // 
            this.lblDescripcionCupones.AutoSize = true;
            this.lblDescripcionCupones.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionCupones.Location = new System.Drawing.Point(3, 6);
            this.lblDescripcionCupones.Name = "lblDescripcionCupones";
            this.lblDescripcionCupones.Size = new System.Drawing.Size(94, 16);
            this.lblDescripcionCupones.TabIndex = 0;
            this.lblDescripcionCupones.Text = "Descripción:";
            // 
            // lblImagenCupones
            // 
            this.lblImagenCupones.AutoSize = true;
            this.lblImagenCupones.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagenCupones.Location = new System.Drawing.Point(3, 56);
            this.lblImagenCupones.Name = "lblImagenCupones";
            this.lblImagenCupones.Size = new System.Drawing.Size(125, 16);
            this.lblImagenCupones.TabIndex = 2;
            this.lblImagenCupones.Text = "Url de la imagen:";
            // 
            // txtImagenCupones
            // 
            this.txtImagenCupones.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCupones, "Imagen", true));
            this.txtImagenCupones.Location = new System.Drawing.Point(6, 75);
            this.txtImagenCupones.Name = "txtImagenCupones";
            this.txtImagenCupones.Size = new System.Drawing.Size(314, 22);
            this.txtImagenCupones.TabIndex = 3;
            // 
            // lblFechaInicioCupones
            // 
            this.lblFechaInicioCupones.AutoSize = true;
            this.lblFechaInicioCupones.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicioCupones.Location = new System.Drawing.Point(3, 107);
            this.lblFechaInicioCupones.Name = "lblFechaInicioCupones";
            this.lblFechaInicioCupones.Size = new System.Drawing.Size(117, 16);
            this.lblFechaInicioCupones.TabIndex = 4;
            this.lblFechaInicioCupones.Text = "Fecha de inicio:";
            // 
            // txtFechaInicioCupones
            // 
            this.txtFechaInicioCupones.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCupones, "FechaInicio", true));
            this.txtFechaInicioCupones.Location = new System.Drawing.Point(6, 126);
            this.txtFechaInicioCupones.Name = "txtFechaInicioCupones";
            this.txtFechaInicioCupones.Size = new System.Drawing.Size(314, 22);
            this.txtFechaInicioCupones.TabIndex = 5;
            // 
            // btnAceptarCupones
            // 
            this.btnAceptarCupones.Image = global::CineApp.Properties.Resources.Aceptar;
            this.btnAceptarCupones.Location = new System.Drawing.Point(255, 416);
            this.btnAceptarCupones.Name = "btnAceptarCupones";
            this.btnAceptarCupones.Size = new System.Drawing.Size(32, 32);
            this.btnAceptarCupones.TabIndex = 19;
            this.btnAceptarCupones.UseVisualStyleBackColor = true;
            this.btnAceptarCupones.Click += new System.EventHandler(this.btnAceptarCupones_Click);
            // 
            // btnEliminarCupones
            // 
            this.btnEliminarCupones.Location = new System.Drawing.Point(174, 416);
            this.btnEliminarCupones.Name = "btnEliminarCupones";
            this.btnEliminarCupones.Size = new System.Drawing.Size(75, 33);
            this.btnEliminarCupones.TabIndex = 16;
            this.btnEliminarCupones.Text = "Eliminar";
            this.btnEliminarCupones.UseVisualStyleBackColor = true;
            this.btnEliminarCupones.Click += new System.EventHandler(this.btnEliminarCupones_Click);
            // 
            // btnEditarCupones
            // 
            this.btnEditarCupones.Location = new System.Drawing.Point(93, 416);
            this.btnEditarCupones.Name = "btnEditarCupones";
            this.btnEditarCupones.Size = new System.Drawing.Size(75, 33);
            this.btnEditarCupones.TabIndex = 15;
            this.btnEditarCupones.Text = "Editar";
            this.btnEditarCupones.UseVisualStyleBackColor = true;
            this.btnEditarCupones.Click += new System.EventHandler(this.btnEditarCupones_Click);
            // 
            // btnAgregarCupones
            // 
            this.btnAgregarCupones.Location = new System.Drawing.Point(12, 416);
            this.btnAgregarCupones.Name = "btnAgregarCupones";
            this.btnAgregarCupones.Size = new System.Drawing.Size(75, 33);
            this.btnAgregarCupones.TabIndex = 14;
            this.btnAgregarCupones.Text = "Agregar";
            this.btnAgregarCupones.UseVisualStyleBackColor = true;
            this.btnAgregarCupones.Click += new System.EventHandler(this.btnAgregarCupones_Click);
            // 
            // FAdministracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 703);
            this.Controls.Add(this.tabCtrlDatos);
            this.Controls.Add(this.lblUsuarioLog);
            this.Name = "FAdministracion";
            this.Text = "Menú Principal (Administración)";
            this.Load += new System.EventHandler(this.FAdministracion_Load);
            this.tabPagUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCine1)).EndInit();
            this.gbUsuarios.ResumeLayout(false);
            this.panCamposUsuarios.ResumeLayout(false);
            this.panCamposUsuarios.PerformLayout();
            this.tabPagSalas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSalas)).EndInit();
            this.gbSalas.ResumeLayout(false);
            this.panCamposSalas.ResumeLayout(false);
            this.panCamposSalas.PerformLayout();
            this.tabPagReservas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAsientos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEstadoPago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSesiones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCupones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsReservas)).EndInit();
            this.gbReservas.ResumeLayout(false);
            this.panCamposReservas.ResumeLayout(false);
            this.panCamposReservas.PerformLayout();
            this.tabPagReseñas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReseñas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPeliculas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsReseñas)).EndInit();
            this.gbReseñas.ResumeLayout(false);
            this.panCamposReseñas.ResumeLayout(false);
            this.panCamposReseñas.PerformLayout();
            this.tabPagPuestosTrabajo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuestosTrabajo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPuestosTrabajo)).EndInit();
            this.gbPuestosTrabajo.ResumeLayout(false);
            this.panCamposPuestosTrabajo.ResumeLayout(false);
            this.panCamposPuestosTrabajo.PerformLayout();
            this.tabPagPeliculas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).EndInit();
            this.gbPeliculas.ResumeLayout(false);
            this.panCamposPeliculas.ResumeLayout(false);
            this.panCamposPeliculas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsGenero)).EndInit();
            this.tabPagSesiones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSesiones)).EndInit();
            this.gbSesiones.ResumeLayout(false);
            this.panCamposSesiones.ResumeLayout(false);
            this.panCamposSesiones.PerformLayout();
            this.tabPagGenero.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenero)).EndInit();
            this.gbGenero.ResumeLayout(false);
            this.panCamposGenero.ResumeLayout(false);
            this.panCamposGenero.PerformLayout();
            this.tabPagEstadoPago.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadoPago)).EndInit();
            this.gbEstadoPago.ResumeLayout(false);
            this.panCamposEstadoPago.ResumeLayout(false);
            this.panCamposEstadoPago.PerformLayout();
            this.tabPagEstadoEmpleados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadoEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEstadoEmpleados)).EndInit();
            this.gbEstadoEmpleados.ResumeLayout(false);
            this.panCamposEstadoEmpleados.ResumeLayout(false);
            this.panCamposEstadoEmpleados.PerformLayout();
            this.tabPagEstadoAsientos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadoAsientos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEstadoAsientos)).EndInit();
            this.gbEstadoAsientos.ResumeLayout(false);
            this.panCamposEstadoAsientos.ResumeLayout(false);
            this.panCamposEstadoAsientos.PerformLayout();
            this.tabPagEmpleados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEmpleados)).EndInit();
            this.gbEmpleados.ResumeLayout(false);
            this.panCamposEmpleados.ResumeLayout(false);
            this.panCamposEmpleados.PerformLayout();
            this.tabPagAsientos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsientos)).EndInit();
            this.gbAsientos.ResumeLayout(false);
            this.panCamposAsientos.ResumeLayout(false);
            this.panCamposAsientos.PerformLayout();
            this.tabCtrlDatos.ResumeLayout(false);
            this.tabPagSesionAsientos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSesionAsientos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSesionAsientos)).EndInit();
            this.gbSesionAsientos.ResumeLayout(false);
            this.panCamposSesionAsientos.ResumeLayout(false);
            this.panCamposSesionAsientos.PerformLayout();
            this.tabPagCupones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCupones)).EndInit();
            this.gbCupones.ResumeLayout(false);
            this.panCamposCupones.ResumeLayout(false);
            this.panCamposCupones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuarioLog;
        //private System.Windows.Forms.DataGridViewTextBoxColumn idEstadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabPagUsuarios;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.GroupBox gbUsuarios;
        private System.Windows.Forms.Button btnCancelarUsuarios;
        private System.Windows.Forms.Button btnAceptarUsuarios;
        private System.Windows.Forms.Button btnEliminarUsuarios;
        private System.Windows.Forms.Button btnEditarUsuarios;
        private System.Windows.Forms.Button btnAgregarUsuarios;
        private System.Windows.Forms.Panel panCamposUsuarios;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label lblCorreoUsuario;
        private System.Windows.Forms.TextBox txtCorreoUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TabPage tabPagSalas;
        private System.Windows.Forms.DataGridView dgvSalas;
        private System.Windows.Forms.GroupBox gbSalas;
        private System.Windows.Forms.Panel panCamposSalas;
        private System.Windows.Forms.TextBox txtCapacidad;
        private System.Windows.Forms.Label lblNombreSala;
        private System.Windows.Forms.TextBox txtNombreSala;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.Button btnCancelarSalas;
        private System.Windows.Forms.Button btnAceptarSalas;
        private System.Windows.Forms.Button btnEliminarSalas;
        private System.Windows.Forms.Button btnEditarSalas;
        private System.Windows.Forms.Button btnAgregarSalas;
        private System.Windows.Forms.TabPage tabPagReservas;
        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.GroupBox gbReservas;
        private System.Windows.Forms.Button btnCancelarReservas;
        private System.Windows.Forms.Button btnAceptarReservas;
        private System.Windows.Forms.Button btnEliminarReservas;
        private System.Windows.Forms.Button btnEditarReservas;
        private System.Windows.Forms.Button btnAgregarReservas;
        private System.Windows.Forms.Panel panCamposReservas;
        private System.Windows.Forms.TextBox txtFechaReservas;
        private System.Windows.Forms.ComboBox cmbEstadosPagoReservas;
        private System.Windows.Forms.Label lblFechaReservas;
        private System.Windows.Forms.Label lblEstadoReserva;
        private System.Windows.Forms.ComboBox cmbSesionesReservas;
        private System.Windows.Forms.Label lblNombreUsuarioReserva;
        private System.Windows.Forms.ComboBox cmbAsientosReservas;
        private System.Windows.Forms.Label lblHorariosReserva;
        private System.Windows.Forms.Label lblAsientosReservas;
        private System.Windows.Forms.ComboBox cmbUsuariosReservas;
        private System.Windows.Forms.TabPage tabPagReseñas;
        private System.Windows.Forms.DataGridView dgvReseñas;
        private System.Windows.Forms.GroupBox gbReseñas;
        private System.Windows.Forms.Button btnCancelasReseñas;
        private System.Windows.Forms.Button btnAceptarReseñas;
        private System.Windows.Forms.Button btnEliminarReseñas;
        private System.Windows.Forms.Button btnEditarReseñas;
        private System.Windows.Forms.Button btnAgregarReseñas;
        private System.Windows.Forms.Panel panCamposReseñas;
        private System.Windows.Forms.ComboBox cmbUsuariosReseñas;
        private System.Windows.Forms.ComboBox cmbPeliculasReseñas;
        private System.Windows.Forms.Label lblTituloPeliculaReseñas;
        private System.Windows.Forms.TextBox txtCalificacion;
        private System.Windows.Forms.Label lblComentario;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label lblCalificacion;
        private System.Windows.Forms.Label lblNombreUsuarioReseñas;
        private System.Windows.Forms.TabPage tabPagPuestosTrabajo;
        private System.Windows.Forms.DataGridView dgvPuestosTrabajo;
        private System.Windows.Forms.GroupBox gbPuestosTrabajo;
        private System.Windows.Forms.Button btnCancelarPuestosTrabajo;
        private System.Windows.Forms.Button btnAceptarPuestosTrabajo;
        private System.Windows.Forms.Button btnEliminarPuestosTrabajo;
        private System.Windows.Forms.Button btnEditarPuestosTrabajo;
        private System.Windows.Forms.Button btnAgregarPuestosTrabajo;
        private System.Windows.Forms.Panel panCamposPuestosTrabajo;
        private System.Windows.Forms.TextBox txtPuestoTrabajo;
        private System.Windows.Forms.Label lblPuestoTrabajo;
        private System.Windows.Forms.TabPage tabPagPeliculas;
        private System.Windows.Forms.DataGridView dgvPeliculas;
        private System.Windows.Forms.GroupBox gbPeliculas;
        private System.Windows.Forms.Button btnCancelarPeliculas;
        private System.Windows.Forms.Button btnAceptarPeliculas;
        private System.Windows.Forms.Button btnEliminarPeliculas;
        private System.Windows.Forms.Button btnEditarPeliculas;
        private System.Windows.Forms.Button btnAgregarPeliculas;
        private System.Windows.Forms.Panel panCamposPeliculas;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtPortada;
        private System.Windows.Forms.ComboBox cmbGeneroPeliculas;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblGeneroPelicula;
        private System.Windows.Forms.Label lblSinopsis;
        private System.Windows.Forms.TextBox txtSinposis;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.Label lblPortada;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.TextBox txtCalificacionPelicula;
        private System.Windows.Forms.Label lblCalificacionPelicula;
        private System.Windows.Forms.TabPage tabPagSesiones;
        private System.Windows.Forms.DataGridView dgvSesiones;
        private System.Windows.Forms.GroupBox gbSesiones;
        private System.Windows.Forms.Button btnCancelarSesiones;
        private System.Windows.Forms.Button btnAceptarSesiones;
        private System.Windows.Forms.Button btnEliminarSesiones;
        private System.Windows.Forms.Button btnEditarSesiones;
        private System.Windows.Forms.Button btnAgregarSesiones;
        private System.Windows.Forms.Panel panCamposSesiones;
        private System.Windows.Forms.TextBox txtHoraInicio;
        private System.Windows.Forms.ComboBox cmbPeliculasSesiones;
        private System.Windows.Forms.Label lblTituloPeliculaSesiones;
        private System.Windows.Forms.ComboBox cmbSalasSesiones;
        private System.Windows.Forms.Label lblNombreSalaSesiones;
        private System.Windows.Forms.Label lblHoraInicio;
        private System.Windows.Forms.TabPage tabPagGenero;
        private System.Windows.Forms.DataGridView dgvGenero;
        private System.Windows.Forms.GroupBox gbGenero;
        private System.Windows.Forms.Button btnCancelarGenero;
        private System.Windows.Forms.Button btnAceptarGenero;
        private System.Windows.Forms.Button btnEliminarGenero;
        private System.Windows.Forms.Button btnEditarGenero;
        private System.Windows.Forms.Button btnAgregarGenero;
        private System.Windows.Forms.Panel panCamposGenero;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.TabPage tabPagEstadoPago;
        private System.Windows.Forms.DataGridView dgvEstadoPago;
        private System.Windows.Forms.GroupBox gbEstadoPago;
        private System.Windows.Forms.Button btnCancelarEstadoPago;
        private System.Windows.Forms.Button btnAceptarEstadoPago;
        private System.Windows.Forms.Button btnEliminarEstadoPago;
        private System.Windows.Forms.Button btnEditarEstadoPago;
        private System.Windows.Forms.Button btnAgregarEstadoPago;
        private System.Windows.Forms.Panel panCamposEstadoPago;
        private System.Windows.Forms.TextBox txtEstadoPago;
        private System.Windows.Forms.Label lblEstadoPago;
        private System.Windows.Forms.TabPage tabPagEstadoEmpleados;
        private System.Windows.Forms.DataGridView dgvEstadoEmpleados;
        private System.Windows.Forms.GroupBox gbEstadoEmpleados;
        private System.Windows.Forms.Button btnCancelarEstadoEmpleados;
        private System.Windows.Forms.Button btnAceptarEstadoEmpleados;
        private System.Windows.Forms.Button btnEliminarEstadoEmpleados;
        private System.Windows.Forms.Button btnEditarEstadoEmpleados;
        private System.Windows.Forms.Button btnAgregarEstadoEmpleados;
        private System.Windows.Forms.Panel panCamposEstadoEmpleados;
        private System.Windows.Forms.TextBox txtEstadoEmpleados;
        private System.Windows.Forms.Label lblEstadoEmpleados;
        private System.Windows.Forms.TabPage tabPagEstadoAsientos;
        private System.Windows.Forms.DataGridView dgvEstadoAsientos;
        private System.Windows.Forms.GroupBox gbEstadoAsientos;
        private System.Windows.Forms.Panel panCamposEstadoAsientos;
        private System.Windows.Forms.TextBox txtEstadoAsientos;
        private System.Windows.Forms.Label lblEstadoAsientos;
        private System.Windows.Forms.Button btnCancelarEstadoAsientos;
        private System.Windows.Forms.Button btnAceptarEstadoAsientos;
        private System.Windows.Forms.Button btnEliminarEstadoAsientos;
        private System.Windows.Forms.Button btnEditarEstadoAsientos;
        private System.Windows.Forms.Button btnAgregarEstadoAsientos;
        private System.Windows.Forms.TabPage tabPagEmpleados;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.GroupBox gbEmpleados;
        private System.Windows.Forms.Panel panCamposEmpleados;
        private System.Windows.Forms.ComboBox cmbUsuariosEmpleados;
        private System.Windows.Forms.ComboBox cmbEstadoEmpleadosEmpleados;
        private System.Windows.Forms.ComboBox cmbPuestoTrabajoEmpleados;
        private System.Windows.Forms.Label lblNombreUsuarioEmpleados;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblEstadoEmpleadosEmpleados;
        private System.Windows.Forms.Label lblPuestoTrabajoEmpleados;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnCancelarEmpleados;
        private System.Windows.Forms.Button btnAceptarEmpleados;
        private System.Windows.Forms.Button btnEliminarEmpleados;
        private System.Windows.Forms.Button btnEditarEmpleados;
        private System.Windows.Forms.Button btnAgregarEmpleados;
        private System.Windows.Forms.TabPage tabPagAsientos;
        private System.Windows.Forms.DataGridView dgvAsientos;
        private System.Windows.Forms.GroupBox gbAsientos;
        private System.Windows.Forms.Button btnCancelarAsientos;
        private System.Windows.Forms.Panel panCamposAsientos;
        private System.Windows.Forms.Label lblSalaEmpleados;
        private System.Windows.Forms.Label lblNumFila;
        private System.Windows.Forms.ComboBox cmbSalaAsientos;
        private System.Windows.Forms.TextBox txtNumFila;
        private System.Windows.Forms.Label lblNumColumna;
        private System.Windows.Forms.TextBox txtNumColumna;
        private System.Windows.Forms.Button btnAceptarAsientos;
        private System.Windows.Forms.Button btnEliminarAsientos;
        private System.Windows.Forms.Button btnEditarAsientos;
        private System.Windows.Forms.Button btnAgregarAsientos;
        private System.Windows.Forms.TabControl tabCtrlDatos;
        private System.Windows.Forms.BindingSource bsAsientos;
        private System.Windows.Forms.BindingSource bsSalas;
        private System.Windows.Forms.BindingSource bsPuestosTrabajo;
        private System.Windows.Forms.BindingSource bsEstadoEmpleados;
        private System.Windows.Forms.BindingSource bsUsuarios;
        private System.Windows.Forms.BindingSource bsEmpleados;
        private System.Windows.Forms.BindingSource bsEstadoAsientos;
        private System.Windows.Forms.BindingSource bsEstadoPago;
        private System.Windows.Forms.BindingSource bsGenero;
        private System.Windows.Forms.BindingSource bsSesiones;
        private System.Windows.Forms.TextBox txtFechaSesiones;
        private System.Windows.Forms.Label lblFechaSesiones;
        private System.Windows.Forms.BindingSource bsPeliculas;
        private System.Windows.Forms.BindingSource bsReseñas;
        private System.Windows.Forms.BindingSource bsReservas;
        private System.Windows.Forms.TabPage tabPagSesionAsientos;
        private System.Windows.Forms.DataGridView dgvSesionAsientos;
        private System.Windows.Forms.GroupBox gbSesionAsientos;
        private System.Windows.Forms.Button btnCancelarSesionAsientos;
        private System.Windows.Forms.Button btnAceptarSesionAsientos;
        private System.Windows.Forms.Button btnEliminarSesionAsientos;
        private System.Windows.Forms.Button btnEditarSesionAsientos;
        private System.Windows.Forms.Button btnAgregarSesionAsientos;
        private System.Windows.Forms.Panel panCamposSesionAsientos;
        private System.Windows.Forms.ComboBox cmbSesionesSesionAsientos;
        private System.Windows.Forms.Label lblSesionesSesionAsientos;
        private System.Windows.Forms.ComboBox cmbAsientosSesionAsientos;
        private System.Windows.Forms.Label lblAsientosSesionAsientos;
        private System.Windows.Forms.ComboBox cmbEstadoAsientosSesionAsientos;
        private System.Windows.Forms.Label lblEstadoAsientosSesionAsientos;
        private System.Windows.Forms.BindingSource bsSesionAsientos;
        //private System.Windows.Forms.DataGridViewTextBoxColumn calificaciónDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsCupones;
        private CAD.DSCine dsCine1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn contraseñaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn puntosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cmbCuponReserva;
        private System.Windows.Forms.Label lblCuponReserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn puestoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGeneroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinopsisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calificacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn portadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn generoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idSalaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numFilaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numColumnaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idPeliculaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idSalaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idPuestoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn idUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewComboBoxColumn idSesionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn idAsientoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewComboBoxColumn idUsuarioDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn idAsientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaReservaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idEstadoPagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idSesionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idCuponDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewComboBoxColumn idPeliculaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn idUsuarioDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn comentarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn calificacionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.TabPage tabPagCupones;
        private System.Windows.Forms.DataGridView dgvCupones;
        private System.Windows.Forms.GroupBox gbCupones;
        private System.Windows.Forms.Button btnCancelarCupones;
        private System.Windows.Forms.Panel panCamposCupones;
        private System.Windows.Forms.Label lblDescripcionCupones;
        private System.Windows.Forms.Label lblImagenCupones;
        private System.Windows.Forms.TextBox txtImagenCupones;
        private System.Windows.Forms.Label lblFechaInicioCupones;
        private System.Windows.Forms.TextBox txtFechaInicioCupones;
        private System.Windows.Forms.Button btnAceptarCupones;
        private System.Windows.Forms.Button btnEliminarCupones;
        private System.Windows.Forms.Button btnEditarCupones;
        private System.Windows.Forms.Button btnAgregarCupones;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imagenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCaducidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costePuntosDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtFechaCaducidadCupones;
        private System.Windows.Forms.Label lblFechaCaducidadCupones;
        private System.Windows.Forms.Label lblCosteCupones;
        private System.Windows.Forms.TextBox txtCostePuntos;
        private System.Windows.Forms.TextBox txtDescripcionCupones;
        private System.Windows.Forms.TextBox txtPuntos;
        private System.Windows.Forms.Label lblPuntos;
    }
}