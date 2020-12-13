using System;

namespace Proyecto_final_Consola_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            PingPong pingPong = new PingPong(20, 20);
            pingPong.Run();
            Console.ReadKey();
        }
    }
}
