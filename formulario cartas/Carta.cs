using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace formulario_cartas
{
    public class Carta 
    {
        protected int nivel;



        public int Nivel 
        {
            get { return nivel; }
            set { nivel = value; }
        }
        public Carta()
        { nivel = 0; }

        public override string ToString()
        { return nivel + "";}
        

    }
}
