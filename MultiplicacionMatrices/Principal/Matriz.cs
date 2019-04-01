using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal
{
    class Matriz
    {
        private int filas;
        private int columnas;
        private int[,] elementos;

        public Matriz(int filas, int columnas)
        {
            this.filas = filas;
            this.columnas = columnas;
            elementos = new int[this.filas, this.columnas];
        }

        public void Mostrar()
        {
            for (int f = 0; f < filas; f++)
            {
                for (int c = 0; c < columnas; c++)
                {
                    Console.Write(elementos[f, c] + " ");
                }
                Console.WriteLine("");
            }
        }

        public void Cargar()
        {
            for (int f = 0; f < filas; f++)
            {
                for (int c = 0; c < columnas; c++)
                {
                    Random aleatorio = new Random();
                    elementos[f, c] = aleatorio.Next(-9, 9);
                }
            }
        }

        private int GenerarNumeroAleatorio(int minimo, int maximo)
        {
            Random aleatorio = new Random();
            return aleatorio.Next(minimo, maximo);
        }

        private bool EsMultiplicablePor(Matriz otra)
        {
            return (this.columnas == otra.filas);
        }

        private Matriz mutiplicar(Matriz otra)
        {
            if (EsMultiplicablePor(otra))
            {
                return new Matriz(2, 2);
            }
            else
                throw new Exception("No se pueden multiplicar");
        }
    }
}