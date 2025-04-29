namespace CineApp
{
    partial class FLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.dsCine1 = new CAD.DSCine();
            this.bsUsuarios = new System.Windows.Forms.BindingSource(this.components);
            this.bsEmpleados = new System.Windows.Forms.BindingSource(this.components);
            this.lblRegistrarse = new System.Windows.Forms.Label();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsCine1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(232, 39);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(182, 22);
            this.txtUsuario.TabIndex = 0;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(232, 95);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(182, 22);
            this.txtContraseña.TabIndex = 1;
            this.txtContraseña.UseSystemPasswordChar = true;
            // 
            // btnAcceder
            // 
            this.btnAcceder.Location = new System.Drawing.Point(339, 176);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(75, 31);
            this.btnAcceder.TabIndex = 2;
            this.btnAcceder.Text = "Acceder";
            this.btnAcceder.UseVisualStyleBackColor = true;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(29, 42);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(177, 16);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuario / Correo electrónico:";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(127, 98);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(79, 16);
            this.lblContraseña.TabIndex = 5;
            this.lblContraseña.Text = "Contraseña:";
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
            // bsEmpleados
            // 
            this.bsEmpleados.DataMember = "Empleados";
            this.bsEmpleados.DataSource = this.dsCine1;
            // 
            // lblRegistrarse
            // 
            this.lblRegistrarse.AutoSize = true;
            this.lblRegistrarse.Location = new System.Drawing.Point(32, 182);
            this.lblRegistrarse.Name = "lblRegistrarse";
            this.lblRegistrarse.Size = new System.Drawing.Size(114, 16);
            this.lblRegistrarse.TabIndex = 6;
            this.lblRegistrarse.Text = "¿No tiene cuenta?";
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.Location = new System.Drawing.Point(161, 175);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(94, 31);
            this.btnRegistrarse.TabIndex = 7;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.UseVisualStyleBackColor = true;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // FLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 237);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.lblRegistrarse);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnAcceder);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Name = "FLogin";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.dsCine1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private CAD.DSCine dsCine1;
        private System.Windows.Forms.BindingSource bsUsuarios;
        private System.Windows.Forms.BindingSource bsEmpleados;
        private System.Windows.Forms.Label lblRegistrarse;
        private System.Windows.Forms.Button btnRegistrarse;
    }
}

