using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimoLab
{
    [Serializable]
    public class Pelicula
    {
        public string nombre, fechaEstreno, descripcion;
        public Director director;
        public int presupuesto;

        public Pelicula(string nombre, string fechaEstreno, string descripcion, Director director, int presupuesto)
        {
            this.nombre = nombre;
            this.fechaEstreno = fechaEstreno;
            this.descripcion = descripcion;
            this.director = director;
            this.presupuesto = presupuesto;
        }
    }
}
