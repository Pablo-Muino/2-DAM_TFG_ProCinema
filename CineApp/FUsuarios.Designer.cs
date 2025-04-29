namespace CineApp
{
    partial class FUsuarios
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
            this.tabCtrlMenu = new System.Windows.Forms.TabControl();
            this.tabPagCartelera = new System.Windows.Forms.TabPage();
            this.panCartelera = new System.Windows.Forms.Panel();
            this.tblCartelera = new System.Windows.Forms.TableLayoutPanel();
            this.grpBoxComunes = new System.Windows.Forms.GroupBox();
            this.btnReservar = new System.Windows.Forms.Button();
            this.panCamposAsientos = new System.Windows.Forms.Panel();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.txtCalificacion = new System.Windows.Forms.TextBox();
            this.lblSinopsis = new System.Windows.Forms.Label();
            this.txtSinopsis = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblNumColumna = new System.Windows.Forms.Label();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.lblCalificacion = new System.Windows.Forms.Label();
            this.tabPagCupones = new System.Windows.Forms.TabPage();
            this.btnCanjear = new System.Windows.Forms.Button();
            this.panCupones = new System.Windows.Forms.Panel();
            this.tblCupones = new System.Windows.Forms.TableLayoutPanel();
            this.lblConseguirPuntos2 = new System.Windows.Forms.Label();
            this.lblConseguirPuntos1 = new System.Windows.Forms.Label();
            this.lblPuntos = new System.Windows.Forms.Label();
            this.lblPuntosObtenidos = new System.Windows.Forms.Label();
            this.tabPagReseñas = new System.Windows.Forms.TabPage();
            this.grpBoxCrearReseña = new System.Windows.Forms.GroupBox();
            this.cmbPeliculaReseña = new System.Windows.Forms.ComboBox();
            this.bsPeliculas = new System.Windows.Forms.BindingSource(this.components);
            this.dsCine1 = new CAD.DSCine();
            this.txtCalificacionReseña = new System.Windows.Forms.TextBox();
            this.lblComentarioReseña = new System.Windows.Forms.Label();
            this.txtComentarioReseña = new System.Windows.Forms.TextBox();
            this.lblPeliculaReseña = new System.Windows.Forms.Label();
            this.lblCalificacionReseña = new System.Windows.Forms.Label();
            this.btnPublicarReseña = new System.Windows.Forms.Button();
            this.btnCancelarFiltro = new System.Windows.Forms.Button();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.fLayPanReseñas = new System.Windows.Forms.FlowLayoutPanel();
            this.bsGenero = new System.Windows.Forms.BindingSource(this.components);
            this.tabCtrlMenu.SuspendLayout();
            this.tabPagCartelera.SuspendLayout();
            this.panCartelera.SuspendLayout();
            this.grpBoxComunes.SuspendLayout();
            this.panCamposAsientos.SuspendLayout();
            this.tabPagCupones.SuspendLayout();
            this.panCupones.SuspendLayout();
            this.tabPagReseñas.SuspendLayout();
            this.grpBoxCrearReseña.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsPeliculas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCine1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGenero)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuarioLog
            // 
            this.lblUsuarioLog.AutoSize = true;
            this.lblUsuarioLog.Location = new System.Drawing.Point(11, 669);
            this.lblUsuarioLog.Name = "lblUsuarioLog";
            this.lblUsuarioLog.Size = new System.Drawing.Size(119, 16);
            this.lblUsuarioLog.TabIndex = 0;
            this.lblUsuarioLog.Text = "Usuario loggeado:";
            // 
            // tabCtrlMenu
            // 
            this.tabCtrlMenu.Controls.Add(this.tabPagCartelera);
            this.tabCtrlMenu.Controls.Add(this.tabPagCupones);
            this.tabCtrlMenu.Controls.Add(this.tabPagReseñas);
            this.tabCtrlMenu.Location = new System.Drawing.Point(11, 113);
            this.tabCtrlMenu.Name = "tabCtrlMenu";
            this.tabCtrlMenu.SelectedIndex = 0;
            this.tabCtrlMenu.Size = new System.Drawing.Size(1155, 540);
            this.tabCtrlMenu.TabIndex = 5;
            this.tabCtrlMenu.SelectedIndexChanged += new System.EventHandler(this.tabCtrlDatos_SelectedIndexChanged);
            // 
            // tabPagCartelera
            // 
            this.tabPagCartelera.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPagCartelera.Controls.Add(this.panCartelera);
            this.tabPagCartelera.Controls.Add(this.grpBoxComunes);
            this.tabPagCartelera.Location = new System.Drawing.Point(4, 25);
            this.tabPagCartelera.Name = "tabPagCartelera";
            this.tabPagCartelera.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPagCartelera.Size = new System.Drawing.Size(1147, 511);
            this.tabPagCartelera.TabIndex = 0;
            this.tabPagCartelera.Text = "Cartelera";
            this.tabPagCartelera.UseVisualStyleBackColor = true;
            // 
            // panCartelera
            // 
            this.panCartelera.AutoScroll = true;
            this.panCartelera.Controls.Add(this.tblCartelera);
            this.panCartelera.Location = new System.Drawing.Point(18, 21);
            this.panCartelera.Name = "panCartelera";
            this.panCartelera.Size = new System.Drawing.Size(717, 474);
            this.panCartelera.TabIndex = 6;
            // 
            // tblCartelera
            // 
            this.tblCartelera.AutoSize = true;
            this.tblCartelera.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblCartelera.ColumnCount = 4;
            this.tblCartelera.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCartelera.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCartelera.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tblCartelera.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tblCartelera.Location = new System.Drawing.Point(7, 3);
            this.tblCartelera.Name = "tblCartelera";
            this.tblCartelera.RowCount = 1;
            this.tblCartelera.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCartelera.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCartelera.Size = new System.Drawing.Size(707, 468);
            this.tblCartelera.TabIndex = 1;
            // 
            // grpBoxComunes
            // 
            this.grpBoxComunes.Controls.Add(this.btnReservar);
            this.grpBoxComunes.Controls.Add(this.panCamposAsientos);
            this.grpBoxComunes.Location = new System.Drawing.Point(751, 21);
            this.grpBoxComunes.Name = "grpBoxComunes";
            this.grpBoxComunes.Size = new System.Drawing.Size(374, 480);
            this.grpBoxComunes.TabIndex = 0;
            this.grpBoxComunes.TabStop = false;
            this.grpBoxComunes.Text = "Más información de la película";
            // 
            // btnReservar
            // 
            this.btnReservar.Location = new System.Drawing.Point(232, 441);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(136, 33);
            this.btnReservar.TabIndex = 14;
            this.btnReservar.Text = "Reservar entrada";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // panCamposAsientos
            // 
            this.panCamposAsientos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panCamposAsientos.Controls.Add(this.txtGenero);
            this.panCamposAsientos.Controls.Add(this.txtCalificacion);
            this.panCamposAsientos.Controls.Add(this.lblSinopsis);
            this.panCamposAsientos.Controls.Add(this.txtSinopsis);
            this.panCamposAsientos.Controls.Add(this.lblTitulo);
            this.panCamposAsientos.Controls.Add(this.lblGenero);
            this.panCamposAsientos.Controls.Add(this.txtTitulo);
            this.panCamposAsientos.Controls.Add(this.lblNumColumna);
            this.panCamposAsientos.Controls.Add(this.txtDuracion);
            this.panCamposAsientos.Controls.Add(this.lblCalificacion);
            this.panCamposAsientos.Location = new System.Drawing.Point(6, 21);
            this.panCamposAsientos.Name = "panCamposAsientos";
            this.panCamposAsientos.Size = new System.Drawing.Size(362, 412);
            this.panCamposAsientos.TabIndex = 5;
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(6, 75);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.ReadOnly = true;
            this.txtGenero.Size = new System.Drawing.Size(353, 22);
            this.txtGenero.TabIndex = 22;
            // 
            // txtCalificacion
            // 
            this.txtCalificacion.Location = new System.Drawing.Point(6, 177);
            this.txtCalificacion.Name = "txtCalificacion";
            this.txtCalificacion.ReadOnly = true;
            this.txtCalificacion.Size = new System.Drawing.Size(353, 22);
            this.txtCalificacion.TabIndex = 21;
            // 
            // lblSinopsis
            // 
            this.lblSinopsis.AutoSize = true;
            this.lblSinopsis.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinopsis.Location = new System.Drawing.Point(3, 210);
            this.lblSinopsis.Name = "lblSinopsis";
            this.lblSinopsis.Size = new System.Drawing.Size(71, 16);
            this.lblSinopsis.TabIndex = 19;
            this.lblSinopsis.Text = "Sinopsis:";
            // 
            // txtSinopsis
            // 
            this.txtSinopsis.Location = new System.Drawing.Point(6, 229);
            this.txtSinopsis.Multiline = true;
            this.txtSinopsis.Name = "txtSinopsis";
            this.txtSinopsis.ReadOnly = true;
            this.txtSinopsis.Size = new System.Drawing.Size(353, 169);
            this.txtSinopsis.TabIndex = 20;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(3, 6);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(50, 16);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Titulo:";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(3, 55);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(62, 16);
            this.lblGenero.TabIndex = 2;
            this.lblGenero.Text = "Género:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(6, 25);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.ReadOnly = true;
            this.txtTitulo.Size = new System.Drawing.Size(353, 22);
            this.txtTitulo.TabIndex = 3;
            // 
            // lblNumColumna
            // 
            this.lblNumColumna.AutoSize = true;
            this.lblNumColumna.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumColumna.Location = new System.Drawing.Point(3, 107);
            this.lblNumColumna.Name = "lblNumColumna";
            this.lblNumColumna.Size = new System.Drawing.Size(73, 16);
            this.lblNumColumna.TabIndex = 4;
            this.lblNumColumna.Text = "Duración:";
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(6, 126);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.ReadOnly = true;
            this.txtDuracion.Size = new System.Drawing.Size(353, 22);
            this.txtDuracion.TabIndex = 5;
            // 
            // lblCalificacion
            // 
            this.lblCalificacion.AutoSize = true;
            this.lblCalificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalificacion.Location = new System.Drawing.Point(3, 158);
            this.lblCalificacion.Name = "lblCalificacion";
            this.lblCalificacion.Size = new System.Drawing.Size(92, 16);
            this.lblCalificacion.TabIndex = 6;
            this.lblCalificacion.Text = "Calificación:";
            // 
            // tabPagCupones
            // 
            this.tabPagCupones.Controls.Add(this.btnCanjear);
            this.tabPagCupones.Controls.Add(this.panCupones);
            this.tabPagCupones.Controls.Add(this.lblConseguirPuntos2);
            this.tabPagCupones.Controls.Add(this.lblConseguirPuntos1);
            this.tabPagCupones.Controls.Add(this.lblPuntos);
            this.tabPagCupones.Controls.Add(this.lblPuntosObtenidos);
            this.tabPagCupones.Location = new System.Drawing.Point(4, 27);
            this.tabPagCupones.Name = "tabPagCupones";
            this.tabPagCupones.Size = new System.Drawing.Size(1147, 509);
            this.tabPagCupones.TabIndex = 2;
            this.tabPagCupones.Text = "Cupones";
            this.tabPagCupones.UseVisualStyleBackColor = true;
            // 
            // btnCanjear
            // 
            this.btnCanjear.Location = new System.Drawing.Point(878, 462);
            this.btnCanjear.Name = "btnCanjear";
            this.btnCanjear.Size = new System.Drawing.Size(214, 35);
            this.btnCanjear.TabIndex = 8;
            this.btnCanjear.Text = "Canjear cupón seleccionado";
            this.btnCanjear.UseVisualStyleBackColor = true;
            this.btnCanjear.Click += new System.EventHandler(this.btnCanjear_Click);
            // 
            // panCupones
            // 
            this.panCupones.AutoScroll = true;
            this.panCupones.Controls.Add(this.tblCupones);
            this.panCupones.Location = new System.Drawing.Point(38, 71);
            this.panCupones.Name = "panCupones";
            this.panCupones.Size = new System.Drawing.Size(1054, 385);
            this.panCupones.TabIndex = 7;
            // 
            // tblCupones
            // 
            this.tblCupones.AutoSize = true;
            this.tblCupones.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblCupones.ColumnCount = 4;
            this.tblCupones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCupones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCupones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tblCupones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tblCupones.Location = new System.Drawing.Point(7, 3);
            this.tblCupones.Name = "tblCupones";
            this.tblCupones.RowCount = 1;
            this.tblCupones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCupones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCupones.Size = new System.Drawing.Size(1047, 375);
            this.tblCupones.TabIndex = 1;
            // 
            // lblConseguirPuntos2
            // 
            this.lblConseguirPuntos2.AutoSize = true;
            this.lblConseguirPuntos2.Location = new System.Drawing.Point(224, 41);
            this.lblConseguirPuntos2.Name = "lblConseguirPuntos2";
            this.lblConseguirPuntos2.Size = new System.Drawing.Size(266, 16);
            this.lblConseguirPuntos2.TabIndex = 3;
            this.lblConseguirPuntos2.Text = "Por cada reserva se conseguirán 50 puntos";
            // 
            // lblConseguirPuntos1
            // 
            this.lblConseguirPuntos1.AutoSize = true;
            this.lblConseguirPuntos1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConseguirPuntos1.Location = new System.Drawing.Point(35, 41);
            this.lblConseguirPuntos1.Name = "lblConseguirPuntos1";
            this.lblConseguirPuntos1.Size = new System.Drawing.Size(172, 16);
            this.lblConseguirPuntos1.TabIndex = 2;
            this.lblConseguirPuntos1.Text = "¿Como consigo puntos?";
            // 
            // lblPuntos
            // 
            this.lblPuntos.AutoSize = true;
            this.lblPuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntos.Location = new System.Drawing.Point(994, 36);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(98, 20);
            this.lblPuntos.TabIndex = 1;
            this.lblPuntos.Text = "(PUNTOS)";
            // 
            // lblPuntosObtenidos
            // 
            this.lblPuntosObtenidos.AutoSize = true;
            this.lblPuntosObtenidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntosObtenidos.Location = new System.Drawing.Point(835, 41);
            this.lblPuntosObtenidos.Name = "lblPuntosObtenidos";
            this.lblPuntosObtenidos.Size = new System.Drawing.Size(133, 16);
            this.lblPuntosObtenidos.TabIndex = 0;
            this.lblPuntosObtenidos.Text = "Puntos Obtenidos:";
            // 
            // tabPagReseñas
            // 
            this.tabPagReseñas.Controls.Add(this.grpBoxCrearReseña);
            this.tabPagReseñas.Controls.Add(this.btnCancelarFiltro);
            this.tabPagReseñas.Controls.Add(this.btnFiltro);
            this.tabPagReseñas.Controls.Add(this.cmbFiltro);
            this.tabPagReseñas.Controls.Add(this.lblFiltro);
            this.tabPagReseñas.Controls.Add(this.fLayPanReseñas);
            this.tabPagReseñas.Location = new System.Drawing.Point(4, 25);
            this.tabPagReseñas.Name = "tabPagReseñas";
            this.tabPagReseñas.Size = new System.Drawing.Size(1147, 511);
            this.tabPagReseñas.TabIndex = 1;
            this.tabPagReseñas.Text = "Reseñas";
            this.tabPagReseñas.UseVisualStyleBackColor = true;
            // 
            // grpBoxCrearReseña
            // 
            this.grpBoxCrearReseña.Controls.Add(this.cmbPeliculaReseña);
            this.grpBoxCrearReseña.Controls.Add(this.txtCalificacionReseña);
            this.grpBoxCrearReseña.Controls.Add(this.lblComentarioReseña);
            this.grpBoxCrearReseña.Controls.Add(this.txtComentarioReseña);
            this.grpBoxCrearReseña.Controls.Add(this.lblPeliculaReseña);
            this.grpBoxCrearReseña.Controls.Add(this.lblCalificacionReseña);
            this.grpBoxCrearReseña.Controls.Add(this.btnPublicarReseña);
            this.grpBoxCrearReseña.Location = new System.Drawing.Point(22, 151);
            this.grpBoxCrearReseña.Name = "grpBoxCrearReseña";
            this.grpBoxCrearReseña.Size = new System.Drawing.Size(389, 341);
            this.grpBoxCrearReseña.TabIndex = 5;
            this.grpBoxCrearReseña.TabStop = false;
            this.grpBoxCrearReseña.Text = "Deja tu reseña";
            // 
            // cmbPeliculaReseña
            // 
            this.cmbPeliculaReseña.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsPeliculas, "Titulo", true));
            this.cmbPeliculaReseña.FormattingEnabled = true;
            this.cmbPeliculaReseña.Location = new System.Drawing.Point(6, 49);
            this.cmbPeliculaReseña.Name = "cmbPeliculaReseña";
            this.cmbPeliculaReseña.Size = new System.Drawing.Size(367, 24);
            this.cmbPeliculaReseña.TabIndex = 29;
            // 
            // bsPeliculas
            // 
            this.bsPeliculas.DataMember = "Peliculas";
            this.bsPeliculas.DataSource = this.dsCine1;
            // 
            // dsCine1
            // 
            this.dsCine1.DataSetName = "DSCine";
            this.dsCine1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtCalificacionReseña
            // 
            this.txtCalificacionReseña.Location = new System.Drawing.Point(6, 100);
            this.txtCalificacionReseña.Name = "txtCalificacionReseña";
            this.txtCalificacionReseña.Size = new System.Drawing.Size(367, 22);
            this.txtCalificacionReseña.TabIndex = 28;
            // 
            // lblComentarioReseña
            // 
            this.lblComentarioReseña.AutoSize = true;
            this.lblComentarioReseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComentarioReseña.Location = new System.Drawing.Point(3, 134);
            this.lblComentarioReseña.Name = "lblComentarioReseña";
            this.lblComentarioReseña.Size = new System.Drawing.Size(90, 16);
            this.lblComentarioReseña.TabIndex = 26;
            this.lblComentarioReseña.Text = "Comentario:";
            // 
            // txtComentarioReseña
            // 
            this.txtComentarioReseña.Location = new System.Drawing.Point(6, 153);
            this.txtComentarioReseña.Multiline = true;
            this.txtComentarioReseña.Name = "txtComentarioReseña";
            this.txtComentarioReseña.Size = new System.Drawing.Size(367, 131);
            this.txtComentarioReseña.TabIndex = 27;
            // 
            // lblPeliculaReseña
            // 
            this.lblPeliculaReseña.AutoSize = true;
            this.lblPeliculaReseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeliculaReseña.Location = new System.Drawing.Point(3, 26);
            this.lblPeliculaReseña.Name = "lblPeliculaReseña";
            this.lblPeliculaReseña.Size = new System.Drawing.Size(67, 16);
            this.lblPeliculaReseña.TabIndex = 23;
            this.lblPeliculaReseña.Text = "Película:";
            // 
            // lblCalificacionReseña
            // 
            this.lblCalificacionReseña.AutoSize = true;
            this.lblCalificacionReseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalificacionReseña.Location = new System.Drawing.Point(3, 81);
            this.lblCalificacionReseña.Name = "lblCalificacionReseña";
            this.lblCalificacionReseña.Size = new System.Drawing.Size(135, 16);
            this.lblCalificacionReseña.TabIndex = 24;
            this.lblCalificacionReseña.Text = "Calificación (1 - 5):";
            // 
            // btnPublicarReseña
            // 
            this.btnPublicarReseña.Location = new System.Drawing.Point(237, 302);
            this.btnPublicarReseña.Name = "btnPublicarReseña";
            this.btnPublicarReseña.Size = new System.Drawing.Size(136, 33);
            this.btnPublicarReseña.TabIndex = 14;
            this.btnPublicarReseña.Text = "Publicar reseña";
            this.btnPublicarReseña.UseVisualStyleBackColor = true;
            this.btnPublicarReseña.Click += new System.EventHandler(this.btnPublicarReseña_Click);
            // 
            // btnCancelarFiltro
            // 
            this.btnCancelarFiltro.Location = new System.Drawing.Point(295, 100);
            this.btnCancelarFiltro.Name = "btnCancelarFiltro";
            this.btnCancelarFiltro.Size = new System.Drawing.Size(115, 31);
            this.btnCancelarFiltro.TabIndex = 4;
            this.btnCancelarFiltro.Text = "Cancelar filtro";
            this.btnCancelarFiltro.UseVisualStyleBackColor = true;
            this.btnCancelarFiltro.Click += new System.EventHandler(this.btnCancelarFiltro_Click);
            // 
            // btnFiltro
            // 
            this.btnFiltro.Location = new System.Drawing.Point(22, 100);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(70, 31);
            this.btnFiltro.TabIndex = 3;
            this.btnFiltro.Text = "Filtrar";
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsPeliculas, "Titulo", true));
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Location = new System.Drawing.Point(22, 57);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(388, 24);
            this.cmbFiltro.TabIndex = 2;
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(19, 29);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(116, 16);
            this.lblFiltro.TabIndex = 1;
            this.lblFiltro.Text = "Filtrar por película:";
            // 
            // fLayPanReseñas
            // 
            this.fLayPanReseñas.AutoScroll = true;
            this.fLayPanReseñas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fLayPanReseñas.Location = new System.Drawing.Point(451, 29);
            this.fLayPanReseñas.Name = "fLayPanReseñas";
            this.fLayPanReseñas.Size = new System.Drawing.Size(669, 463);
            this.fLayPanReseñas.TabIndex = 0;
            // 
            // bsGenero
            // 
            this.bsGenero.DataMember = "Genero";
            this.bsGenero.DataSource = this.dsCine1;
            // 
            // FUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 703);
            this.Controls.Add(this.tabCtrlMenu);
            this.Controls.Add(this.lblUsuarioLog);
            this.Name = "FUsuarios";
            this.Text = "Menú Principal (Usuarios)";
            this.Load += new System.EventHandler(this.FUsuarios_Load);
            this.tabCtrlMenu.ResumeLayout(false);
            this.tabPagCartelera.ResumeLayout(false);
            this.panCartelera.ResumeLayout(false);
            this.panCartelera.PerformLayout();
            this.grpBoxComunes.ResumeLayout(false);
            this.panCamposAsientos.ResumeLayout(false);
            this.panCamposAsientos.PerformLayout();
            this.tabPagCupones.ResumeLayout(false);
            this.tabPagCupones.PerformLayout();
            this.panCupones.ResumeLayout(false);
            this.panCupones.PerformLayout();
            this.tabPagReseñas.ResumeLayout(false);
            this.tabPagReseñas.PerformLayout();
            this.grpBoxCrearReseña.ResumeLayout(false);
            this.grpBoxCrearReseña.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsPeliculas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCine1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGenero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuarioLog;
        private System.Windows.Forms.TabControl tabCtrlMenu;
        private System.Windows.Forms.TabPage tabPagCartelera;
        private System.Windows.Forms.GroupBox grpBoxComunes;
        private System.Windows.Forms.Panel panCamposAsientos;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblNumColumna;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.Label lblCalificacion;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.TextBox txtCalificacion;
        private System.Windows.Forms.Label lblSinopsis;
        private System.Windows.Forms.TextBox txtSinopsis;
        private CAD.DSCine dsCine1;
        private System.Windows.Forms.BindingSource bsGenero;
        private System.Windows.Forms.TableLayoutPanel tblCartelera;
        private System.Windows.Forms.Panel panCartelera;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.TabPage tabPagReseñas;
        private System.Windows.Forms.FlowLayoutPanel fLayPanReseñas;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.BindingSource bsPeliculas;
        private System.Windows.Forms.Button btnCancelarFiltro;
        private System.Windows.Forms.GroupBox grpBoxCrearReseña;
        private System.Windows.Forms.Button btnPublicarReseña;
        private System.Windows.Forms.TextBox txtCalificacionReseña;
        private System.Windows.Forms.Label lblComentarioReseña;
        private System.Windows.Forms.TextBox txtComentarioReseña;
        private System.Windows.Forms.Label lblPeliculaReseña;
        private System.Windows.Forms.Label lblCalificacionReseña;
        private System.Windows.Forms.ComboBox cmbPeliculaReseña;
        private System.Windows.Forms.TabPage tabPagCupones;
        private System.Windows.Forms.Label lblPuntosObtenidos;
        private System.Windows.Forms.Label lblConseguirPuntos1;
        private System.Windows.Forms.Label lblPuntos;
        private System.Windows.Forms.Label lblConseguirPuntos2;
        private System.Windows.Forms.Panel panCupones;
        private System.Windows.Forms.TableLayoutPanel tblCupones;
        private System.Windows.Forms.Button btnCanjear;
    }
}