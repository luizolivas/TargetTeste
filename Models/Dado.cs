using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteTecnicoTargetErp.Models
{
    internal class Dado
    {
        public int Dia { get; set; }
        public double Valor { get; set; }

        private static Dado _instancia;

        private Dado() { }

        public static Dado GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new Dado();
            }
            return _instancia;
        }
    }
}
