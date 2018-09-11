using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloGit
{
    class Tom
    {
        public static void HejTom()
        {
            for (int i = 0; i < 999; i++)
            {
                Console.WriteLine("Hej Tom!!");
                HejTom();
                HejTom();
            }

            Console.ReadLine();
        }
    }
}
