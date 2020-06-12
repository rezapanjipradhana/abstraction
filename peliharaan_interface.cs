using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction_interface
{
    public class peliharaan_interface : Ihewan
    {
        public void air()
        {
            Console.WriteLine("ini dia jenis dari hewan peliharaan : ");
            Console.WriteLine("Kucing, Hamster, Marmut, Kelinci, Kura-kura.");
        }
    }
}
