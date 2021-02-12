using System;

namespace Inverse_Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] helloworld = {"H", "e", "l", "l", "o", " ", "W", "o", "r", "l", "d", "!"};

            for (int i = 11; i > -1; i--)
            {
                Console.Write(helloworld[i]);
            }

        }
    }
}
