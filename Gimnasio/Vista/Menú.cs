using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gimnasio.Vista;
using Gimnasio.Controlador;
using Gimnasio.Modelo;

namespace Gimnasio
{
    public partial class Menu : Form
    {

        private PersonaController controlador;

        public Menu()
        {
            InitializeComponent();
            Pantalla();
            Centrarcontroles();
        }



        public void Pantalla(){

            this.KeyPreview = true;
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

        }


        private void Centrarcontroles()
        {
            panel_1.Left = 0;
            panel_1.Top = 0;


            panel_botones.Left = (this.ClientSize.Width - panel_botones.Width) / 2;
            panel_botones.Top = (this.ClientSize.Height - panel_botones.Height) / 2;

            panel_2.Left = 0;
            panel_2.Top = (this.ClientSize.Height - panel_2.Height+220);

            panel_3.Left = (this.ClientSize.Width - panel_3.Width+50);
            panel_3.Top = 0;

            panel_4.Left = (this.ClientSize.Width - panel_4.Width+40);
            panel_4.Top = (this.ClientSize.Height - panel_4.Height+220);

            label1.Left = (this.ClientSize.Width - label1.Width) / 2;
            label1.Top = 50;

          

        }




        // Eventos con el mouse

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

        private void menu_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void menu_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space)
            {

                e.SuppressKeyPress = true;
            }


        }



        private void button1_Paint(object sender, PaintEventArgs e)
        {
            // Dibujar un borde rojo alrededor del botón
            Button btn = sender as Button;
            Pen pen = new Pen(System.Drawing.Color.Black, 8); // Cambia 'Red' por el color que desees, y el segundo parámetro es el grosor

            // Obtener el área del botón para dibujar el borde
            Rectangle rect = new Rectangle(0, 0, btn.Width, btn.Height);

            // Dibujar el rectángulo del borde
            e.Graphics.DrawRectangle(pen, rect);

            // Liberar el objeto Pen
            pen.Dispose();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            controlador = new PersonaController();

            controlador.GuardarPersonas(controlador.ObtenerPersonas());

            this.Close();
        }

        private void gestionar_Click(object sender, EventArgs e)
        {
            Gestionar_Persona obj = new Gestionar_Persona();
            obj.Show();
        }

        private void pagos_Click(object sender, EventArgs e)
        {
            controlador = new PersonaController();
            if (controlador.PersonasPaganHoy().Count == 0)
            {
                MessageBox.Show("Nadie debe pagar hoy");

            }

            else
            {

                Pagos_Día obj = new Pagos_Día();
                obj.Show();

            }



        }

       

       

    }
}
