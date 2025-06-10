namespace CineApp
{
    partial class ReseñaCard
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblPelicula = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.picBoxEstrellas = new System.Windows.Forms.PictureBox();
            this.lblComentario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEstrellas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblUsuario.Location = new System.Drawing.Point(23, 32);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(57, 16);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblPelicula
            // 
            this.lblPelicula.AutoSize = true;
            this.lblPelicula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblPelicula.Location = new System.Drawing.Point(23, 66);
            this.lblPelicula.Name = "lblPelicula";
            this.lblPelicula.Size = new System.Drawing.Size(58, 16);
            this.lblPelicula.TabIndex = 1;
            this.lblPelicula.Text = "Película:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblFecha.Location = new System.Drawing.Point(23, 322);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(48, 16);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha:";
            // 
            // picBoxEstrellas
            // 
            this.picBoxEstrellas.Location = new System.Drawing.Point(396, 13);
            this.picBoxEstrellas.Name = "picBoxEstrellas";
            this.picBoxEstrellas.Size = new System.Drawing.Size(224, 35);
            this.picBoxEstrellas.TabIndex = 3;
            this.picBoxEstrellas.TabStop = false;
            // 
            // lblComentario
            // 
            this.lblComentario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblComentario.Location = new System.Drawing.Point(23, 100);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(500, 200);
            this.lblComentario.TabIndex = 4;
            this.lblComentario.Text = "Comentario:";
            // 
            // ReseñaCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(44)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblComentario);
            this.Controls.Add(this.picBoxEstrellas);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblPelicula);
            this.Controls.Add(this.lblUsuario);
            this.Name = "ReseñaCard";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(633, 363);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEstrellas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblPelicula;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.PictureBox picBoxEstrellas;
        private System.Windows.Forms.Label lblComentario;
    }
}
