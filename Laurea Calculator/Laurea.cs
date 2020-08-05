using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laurea_Calculator
{
    public class Laurea
    {
        public int Voto { get; private set; }
        public float Media { get; set; }

        public Laurea(int voto, int media)
        {
            Voto = voto;
            Media = media;
        }

        public int CalculateVoto()
        {
            return Voto = (int)((Media * 110) / 30);
        }
    }
}
