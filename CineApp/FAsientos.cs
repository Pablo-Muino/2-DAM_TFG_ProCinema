using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAD;
using CAD.DSCineTableAdapters;
using Negocio;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Net;
using System.Net.Mail;

namespace CineApp
{
    public partial class FAsientos : Form
    {
        /**
         * Variables de la clase:
         * usuario - Usuario que se ha loggeado en la aplicación
         * pelicula - Pelicula seleccionada por el usuario en la cartelera
         * sesion - Sesion que escogerá el usuario al introducir la fecha y la hora de inicio
         * asiento - Asiento de la sala del que se comprobará después su estado
         * asientos - Lista de asientos de una sala
         * sesionAsiento - El asiento de la sala ya asociado a la sesión que ha elegido el usuario
         * estadoAAsiento - Estado del asiento en esa sesión
         * asientosSeleccionados - Lista de asientos seleccionados en la sala
         * inhabilitado - Establece si el asiento seleccionado está habilitado o no
         */
        private Usuario usuario;
        private Pelicula pelicula;
        private Sesion sesion;
        private Asiento asiento;
        private List<Asiento> asientos;
        private SesionAsiento sesionAsiento;
        private EstadoAsiento estadoAsiento;
        private List<Asiento> asientosSeleccionados = new List<Asiento>();
        private Cupon cupon;
        private bool inhabilitado;

        /**
         * Constructor de la clase
         * _usuario - El usuario que se ha loggeado en la aplicación
         * _pelicula - La película que haya seleccionado el usuario en la cartelera
         * _cupon - El cupón que haya seleccionado el usuario para canjear en su proxima reserva
         */
        public FAsientos(Usuario _usuario, Pelicula _pelicula, Cupon _cupon)
        {
            InitializeComponent();

            //Se establece que el usuario que ha entrado con sus credenciales sea el usuario loggeado
            this.usuario = _usuario;

            //Se establece que la pelicula que se ha seleccionado sea la pelicula con la que se va a trabajar
            this.pelicula = _pelicula;

            //Se establece que el cupón que se ha seleccionado sea el cupón con la que se va a trabajar
            this.cupon = _cupon;
        }

        /**
         * Evento que se lanza al cargar el formulario
         */
        private void FAsientos_Load(object sender, EventArgs e)
        {
            //Al iniciar el formulario se mostrará el nombre del usuario loggeado
            lblUsuarioLog.Text = "Usuario loggeado: " + usuario.Nombre;

            //Se rellena el txtTitulo con el título de la película seleccionada anteriormente
            txtTitulo.Text = pelicula.Titulo;

            //Se obtienen las sesiones para la película seleccionada mediante su Id
            List<Sesion> sesiones = NSesiones.obtenerSesionesIdPelicula(dsCine1, pelicula.Id);

            //Se puebla el cmbFecha con las fechas asociadas a esa peliícula (en caso de haber repetidas sólo saldría una vez)
            List<DateTime> fechasUnicas = sesiones.Select(s => s.Fecha.Date).Distinct().ToList();
            cmbFecha.DataSource = fechasUnicas;

            //Se puebla el comboBox de cmbHoraInicio indicando que el origen sea su tabla (Sesiones)
            cmbHoraInicio.DataSource = bsSesiones;
            cmbHoraInicio.DisplayMember = "HoraInicio";
            cmbHoraInicio.ValueMember = "HoraInicio";
        }

        /**
         * Evento que se dispara al seleccionar una opción del cmbFecha
         */
        private void cmbFecha_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFecha.SelectedValue == null) return;

