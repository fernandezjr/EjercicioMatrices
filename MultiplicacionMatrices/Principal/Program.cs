using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal
{
    class Program
    {
        static void Main(string[] args)
        {
            Matriz m1 = new Matriz(3, 2);

            m1.Cargar();
            m1.Mostrar();
            Console.ReadKey();
        }
    }
}