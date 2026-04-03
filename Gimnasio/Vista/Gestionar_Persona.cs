using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Controls;
using System.Drawing.Imaging;
using Gimnasio.Controlador;
using Gimnasio.Modelo;



namespace Gimnasio.Vista
{
    public partial class Gestionar_Persona : Form
    {

        private PersonaController controller;

        // Cámara y foto

        bool cámara=false;
        VideoCaptureDevice videoSource;
        VideoSourcePlayer videoSourcePlayer;
        Image frameActual;
        System.Windows.Forms.PictureBox Foto_final = new System.Windows.Forms.PictureBox();
     

        public Gestionar_Persona()
        {
           
            controller = new PersonaController();
            InitializeComponent();
            CentrarControles();
           
            
          

            Pantalla();
         
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                Validar_Datos();

                Persona persona = new Persona
                {
                    Id = (txtID.Text),
                    Nombre = txtNombre.Text,
                    Edad = int.Parse(txtEdad.Text),
                    Sexo = sexo.Text,
                    Estatura = float.Parse(txtEstatura.Text),
                    Peso = float.Parse(txtPeso.Text),
                    Color = color.Text,
                    Teléfono = txtTelefono.Text,
                    Dirección = txtDireccion.Text,
                    FechaRegistro = fecha_pago.Value.Date,
                    PróximoPago = fecha_pago.Value.Date.AddMonths(1),
                    ImagenBase64 = controller.ConvertirImagenABase64(Foto_final.Image),
                };



                controller.AgregarPersona(persona);

                VaciarCampos();

                CargarTabla();


                if (controller.ObtenerPersonas().Count == 1)
                {
                    controller.GuardarPersonas(controller.ObtenerPersonas());

                    Gestionar_Persona obj = new Gestionar_Persona();
                    obj.Show();
                    this.Close();

                }


               

                this.Controls.Remove(Foto_final);
                panel_vistaPrevia.Visible = true;
                capturar.Visible = false;
                abrir_cámara.Visible = true;


            }


                

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }



        public void CargarTabla()
        {
            controller.EstablecerImágenes();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = controller.ObtenerPersonas();

            AjustarTabla();
            
            dataGridView1.ClearSelection();
            dataGridView1.Refresh();
            
            

                   }


        public void AjustarTabla()
        {

            foreach (DataGridViewRow rows in dataGridView1.Rows)
            {
                rows.Height = 100;
            }

            ((DataGridViewImageColumn)dataGridView1.Columns["Imagen"]).ImageLayout = DataGridViewImageCellLayout.Zoom;

        }




        public void Validar_Datos()
        {


            Control[] controles = { txtID, txtNombre, txtEdad, sexo, txtEstatura,  txtPeso,color, txtTelefono, txtDireccion };

            foreach (var control in controles)
            {

                if (string.IsNullOrEmpty(control.Text))
                {
                    throw new Exception("Uno o más campos están vacíos");
                }

                

            }




            // Validación ID

            if (txtID.Text.Length < 5)
            {

                throw new Exception("El ID debe tener exactamente 5 dígitos");
              

            }


            // Validación Nombre


            if (txtNombre.Text.Length < 5)
            {

                throw new Exception("Nombre demasiado corto");

            }


            // Validación Edad


            if (int.Parse(txtEdad.Text) < 16)
            {

                throw new Exception("La edad mínima es 16");
              

            }



            else if (int.Parse(txtEdad.Text) > 120)
            {

                throw new Exception("Edad no válida");
              

            }




            // Validación Estatura


            if (float.Parse(txtEstatura.Text) < 1.40)
            {

                throw new Exception("Estatura no válida");

            }



            else if(float.Parse(txtEstatura.Text)>2.50){

                throw new Exception("Estatura no válida");

            }




            // Validación Peso


            if (float.Parse(txtPeso.Text) < 40)
            {

                throw new Exception("Peso no válido");

            }



            else if (float.Parse(txtPeso.Text) > 250)
            {

                throw new Exception("Peso no válido");

            }



            // Validación Teléfono


            int contador = 0;

            foreach (char c in txtTelefono.Text)
            {

                if (char.IsDigit(c))
                {
                    contador++;
                }


            }

            if (contador != 10)
            {
                throw new Exception("El número de teléfono debe tener exactamente 10 dígitos");

            }



            // Validación Dirección


            if (txtDireccion.Text.Length < 4)
            {

                throw new Exception("Dirección no válida");

            }



            // Validación Fecha


            if (fecha_pago.Value.DayOfYear > DateTime.Today.DayOfYear)
            {

                throw new Exception("Fecha de registro incorrecta");
            }



            // Validación Foto

            if (!this.Controls.Contains(Foto_final))
            {
                throw new Exception("No has capturado la foto");
            }


        }


