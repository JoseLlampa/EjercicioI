using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioI
{
    class Program
    {
        static void Main(string[] args)
        {
            int respuesta = 1;

            while (respuesta < 321)
            {
                Console.WriteLine(respuesta);
                int cont = respuesta + 1;
                respuesta = cont;
            }
        }
    }
}
