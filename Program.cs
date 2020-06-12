using System;

namespace Abstrction
{
    class Program
    {
        static void Main(string[] args)
        {
            hewan hewan;

            hewan = new buas();
            hewan.jenis();

            Console.WriteLine();
            hewan = new peliharaan();
            hewan.jenis();

            Console.ReadKey();
        }
    }
}
