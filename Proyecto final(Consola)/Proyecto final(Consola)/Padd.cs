using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_final_Consola_
{
    class Padd
    {
        public int X { set; get; }
        public int Y { set; get; }
        public int largo { set; get; }
        int alturatabla;

        public Padd(int x, int alturatabla)
        {
            this.alturatabla = alturatabla;
            X = x;
            Y = alturatabla / 2;
            largo = alturatabla / 3;
        }
        public void arriba()
        {
            if ((Y - 1 - (largo / 2)) != 0)
            {
                Console.SetCursorPosition(X, (Y + (largo / 2)) - 1);
                Console.Write("\0");
                Y--;
                Write();
            }
        }
        public void abajo()
        {
            if((Y + 1 + (largo / 2)) != alturatabla + 2)
            {
                Console.SetCursorPosition(X, (Y - (largo / 2)));
                Console.Write("\0");
                Y++;
                Write();
            }
        }

        public void Write()
        {
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = (Y - (largo / 2)); i < (Y + (largo / 2)); i++)
            {
                Console.SetCursorPosition(X, i);
                Console.Write("│");
            }
            Console.ForegroundColor = ConsoleColor.Red;
        }
    }
}
