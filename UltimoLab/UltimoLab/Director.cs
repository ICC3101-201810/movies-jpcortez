using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimoLab
{
    [Serializable]
    public class Director : Persona
    {
        public string cargo;

        public Director(string nombre, string apellido, string fechaN, string bio, string cargo):base(nombre, apellido, fechaN, bio)
        {
            this.cargo = "director";
        }
    }
}
