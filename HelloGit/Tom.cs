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
            for (int i = 0; i < 100; i++)
            {
                if(i % 5 == 0) {
                    Console.WriteLine("Inte Tom");
                    tomCounter--;
                }
                Console.WriteLine("Tom");

                
                tomCounter++;


            }

            Console.WriteLine("Anatelt tom's: " +tomCounter);

            Console.ReadLine();
        }
    }
}
