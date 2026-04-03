using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Gimnasio.Modelo;
using System.Xml.Serialization;
using System.Xml.Linq;
using System.IO;
using System.Drawing.Imaging;

namespace Gimnasio.Controlador
{
   


public class PersonaController
{
    private string rutaArchivo = @"Datos\personas.xml";
    private List<Persona> personas;

    public PersonaController(){

        personas = new List<Persona>();

        if (CargarPersonas().Count != 0)
        {

            personas.AddRange(CargarPersonas());

        }

        EstablecerPróximoPago();
       

    }



    public void AgregarPersona(Persona persona)
    {

        personas.Add(persona);

    }

    public List<Persona> ObtenerPersonas()
    {
        return personas;

    }


 
        public void 
            ModificarPersona(Persona personaModificada)
    {
        // Buscar la persona por su Id (o cualquier campo que garantice que sea único)
        Persona personaExistente = personas.FirstOrDefault(p => p.Id == personaModificada.Id);
        
        if (personaExistente != null)
        {
            // Actualizar las propiedades de la persona existente con los valores nuevos

            personaExistente.Id = personaModificada.Id;
            personaExistente.Nombre = personaModificada.Nombre;
            personaExistente.Edad = personaModificada.Edad;
            personaExistente.Sexo = personaModificada.Sexo;
            personaExistente.Estatura = personaModificada.Estatura;
            personaExistente.Peso = personaModificada.Peso;
            personaExistente.Color = personaModificada.Color;
            personaExistente.Teléfono = personaModificada.Teléfono;
            personaExistente.Dirección = personaModificada.Dirección;
            personaExistente.FechaRegistro = personaModificada.FechaRegistro;
            personaExistente.PróximoPago = personaModificada.PróximoPago;
            personaExistente.ImagenBase64 = ConvertirImagenABase64(personaModificada.Imagen);
            personaExistente.Imagen = personaModificada.Imagen; 
        }
        else
        {
            throw new Exception("Persona no encontrada.");
        }
    }

   


 
    public void EliminarPersona(Persona persona)
    {
        personas.Remove(persona);


    }


    public void VaciarLista()
    {

        personas.Clear();

    }



    public List<Persona> PersonasPaganHoy()
    {
        List<Persona> pagan_hoy = new List<Persona>();
        int hoy = DateTime.Today.DayOfYear;

        foreach (Persona persona in personas)
        {

            if (persona.PróximoPago.DayOfYear == hoy)
            {

                pagan_hoy.Add(persona);


            }



        }


        return pagan_hoy;

    }




    public void EstablecerPróximoPago(){

        int hoy = DateTime.Today.DayOfYear;

        foreach (Persona persona in personas)
        {

            if (persona.PróximoPago.DayOfYear < hoy)
            {

                persona.PróximoPago = persona.PróximoPago.AddMonths(1);


            }



        }

    }



    // Método para convertir una imagen a Base64
    public string ConvertirImagenABase64(System.Drawing.Image imagen)
    {
        using (MemoryStream ms = new MemoryStream())
        {

           
            imagen.Save(ms, ImageFormat.Png);
            byte[] imagenBytes = ms.ToArray();
            return Convert.ToBase64String(imagenBytes);
        }
    }


    // Método para convertir Base64 a Imagen
    public static System.Drawing.Image ConvertirBase64AImagen(string base64)
    {
        byte[] imagenBytes = Convert.FromBase64String(base64);
        using (MemoryStream ms = new MemoryStream(imagenBytes))
        {
            return System.Drawing.Image.FromStream(ms);
        }
    }



    public void EstablecerImágenes()
    {

        foreach (Persona persona in personas)
        {
            if (persona.ImagenBase64!=null)
            {

                if (persona.Imagen == null)
                {

                    persona.Imagen = ConvertirBase64AImagen(persona.ImagenBase64);

                }

            }

        }



    }

    public void RetirarImágenes()
    {

        foreach (Persona persona in personas)
        {
          

                if (persona.Imagen != null)
                {

                    persona.Imagen =null;

                }

            }


    }




    // Guardar y cargar personas

    public void GuardarPersonas(List<Persona> personas)
    {
        RetirarImágenes();

        XmlSerializer serializer = new XmlSerializer(typeof(List<Persona>));
        using (StreamWriter writer = new StreamWriter(rutaArchivo))
        {
            serializer.Serialize(writer, personas);
        }
    }


    public List<Persona> CargarPersonas()
    {
        if (File.Exists(rutaArchivo))
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Persona>));
            using (StreamReader reader = new StreamReader(rutaArchivo))
            {
                return (List<Persona>)serializer.Deserialize(reader);
            }
        }


        return new List<Persona>(); // Si no existe el archivo, retorna una lista vacía
    }



   
}

    }

