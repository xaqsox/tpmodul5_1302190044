using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul5_1302190044
{
    class Program
    {
        public class HaloGeneric
        {
            public void SapaUser<T>(T ngaran)
            {
                Console.WriteLine("Oi!! " + ngaran);
            }

            static void Main(string[] args)
            {
                HaloGeneric halo = new HaloGeneric();
                halo.SapaUser("Nama Panggilan : aqso"); /*1302190044*/
            }
        }
    }
}
