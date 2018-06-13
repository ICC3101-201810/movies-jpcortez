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
        public List<Actor> actores;
        public List<Director> directores;
        public List<Productor> productores;
        public List<PeliculaProductor> peliprod;
        public List<PeliculaActor> peliact;
        public List<Pelicula> pelicula;
        public List<Estudio> estudio;
        public BaseDeDatos()
        {
            actores = new List<Actor>();
            directores = new List<Director>();
            productores = new List<Productor>();
            peliprod = new List<PeliculaProductor>();
            peliact = new List<PeliculaActor>();
            pelicula = new List<Pelicula>();
            estudio = new List<Estudio>();
        }

        public void Serializar()
        {
            BinaryFormatter binf = new BinaryFormatter();
            FileStream fs = File.Open("bdd.txt", FileMode.OpenOrCreate);
            binf.Serialize(fs, this);
            fs.Close();
        }

        public List<string> NombresPeli()
        {
            List<string> a = new List<string>();
            foreach (Pelicula p in pelicula)
            {
                a.Add(p.nombre);
            }
            return a;
        }
        public List<string> NombresEstudio()
        {
            List<string> a = new List<string>();
            foreach (Estudio p in estudio)
            {
                a.Add(p.nombre);
            }
            return a;
        }
        public List<string> NombresActores()
        {
            List<string> a = new List<string>();
            foreach (Actor p in actores)
            {
                a.Add(p.nombre +" "+ p.apellido);
            }
            return a;
        }
        public List<string> NombresDir()
        {
            List<string> a = new List<string>();
            foreach (Director p in directores)
            {
                a.Add(p.nombre + " " + p.apellido);
            }
            return a;
        }
        public List<string> NombresProd()
        {
            List<string> a = new List<string>();
            foreach (Productor p in productores)
            {
                a.Add(p.nombre + " "+ p.apellido);
            }
            return a;
        }

        public Estudio GetEstudio(string s)
        {
            foreach (Estudio e in estudio)
            {
                if (e.nombre.ToLower() == s.ToLower())
                {
                    return e;
                }
            }
            return null;
        }

        public Pelicula GetPeli(string s)
        {
            foreach (Pelicula p in pelicula)
            {
                if (p.nombre.ToLower() == s.ToLower())
                {
                    return p;
                }
            }
            return null;
        }

        public Actor GetActor(string s, string p)
        {
            foreach (Actor a in actores)
            {
                if (a.nombre.ToLower() == s.ToLower() && a.apellido.ToLower() == p.ToLower())
                {
                    return a;
                }
            }
            return null;
        }
        public Director GetDirector(string s, string p)
        {
            foreach (Director a in directores)
            {
                if (a.nombre.ToLower() == s.ToLower() && a.apellido.ToLower() == p.ToLower())
                {
                    return a;
                }
            }
            return null;
        }
        public Productor GetProductor(string s, string p)
        {
            foreach (Productor a in productores)
            {
                if (a.nombre.ToLower() == s.ToLower() && a.apellido.ToLower() == p.ToLower())
                {
                    return a;
                }
            }
            return null;
        }
    }
}
