using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_final_Consola_
{
    public class Raqueta
    {
        public int Alto { set; get; }
        public int Ancho { set; get; }
        public Raqueta()
        { Ancho = 60; Alto = 60; }                                                                                                                                                                                                                   
        public Raqueta(int alto, int ancho)
        { Alto = alto; Ancho = ancho; }
        public void Write()
        {
            for (int i = 1; i <= Ancho; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("─");
            }
            for (int i = 1;i<= Alto; i++)
            {
                Console.SetCursorPosition(i, (Alto + 1));
                Console.Write("─");
            }
            for (int i = 1;i<= Alto; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("│");
            }
            for (int i = 1; i <= Alto; i++)
            {
                Console.SetCursorPosition((Alto+1),i);
                Console.Write("│");
            }
            Console.SetCursorPosition(0, 0);
            Console.Write("┌");
            Console.SetCursorPosition(Ancho + 1, 0);
            Console.Write("┐");
            Console.SetCursorPosition(0, Alto + 1);
            Console.Write("└");
            Console.SetCursorPosition(Ancho + 1, Alto + 1);
            Console.Write("┘");
        }
    }
}
