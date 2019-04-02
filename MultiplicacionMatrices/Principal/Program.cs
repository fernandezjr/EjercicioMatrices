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
            Matriz m1 = new Matriz(2, 2);       
            m1.Cargar();
            m1.Mostrar();

            Console.WriteLine(" ");

            Matriz m2 = new Matriz(3, 2);
            m2.Cargar();
            m2.Mostrar();
            Console.WriteLine(" ");

            m1.Multiplicar(m2).Mostrar();

            Console.ReadKey();
        }
    }
}