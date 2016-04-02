using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concatenacion
{
    class Concatenacion
    {
        static void Main(string[] args)
        {
            
            /*var cadena= string.Empty;
            for (int i = 0; i < 100000; i++) {

                cadena += i;
                
                
            }
            Console.Write(cadena);
            Console.ReadLine();*/

            var sb = new StringBuilder();
            for (int i=0; i < 10000; i++) {
                sb.Append(i);  // clase especial para concatenar cadenas
            }
            Console.WriteLine(sb);
            Console.ReadLine();

        }
    }
}
