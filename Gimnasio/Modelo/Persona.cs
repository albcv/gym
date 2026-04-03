using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;


namespace Gimnasio.Modelo
{

    public class Persona
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public float Estatura { get; set; }
        public float Peso { get; set; }
        public string Color { get; set; }
        public string Teléfono { get; set; }
        public string Dirección { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime PróximoPago { get; set; }
        public Image Imagen { get; set; }


        [Browsable(false)]
        public string ImagenBase64 { get; set; }
    }

}
