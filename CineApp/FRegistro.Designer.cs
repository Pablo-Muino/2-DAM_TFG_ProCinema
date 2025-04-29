namespace CineApp
{
    partial class FRegistro
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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblConfContraseña = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtConfContraseña = new System.Windows.Forms.TextBox();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.dsCine1 = new CAD.DSCine();
            this.bsUsuarios = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dsCine1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(100, 48);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(125, 16);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Nombre de usuario:";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(105, 85);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(120, 16);
            this.lblCorreo.TabIndex = 1;
            this.lblCorreo.Text = "Correo electrónico:";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(146, 128);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(79, 16);
            this.lblContraseña.TabIndex = 2;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // lblConfContraseña
            // 
            this.lblConfContraseña.AutoSize = true;
            this.lblConfContraseña.Location = new System.Drawing.Point(88, 172);
            this.lblConfContraseña.Name = "lblConfContraseña";
            this.lblConfContraseña.Size = new System.Drawing.Size(137, 16);
            this.lblConfContraseña.TabIndex = 3;
            this.lblConfContraseña.Text = "Confirmar contraseña:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(240, 45);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(197, 22);
            this.txtNombre.TabIndex = 4;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(240, 85);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(197, 22);
            this.txtCorreo.TabIndex = 5;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(240, 125);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(197, 22);
            this.txtContraseña.TabIndex = 6;
            this.txtContraseña.UseSystemPasswordChar = true;
            // 
            // txtConfContraseña
            // 
            this.txtConfContraseña.Location = new System.Drawing.Point(240, 169);
            this.txtConfContraseña.Name = "txtConfContraseña";
            this.txtConfContraseña.Size = new System.Drawing.Size(197, 22);
            this.txtConfContraseña.TabIndex = 7;
            this.txtConfContraseña.UseSystemPasswordChar = true;
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.Location = new System.Drawing.Point(216, 231);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(95, 29);
            this.btnRegistrarse.TabIndex = 8;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.UseVisualStyleBackColor = true;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // dsCine1
            // 
            this.dsCine1.DataSetName = "DSCine";
            this.dsCine1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsUsuarios
            // 
            this.bsUsuarios.DataMember = "Usuarios";
            this.bsUsuarios.DataSource = this.dsCine1;
            // 
            // FRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 314);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.txtConfContraseña);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblConfContraseña);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblUsuario);
            this.Name = "FRegistro";
            this.Text = "FRegistro";
            ((System.ComponentModel.ISupportInitialize)(this.dsCine1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblConfContraseña;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtConfContraseña;
        private System.Windows.Forms.Button btnRegistrarse;
        private CAD.DSCine dsCine1;
        private System.Windows.Forms.BindingSource bsUsuarios;
    }
}