        public void VaciarCampos()
        {

            Control[] controles = { txtID, txtNombre, txtEdad, sexo, txtEstatura, txtPeso, color, txtTelefono, txtDireccion,panel_vistaPrevia };

            foreach (var control in controles)
            {

                if (control is TextBox)
                {
                    (control as TextBox).Clear();
                }

                else if (control is ComboBox)
                {

                    (control as ComboBox).SelectedIndex = -1;
                }

                else if (control is Panel)
                {
                    (control as Panel).BackgroundImage = null;

                }


            }

            if (this.Controls.Contains(Foto_final))
            {
                this.Controls.Remove(Foto_final);

            }
            abrir_cámara.Visible = true;
            capturar.Visible = false;

        }



        private void Abrir_Cámara_Click(object sender, EventArgs e)
        {

            cámara = true;

            if (this.Controls.Contains(Foto_final))
            {
                this.Controls.Remove(Foto_final);
            }

            if (panel_vistaPrevia.Visible == false)
            {
                panel_vistaPrevia.Visible = true;
            }

            panel_vistaPrevia.Controls.Remove(videoSourcePlayer);
            

             StartCamera();
             abrir_cámara.Visible = false;
             capturar.Visible = true;

          
            
        }



        public void Pantalla()
        {

            this.KeyPreview = true;
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

        }


        private void CentrarControles()
        {
           

            salir.Left = (this.ClientSize.Width - salir.Width+20);
            salir.Top = (this.ClientSize.Height - salir.Height+180);

            vaciar.Left = 20;
            vaciar.Top = (this.ClientSize.Height - vaciar.Height + 180);


            CentrarBotonesEnPanel(panel_botones, Agregar, eliminar, Modificar, Cancelar);

            guardar_cambios.Location = Agregar.Location;
        }



       



