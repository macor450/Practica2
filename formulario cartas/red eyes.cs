using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formulario_cartas
{
    class red_eyes : Carta
    {
        protected string tipo;

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public red_eyes() : base()
        { tipo = ""; }

        public override string ToString()
        { return tipo + "" + base.ToString(); }
    }
    
}
 