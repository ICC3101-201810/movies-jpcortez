using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimoLab
{
    [Serializable]
    public class Actor 
    {
        public string nombre, apellido, fechaN, bio, cargo;

        public Actor(string nombre, string apellido, string fechaN, string bio)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaN = fechaN;
            this.bio = bio;
            this.cargo = "actor";
        }
    }
}
