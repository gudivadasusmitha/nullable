using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nullable
{
    internal class Program
    {
         public static void Main(string[] args)
        {
            int? i = null;
            int j = i ?? 0;
            Console.WriteLine(j);
            Console.ReadLine();

        }
    }
}
