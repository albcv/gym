using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gimnasio.Controlador;
using Gimnasio.Modelo;

namespace Gimnasio.Vista
{
    public partial class Pagos_Día : Form
    {

        private PersonaController controlador;


        public Pagos_Día()
        {
            InitializeComponent();
            Pantalla();
            OrdenarControles();
            controlador = new PersonaController();

        }


        public void CargarTabla(){

            controlador.EstablecerImágenes();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource=controlador.PersonasPaganHoy();
            AjustarTabla();
            dataGridView1.ClearSelection();
            dataGridView1.Refresh();


        }

        public void AjustarTabla()
        {

            foreach (DataGridViewRow rows in dataGridView1.Rows)
            {
                rows.Height = 150;
            }

            ((DataGridViewImageColumn)dataGridView1.Columns["Imagen"]).ImageLayout = DataGridViewImageCellLayout.Zoom;

        }




        public void Pantalla()
        {

            this.KeyPreview = true;
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

        }


        private void menu_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void menu_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {

                e.SuppressKeyPress = true;
            }


        }



        private void OrdenarControles()
        {


            salir.Left = (this.ClientSize.Width - salir.Width - 20);
            salir.Top = (this.ClientSize.Height - salir.Height - 20);

            
             dataGridView1.Left = (this.ClientSize.Width -  dataGridView1.Width)/2;
             dataGridView1.Top = (this.ClientSize.Height -  dataGridView1.Height)/2;

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




        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Pagos_Día_Load(object sender, EventArgs e)
        {
            CargarTabla();

        }

        private void Pagos_Día_Resize(object sender, EventArgs e)
        {
            dataGridView1.Left = (this.ClientSize.Width - dataGridView1.Width) / 2;
            dataGridView1.Top = (this.ClientSize.Height - dataGridView1.Height) / 2;

            salir.Left = (this.ClientSize.Width - salir.Width-20 );
            salir.Top = (this.ClientSize.Height - salir.Height-20 );
        }




    }
}
