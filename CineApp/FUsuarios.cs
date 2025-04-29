using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAD;
using CAD.DSCineTableAdapters;
using Negocio;

namespace CineApp
{
    public partial class FUsuarios : Form
    {
        /**
         * Variables de la clase:
         * usuario - Usuario que se ha loggeado en la aplicación
         * panelSeleccionado - Variable que guardará el panel seleccionado en ese momento
         * peliculas - Lista de peliculas que hay en la cartelera
         * pelicula - Película sobre la que se está trabajando de la lista de peliculas
         * peliculaActual - Película que haya seleccionado el usuario
         * reseñas - Lista de reseñas que se mostrarán
         * cupones - Lista de cupones que se mostrarán
         * cupon - Cupón sobre el que se está trabajando de la lista de cupones
         * cuponSeleccionado - Cupón que ha seleccionado el usuario pero está pendiente de ser canjeado
         * cuponActual - Cupón ya canjeado por el usuario
         */
        private Usuario usuario;
        private Panel panelSeleccionado = null;
        private List<Pelicula> peliculas;
        private Pelicula pelicula = null;
        private Pelicula peliculaActual = null;
        private List<Reseña> reseñas;
        private List<Cupon> cupones;
        private Cupon cupon = null;
        private Cupon cuponSeleccionado = null;
        private Cupon cuponActual = null;

        /**
         * Constructor de la clase
         * _usuario - El usuario que se ha loggeado en la aplicación
         */
        public FUsuarios(Usuario _usuario)
        {
            InitializeComponent();

            //Se establece que el usuario que ha entrado con sus credenciales sea el usuario loggeado
            this.usuario = _usuario;
        }

        /**
         * Evento que se lanza al cargar el formulario
         */
        private void FUsuarios_Load(object sender, EventArgs e)
        {
            //Al iniciar el formulario se mostrará el nombre del usuario loggeado
            lblUsuarioLog.Text = "Usuario loggeado: " + usuario.Nombre;

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
                { "tabPagCartelera", () => CargarCartelera() },
                { "tabPagCupones", () => CargarCupones() },
                { "tabPagReseñas", () => CargarReseñas() }
            };

            //Si el diccionario contiene el tabPage actual se llama al método asociado para cargar los datos
            if (cargaDatos.ContainsKey(tabCtrlMenu.SelectedTab.Name))
            {
                cargaDatos[tabCtrlMenu.SelectedTab.Name]();
            }
        }

        /**
         * Método que carga las peliculas existentes en la tabla Peliculas y sus portadas en la cartelera
         */
        private void CargarCartelera()
        {
            //Se limpian los campos por si acaso hubieran datos en ellos
            txtTitulo.Clear();
            txtGenero.Clear();
            txtDuracion.Clear();
            txtCalificacion.Clear();
            txtSinopsis.Clear();

            //Se obtienen las peliculas de la tabla Peliculas
            peliculas = NPeliculas.obtenerListaPeliculas(dsCine1);

            //Se muestran las portadas en el FlowLayoutPanel
            MostrarPortadas();
        }

