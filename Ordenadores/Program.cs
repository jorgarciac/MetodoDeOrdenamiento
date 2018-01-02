using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ordenadores.EntradaSalidaDatos;
using Ordenadores.mnOrdenadores;

namespace Ordenadores
{
    class Program
    {
        static void Main(string[] args)
        {
            LlenarImprimirArreglo llenarImprimirArreglo = new LlenarImprimirArreglo();
            TipoOrdenado tipoOrdenado = new TipoOrdenado();
            var arregloInicial = llenarImprimirArreglo.LlenarArreglo();
            Console.WriteLine("Ordenado de Burbuja");
            llenarImprimirArreglo.Imprimir(tipoOrdenado.OrdenarBurbuja(arregloInicial));
            Console.WriteLine("Ordenado de Shell");
            llenarImprimirArreglo.Imprimir(tipoOrdenado.OrdenarShell(arregloInicial));
            Console.WriteLine("Ordenado de Quick");
            llenarImprimirArreglo.Imprimir(tipoOrdenado.OrdenarQuickSort(arregloInicial, 0, arregloInicial.Length - 1));
            Console.ReadKey();
        }
    }
}
