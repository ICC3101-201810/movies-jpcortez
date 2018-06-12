using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Media;


namespace UltimoLab
{
    [Serializable]
    public class BaseDeDatos
    {        
        public List<Persona> personas;
        public List<PeliculaProductor> peliprod;
        public List<PeliculaActor> peliact;
        public List<Pelicula> pelicula;
        public List<Estudio> estudio;

        public BaseDeDatos()
        {
            personas = new List<Persona>();
            peliprod = new List<PeliculaProductor>();
            peliact = new List<PeliculaActor>();
            pelicula = new List<Pelicula>();
            estudio = new List<Estudio>();
        }

        public void Serializar()
        {
            BinaryFormatter binf = new BinaryFormatter();
            FileStream fs = File.Open("basededatos.txt", FileMode.OpenOrCreate);
            binf.Serialize(fs, this);
            fs.Close();
        }

    }
}