        /**
         * Método que muestra las portadas de las películas actuales en una tabla así como el título de las mismas a forma de cartelera
         */
        private void MostrarPortadas()
        {
            //Se creará la tabla automáticamente cada vez que se inicie el formulario y su tamaño dependerá de las películas que haya en ese momento en la tabla Peliculas
            //Para conseguir esto primero se debe de borrar todos los controles, filas y columnas de la tabla para evitar duplicaciones
            tblCartelera.Controls.Clear();
            tblCartelera.RowStyles.Clear();
            tblCartelera.ColumnStyles.Clear();

            //Se recoge el número de peliculas actuales en la tabla Peliculas
            int totalPeliculas = peliculas.Count;

            //Se establece que hayan 4 columnas (para que sea más visible)
            int columnas = 4;

            //Se establece que el número de filas sea el total de películas entre las columnas redondeando hacia arriba
            int filas = (int) Math.Ceiling((double) totalPeliculas / columnas);

            //Se establecen el número de columnas y filas recien calculados a las propiedades respectivas en la tabla
            tblCartelera.RowCount = filas;
            tblCartelera.ColumnCount = columnas;

            //Se distribuye cada columna de manera equitativa, ocupando un 25% del ancho
            for (int i = 0; i < columnas; i++)
            {
                tblCartelera.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / columnas));
            }

            //Variable que guarda la posición de la película que se esté iterando
            int indice = 0;

            //Se itera por filas y columnas para añadir las peliculas a la tabla
            for (int fila = 0; fila < filas; fila++)
            {
                //Se establece que la fila ocupe lo que ocupe el contenido de la misma
                tblCartelera.RowStyles.Add(new RowStyle(SizeType.AutoSize));

                for (int columna = 0; columna < columnas; columna++)
                {
                    //Si ya se han mostrado todas las peliculas se sale del bucle
                    if (indice >= totalPeliculas) break;

                    //Se guarda la pelicula que se esté iterando
                    pelicula = peliculas[indice];

                    //Se crea el panel que contendrá la imagen de portada y el título
                    Panel panel = new Panel
                    {
                        //Color de fondo inicial (antes de que se le de clic)
                        BackColor = Color.FromArgb(10, 15, 44),

                        Padding = new Padding(5),
                        Margin = new Padding(5),
                        BorderStyle = BorderStyle.FixedSingle,
                        Size = new Size(100, 190)
                    };

                    //Se crea el PictureBox donde irá la imágen de portada
                    PictureBox portada = new PictureBox
                    {
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Width = 90,
                        Height = 120,
                        Dock = DockStyle.Top,
                        
                        //Se establece que el tag sea la pelicula que se esté iterando para poder referenciarlo en un futuro
                        Tag = pelicula
                    };

                    //Se define el tamaño de la fuente según la longitud del título
                    Font fuenteTitulo = (pelicula.Titulo.Length > 20) ? new Font("Arial", 6, FontStyle.Bold) : new Font("Arial", 8, FontStyle.Bold);

                    //Se crea el Label que contendrá el título de la pelicula
                    Label lblTitulo = new Label
                    {
                        Text = pelicula.Titulo,
                        Dock = DockStyle.Bottom,
                        TextAlign = ContentAlignment.MiddleCenter,
                        AutoSize = false,
                        Height = 60,
                        Font = fuenteTitulo
                    };


                    //Se intenta descargar la imagen de portada a través de su link (URL)
                    try
                    {
                        //Para esto se usa un cliente web que permite la descarga y, cuando acabe, éste se cierra
                        using (System.Net.WebClient client = new System.Net.WebClient())
                        {
                            //La imagen se almacena en un array de bytes ya que la descarga devuelve los datos en formato binario
                            byte[] imageBytes = client.DownloadData(pelicula.Portada);

                            //Se convierten estos bytes en un flujo de datos para manejarlos desde la memoria (al acabar se cierra)
                            using (MemoryStream stream = new MemoryStream(imageBytes))
                            {
                                //Por último se convierte ese flujo en una imágen válida
                                portada.Image = Image.FromStream(stream);
                            }
                        }
                    }
                    catch
                    {
                        //Si falla la imagen se usa una imagen predeterminada
                        portada.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Imagenes", "predeterminada.png"));
                    }

                    //Se asocia el evento Portada_Click para que al hacer clic en la portada se seleccione la película
                    portada.Click += (s, e) => Portada_Click(s, e, panel);

                    //Se añaden tanto la imagen como el titulo al panel y éste, a la tabla en la fila y columna correspondiente (la que se esté iterando)
                    panel.Controls.Add(portada);
                    panel.Controls.Add(lblTitulo);
                    tblCartelera.Controls.Add(panel, columna, fila);

                    //Se pasa a la siguiente pelicula
                    indice++;
                }
            }
        }

        /**
         * Evento que se dispara al darle clic a un panel en la tabla de la cartelera
         * panelActual - Panel al que se le acaba de dar clic
         */
        private void Portada_Click(object sender, EventArgs e, Panel panelActual)
        {
            //Si habia una pelicula seleccionada se restablece su color
            if (panelSeleccionado != null)
            {
                panelSeleccionado.BackColor = Color.White;
            }

            //Se establece que el panel seleccionado sea el actual (al que se le acaba de dar clic)
            panelSeleccionado = panelActual;

            //Se le cambia el color de fondo para resaltar la selección
            panelSeleccionado.BackColor = Color.LightBlue;

            //Se recupera la pelicula almacenada en Tag cuando se creó el PictureBox y, si coincide con la pelicula seleccionada se sigue
            if (sender is PictureBox portada && portada.Tag is Pelicula pelicula)
            {
                //Se pueblan los datos en los taxtBox/comboBox del formulario
                txtTitulo.Text = pelicula.Titulo;
                txtGenero.Text = NGenero.ObtenerNombreGeneroById(dsCine1, (int) pelicula.IdGenero);
                txtDuracion.Text = pelicula.Duracion + " minutos";
                txtCalificacion.Text = pelicula.Calificacion.ToString();
                txtSinopsis.Text = pelicula.Sinopsis;

                peliculaActual = pelicula;
            }
        }

        /**
         * Evento que se lanza al pulsar el botón btnReservar
         */
        private void btnReservar_Click(object sender, EventArgs e)
        {
            //Se cierra la ventana Usuarios
            Hide();

            FAsientos fAsientos = new FAsientos(usuario, peliculaActual, cuponActual);

            //Al cerrar la ventana fAsientos se volverá a mostrar fUsuarios
            fAsientos.FormClosed += (s, args) => Show();

            //Se muestra la ventana Asientos
            fAsientos.Show();
        }

        /**
         * Método que carga los cupones existentes en la tabla Cupones y sus imágenes en la tabla
         */
        private void CargarCupones()
        {
            //Se obtienen los cupones de la tabla Cupones
            cupones = NCupones.obtenerListaCupones(dsCine1);

            //Se muestran los puntos actuales del usuario
            lblPuntos.Text = usuario.Puntos.ToString();

            //Se muestran las imagenes en el FlowLayoutPanel
            MostrarCupones();
        }

        /**
         * Método que muestra los imágenes de los cupones actuales en una tabla así como la descripción de los mismos, su fecha de vigencia y el coste de canjeo
         */
        private void MostrarCupones()
        {
            //Se creará la tabla automáticamente cada vez que se inicie el formulario y su tamaño dependerá de los cupones que haya en ese momento en la tabla Cupones
            //Para conseguir esto primero se debe de borrar todos los controles, filas y columnas de la tabla para evitar duplicaciones
            tblCupones.Controls.Clear();
            tblCupones.RowStyles.Clear();
            tblCupones.ColumnStyles.Clear();

            //Se recoge el número de cupones actuales en la tabla Cupones
            int totalCupones = cupones.Count;

            //Se establece que hayan 4 columnas (para que sea más visible)
            int columnas = 4;

            //Se establece que el número de filas sea el total de cupones entre las columnas redondeando hacia arriba
            int filas = (int)Math.Ceiling((double)totalCupones / columnas);

            //Se establecen el número de columnas y filas recien calculados a las propiedades respectivas en la tabla
            tblCupones.RowCount = filas;
            tblCupones.ColumnCount = columnas;

            //Se distribuye cada columna de manera equitativa, ocupando un 25% del ancho
            for (int i = 0; i < columnas; i++)
            {
                tblCupones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / columnas));
            }

            //Variable que guarda la posición del cupón que se esté iterando
            int indice = 0;

            //Se itera por filas y columnas para añadir los cupones a la tabla
            for (int fila = 0; fila < filas; fila++)
            {
                //Se establece que la fila ocupe lo que ocupe el contenido de la misma
                tblCupones.RowStyles.Add(new RowStyle(SizeType.AutoSize));

                for (int columna = 0; columna < columnas; columna++)
                {
                    //Si ya se han mostrado todos los cupones se sale del bucle
                    if (indice >= totalCupones) break;

                    //Se guarda el cupón que se esté iterando
                    cupon = cupones[indice];

                    //Se crea el panel que contendrá la imagen representativa del cupón, la descripción, el tiempo de vigencia y el coste de canjeo
                    Panel panel = new Panel
                    {
                        //Color de fondo inicial (antes de que se le de clic)
                        BackColor = Color.White,

                        Padding = new Padding(5),
                        Margin = new Padding(5),
                        BorderStyle = BorderStyle.FixedSingle,
                        Size = new Size(160, 250)
                    };

                    //Se crea el PictureBox donde irá la imágen representativa
                    PictureBox imagen = new PictureBox
                    {
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Width = 110,
                        Height = 120,
                        Dock = DockStyle.Top,

                        //Se establece que el tag sea el cupón que se esté iterando para poder referenciarlo en un futuro
                        Tag = cupon
                    };

                    //Se crea el Label que contendrá la descripción del cupón
                    Label lblDescripcion = new Label
                    {
                        Text = cupon.Descripcion,
                        Dock = DockStyle.Bottom,
                        TextAlign = ContentAlignment.MiddleCenter,
                        AutoSize = false,
                        Height = 40,
                        Font = new Font("Arial", 7, FontStyle.Bold)
                    };

                    //Se crea el Label que contendrá la vigencia del cupón
                    Label lblVigencia = new Label
                    {
                        Text = $"{cupon.FechaInicio} - {cupon.FechaCaducidad}",
                        Dock = DockStyle.Bottom,
                        TextAlign = ContentAlignment.MiddleCenter,
                        AutoSize = false,
                        Height = 30,
                        Font = new Font("Arial", 6, FontStyle.Regular)
                    };

                    //Se crea el Label que contendrá el coste de canje del cupón
                    Label lblCoste = new Label
                    {
                        Text = $"Coste: {cupon.CostePuntos} pts",
                        Dock = DockStyle.Bottom,
                        TextAlign = ContentAlignment.MiddleCenter,
                        AutoSize = false,
                        Height = 30,
                        Font = new Font("Arial", 7, FontStyle.Regular)
                    };


                    //Se intenta descargar la imagen representativa a través de su link (URL)
                    try
                    {
                        //Para esto se usa un cliente web que permite la descarga y, cuando acabe, éste se cierra
                        using (System.Net.WebClient client = new System.Net.WebClient())
                        {
                            //La imagen se almacena en un array de bytes ya que la descarga devuelve los datos en formato binario
                            byte[] imageBytes = client.DownloadData(cupon.Imagen);

                            //Se convierten estos bytes en un flujo de datos para manejarlos desde la memoria (al acabar se cierra)
                            using (MemoryStream stream = new MemoryStream(imageBytes))
                            {
                                //Por último se convierte ese flujo en una imágen válida
                                imagen.Image = Image.FromStream(stream);
                            }
                        }
                    }
                    catch
                    {
                        //Si falla la imagen se usa una imagen predeterminada
                        imagen.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Imagenes", "predeterminada.png"));
                    }

                    //Se asocia el evento Portada_Click para que al hacer clic en la portada se seleccione la película
                    imagen.Click += (s, e) => Imagen_Click(s, e, panel);

                    //Se añaden tanto la imagen como el titulo al panel y éste, a la tabla en la fila y columna correspondiente (la que se esté iterando)
                    panel.Controls.Add(imagen);
                    panel.Controls.Add(lblDescripcion);
                    panel.Controls.Add(lblVigencia);
                    panel.Controls.Add(lblCoste);
                    tblCupones.Controls.Add(panel, columna, fila);

                    //Se pasa al siguiente cupón
                    indice++;
                }
            }
        }

        /**
         * Evento que se dispara al darle clic a un panel en la tabla de la cartelera
         * panelActual - Panel al que se le acaba de dar clic
         */
        private void Imagen_Click(object sender, EventArgs e, Panel panelActual)
        {
            //Si habia un cupón seleccionado se restablece su color
            if (panelSeleccionado != null)
            {
                panelSeleccionado.BackColor = Color.White;
            }

            //Se establece que el panel seleccionado sea el actual (al que se le acaba de dar clic)
            panelSeleccionado = panelActual;

            //Se le cambia el color de fondo para resaltar la selección
            panelSeleccionado.BackColor = Color.LightBlue;

            //Se recupera el cupón almacenado en Tag cuando se creó el PictureBox y, si coincide con el cupón seleccionada se sigue
            if (sender is PictureBox imagen && imagen.Tag is Cupon cupon)
            {
                cuponSeleccionado = cupon;
            }
        }

        /**
         * Evento que se lanza al dar clic sobre el botón btnCanjear
         */
        private void btnCanjear_Click(object sender, EventArgs e)
        {
            //Si el usuario no se puede permitir canjear el cupón porque éste cuesta más puntos de los que el usuario tiene se le notifica
            if (cuponSeleccionado.CostePuntos > usuario.Puntos)
            {
                MessageBox.Show("No es posible canjear este cupón. Falta de puntos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Se advierte al usuario de la operación que va a realizar
            DialogResult result = MessageBox.Show("¿Deseas canjear este cupón?, se restarán los puntos de coste del mismo.", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //Si el usuario dice que si se le restan los puntos del coste del cupón. En caso contrario, se deja de guardar ese cupón seleccionado
            if (result == DialogResult.Yes)
            {
                cuponActual = cuponSeleccionado;
                usuario.Puntos = usuario.Puntos - cuponActual.CostePuntos;
                lblPuntos.Text = usuario.Puntos.ToString();
            } else
            {
                cuponActual = null;
            }
        }

        /**
         * Método que carga las reseñas existentes de la tabla Reseñas
         */
        private void CargarReseñas()
        {
            //Se puebla el dataGridView con la tabla Peliculas
            NPeliculas.obtenerPeliculas(dsCine1);

            //Se pueblan los cmbFiltro y cmbPeliculaReseña indicando que el origen sea su tabla (Peliculas)
            PeliculasTableAdapter taPeliculas = new PeliculasTableAdapter();
            taPeliculas.Fill(dsCine1.Peliculas);

            //Para eso se hacen copias de los datos para que cada comboBox sea independiente del otro
            DataTable peliculasFiltro = dsCine1.Peliculas.Copy();
            DataTable peliculasReseña = dsCine1.Peliculas.Copy();

            cmbFiltro.DataSource = peliculasFiltro;
            cmbFiltro.DisplayMember = "Titulo";
            cmbFiltro.ValueMember = "Id";

            cmbPeliculaReseña.DataSource = peliculasReseña;
            cmbPeliculaReseña.DisplayMember = "Titulo";
            cmbPeliculaReseña.ValueMember = "Id";

            //Se recogen las reseñas que haya en la tabla Reseñas y se muestran
            reseñas = NReseñas.obtenerListaReseñas(dsCine1);
            MostrarReseñas(reseñas);
        }

        /**
         * Método que muestra las reseñas existentes en la tabla Reseñas
         */
        private void MostrarReseñas(List<Reseña> reseñas)
        {
            //Se limpia por si hubiera algo antes de mostrar las reseñas
            fLayPanReseñas.Controls.Clear();

            for (int i = 0; i < reseñas.Count; i++)
            {
                //Por cada reseña se recoge ésta, su usuario y su película
                Reseña reseña = reseñas[i];
                Usuario usuario = NUsuarios.obtenerUsuarioId(dsCine1, reseña.IdUsuario);

                //Se le pasa al método un nuevo dataSource para que no se cambien las películas en el cmbFiltro cuando se haga el Fill
                Pelicula pelicula = NPeliculas.obtenerPeliculaId(new DSCine(), reseña.IdPelicula);
                Image estrellas;
                
                //Se establece que la imagen de las estarellas sea el adecuado según la calificación adjunta en la reseña
                switch(reseña.Calificacion)
                {
                    case 1:
                        estrellas = Image.FromFile(Path.Combine(Application.StartupPath, "Imagenes", "1_estrella.png"));
                        break;
                    case 2:
                        estrellas = Image.FromFile(Path.Combine(Application.StartupPath, "Imagenes", "2_estrellas.png"));
                        break;
                    case 3:
                        estrellas = Image.FromFile(Path.Combine(Application.StartupPath, "Imagenes", "3_estrellas.png"));
                        break;
                    case 4:
                        estrellas = Image.FromFile(Path.Combine(Application.StartupPath, "Imagenes", "4_estrellas.png"));
                        break;
                    case 5:
                        estrellas = Image.FromFile(Path.Combine(Application.StartupPath, "Imagenes", "5_estrellas.png"));
                        break;
                    default:
                        estrellas = Image.FromFile(Path.Combine(Application.StartupPath, "Imagenes", "predeterminada.png"));
                        break;
                }

                //Se crea un ReseñaCard con todos los datos necesarios
                ReseñaCard reseñaCard = new ReseñaCard();
                reseñaCard.Usuario = "Usuario: " + usuario.Nombre;
                reseñaCard.Pelicula = "Película: " + pelicula.Titulo;
                reseñaCard.Fecha = "Fecha de publicación: " + DateTime.Now.ToString();
                reseñaCard.Comentario = reseña.Comentario;
                reseñaCard.Estrellas = estrellas;

                //Y ésta se añade al flowLayoutPanel para mostrarselo al usuario
                fLayPanReseñas.Controls.Add(reseñaCard);
            }
        }

        /**
         * Evento que se dispara al hacer clic sobre btnFiltro
         */
        private void btnFiltro_Click(object sender, EventArgs e)
        {
            //Se recoge  las reseñas asociadas a la película especificada
            reseñas = NReseñas.obtenerListaReseñasIdPelicula(dsCine1, (int)cmbFiltro.SelectedValue);

            //Si no se obtiene ninguna se le avisa al usuario
            if (reseñas.Count == 0)
            {
                MessageBox.Show("No existen reseñas para esta película.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Se muestran otra vez las reseñas pero ya con el filtro hecho
            MostrarReseñas(reseñas);
        }

        /**
         * Evento que se dispara al hacer clic sobre btnCancelarFiltro
         */
        private void btnCancelarFiltro_Click(object sender, EventArgs e)
        {
            //Se vuelven a obtener todas las reseñas sin ningún filtro y se vuelven a mostrar
            reseñas = NReseñas.obtenerListaReseñas(dsCine1);

            MostrarReseñas(reseñas);
        }

        /**
         * Evento que se dispara al hacer clic sobre el btnPublicarReseña
         */
        private void btnPublicarReseña_Click(object sender, EventArgs e)
        {
            //Se recoge la película seleccionada
            Pelicula pelicula = NPeliculas.obtenerPeliculaId(dsCine1, (int)cmbPeliculaReseña.SelectedValue);

            //Si alguno de los campos necesarios está vacío se le advierte al usuario
            if (txtCalificacionReseña.Text.Equals("") || txtComentarioReseña.Text.Equals(""))
            {
                MessageBox.Show("Se deben de rellenar todos los campos para publicar la reseña.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Se intentamos convertir a int la calificación dada por el usuario, en caso de no conseguirlo se le advierte
            if (!int.TryParse(txtCalificacionReseña.Text, out int calificacion) || calificacion < 1 || calificacion > 5)
            {
                MessageBox.Show("La calificación indicada en la reseña no es válida. Debe ser un número entre 1 y 5.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Se recoge el comentario escrito por el usuario
            string comentario = txtComentarioReseña.Text;

            //Se crea el objeto Reseña con todos los datos recogidos
            Reseña nuevaReseña = new Reseña(pelicula.Id, usuario.Id, calificacion, comentario, DateTime.Now);

            //Se guarda la reseña en la base de datos
            NReseñas.insertarReseña(dsCine1, nuevaReseña);

            //Por último, se recargan las reseñas ya con ésta nueva introducida y se muestran
            reseñas = NReseñas.obtenerListaReseñas(dsCine1);
            MostrarReseñas(reseñas);

            //Se limpian los campos
            txtCalificacion.Text = "";
            txtComentarioReseña.Text = "";

            //Se le informa al usuario que la operación ha sido un éxito
            MessageBox.Show("¡Reseña publicada con éxito!", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
