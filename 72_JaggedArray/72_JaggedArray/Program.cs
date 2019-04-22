using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _72_JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            String[][] x = new string[3][];

            x[0] = new string[2];
            x[1] = new string[2];
            x[2] = new string[2];

            x[0] = new string[] { "Renata", "Paulo" };
            x[1] = new string[] { "João", "Pedro" };
            x[2] = new string[] { "Rodrigo", "Rafael" };

            Console.WriteLine("Oi {0} te apresento {1}", x[0][0], x[1][0]);
            Console.WriteLine("Oi {0} te apresento {1}", x[1][1], x[0][1]);
            Console.WriteLine("Oi {0} te apresento {1}", x[2][0], x[1][1]);

            for (int f = 0; f < x.Length; f++)
            {
                Console.WriteLine("\nElemento {0}", f);
                for (int z = 0; z < x[f].Length; z++)
                {
                    
                    Console.WriteLine("{0}", x[f][z]);
                    
                }
                
            }

            Console.Read();

        }
    }
}
