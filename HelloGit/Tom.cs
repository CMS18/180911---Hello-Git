using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HelloGit
{
    class Tom
    {
        public static void HejTom()
        {
            int tomCounter = 0;
            for (int i = 0; i < 20; i++)
            {
                if(i % 5 == 0) {
                    Console.WriteLine("Inte Zorro");
                    tomCounter--;
                }
                Console.WriteLine("ZORRO");

                
                tomCounter++;


            }

            Console.WriteLine("Antalet ZORRO's: " +tomCounter);

        }
    }
}
