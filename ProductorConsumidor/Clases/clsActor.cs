using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductorConsumidor.Clases
{
    public class clsActor
    {
        public string Estatus;
        public int Indice;
        public int Tiempo;

        public clsActor(String Estatus, int Tiempo)
        {
            this.Estatus = Estatus;
            this.Tiempo = Tiempo;
            Indice = 0;
        }

    }
}
