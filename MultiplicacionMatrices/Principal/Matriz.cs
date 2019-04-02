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
                    elementos[f, c] = GenerarNumeroAleatorio(-9, 9);
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

        public Matriz Multiplicar(Matriz otra)
        {
            try
            {
                return MultiplicarMatrices(otra);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }            
        }

        private Matriz MultiplicarMatrices(Matriz otra)
        {
            if (EsMultiplicablePor(otra))
            {
                return this.MultiplicarPor(otra);
            }
            else
                throw new Exception("No se pueden multiplicar");
        }

        private Matriz MultiplicarPor(Matriz otra)
        {
            Matriz resultado = new Matriz(this.filas, otra.columnas);
            for (int f = 0; f < resultado.filas; f++)
            {
                for (int c = 0; c < resultado.columnas; c++)
                {
                    resultado.elementos[f, c] = MultiplicarArreglos(this.GetFila(f), otra.GetColumna(c));
                }
            }
            return resultado;
        }

        private int MultiplicarArreglos(int[] a, int[] b)
        {
            int resultado = 0;
            for (int i = 0; i < a.Length; i++)
            {
                resultado += a[i] * b[i];
            }
            return resultado;
        }

        private int[] GetFila(int fila)
        {
            int[] arreglo = new int[columnas];
            int f = 0, c = 0;
            bool completo = false;
            while(!completo && f < filas)
            {
                if(f == fila)
                {
                    while(c < columnas)
                    {
                        arreglo[c] = elementos[f, c];
                        c++;
                    }
                    completo = true;
                }
                f++;
            }
            return arreglo;
        }

        public int[] GetColumna(int columna)
        {
            int[] arreglo = new int[filas];
            int c = 0, f = 0;
            bool completo = false;
            while(!completo && c < columnas)
            {
                if(c == columna)
                {
                    while(f < filas)
                    {
                        arreglo[f] = elementos[f, c];
                        f++;
                    }
                    completo = true;
                }
                c++;
            }
            return arreglo;
        }
    }
}