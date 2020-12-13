using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_final_Consola_
{
    class Bola
    {
        public int X { set; get; }
        public int Y { set; get; }
        int zwortX;
        int zwortY;
        int altatabla;
        int anchatabla;
        public int Kierunek { set; get; }
        public Bola(int x, int y, int altatabla, int anchatabla)
        {
            X = x;
            Y = y;
            this.altatabla = altatabla;
            this.anchatabla = anchatabla;
            zwortX = -1;
            zwortY = 1;
        }
        public void Logic(Padd padd1, Padd padd2)
        {
            Console.SetCursorPosition(X, Y);
            Console.Write("\0");
            if(Y<=1 || Y>=altatabla)
            {
                zwortY *= -1;
            }
            if (((X == 3 || X == anchatabla - 3) && (padd1.Y - (padd1.largo / 2)) <= Y && (padd1.Y + (padd1.largo / 2)) > Y))
            {
                zwortX *= -1;
                if (Y == padd1.Y)
                {
                    Kierunek = 0;
                }
                if ((Y >= (padd1.Y - (padd1.largo / 2)) && Y < padd1.Y) || (Y > padd1.Y && Y < (padd1.Y + (padd1.largo / 2))))
                {
                    Kierunek = 1;
                }
            }
                switch(Kierunek)
                {
                    case 0:
                        X += zwortX;
                        break;
                    case 1:
                        X += zwortX;
                        Y += zwortY;
                        break;
                }
            
        }
        public void Write()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(X, Y);
            Console.Write("■");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
