using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenadores.Logica
{
    class Validaciones
    {
        public int validarNumeroEntero()
        {
            int valor;
            string numero;
            bool esNumero;
            do
            {                
                numero = Console.ReadLine();
                esNumero = int.TryParse(numero, out valor);
                if (!esNumero)
                {
                    Console.WriteLine("Ingrese unicamente números enteros positivos");
                }
            } while (!esNumero);
            return Int32.Parse(numero);
        }
    }
}
