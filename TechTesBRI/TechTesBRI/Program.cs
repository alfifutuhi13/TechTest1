using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechTesBRI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deret output: 1 4 9 16 25 36
            Console.WriteLine("Deret: ");
            for (int i = 1; i<=6; i++)
            {
                Console.Write("{0} ",i*i);
            }
            Console.WriteLine();
        }
    }
}
