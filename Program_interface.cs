using System;

namespace Abstraction_interface
{
    class Program_interface
    {
        static void Main(string[] args)
        {
            Ihewan hewan;

            hewan = new buas();
            hewan.jenis();

            Console.WriteLine();
            hewan = new peliharaan();
            hewan.jenis();
        }
    }
}
