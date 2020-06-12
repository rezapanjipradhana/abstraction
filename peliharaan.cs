using System;
using System.Collections.Generic;
using System.Text;

namespace Abstrction
{
    public class peliharaan :hewan
    {
        public override void jenis()
        {
            Console.WriteLine("ini dia jenis dari hewan peliharaan : ");
            Console.WriteLine("Kucing, Hamster, Marmut, Kelinci, Kura-kura.");
        }
    }
}
