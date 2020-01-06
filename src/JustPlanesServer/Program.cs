using System;

namespace JustPlanes.Core.Network.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ServerTCP.InitializeNetwork();
            Console.WriteLine("Server STARTED ~~~");
            GameRunner.Initialize();
            Console.CancelKeyPress += (object sender, ConsoleCancelEventArgs args1) => { GameRunner.Stop(); args1.Cancel = true; };
            GameRunner.Run();
        }
    }
}
