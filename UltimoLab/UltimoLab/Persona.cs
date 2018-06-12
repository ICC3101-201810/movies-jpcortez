using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimoLab
{
    [Serializable]
    public abstract class Persona
    {
        public string nombre, apellido, fechaN, bio;
 
        public Persona(string nombre, string apellido, string fechaN, string bio)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaN = fechaN;
            this.bio = bio;
        }
    }
}
