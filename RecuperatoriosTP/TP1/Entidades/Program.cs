using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Program
    {
        static void Main(string[] args)
        {
            Numero num = new Numero();
            
            Console.WriteLine(num.BinarioDecimal("0000011"));
            Console.ReadKey();
        }
    }
}
