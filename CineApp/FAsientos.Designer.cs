namespace CineApp
{
    partial class FAsientos
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
            this.panAsientos = new System.Windows.Forms.Panel();
            this.tblAsientos = new System.Windows.Forms.TableLayoutPanel();
            this.gbDatosSesion = new System.Windows.Forms.GroupBox();
            this.btnIntroducirDatos = new System.Windows.Forms.Button();
            this.panDatosRequeridos = new System.Windows.Forms.Panel();
            this.lblHoraInicio = new System.Windows.Forms.Label();
            this.cmbHoraInicio = new System.Windows.Forms.ComboBox();
            this.bsSesiones = new System.Windows.Forms.BindingSource(this.components);
            this.dsCine1 = new CAD.DSCine();
            this.cmbFecha = new System.Windows.Forms.ComboBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gbInfoReserva = new System.Windows.Forms.GroupBox();
            this.btnReservar = new System.Windows.Forms.Button();
            this.panInformacionReserva = new System.Windows.Forms.Panel();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtNumAsientos = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblNumAsientos = new System.Windows.Forms.Label();
            this.bsReservas = new System.Windows.Forms.BindingSource(this.components);
            this.panAsientos.SuspendLayout();
            this.gbDatosSesion.SuspendLayout();
            this.panDatosRequeridos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsSesiones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCine1)).BeginInit();
            this.gbInfoReserva.SuspendLayout();
            this.panInformacionReserva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuarioLog
            // 
            this.lblUsuarioLog.AutoSize = true;
            this.lblUsuarioLog.ForeColor = System.Drawing.Color.White;
            this.lblUsuarioLog.Location = new System.Drawing.Point(12, 588);
            this.lblUsuarioLog.Name = "lblUsuarioLog";
            this.lblUsuarioLog.Size = new System.Drawing.Size(119, 16);
            this.lblUsuarioLog.TabIndex = 1;
            this.lblUsuarioLog.Text = "Usuario loggeado:";
            // 
            // panAsientos
            // 
            this.panAsientos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panAsientos.AutoScroll = true;
            this.panAsientos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(44)))));
            this.panAsientos.Controls.Add(this.tblAsientos);
            this.panAsientos.Location = new System.Drawing.Point(12, 220);
            this.panAsientos.Name = "panAsientos";
            this.panAsientos.Size = new System.Drawing.Size(1058, 355);
            this.panAsientos.TabIndex = 7;
            // 
            // tblAsientos
            // 
            this.tblAsientos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblAsientos.AutoSize = true;
            this.tblAsientos.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblAsientos.ColumnCount = 4;
            this.tblAsientos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblAsientos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblAsientos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblAsientos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tblAsientos.Location = new System.Drawing.Point(7, 3);
            this.tblAsientos.Name = "tblAsientos";
            this.tblAsientos.RowCount = 1;
            this.tblAsientos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblAsientos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblAsientos.Size = new System.Drawing.Size(1048, 349);
            this.tblAsientos.TabIndex = 1;
            // 
            // gbDatosSesion
            // 
            this.gbDatosSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(44)))));
            this.gbDatosSesion.Controls.Add(this.btnIntroducirDatos);
            this.gbDatosSesion.Controls.Add(this.panDatosRequeridos);
            this.gbDatosSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosSesion.ForeColor = System.Drawing.Color.White;
            this.gbDatosSesion.Location = new System.Drawing.Point(12, 12);
            this.gbDatosSesion.Name = "gbDatosSesion";
            this.gbDatosSesion.Size = new System.Drawing.Size(508, 202);
            this.gbDatosSesion.TabIndex = 8;
            this.gbDatosSesion.TabStop = false;
            this.gbDatosSesion.Text = "Datos requeridos";
            // 
            // btnIntroducirDatos
            // 
            this.btnIntroducirDatos.BackColor = System.Drawing.Color.Firebrick;
            this.btnIntroducirDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntroducirDatos.ForeColor = System.Drawing.Color.White;
            this.btnIntroducirDatos.Location = new System.Drawing.Point(321, 149);
            this.btnIntroducirDatos.Name = "btnIntroducirDatos";
            this.btnIntroducirDatos.Size = new System.Drawing.Size(181, 47);
            this.btnIntroducirDatos.TabIndex = 31;
            this.btnIntroducirDatos.Text = "Introducir datos";
            this.btnIntroducirDatos.UseVisualStyleBackColor = false;
            this.btnIntroducirDatos.Click += new System.EventHandler(this.btnIntroducirDatos_Click);
            // 
            // panDatosRequeridos
            // 
            this.panDatosRequeridos.Controls.Add(this.lblHoraInicio);
            this.panDatosRequeridos.Controls.Add(this.cmbHoraInicio);
            this.panDatosRequeridos.Controls.Add(this.cmbFecha);
            this.panDatosRequeridos.Controls.Add(this.lblFecha);
            this.panDatosRequeridos.Controls.Add(this.txtTitulo);
            this.panDatosRequeridos.Controls.Add(this.lblTitulo);
            this.panDatosRequeridos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panDatosRequeridos.Location = new System.Drawing.Point(10, 21);
            this.panDatosRequeridos.Name = "panDatosRequeridos";
            this.panDatosRequeridos.Size = new System.Drawing.Size(492, 122);
            this.panDatosRequeridos.TabIndex = 17;
            // 
            // lblHoraInicio
            // 
            this.lblHoraInicio.AutoSize = true;
            this.lblHoraInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraInicio.Location = new System.Drawing.Point(236, 66);
            this.lblHoraInicio.Name = "lblHoraInicio";
            this.lblHoraInicio.Size = new System.Drawing.Size(108, 16);
            this.lblHoraInicio.TabIndex = 5;
            this.lblHoraInicio.Text = "Hora de Inicio:";
            // 
            // cmbHoraInicio
            // 
            this.cmbHoraInicio.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsSesiones, "HoraInicio", true));
            this.cmbHoraInicio.FormattingEnabled = true;
            this.cmbHoraInicio.Location = new System.Drawing.Point(239, 85);
            this.cmbHoraInicio.Name = "cmbHoraInicio";
            this.cmbHoraInicio.Size = new System.Drawing.Size(191, 24);
            this.cmbHoraInicio.TabIndex = 4;
            // 
            // bsSesiones
            // 
            this.bsSesiones.DataMember = "Sesiones";
            this.bsSesiones.DataSource = this.dsCine1;
            // 
            // dsCine1
            // 
            this.dsCine1.DataSetName = "DSCine";
            this.dsCine1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbFecha
            // 
            this.cmbFecha.FormattingEnabled = true;
            this.cmbFecha.Location = new System.Drawing.Point(6, 85);
            this.cmbFecha.Name = "cmbFecha";
            this.cmbFecha.Size = new System.Drawing.Size(191, 24);
            this.cmbFecha.TabIndex = 3;
            this.cmbFecha.SelectedIndexChanged += new System.EventHandler(this.cmbFecha_SelectedIndexChanged);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(3, 66);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(54, 16);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Enabled = false;
            this.txtTitulo.Location = new System.Drawing.Point(6, 31);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(477, 22);
            this.txtTitulo.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(3, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(148, 16);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Título de la película:";
            // 
            // gbInfoReserva
            // 
            this.gbInfoReserva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbInfoReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(44)))));
            this.gbInfoReserva.Controls.Add(this.btnReservar);
            this.gbInfoReserva.Controls.Add(this.panInformacionReserva);
            this.gbInfoReserva.Enabled = false;
            this.gbInfoReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfoReserva.ForeColor = System.Drawing.Color.White;
            this.gbInfoReserva.Location = new System.Drawing.Point(544, 12);
            this.gbInfoReserva.Name = "gbInfoReserva";
            this.gbInfoReserva.Size = new System.Drawing.Size(508, 202);
            this.gbInfoReserva.TabIndex = 32;
            this.gbInfoReserva.TabStop = false;
            this.gbInfoReserva.Text = "Información de la reserva";
            // 
            // btnReservar
            // 
            this.btnReservar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReservar.BackColor = System.Drawing.Color.Firebrick;
            this.btnReservar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservar.ForeColor = System.Drawing.Color.White;
            this.btnReservar.Location = new System.Drawing.Point(343, 149);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(159, 47);
            this.btnReservar.TabIndex = 31;
            this.btnReservar.Text = "Hacer reserva";
            this.btnReservar.UseVisualStyleBackColor = false;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // panInformacionReserva
            // 
            this.panInformacionReserva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panInformacionReserva.Controls.Add(this.txtCorreo);
            this.panInformacionReserva.Controls.Add(this.txtPrecio);
            this.panInformacionReserva.Controls.Add(this.txtNumAsientos);
            this.panInformacionReserva.Controls.Add(this.lblPrecio);
            this.panInformacionReserva.Controls.Add(this.lblCorreo);
            this.panInformacionReserva.Controls.Add(this.lblNumAsientos);
            this.panInformacionReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panInformacionReserva.Location = new System.Drawing.Point(10, 21);
            this.panInformacionReserva.Name = "panInformacionReserva";
            this.panInformacionReserva.Size = new System.Drawing.Size(492, 122);
            this.panInformacionReserva.TabIndex = 17;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCorreo.Location = new System.Drawing.Point(12, 87);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(456, 22);
            this.txtCorreo.TabIndex = 6;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrecio.Location = new System.Drawing.Point(245, 31);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(175, 22);
            this.txtPrecio.TabIndex = 7;
            // 
            // txtNumAsientos
            // 
            this.txtNumAsientos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumAsientos.Location = new System.Drawing.Point(12, 31);
            this.txtNumAsientos.Name = "txtNumAsientos";
            this.txtNumAsientos.Size = new System.Drawing.Size(175, 22);
            this.txtNumAsientos.TabIndex = 6;
            // 
            // lblPrecio
            // 
            this.lblPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(242, 10);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(114, 16);
            this.lblPrecio.TabIndex = 5;
            this.lblPrecio.Text = "Precio a pagar:";
            // 
            // lblCorreo
            // 
            this.lblCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(9, 68);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(295, 16);
            this.lblCorreo.TabIndex = 0;
            this.lblCorreo.Text = "Correo electrónico asociado a la reserva:";
            // 
            // lblNumAsientos
            // 
            this.lblNumAsientos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumAsientos.AutoSize = true;
            this.lblNumAsientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumAsientos.Location = new System.Drawing.Point(9, 10);
            this.lblNumAsientos.Name = "lblNumAsientos";
            this.lblNumAsientos.Size = new System.Drawing.Size(92, 16);
            this.lblNumAsientos.TabIndex = 2;
            this.lblNumAsientos.Text = "Nº Asientos:";
            // 
            // bsReservas
            // 
            this.bsReservas.DataMember = "Reservas";
            this.bsReservas.DataSource = this.dsCine1;
            // 
            // FAsientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1082, 613);
            this.Controls.Add(this.gbInfoReserva);
            this.Controls.Add(this.gbDatosSesion);
            this.Controls.Add(this.panAsientos);
            this.Controls.Add(this.lblUsuarioLog);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FAsientos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservar asientos";
            this.Load += new System.EventHandler(this.FAsientos_Load);
            this.panAsientos.ResumeLayout(false);
            this.panAsientos.PerformLayout();
            this.gbDatosSesion.ResumeLayout(false);
            this.panDatosRequeridos.ResumeLayout(false);
            this.panDatosRequeridos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsSesiones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCine1)).EndInit();
            this.gbInfoReserva.ResumeLayout(false);
            this.panInformacionReserva.ResumeLayout(false);
            this.panInformacionReserva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsReservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuarioLog;
        private System.Windows.Forms.Panel panAsientos;
        private System.Windows.Forms.TableLayoutPanel tblAsientos;
        private System.Windows.Forms.GroupBox gbDatosSesion;
        private System.Windows.Forms.Button btnIntroducirDatos;
        private System.Windows.Forms.Panel panDatosRequeridos;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cmbFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHoraInicio;
        private System.Windows.Forms.ComboBox cmbHoraInicio;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.GroupBox gbInfoReserva;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Panel panInformacionReserva;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblNumAsientos;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtNumAsientos;
        private CAD.DSCine dsCine1;
        private System.Windows.Forms.BindingSource bsSesiones;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.BindingSource bsReservas;
    }
}