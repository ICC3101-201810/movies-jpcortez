using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimoLab
{
    [Serializable]
    public class Estudio
    {
        public string nombre, direccion, fechaAp;

        public Estudio(string nombre, string direccion, string fechaAp)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.fechaAp = fechaAp;
        }
    }
}
