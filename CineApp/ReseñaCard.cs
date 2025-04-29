using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineApp
{
    /**
     * Clase parcial que define las cartas donde aparecerán las reseñas dejadas por los usuarios
     */
    public partial class ReseñaCard : UserControl
    {
        public ReseñaCard()
        {
            InitializeComponent();
        }

        /**
         * Getters y Setters
         */
        public string Usuario
        {
            get { return lblUsuario.Text; }
            set { lblUsuario.Text = value; }
        }

        public string Pelicula
        {
            get { return lblPelicula.Text; }
            set { lblPelicula.Text = value; }
        }

        public string Fecha
        {
            get { return lblFecha.Text; }
            set { lblFecha.Text = value; }
        }

        public string Comentario
        {
            get { return lblComentario.Text; }
            set {lblComentario.Text = value; }
        }

        public Image Estrellas
        {
            get { return picBoxEstrellas.Image; }
            set { picBoxEstrellas.Image = value; }
        }
    }
}
