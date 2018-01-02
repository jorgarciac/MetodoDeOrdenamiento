using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenadores.mnOrdenadores
{
    class TipoOrdenado
    {

        public int[] OrdenarBurbuja(int[] ArregloAOrdenar)
        {
            int t;
            for (int i = 1; i < ArregloAOrdenar.Length; i++)
            {
                for (int j = ArregloAOrdenar.Length - 1; j >= i; j--)
                {
                    if (ArregloAOrdenar[j - 1] > ArregloAOrdenar[j])
                    {
                        t = ArregloAOrdenar[j - 1];
                        ArregloAOrdenar[j - 1] = ArregloAOrdenar[j];
                        ArregloAOrdenar[j] = t;
                    }
                }
            }
            return ArregloAOrdenar;                
        }


        public int[] OrdenarShell(int[] ArregloAOrdenar)
        {
            int salto = 0;
            int sw = 0;
            int auxi = 0;
            int e = 0;
            salto = ArregloAOrdenar.Length / 2;
            while (salto > 0)
            {
                sw = 1;
                while (sw != 0)
                {
                    sw = 0;
                    e = 1;
                    while (e <= (ArregloAOrdenar.Length - salto))
                    {
                        if (ArregloAOrdenar[e - 1] > ArregloAOrdenar[(e - 1) + salto])
                        {
                            auxi = ArregloAOrdenar[(e - 1) + salto];
                            ArregloAOrdenar[(e - 1) + salto] = ArregloAOrdenar[e - 1];
                            ArregloAOrdenar[(e - 1)] = auxi;
                            sw = 1;
                        }
                        e++;
                    }
                }
                salto = salto / 2;
            }
            return ArregloAOrdenar;
        }

        public int[] OrdenarQuickSort(int[] ArregloAOrdenar, int primero, int ultimo)
        {            
            int i, j, central;
            double pivote;
            central = (primero + ultimo) / 2;
            pivote = ArregloAOrdenar[central];
            i = primero;
            j = ultimo;
            do
            {
                while (ArregloAOrdenar[i] < pivote) i++;
                while (ArregloAOrdenar[j] > pivote) j--;
                if (i <= j)
                {
                    int temp;
                    temp = ArregloAOrdenar[i];
                    ArregloAOrdenar[i] = ArregloAOrdenar[j];
                    ArregloAOrdenar[j] = temp;
                    i++;
                    j--;
                }
            } while (i <= j);

            if (primero < j)
            {
                OrdenarQuickSort(ArregloAOrdenar, primero, j);
            }
            if (i < ultimo)
            {
                OrdenarQuickSort(ArregloAOrdenar, i, ultimo);
            }
            return ArregloAOrdenar;
        }

    }
}
