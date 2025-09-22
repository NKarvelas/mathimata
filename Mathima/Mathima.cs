using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathima
{
    internal class Mathima
    {
        static void Main(string[] args)
        {
            Person arithmitiki,pip;
            arithmitiki = new Person();

            float apotelesma = arithmitiki.prosthesi(2, 5);

            System.Console.WriteLine(apotelesma);
        }
    }
}
