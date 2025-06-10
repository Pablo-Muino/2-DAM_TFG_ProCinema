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
            this.panLogo = new System.Windows.Forms.Panel();
            this.lblEncabezado1 = new System.Windows.Forms.Label();
            this.lblEncabezado2 = new System.Windows.Forms.Label();
            this.lblUsuarioLog = new System.Windows.Forms.Label();
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
            // tabCtrlMenu
            // 
            this.tabCtrlMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabCtrlMenu.Controls.Add(this.tabPagCartelera);
            this.tabCtrlMenu.Controls.Add(this.tabPagCupones);
            this.tabCtrlMenu.Controls.Add(this.tabPagReseñas);
            this.tabCtrlMenu.Location = new System.Drawing.Point(11, 140);
            this.tabCtrlMenu.Name = "tabCtrlMenu";
            this.tabCtrlMenu.SelectedIndex = 0;
            this.tabCtrlMenu.Size = new System.Drawing.Size(1155, 540);
            this.tabCtrlMenu.TabIndex = 5;
            this.tabCtrlMenu.SelectedIndexChanged += new System.EventHandler(this.tabCtrlDatos_SelectedIndexChanged);
            // 
            // tabPagCartelera
            // 
            this.tabPagCartelera.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tabPagCartelera.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPagCartelera.Controls.Add(this.panCartelera);
            this.tabPagCartelera.Controls.Add(this.grpBoxComunes);
            this.tabPagCartelera.Location = new System.Drawing.Point(4, 25);
            this.tabPagCartelera.Name = "tabPagCartelera";
            this.tabPagCartelera.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagCartelera.Size = new System.Drawing.Size(1147, 511);
            this.tabPagCartelera.TabIndex = 0;
            this.tabPagCartelera.Text = "Cartelera";
            // 
            // panCartelera
            // 
            this.panCartelera.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panCartelera.AutoScroll = true;
            this.panCartelera.Controls.Add(this.tblCartelera);
            this.panCartelera.Location = new System.Drawing.Point(18, 21);
            this.panCartelera.Name = "panCartelera";
            this.panCartelera.Size = new System.Drawing.Size(717, 474);
            this.panCartelera.TabIndex = 6;
            // 
            // tblCartelera
            // 
            this.tblCartelera.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblCartelera.AutoScroll = true;
            this.tblCartelera.AutoSize = true;
            this.tblCartelera.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblCartelera.ColumnCount = 4;
            this.tblCartelera.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCartelera.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCartelera.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tblCartelera.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tblCartelera.Location = new System.Drawing.Point(7, 3);
            this.tblCartelera.Name = "tblCartelera";
            this.tblCartelera.RowCount = 1;
            this.tblCartelera.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCartelera.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCartelera.Size = new System.Drawing.Size(706, 468);
            this.tblCartelera.TabIndex = 1;
            // 
            // grpBoxComunes
            // 
            this.grpBoxComunes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxComunes.Controls.Add(this.btnReservar);
            this.grpBoxComunes.Controls.Add(this.panCamposAsientos);
            this.grpBoxComunes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxComunes.Location = new System.Drawing.Point(751, 21);
            this.grpBoxComunes.Name = "grpBoxComunes";
            this.grpBoxComunes.Size = new System.Drawing.Size(374, 480);
            this.grpBoxComunes.TabIndex = 0;
            this.grpBoxComunes.TabStop = false;
            this.grpBoxComunes.Text = "Más información de la película";
            // 
            // btnReservar
            // 
            this.btnReservar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReservar.BackColor = System.Drawing.Color.Firebrick;
            this.btnReservar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservar.ForeColor = System.Drawing.Color.White;
            this.btnReservar.Location = new System.Drawing.Point(189, 431);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(179, 43);
            this.btnReservar.TabIndex = 14;
            this.btnReservar.Text = "Reservar entrada";
            this.btnReservar.UseVisualStyleBackColor = false;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // panCamposAsientos
            // 
            this.panCamposAsientos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.panCamposAsientos.Size = new System.Drawing.Size(362, 392);
            this.panCamposAsientos.TabIndex = 5;
            // 
            // txtGenero
            // 
            this.txtGenero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenero.Location = new System.Drawing.Point(6, 75);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.ReadOnly = true;
            this.txtGenero.Size = new System.Drawing.Size(353, 22);
            this.txtGenero.TabIndex = 22;
            // 
            // txtCalificacion
            // 
            this.txtCalificacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCalificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalificacion.Location = new System.Drawing.Point(6, 177);
            this.txtCalificacion.Name = "txtCalificacion";
            this.txtCalificacion.ReadOnly = true;
            this.txtCalificacion.Size = new System.Drawing.Size(353, 22);
            this.txtCalificacion.TabIndex = 21;
            // 
            // lblSinopsis
            // 
            this.lblSinopsis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.txtSinopsis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSinopsis.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSinopsis.Location = new System.Drawing.Point(6, 229);
            this.txtSinopsis.Multiline = true;
            this.txtSinopsis.Name = "txtSinopsis";
            this.txtSinopsis.ReadOnly = true;
            this.txtSinopsis.Size = new System.Drawing.Size(353, 160);
            this.txtSinopsis.TabIndex = 20;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.lblGenero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.txtTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(6, 25);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.ReadOnly = true;
            this.txtTitulo.Size = new System.Drawing.Size(353, 22);
            this.txtTitulo.TabIndex = 3;
            // 
            // lblNumColumna
            // 
            this.lblNumColumna.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.txtDuracion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDuracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuracion.Location = new System.Drawing.Point(6, 126);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.ReadOnly = true;
            this.txtDuracion.Size = new System.Drawing.Size(353, 22);
            this.txtDuracion.TabIndex = 5;
            // 
            // lblCalificacion
            // 
            this.lblCalificacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.tabPagCupones.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tabPagCupones.Controls.Add(this.btnCanjear);
            this.tabPagCupones.Controls.Add(this.panCupones);
            this.tabPagCupones.Controls.Add(this.lblConseguirPuntos2);
            this.tabPagCupones.Controls.Add(this.lblConseguirPuntos1);
            this.tabPagCupones.Controls.Add(this.lblPuntos);
            this.tabPagCupones.Controls.Add(this.lblPuntosObtenidos);
            this.tabPagCupones.Location = new System.Drawing.Point(4, 25);
            this.tabPagCupones.Name = "tabPagCupones";
            this.tabPagCupones.Size = new System.Drawing.Size(1147, 511);
            this.tabPagCupones.TabIndex = 2;
            this.tabPagCupones.Text = "Cupones";
            // 
            // btnCanjear
            // 
            this.btnCanjear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCanjear.BackColor = System.Drawing.Color.Firebrick;
            this.btnCanjear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCanjear.ForeColor = System.Drawing.Color.White;
            this.btnCanjear.Location = new System.Drawing.Point(782, 448);
            this.btnCanjear.Name = "btnCanjear";
            this.btnCanjear.Size = new System.Drawing.Size(310, 49);
            this.btnCanjear.TabIndex = 8;
            this.btnCanjear.Text = "Canjear cupón seleccionado";
            this.btnCanjear.UseVisualStyleBackColor = false;
            this.btnCanjear.Click += new System.EventHandler(this.btnCanjear_Click);
            // 
            // panCupones
            // 
            this.panCupones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panCupones.AutoScroll = true;
            this.panCupones.Controls.Add(this.tblCupones);
            this.panCupones.Location = new System.Drawing.Point(38, 71);
            this.panCupones.Name = "panCupones";
            this.panCupones.Size = new System.Drawing.Size(1054, 371);
            this.panCupones.TabIndex = 7;
            // 
            // tblCupones
            // 
            this.tblCupones.AutoScroll = true;
            this.tblCupones.AutoSize = true;
            this.tblCupones.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblCupones.ColumnCount = 4;
            this.tblCupones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCupones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCupones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tblCupones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tblCupones.Location = new System.Drawing.Point(7, 3);
            this.tblCupones.Name = "tblCupones";
            this.tblCupones.RowCount = 1;
            this.tblCupones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCupones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCupones.Size = new System.Drawing.Size(1046, 361);
            this.tblCupones.TabIndex = 1;
            // 
            // lblConseguirPuntos2
            // 
            this.lblConseguirPuntos2.AutoSize = true;
            this.lblConseguirPuntos2.Location = new System.Drawing.Point(250, 40);
            this.lblConseguirPuntos2.Name = "lblConseguirPuntos2";
            this.lblConseguirPuntos2.Size = new System.Drawing.Size(266, 16);
            this.lblConseguirPuntos2.TabIndex = 3;
            this.lblConseguirPuntos2.Text = "Por cada reserva se conseguirán 50 puntos";
            // 
            // lblConseguirPuntos1
            // 
            this.lblConseguirPuntos1.AutoSize = true;
            this.lblConseguirPuntos1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConseguirPuntos1.Location = new System.Drawing.Point(35, 38);
            this.lblConseguirPuntos1.Name = "lblConseguirPuntos1";
            this.lblConseguirPuntos1.Size = new System.Drawing.Size(193, 18);
            this.lblConseguirPuntos1.TabIndex = 2;
            this.lblConseguirPuntos1.Text = "¿Como consigo puntos?";
            // 
            // lblPuntos
            // 
            this.lblPuntos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPuntos.AutoSize = true;
            this.lblPuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntos.ForeColor = System.Drawing.Color.Black;
            this.lblPuntos.Location = new System.Drawing.Point(994, 36);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(98, 20);
            this.lblPuntos.TabIndex = 1;
            this.lblPuntos.Text = "(PUNTOS)";
            // 
            // lblPuntosObtenidos
            // 
            this.lblPuntosObtenidos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPuntosObtenidos.AutoSize = true;
            this.lblPuntosObtenidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntosObtenidos.Location = new System.Drawing.Point(830, 37);
            this.lblPuntosObtenidos.Name = "lblPuntosObtenidos";
            this.lblPuntosObtenidos.Size = new System.Drawing.Size(148, 18);
            this.lblPuntosObtenidos.TabIndex = 0;
            this.lblPuntosObtenidos.Text = "Puntos Obtenidos:";
            // 
            // tabPagReseñas
            // 
            this.tabPagReseñas.BackColor = System.Drawing.SystemColors.ActiveBorder;
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
            // 
            // grpBoxCrearReseña
            // 
            this.grpBoxCrearReseña.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpBoxCrearReseña.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.grpBoxCrearReseña.Controls.Add(this.cmbPeliculaReseña);
            this.grpBoxCrearReseña.Controls.Add(this.txtCalificacionReseña);
            this.grpBoxCrearReseña.Controls.Add(this.lblComentarioReseña);
            this.grpBoxCrearReseña.Controls.Add(this.txtComentarioReseña);
            this.grpBoxCrearReseña.Controls.Add(this.lblPeliculaReseña);
            this.grpBoxCrearReseña.Controls.Add(this.lblCalificacionReseña);
            this.grpBoxCrearReseña.Controls.Add(this.btnPublicarReseña);
            this.grpBoxCrearReseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxCrearReseña.ForeColor = System.Drawing.Color.Black;
            this.grpBoxCrearReseña.Location = new System.Drawing.Point(22, 151);
            this.grpBoxCrearReseña.Name = "grpBoxCrearReseña";
            this.grpBoxCrearReseña.Size = new System.Drawing.Size(389, 341);
            this.grpBoxCrearReseña.TabIndex = 5;
            this.grpBoxCrearReseña.TabStop = false;
            this.grpBoxCrearReseña.Text = "Deja tu reseña";
            // 
            // cmbPeliculaReseña
            // 
            this.cmbPeliculaReseña.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbPeliculaReseña.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsPeliculas, "Titulo", true));
            this.cmbPeliculaReseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.txtCalificacionReseña.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCalificacionReseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalificacionReseña.Location = new System.Drawing.Point(6, 100);
            this.txtCalificacionReseña.Name = "txtCalificacionReseña";
            this.txtCalificacionReseña.Size = new System.Drawing.Size(367, 22);
            this.txtCalificacionReseña.TabIndex = 28;
            // 
            // lblComentarioReseña
            // 
            this.lblComentarioReseña.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
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
            this.txtComentarioReseña.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtComentarioReseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComentarioReseña.Location = new System.Drawing.Point(6, 153);
            this.txtComentarioReseña.Multiline = true;
            this.txtComentarioReseña.Name = "txtComentarioReseña";
            this.txtComentarioReseña.Size = new System.Drawing.Size(367, 131);
            this.txtComentarioReseña.TabIndex = 27;
            // 
            // lblPeliculaReseña
            // 
            this.lblPeliculaReseña.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
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
            this.lblCalificacionReseña.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
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
            this.btnPublicarReseña.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPublicarReseña.BackColor = System.Drawing.Color.Firebrick;
            this.btnPublicarReseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPublicarReseña.ForeColor = System.Drawing.Color.White;
            this.btnPublicarReseña.Location = new System.Drawing.Point(216, 290);
            this.btnPublicarReseña.Name = "btnPublicarReseña";
            this.btnPublicarReseña.Size = new System.Drawing.Size(157, 45);
            this.btnPublicarReseña.TabIndex = 14;
            this.btnPublicarReseña.Text = "Publicar reseña";
            this.btnPublicarReseña.UseVisualStyleBackColor = false;
            this.btnPublicarReseña.Click += new System.EventHandler(this.btnPublicarReseña_Click);
            // 
            // btnCancelarFiltro
            // 
            this.btnCancelarFiltro.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancelarFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarFiltro.ForeColor = System.Drawing.Color.White;
            this.btnCancelarFiltro.Location = new System.Drawing.Point(268, 87);
            this.btnCancelarFiltro.Name = "btnCancelarFiltro";
            this.btnCancelarFiltro.Size = new System.Drawing.Size(143, 44);
            this.btnCancelarFiltro.TabIndex = 4;
            this.btnCancelarFiltro.Text = "Cancelar filtro";
            this.btnCancelarFiltro.UseVisualStyleBackColor = false;
            this.btnCancelarFiltro.Click += new System.EventHandler(this.btnCancelarFiltro_Click);
            // 
            // btnFiltro
            // 
            this.btnFiltro.BackColor = System.Drawing.Color.Firebrick;
            this.btnFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltro.ForeColor = System.Drawing.Color.White;
            this.btnFiltro.Location = new System.Drawing.Point(22, 87);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(80, 44);
            this.btnFiltro.TabIndex = 3;
            this.btnFiltro.Text = "Filtrar";
            this.btnFiltro.UseVisualStyleBackColor = false;
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
            this.fLayPanReseñas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            // panLogo
            // 
            this.panLogo.BackgroundImage = global::CineApp.Properties.Resources.LogoApp;
            this.panLogo.Location = new System.Drawing.Point(15, 12);
            this.panLogo.Name = "panLogo";
            this.panLogo.Size = new System.Drawing.Size(115, 100);
            this.panLogo.TabIndex = 6;
            // 
            // lblEncabezado1
            // 
            this.lblEncabezado1.AutoSize = true;
            this.lblEncabezado1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncabezado1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.lblEncabezado1.Location = new System.Drawing.Point(173, 23);
            this.lblEncabezado1.Name = "lblEncabezado1";
            this.lblEncabezado1.Size = new System.Drawing.Size(537, 38);
            this.lblEncabezado1.TabIndex = 7;
            this.lblEncabezado1.Text = "ProCinema - Gestión inteligente de Cines";
            // 
            // lblEncabezado2
            // 
            this.lblEncabezado2.AutoSize = true;
            this.lblEncabezado2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncabezado2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblEncabezado2.Location = new System.Drawing.Point(175, 76);
            this.lblEncabezado2.Name = "lblEncabezado2";
            this.lblEncabezado2.Size = new System.Drawing.Size(186, 28);
            this.lblEncabezado2.TabIndex = 8;
            this.lblEncabezado2.Text = "Tu cine, tu control.";
            // 
            // lblUsuarioLog
            // 
            this.lblUsuarioLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuarioLog.AutoSize = true;
            this.lblUsuarioLog.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioLog.ForeColor = System.Drawing.Color.White;
            this.lblUsuarioLog.Location = new System.Drawing.Point(872, 79);
            this.lblUsuarioLog.Name = "lblUsuarioLog";
            this.lblUsuarioLog.Size = new System.Drawing.Size(161, 24);
            this.lblUsuarioLog.TabIndex = 9;
            this.lblUsuarioLog.Text = "Usuario loggeado:";
            // 
            // FUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1182, 703);
            this.Controls.Add(this.lblUsuarioLog);
            this.Controls.Add(this.lblEncabezado2);
            this.Controls.Add(this.lblEncabezado1);
            this.Controls.Add(this.panLogo);
            this.Controls.Add(this.tabCtrlMenu);
            this.Name = "FUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Panel panLogo;
        private System.Windows.Forms.Label lblEncabezado1;
        private System.Windows.Forms.Label lblEncabezado2;
        private System.Windows.Forms.Label lblUsuarioLog;
    }
}