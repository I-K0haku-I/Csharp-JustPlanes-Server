using System;

namespace JustPlanes.Network.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ServerTCP.InitializeNetwork();
            Console.WriteLine("Server STARTED ~~~");
            Console.ReadLine();
        }
    }
}