        private void menu_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void menu_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter )
            {

                e.SuppressKeyPress = true;
            }


        }

        private void salir_Click(object sender, EventArgs e)
        {
            if (cámara == true)
            {
                DetenerCámara();

            }
            controller.GuardarPersonas(controller.ObtenerPersonas());
            this.Close();
        }

        private void vaciar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Deseas eliminar todos los datos?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


            if (result == DialogResult.Yes)
            {

                controller.VaciarLista();
                CargarTabla();


            }

        }


        private void Gestionar_Persona_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }




        private void eliminar_Click_1(object sender, EventArgs e)
        {

            try
            {

                if (dataGridView1.SelectedRows.Count > 0)  // Verifica si hay una fila seleccionada
                {
                    // Obtener la fila seleccionada
                    DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];

                    // Obtener el objeto asociado a esa fila (si estás usando BindingSource o una lista)
                    Persona personaSeleccionada = (Persona)filaSeleccionada.DataBoundItem;



                    DialogResult result = MessageBox.Show("¿Deseas eliminar a la persona?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


                    if (result == DialogResult.Yes)
                    {

                        controller.EliminarPersona(personaSeleccionada);
                        CargarTabla();


                    }

                }
                else
                {
                    throw new Exception("No hay ninguna persona seleccionada.");
                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }



        }

        private void Modificar_Click(object sender, EventArgs e)
        {

            try
    {
        // Verifica si hay una fila seleccionada en el DataGridView
        if (dataGridView1.SelectedRows.Count > 0)
        {
           panel_vistaPrevia.Visible = false;
           Agregar.Visible=false;
           guardar_cambios.Visible=true;

            // Obtén la fila seleccionada
            DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];

            // Carga los datos de la fila seleccionada en los campos del formulario
            txtID.Text = filaSeleccionada.Cells["Id"].Value.ToString();
            txtNombre.Text = filaSeleccionada.Cells["Nombre"].Value.ToString();
            txtEdad.Text = filaSeleccionada.Cells["Edad"].Value.ToString();
            sexo.Text = filaSeleccionada.Cells["Sexo"].Value.ToString();
            txtEstatura.Text = filaSeleccionada.Cells["Estatura"].Value.ToString();
            txtPeso.Text = filaSeleccionada.Cells["Peso"].Value.ToString();
            color.Text = filaSeleccionada.Cells["Color"].Value.ToString();
            txtTelefono.Text = filaSeleccionada.Cells["Teléfono"].Value.ToString();
            txtDireccion.Text = filaSeleccionada.Cells["Dirección"].Value.ToString();
            fecha_pago.Value = DateTime.Parse(filaSeleccionada.Cells["FechaRegistro"].Value.ToString());

            CrearPictureBox();

            Foto_final.Image = RedimensionarImagen((Image)filaSeleccionada.Cells["Imagen"].Value, 200, 200);
        }
        else
        {
            MessageBox.Show("Selecciona una persona para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}

        private void guardar_cambios_Click(object sender, EventArgs e)
        {
            try
            {

                // Verifica si hay una fila seleccionada
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    // Obtener la fila seleccionada
                    DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];


                    Validar_Datos();


                    // Modificar los datos de objeto 

                    Persona personaModificada = (Persona)filaSeleccionada.DataBoundItem;

                    personaModificada.Id = txtID.Text;
                    personaModificada.Nombre = txtNombre.Text;
                    personaModificada.Edad = int.Parse(txtEdad.Text);
                    personaModificada.Sexo = sexo.Text;
                    personaModificada.Estatura = float.Parse(txtEstatura.Text);
                    personaModificada.Peso = float.Parse(txtPeso.Text);
                    personaModificada.Color = color.Text;
                    personaModificada.Teléfono = txtTelefono.Text;
                    personaModificada.Dirección = txtDireccion.Text;
                    personaModificada.FechaRegistro = fecha_pago.Value;
                    personaModificada.PróximoPago = fecha_pago.Value.AddMonths(1);
                    personaModificada.Imagen = Foto_final.Image;

                    // Actualizar la tabla

                    controller.ModificarPersona(personaModificada);
                    VaciarCampos();
                    CargarTabla();

                    guardar_cambios.Visible = false;
                    Agregar.Visible = true;


                    panel_vistaPrevia.Visible = true;

                   

                }
                else
                {
                    MessageBox.Show("Selecciona una persona para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

    
}

        private void Cancelar_Click(object sender, EventArgs e)
        {
            if (cámara == true)
            {
                DetenerCámara();

            }

            if (this.Controls.Contains(Foto_final))
            {
                this.Controls.Remove(Foto_final);

            }


            if (panel_vistaPrevia.Visible == false)
            {
                panel_vistaPrevia.Visible = true;

            }

            
            VaciarCampos();
            guardar_cambios.Visible = false;
            Agregar.Visible = true;


    dataGridView1.ClearSelection();
}



        

        // Acciones que se realizan mientras el usuario teclea

private void txtTelefono_TextChanged(object sender, EventArgs e)
{
    // Almacenar la posición del cursor para restaurarla después de aplicar el formato
    int cursorPos = txtTelefono.SelectionStart;



     // Validar que solo se permitan números
    foreach (char c in txtTelefono.Text)
    {
        if (!char.IsDigit(c) && c != '(' && c != ')' && c != ' ' && c != '-')
        {
            // Si se encuentra un carácter no numérico, lanzar una excepción o mostrar un mensaje
            MessageBox.Show("Por favor, introduce solo números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtTelefono.Text = txtTelefono.Text.Remove(cursorPos - 1, 1);
            txtTelefono.SelectionStart = cursorPos - 1;
            return;
        }


    }


   
    // Quitar todos los caracteres no numéricos antes de aplicar el formato
    string numero = txtTelefono.Text.Replace("(", "")
                                    .Replace(")", "")
                                    .Replace(" ", "")
                                    .Replace("-", "");



    if (numero.Length > 10)
    {

        MessageBox.Show("El número de teléfono debe tener exactamente 10 dígitos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        numero=numero.Substring(0, 10);

    }


    // Validar el código de área (primer dígito debe ser entre 2 y 9)
    if (numero.Length >= 3 && (numero[0] < '2' || numero[0] > '9'))
    {
        MessageBox.Show("El código de área debe empezar con un dígito entre 2 y 9.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        txtTelefono.Clear(); // Reiniciar el número si no es válido

        return;
    }

    // Validar el prefijo (primer dígito del prefijo también debe ser entre 2 y 9)
    else if (numero.Length >= 6 && (numero[3] < '2' || numero[3] > '9'))
    {
        MessageBox.Show("El prefijo debe empezar con un dígito entre 2 y 9.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        numero = numero.Substring(0, 3); // Mantener solo el código de área válido
    }




    // Aplicar el formato de teléfono solo si el número tiene más de 3 dígitos
    if (numero.Length >= 1)
    {
        if (numero.Length > 3 && numero.Length <= 6)
        {
            // Formato: (123) 456
            txtTelefono.Text = "("+numero.Substring(0, 3)+") "+numero.Substring(3);
        }
        else if (numero.Length > 6)
        {
            // Formato: (123) 456-7890
            txtTelefono.Text = "("+numero.Substring(0, 3)+") "+numero.Substring(3, 3) +"-"+numero.Substring(6);
        }
        else
        {
            // Formato: (123
            txtTelefono.Text = numero;
        }
    }


    txtTelefono.SelectionStart = txtTelefono.Text.Length;
    txtTelefono.SelectionLength = 0;


    
}

private void txtEdad_TextChanged(object sender, EventArgs e)
{


    foreach (char c in txtEdad.Text)
    {

        if (!char.IsDigit(c))
        {

            MessageBox.Show("Por favor, introduce solo números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtEdad.Clear();
            break;
          

        }



    }


    if (txtEdad.Text.Length > 3)
    {

        MessageBox.Show("Edad no válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        txtEdad.Clear();
    }





}

private void txtID_TextChanged(object sender, EventArgs e)
{

    foreach (char c in txtID.Text)
    {

        if (!char.IsDigit(c))
        {

            MessageBox.Show("Por favor, introduce solo números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtID.Clear();
            break;


        }



    }


    if (txtID.Text.ToString().Length > 5)
    {

        MessageBox.Show("El ID debe tener exactamente 5 dígitos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        txtID.Text = txtID.Text.ToString().Substring(0, 5);
        txtID.SelectionStart = txtID.Text.Length;
    }




}

private void txtNombre_TextChanged(object sender, EventArgs e)
{

    foreach (char c in txtNombre.Text)
    {

        if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
        {

            MessageBox.Show("Por favor, introduce solo letras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtNombre.Clear();
            break;


        }



    }


    if (txtNombre.Text.Length > 70)
    {

        MessageBox.Show("Nombre demasiado largo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        txtNombre.Text = txtNombre.Text.ToString().Substring(0, 70);
        txtNombre.SelectionStart = txtNombre.Text.Length;

    }




}

private void txtEstatura_TextChanged(object sender, EventArgs e)
{

    foreach (char c in txtEstatura.Text)
    {

        if (!char.IsDigit(c) && !char.IsPunctuation(c))
        {

            MessageBox.Show("Por favor, introduce solo números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtEstatura.Clear();
            break;


        }



    }



}

private void txtPeso_TextChanged(object sender, EventArgs e)
{

    foreach (char c in txtPeso.Text)
    {

        if (!char.IsDigit(c) && !char.IsPunctuation(c))
        {

            MessageBox.Show("Por favor, introduce solo números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtEstatura.Clear();
            break;


        }



    }




}


private void txtDireccion_TextChanged(object sender, EventArgs e)
{


    if (txtDireccion.Text.Length > 150)
    {

        MessageBox.Show("Dirección demasiado larga", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        txtDireccion.Text = txtDireccion.Text.Substring(0, 150);
        txtDireccion.SelectionStart = txtDireccion.Text.Length;

    }

}

        

private void txtBuscar_TextChanged(object sender, EventArgs e)
{
    string filtro = txtBuscar.Text.ToLower();
    // Filtramos las personas según lo que escribe el usuario
    var resultados = controller.ObtenerPersonas().Where(p => p.Nombre.ToLower().Contains(filtro)).ToList();
   
    // Actualizamos el DataGridView
    dataGridView1.DataSource = null;
    dataGridView1.DataSource = resultados;
    AjustarTabla();

    
}





        // Eventos sobre botones

private void btnExample_MouseEnter(object sender, EventArgs e)
{
    // Guardar el tamaño original (opcional)
    Button btn = sender as Button;
    btn.Tag = btn.Size;

    // Aumentar el tamaño del botón
    btn.Size = new Size(btn.Width + 10, btn.Height + 10);  // Puedes ajustar el valor como desees
}

private void btnExample_MouseLeave(object sender, EventArgs e)
{
    // Restaurar el tamaño original del botón
    Button btn = sender as Button;
    if (btn.Tag != null)
    {
        btn.Size = (Size)btn.Tag;
    }
}


        // Ordenar, centrar y otras funciones

private void CentrarBotonesEnPanel(Panel panel, Button btn1, Button btn2, Button btn3, Button btn4)
{
    // Tamaño del panel
    int anchoPanel = panel.Width;
    int altoPanel = panel.Height;

    // Tamaño de los botones (suponiendo que todos los botones tienen el mismo tamaño)
    int anchoBoton = btn1.Width;
    int altoBoton = btn1.Height;

    // Espacio horizontal y vertical entre los botones
    int espacioHorizontal = (anchoPanel - (2 * anchoBoton)) / 3;
    int espacioVertical = (altoPanel - (2 * altoBoton)) / 3;

    // Posición de los botones
    // Botón 1 (superior izquierdo)
    btn1.Left = espacioHorizontal;
    btn1.Top = espacioVertical;

    // Botón 2 (superior derecho)
    btn2.Left = btn1.Left + anchoBoton + espacioHorizontal;
    btn2.Top = btn1.Top;

    // Botón 3 (inferior izquierdo)
    btn3.Left = btn1.Left;
    btn3.Top = btn1.Top + altoBoton + espacioVertical;

    // Botón 4 (inferior derecho)
    btn4.Left = btn2.Left;
    btn4.Top = btn3.Top;
}


private void CentrarTextBoxesEnPanel(Panel panel,  int espacioVertical)
{

    Control[] campos = { txtID, txtNombre, txtEdad, sexo, txtEstatura, txtPeso, color, txtTelefono, txtDireccion, fecha_pago };


    // Tamaño del panel
    int anchoPanel = panel.Width;
    int altoPanel = panel.Height;

    // Calcular la altura total de todos los TextBox más el espacio entre ellos
    int altoTotalTextBoxes = (campos.Length * campos.First().Height) + ((campos.Length - 1) * espacioVertical);

    // Posición inicial Y para centrar los TextBox verticalmente en el panel
    int posicionYInicial = (altoPanel / 2) - (altoTotalTextBoxes / 2);

    // Posicionar los TextBox en el panel
    for (int i = 0; i < campos.Length; i++)
    {
        Control c = campos[i];

        // Posición X para centrar el TextBox horizontalmente en el panel
        int posicionX = (anchoPanel / 2) - (c.Width / 2);

        // Ajustar la posición del TextBox
        c.Left = posicionX;
        c.Top = posicionYInicial + (i * (c.Height + espacioVertical));
    }
}



private Image RedimensionarImagen(Image imagenOriginal, int anchoMax, int altoMax)
{
    int ancho = imagenOriginal.Width;
    int alto = imagenOriginal.Height;

    // Calcular las proporciones de la imagen
    if (ancho > anchoMax || alto > altoMax)
    {
        double relacionAncho = (double)anchoMax / ancho;
        double relacionAlto = (double)altoMax / alto;
        double proporcion = Math.Min(relacionAncho, relacionAlto);

        ancho = (int)(ancho * proporcion);
        alto = (int)(alto * proporcion);
    }

    // Crear una nueva imagen redimensionada
    Bitmap imagenRedimensionada = new Bitmap(ancho, alto);
    using (Graphics g = Graphics.FromImage(imagenRedimensionada))
    {
        g.DrawImage(imagenOriginal, 0, 0, ancho, alto);
    }

    return imagenRedimensionada;
}



public void StartCamera()
{
    // Obtener la lista de dispositivos de video (cámaras)
    FilterInfoCollection dispositivosDeVideo = new FilterInfoCollection(FilterCategory.VideoInputDevice);

    if (dispositivosDeVideo.Count > 0)
    {
        // Seleccionar la primera cámara (cámara predeterminada)
        videoSource = new VideoCaptureDevice(dispositivosDeVideo[0].MonikerString);

        // Asignar el VideoSourcePlayer al control del formulario
        videoSourcePlayer = new VideoSourcePlayer();
        videoSourcePlayer.Dock = DockStyle.Fill;
        panel_vistaPrevia.Controls.Add(videoSourcePlayer);  // Añadir el VideoSourcePlayer al panel
        videoSourcePlayer.VideoSource = videoSource;

        // Iniciar la transmisión de video
        videoSourcePlayer.Start();
    }
    else
    {
        MessageBox.Show("No se encontró ninguna cámara.");
    }
}


public void DetenerCámara()
{

 
    if (videoSourcePlayer.VideoSource != null)
    {
        videoSourcePlayer.SignalToStop();  // Detiene la transmisión de la cámara
        videoSourcePlayer.WaitForStop();   // Espera hasta que la cámara se haya detenido completamente
        videoSourcePlayer.VideoSource = null;  // Libera el recurso
    }

    
}


public void CaptarImagen()
{
    if (videoSourcePlayer != null && videoSourcePlayer.IsRunning)
    {
        // Obtener el frame actual
         frameActual = videoSourcePlayer.GetCurrentVideoFrame();

         DetenerCámara();

        if (frameActual != null)
        {
            panel_vistaPrevia.Controls.Remove(videoSourcePlayer);
            panel_vistaPrevia.Visible = false;

            CrearPictureBox();

            Foto_final.Image = (Image)frameActual.Clone();

            
            // Liberar el frame para evitar consumo innecesario de memoria
            frameActual.Dispose();

            capturar.Visible = false;
            abrir_cámara.Visible = true;
            
        }
        else
        {
            MessageBox.Show("No se pudo capturar la imagen.");
        }
    }
}

private void capturar_Click(object sender, EventArgs e)
{

    CaptarImagen();
}


public void CrearPictureBox()
{
    this.Controls.Add(Foto_final);

    Foto_final.Location = panel_vistaPrevia.Location;
    Foto_final.Size = panel_vistaPrevia.Size;
    Foto_final.SizeMode = PictureBoxSizeMode.StretchImage;


}

   

  
}

 
}