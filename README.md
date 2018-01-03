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

- Tendrá que instanciar los objetos LlenarImprimirArreglo y TipoOrdenado, siendo de entrada - salida de arreglos y metodos de ordenamiento respectivamente.
	
	```csharp
	// Clase donde se va a llenar el arreglo a ser ordenado
	LlenarImprimirArreglo llenarImprimirArreglo = new LlenarImprimirArreglo();
	// Clase donde se encuentran los tipos de ordenamiento
	TipoOrdenado tipoOrdenado = new TipoOrdenado();
	
- Se deberá cargar un arreglo inicial para proceder con el ordenamiento

	```csharp
	// Almacena en variable el contenido del arreglo que se creo usando el metodo de llenar arreglo de la clase LlenarImprimirArreglo
	var arregloInicial = llenarImprimirArreglo.LlenarArreglo();
	
- En el presente se realiza la impresion del arreglo desde la libreria LlenarImprimirArreglo sabiendo que está puede ser invocada de otra forma, esta se la realizó de esta manera con el fin de realizar la impresion en la consola

	```csharp
	/*
	Accede a la clase llenarImprimirArreglo con el metodo Imprimir, la cual recibe el metodo de ordenamiento de la clase tipoOrdenado... este último metodo es quien se encargara de ordenar el arreglo que llenamos en el anterior y lo pasamos a este metodo, este metodo me retorna un arreglo
	*/
	llenarImprimirArreglo.Imprimir(tipoOrdenado.OrdenarBurbuja(arregloInicial));
	Console.WriteLine("Ordenado de Shell");
	llenarImprimirArreglo.Imprimir(tipoOrdenado.OrdenarShell(arregloInicial));
	Console.WriteLine("Ordenado de Quick");
	llenarImprimirArreglo.Imprimir(tipoOrdenado.OrdenarQuickSort(arregloInicial, 0, arregloInicial.Length - 1));

