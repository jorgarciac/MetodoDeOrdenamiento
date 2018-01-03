# Métodos de ordenamiento

Implementación de métodos de ordenamiento, para la clase de Ingenieria de Software de la Tecnologia en Desarrollo de Software.

Las clases fueron creadas en Visual Studio C#

Se implementaron las siguientes metodos de ordenamiento:

	- Burbuja
	- ShellSort 
	- QuickSort
	
# Recomendaciónes

- Se recomienda no hacer modificaciones en los archivos con extención .config del directorio en el que se encuentra el ejecutable de la calculadora.


# Observaciones en la compilación

- En la actualidad los métodos de ordenamiento únicamente ordenan numeros enteros, por lo que para futuras versiones se implementará la función de ordenar otros tipos de datos y ademas nuevos métodos de ordenamiento.


# Uso de la libreria

- tendra que instanciar los objetos LlenarImprimirArreglo y TipoOrdenado, siendo de entrada - salida de arreglos y metodos de ordenamiento respectivamente.
	
	```csharp
   for (int i = 0 ; i < 10; i++)
   {
     // Code to execute.
   }
	
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
	
