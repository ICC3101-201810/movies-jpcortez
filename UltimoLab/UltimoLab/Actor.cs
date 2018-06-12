using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimoLab
{
    public class Actor : Persona
    {
        public string cargo;

        public Actor(string nombre, string apellido, string fechaN, string bio, string cargo) : base(nombre, apellido, fechaN, bio)
        {
            this.cargo = "actor";
        }
    }
}
