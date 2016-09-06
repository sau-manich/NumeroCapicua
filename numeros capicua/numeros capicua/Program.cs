using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numeros_capicua
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int res = 0;
            int invert = 0;
            Console.WriteLine("INGRESE EL VALOR QUE DECEA IMBERTIR");
            num = Convert.ToInt32(Console.ReadLine());
            while (num > 0)
            {
            res = num % 10;
            num = num / 10;
            invert = invert * 10 + res; 
            }
            
            Console.WriteLine("EL NUMERO IMBERTIDO ES " + invert);
            Console.ReadKey();
    }
  }
}
