using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello World");
            Console.WriteLine("Hello World again!");
            Console.ReadKey();d
            Console.WriteLine("Hello TreinaWeb");
            Console.ReadKey(); */
            // Inferência
            //int inteiro1 = 4;
            var inteiro1 = 4;
            var nome = "TreinaWeb";
            Console.WriteLine("inteiro1 = {0}", inteiro1);
            dynamic minhaVariavel = 2;
            Console.WriteLine("inteiro1 + minhaVariavel = {0}", inteiro1 + minhaVariavel);
            minhaVariavel = "TreinaWeb";
            Console.WriteLine("minhaVariavel = {0}", minhaVariavel);
            Console.ReadKey();
        }
    }
}