            //En caso de que no sea null se puebla el cmbHoraInicio con las sesiones que concuerden con la película y fecha seleccionadas (también sin recursividad)
            List<Sesion> sesiones = NSesiones.obtenerSesionesIdPeliculaFecha(dsCine1, pelicula.Id, (DateTime)cmbFecha.SelectedValue);
            List<TimeSpan> horasInicioUnicas = sesiones.Select(s => s.HoraInicio).Distinct().ToList();
            cmbHoraInicio.DataSource = horasInicioUnicas;
        }

        /**
         * Evento que se dispara al darle al botón btnIntroducirDatos
         */
        private void btnIntroducirDatos_Click(object sender, EventArgs e)
        {
            //Para evitar el parpadeo que se genera cuando el sistema carga cada una de las imágenes de los asientos se establece que se carguen internamente
            SuspendDrawing(this.Handle);

            //Se habilita el groupBox con los datos finales de la reserva
            gbInfoReserva.Enabled = true;

            //Se rellena el txtCorreo con el correo del usuario loggeado
            txtCorreo.Text = usuario.Correo;

            //Se cargan los asientos de la sesión
            CargarAsientos();

            //Se limpian los campos txtNumAsientos y txtPrecio por si acaso hubieran ya datos en ellos
            txtNumAsientos.Clear();
            txtPrecio.Clear();

            //Cuando se terminen de cargas las imágenes se actualiza de una sola vez
            ResumeDrawing(this.Handle);
            this.Refresh();
            this.Update();
        }

        /**
         * Método que carga los asientos de la sesión escogida por el usuario (habiendo escogido película, fecha y hora de inicio)
         */
        private void CargarAsientos()
        {
            //Se obtiene la sesión mediante el Id de la película seleccionada, la fecha seleccionada y la hora de inicio seleccionada
            sesion = NSesiones.obtenerSesionIdPeliculaFechaHoraInicio(dsCine1, pelicula.Id, (DateTime)cmbFecha.SelectedValue, (TimeSpan)cmbHoraInicio.SelectedValue);

            //En caso de no encontrar dicha sesión se le avisa al usuario
            if (sesion == null)
            {
                MessageBox.Show("No se encontró una sesión con los datos ingresados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Se obtienen los asientos de la sesión mediante el Id de la sala donde se hará la misma
            Console.WriteLine($"Sesión: {sesion.Id}");
            asientos = NAsientos.obtenerListaAsientosSala(dsCine1, sesion.IdSala);

            //Se muestran los asientos recogidos en formato de tabla
            MostrarAsientos();
        }

        /**
         * Método que muestra los asientos de una sesión en formato de tabla
         */
        private void MostrarAsientos()
        {
            //Se creará la tabla automáticamente cada vez que se inicie el formulario y su tamaño dependerá de los asientos que haya en la lista listaAsientos
            //Para conseguir esto primero se debe de borrar todos los controles, filas y columnas de la tabla para evitar duplicaciones
            tblAsientos.Controls.Clear();
            tblAsientos.RowStyles.Clear();
            tblAsientos.ColumnStyles.Clear();

            //Se recoge el número de asientos de la lista
            int totalAsientos = asientos.Count;

            //Se establece que hayan 10 columnas (para que sea más visible)
            int columnas = 10;

            //Se establece que el número de filas sea el total de asientos entre las columnas redondeando hacia arriba
            int filas = (int)Math.Ceiling((double)totalAsientos / columnas);

            //Se establecen el número de columnas y filas recien calculados a las propiedades respectivas en la tabla
            tblAsientos.RowCount = filas;
            tblAsientos.ColumnCount = columnas;

            //Se distribuye cada columna de manera equitativa, ocupando un 10% del ancho
            for (int i = 0; i < columnas; i++)
            {
                tblAsientos.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / filas));
                tblAsientos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / columnas));
            }

            //Variable que guarda la posición del asiento que se esté iterando
            int indice = 0;

            //Se itera por filas y columnas para añadir los asientos a la tabla
            for (int fila = 0; fila < filas; fila++)
            {
                //Se establece que la fila ocupe lo que ocupe el contenido de la misma
                tblAsientos.RowStyles.Add(new RowStyle(SizeType.AutoSize));

                for (int columna = 0; columna < columnas; columna++)
                {
                    //Si ya se han mostrado todos los asientos se sale del bucle
                    if (indice >= totalAsientos) break;

                    //Se guarda el asiento que se esté iterando
                    asiento = asientos[indice];

                    //Se obtiene el asiento actual de la sesión mediante el Id de la sesión y el Id del asiento
                    sesionAsiento = NSesionAsientos.obtenerSesionAsientosSesionAsiento(dsCine1, sesion.Id, asiento.Id);

                    if (sesionAsiento == null)
                    {
                        Console.WriteLine($"⚠️ No se encontró sesionAsiento para Sesion ID: {sesion.Id}, Asiento ID: {asiento.Id}");
                    }

                    //Se obtiene el estado del asiento actual de la sesión mediante el Id de estado del asiento en la sesión
                    estadoAsiento = (sesionAsiento != null) ? NEstadoAsientos.obtenerEstadosAsientoId(dsCine1, sesionAsiento.IdEstado) : null;

                    //Se declara el color de fondo del panel dependiendo del estado del asiento en la sesión y de si está habilitado o no
                    inhabilitado = asiento.Inhabilitado;
                    Color colorFondo = estadoAsiento != null ? ObtenerColorFondo(estadoAsiento, inhabilitado) : Color.Gray;

                    //Se crea el panel que contendrá la imagen del asiento
                    Panel panel = new Panel
                    {
                        //Color de fondo inicial (antes de que se le de clic)
                        BackColor = colorFondo,
                        Dock = DockStyle.Fill,
                        Padding = new Padding(0),
                        Margin = new Padding(2),
                        BorderStyle = BorderStyle.FixedSingle,
                        Size = new Size(50, 75)
                    };

                    //Se crea el PictureBox donde irá la imágen del asiento
                    PictureBox imgAsiento = new PictureBox
                    {
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Dock = DockStyle.Fill,

                        //Se establece que el tag sea el asiento q se esté iterando para poder referenciarlo en un futuro
                        Tag = asiento
                    };

                    try
                    {
                        //Se intenta adjuntar la imágen del asiento al PictureBox
                        imgAsiento.Image = Properties.Resources.asiento;
                    }
                    catch
                    {
                        //Si falla esa imagen se usa una imagen predeterminada
                        imgAsiento.Image = Properties.Resources.predeterminada;
                    }

                    //Se asocia el evento Asiento_Click para que al hacer clic en el asiento, éste se seleccione
                    imgAsiento.Click += (s, e) => Asiento_Click(s, e, panel);

                    //Se añade la imagen al panel y éste, a la tabla en la fila y columna correspondiente (la que se esté iterando)
                    panel.Controls.Add(imgAsiento);
                    tblAsientos.Controls.Add(panel, columna, fila);

                    //Se pasa al siguiente asiento
                    indice++;
                }
            }
           
        }

        /**
         * Evento que se dispara aal dar clic sobre el panel de un asiento
         * panelActual - Panel al que se le acaba de dar clic
         */
        private void Asiento_Click(object sender, EventArgs e, Panel panelActual)
        {
            //Se recupera el asiento almacenado en Tag cuando se creó el PictureBox y, si coincide con el asiento seleccionado se sigue
            if (sender is PictureBox imgAsiento && imgAsiento.Tag is Asiento asientoSeleccionado)
            {
                //Se vuelven a obtener el asiento de esa sesión y su respectivo estado
                sesionAsiento = NSesionAsientos.obtenerSesionAsientosSesionAsiento(dsCine1, sesion.Id, asientoSeleccionado.Id);
                estadoAsiento = (sesionAsiento != null) ? NEstadoAsientos.obtenerEstadosAsientoId(dsCine1, sesionAsiento.IdEstado) : null;

                //Si el asiento está ocupado, reservado o inhabilitado se le notifica al usuario
                if (estadoAsiento != null && (estadoAsiento.Estado.Equals("Ocupado") || estadoAsiento.Estado.Equals("Reservado")) || asientoSeleccionado.Inhabilitado == true)
                {
                    MessageBox.Show("Este asiento no está disponible para su selección.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //Si el asiento que el usuario quiere seleccionar ya estaba seleccionado, se deselecciona y se cambia su color dependiendo de su estado y de si está habilitado o no
                if (asientosSeleccionados.Contains(asientoSeleccionado))
                {
                    asientosSeleccionados.Remove(asientoSeleccionado);
                    panelActual.BackColor = ObtenerColorFondo(estadoAsiento, inhabilitado);
                }
                else
                {
                    //Si no, se añade ese asiento a la lista de los seleccionados y se cambia su color de fondo para indicarlo
                    asientosSeleccionados.Add(asientoSeleccionado);
                    panelActual.BackColor = Color.LightBlue;
                }

                //Se actualiza la información de la reserva
                ActualizarInfoReserva();
            }
        }

        /**
         * Método que actualiza los campos de la información de la reserva
         */
        private void ActualizarInfoReserva()
        {
            //Se rellenan los campos txtNumAsientos con el número de asientos seleccionados y txtPrecio con el precio de dichos asientos (5€ por asiento)
            int numAsientos = asientosSeleccionados.Count;
            int precioTotal = numAsientos * 5;

            txtNumAsientos.Text = numAsientos.ToString();
            txtPrecio.Text = precioTotal.ToString() + " €";
        }

        /**
         * Método que obtiene el color de fondo del panel de un asiento dependiendo del estado del mismo
         */
        private Color ObtenerColorFondo(EstadoAsiento estadoAsiento, bool inhabilitado)
        {
            if (inhabilitado)
            {
                return Color.Black;
            } else
            {
                switch (estadoAsiento.Estado)
                {
                    case "Disponible":
                        return Color.Green;
                    case "Ocupado":
                        return Color.Red;
                    case "Reservado":
                        return Color.Orange;
                    default:
                        return Color.Gray;
                }
            }
        }

        /**
         * Evento que se dispara al dar clic sobre el botón btnReservar
         */
        private void btnReservar_Click(object sender, EventArgs e)
        {
            //Si no hay asientos seleccionados se la avisa al usuario
            if (asientosSeleccionados.Count == 0)
            {
                MessageBox.Show("No has seleccionado ningún asiento.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Se le pide al usuario que confirme los datos antes de realizar la reserva
            DialogResult result = MessageBox.Show($"Antes de realizar la reserva confirme los siguientes datos:\n" +
                                                  $"Nº entradas: {asientosSeleccionados.Count} entradas\n" +
                                                  $"Cupón canjeado: {(cupon != null ? cupon.Descripcion : "Ninguno")}\n" +
                                                  $"Correo asociado a la reserva: {usuario.Correo}\n" +
                                                  $"Fecha de la reserva: {DateTime.Now}", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //Si el usuario dice que si se procede a realizar la reserva/s
            if (result == DialogResult.Yes)
            {
                //Si el usuario ha canjeado un cupón que permita que 5 asientos sean gratis y reserva menos se le avisará para que aproveche este cupón a su máximo
                if (cupon != null && cupon.Descripcion.Contains("5") && asientosSeleccionados.Count < 5)
                {
                    MessageBox.Show("Se están reservando menos asientos de los que el cupón puede llegar a permitir. Por favor, reserve tantos asientos como le ofrece el cupón que ha canjeado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //Se realizan las reservas
                foreach (Asiento asiento in asientosSeleccionados)
                {
                    try
                    {
                        //Por cada asiento seleccionado se crea una nueva reserva y se actualiza el estado de los mismos
                        NReservas.agregarReserva(dsCine1, usuario, sesion, asiento, cupon);
                        ActualizarEstadoAsientos(asiento, "Reservado");

                        //Se intenta mandar un correo con los datos de la reserva al usuario, en caso contrario se le avisa
                        try
                        {
                            //Primero se genera el pdf con los datos de la reserva
                            string pdf = GenerarPDFReserva(usuario, asientosSeleccionados, cupon, NSalas.obtenerSalaId(dsCine1, sesion.IdSala));

                            //Y una vez creado el pdf se le manda al usuario
                            EnviarCorreoConPDF(usuario.Correo, pdf);

                            MessageBox.Show("Se ha enviado un correo con los detalles de tu reserva.", "Correo Enviado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Reserva realizada, pero no se pudo enviar el correo: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al realizar la reserva: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            } else
            {
                return;
            }

            //En caso de éxito en la realización de la reserva se le indica al usuario
            MessageBox.Show("Reserva realizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Se refrescan los datos de la sesión antes de mostrar los asientos
            NSesionAsientos.obtenerSesionAsientos(dsCine1);

            //Se limpian los asientos seleccionados, se actualizan los datos de la reserva y se vuelven a mostrar los asientos ya actualizados
            asientosSeleccionados.Clear();
            ActualizarInfoReserva();
            MostrarAsientos();
        }

        /**
         * Método que actualiza el estado de un asiento
         * asiento - Asiento que ha seleccionado el usuario para reservar
         * nuevoEstado - Estado al que pasará estar este asiento
         */
        private void ActualizarEstadoAsientos(Asiento asiento, string nuevoEstado)
        {
            try
            {
                //Se obtiene el asiento de la sesión mediante el Id de la sesión y del asiento
                SesionAsiento sesionAsiento = NSesionAsientos.obtenerSesionAsientosSesionAsiento(dsCine1, sesion.Id, asiento.Id);

                if (sesionAsiento == null)
                {
                    //Si no se encuentra se le indica al usuario
                    MessageBox.Show("Error: No se encontró el asiento en la sesión.");
                    return;
                }

                //Se obtiene el nuevo estado mediante su nombre
                EstadoAsiento estado = NEstadoAsientos.obtenerEstadosAsientoNombre(dsCine1, nuevoEstado);
                if (estado == null)
                {
                    //Si no se encuentra se le indica al usuario
                    MessageBox.Show("Error: No se encontró el estado '" + nuevoEstado + "'.");
                    return;
                }

                //Se recoge el registro asociado al Id del asiento en la sesión
                var filaAsiento = dsCine1.SesionAsientos.FindById(sesionAsiento.Id);

                if (filaAsiento != null)
                {
                    //Si no es null se le cambia el estado al nuevo
                    filaAsiento.IdEstado = estado.Id;

                    //Se guardan los cambios en la tabla
                    NSesionAsientos.actualizarSesionAsientos(dsCine1);

                    //Se vuelve a cargar los datos de la tabla SesionAsientos y se vuele a recoger (ya con el estado cambiado) el asiento de la sesión
                    NSesionAsientos.obtenerSesionAsientos(dsCine1);
                    sesionAsiento = NSesionAsientos.obtenerSesionAsientosSesionAsiento(dsCine1, sesion.Id, asiento.Id);
                }
                else
                {
                    //En caso contrario se le indica al usuario
                    MessageBox.Show("Error: No se encontró la fila del asiento en el DataSet.");
                }
            }
            catch (Exception ex)
            {
                //En caso de no encontrar el asiento de la sesión se le advierte al usuarios
                MessageBox.Show("Error al actualizar el estado del asiento: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /**
         * Método que genera un rchivo pdf con los datos de la reserva realizada por el usuario
         * usuario - Usuario el cual ha realizado la reserva
         * asientos - Los asientos que el usuario ha seleccionado para reservar
         * cupon - Cupón que el usuario ha canjeado para su proxima reserva (null si no ha seleccionado ninguno)
         * sala - Sala donde se encuentran los asientos reservados por el usuario
         */
        private string GenerarPDFReserva(Usuario usuario, List<Asiento> asientos, Cupon cupon, Sala sala)
        {
            //Se crea la ruta del archivo pdf
            string nombreArchivo = Path.Combine(Path.GetTempPath(), $"reserva_{Guid.NewGuid()}.pdf");

            //Se crea el documento y se abre
            Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream(nombreArchivo, FileMode.Create));
            doc.Open();

            //Se le añaden los datos de la reserva
            doc.Add(new Paragraph("Confirmación de Reserva de Cine"));
            doc.Add(new Paragraph($"\nFecha de Reserva: {DateTime.Now}"));
            doc.Add(new Paragraph($"Correo del Usuario: {usuario.Correo}"));
            doc.Add(new Paragraph($"Cupón Canjeado: {(cupon != null ? cupon.Descripcion : "Ninguno")}"));
            doc.Add(new Paragraph($"Número de Entradas: {asientos.Count}"));
            doc.Add(new Paragraph($"\nSala: {sala.Nombre}"));
            doc.Add(new Paragraph("Detalles de Asientos:"));

            foreach (var asiento in asientos)
            {
                doc.Add(new Paragraph($"- Fila: {asiento.NumFila}, Número: {asiento.NumColumna}"));
            }

            //Se cierra el documento una vez acabados de introducir los datos y se devuelve
            doc.Close();
            return nombreArchivo;
        }

        /**
         * Método que manda el pdf de la reserva al usuario
         * destinatario - Correo del usuario donde a donde se mandará el pdf
         * rutaPDF - Ruta del pdf a mandar
         */
        private void EnviarCorreoConPDF(string destinatario, string rutaPDF)
        {
            //Se crea el mensaje de correo y se especifican los detalles del mismo (procedencia, destinatario, asunto y cuerpo)
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("procinemareservas@gmail.com");
            mail.To.Add(destinatario);
            mail.Subject = "Confirmación de tu reserva de cine";
            mail.Body = "Adjunto encontrarás el comprobante en PDF de tu reserva.";

            //Se le adjunta el pdf creado anteriormente
            Attachment pdfAdjunto = new Attachment(rutaPDF);
            mail.Attachments.Add(pdfAdjunto);

            //Se crea un cliente SMTP apuntando al servidor de gmail usando el puerto 587 (el puerto estandar)
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);

            //Se establecen las credenciales de autenticación para iniciar sesión en la cuenta de gmail proveedor del pdf
            smtp.Credentials = new NetworkCredential("procinemareservas@gmail.com", "qprv udtt rdhq zbkz");
            smtp.EnableSsl = true;

            //Por último se manda el correo
            smtp.Send(mail);
        }

        //Se importa la función SendMessage de la API de Windows
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr wnd, int msg, bool param, int lparam);

        public static int WM_SETREDRAW = 0x000B;

        /**
         * Método que suspende el Redibujo del control
         */
        public static void SuspendDrawing(IntPtr handle)
        {
            SendMessage(handle, WM_SETREDRAW, false, 0);
        }

        /**
         * Método que habilita el redibujo del control
         */
        public static void ResumeDrawing(IntPtr handle)
        {
            SendMessage(handle, WM_SETREDRAW, true, 0);
        }
    }
}
