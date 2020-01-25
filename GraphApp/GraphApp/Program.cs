using System;

namespace GraphApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MatrixGraphReader matrix = new MatrixGraphReader();
            matrix.read("lol.txt");
        }
    }
}
