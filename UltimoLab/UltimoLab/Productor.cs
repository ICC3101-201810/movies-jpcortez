using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimoLab
{
    [Serializable]
    public class Productor : Persona
    {
        public string cargo;

        public Productor(string nombre, string apellido, string fechaN, string bio, string cargo) : base(nombre, apellido, fechaN, bio)
        {
            this.cargo = "productor";
        }
    }
}
