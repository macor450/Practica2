using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace Proyecto_final_Consola_
{
    class PingPong
    {
        int Ancho;
        int Alto;
        Raqueta raqueta;
        Padd jugador1;
        Padd jugador2;
        ConsoleKeyInfo info;
        ConsoleKey key;
        Bola bola;
        public PingPong(int ancho, int alto)
        { 
            this.Ancho = ancho; 
            this.Alto = alto;
            raqueta = new Raqueta(ancho, alto);
            bola = new Bola(ancho / 2, alto / 2, alto, ancho); 
        }
        private void Setup()
        {
            jugador1 = new Padd(2, Alto);
            jugador2 = new Padd(Ancho - 2, Alto);
            info = new ConsoleKeyInfo();
            key = new ConsoleKey();
            bola.X = Ancho / 2;
            bola.Y = Alto / 2;
            bola.Kierunek = 0;
        }
        void Input()
        {
            if(Console.KeyAvailable)
            {
                info = Console.ReadKey(true);
                key = info.Key;
            }
        }
        public void Run()
        { 
            while(true)
            {
                Console.Clear();
                Setup();
                raqueta.Write();
                jugador1.Write();
                jugador2.Write();
                bola.Write();
                while(bola.X != 1 && bola.X != Ancho-1)
                {
                    Input();
                    switch(key)
                    {
                        case ConsoleKey.S:
                            jugador1.arriba();
                            jugador2.arriba();
                            break;
                        case ConsoleKey.A:
                            jugador1.arriba();
                            jugador2.abajo();
                            break;
                    }
                    key = ConsoleKey.A;
                    bola.Logic(jugador1, jugador2);
                    bola.Write();
                    Thread.Sleep(100);
                }
            }
        }
    }

}
/*int ancho;
       int alto;
       Raqueta raqueta;
       public PingPong(int ancho, int alto);
       { this.ancho = ancho; this.alto = alto; raqueta = new Raqueta(ancho, alto); }
   }
public void Run();
{ raqueta.Write(); }*/
