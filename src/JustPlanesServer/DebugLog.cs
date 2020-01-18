using System;

namespace JustPlanes
{
    public static class DebugLog
    {
        public static void Warning(string msg)
        {
            Console.WriteLine(msg);
        }

        public static void Info(string msg)
        {
            Console.WriteLine(msg);
        }

        public static void LogConn(string msg)
        {
            // Console.WriteLine(msg);
        }

        public static void LogPackets(string msg)
        {
            // Console.WriteLine(msg);
        }

        public static void Severe(string msg)
        {
            Console.WriteLine($"!WARNING! {msg}");
        }
    }
}