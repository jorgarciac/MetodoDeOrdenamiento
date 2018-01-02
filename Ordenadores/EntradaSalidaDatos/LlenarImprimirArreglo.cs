using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ordenadores.Logica;

namespace Ordenadores.EntradaSalidaDatos
{
    class LlenarImprimirArreglo
    {
        Validaciones validaciones = new Validaciones();
        private int[] vectorInicial;
        public int[] LlenarArreglo()
        {
            Console.WriteLine("********************************************");
            Console.WriteLine("********** Ordenamiento Burbuja ************");
            Console.WriteLine("********************************************");
            Console.WriteLine("¿Cuál es el tamaño del arreglo?, ingrese únicamente números enteros");            
            int cantidad = validaciones.validarNumeroEntero();
            vectorInicial = new int[cantidad];
            for (int i = 0; i < vectorInicial.Length; i++)
            {
                Console.Write("Ingrese elemento " + (i + 1) + ": ");
                vectorInicial[i] = validaciones.validarNumeroEntero();
            }
            return vectorInicial;
        }

        public void Imprimir(int[] arregloImprimir)
        {
            for (int i = 0; i < arregloImprimir.Length; i++)
            {
                Console.Write(arregloImprimir[i] + "  ");
            }
            Console.WriteLine();
        }

    }
}
