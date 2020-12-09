using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formulario_cartas
{
    class blue_eyes : Carta
    {
        protected int ataque;

        public int Ataque
        {
            get { return ataque; }
            set { ataque = value; }
        }
        public blue_eyes() : base()
        { ataque = 0; }

        public override string ToString()
        { return ataque + ""; }

    }
}
