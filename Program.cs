// Determinar el tamaño de cada dimensión mediante valores ingresados por consola.
Console.WriteLine("Determine la cantidad de columnas a usar");
int cantColumnas = int.Parse(Console.ReadLine());

Console.WriteLine("Determine la cantidad de filas a usar");
int cantFilas = int.Parse(Console.ReadLine());

// Se crea matriz de dos dimensiones.
int[,] numeros = new int[cantFilas, cantColumnas];

int lengthFilas = numeros.GetUpperBound(0) + 1;
int lengthColumnas = numeros.GetUpperBound(1) + 1;

// Se declara vector de tipo double llamado promedios.
double[] promedios = new double[lengthColumnas];

// Variable utilizada para almacenar valor de promedios.
double valor = 0.0d;

// Ciclo for para que usuario ingrese los valores correspondientes a las filas y columnas requeridas.
for (int columna = 0; columna < lengthColumnas; columna++)
{
    Console.WriteLine("================================");
    Console.WriteLine();
    Console.WriteLine($"Valores asignados a la columna: ({columna + 1}/{lengthColumnas})");
    Console.WriteLine("--------------------------------");

    for (int fila = 0; fila < lengthFilas; fila++)
    {
        Console.WriteLine($"Ingrese el valor de la fila: ({fila + 1}/{lengthFilas})");
        numeros[fila, columna] = int.Parse(Console.ReadLine());
        Console.WriteLine();
    }
}

// Ciclo for para mostrar valores ingresados.
for (int columna = 0; columna < lengthColumnas; columna++)
{
    Console.WriteLine("================================");
    Console.WriteLine();
    Console.WriteLine($"Valores asignados a la columna: ({columna + 1}/{lengthColumnas})");
    Console.WriteLine("--------------------------------");

    for (int fila = 0; fila < lengthFilas; fila++)
    {
        Console.Write($"Valor de la fila: ({fila + 1}/{lengthFilas}):");
        Console.WriteLine(numeros[fila, columna]);
        Console.WriteLine();
    }

}

//Mostramos la matriz
Console.WriteLine("La matriz es la siguiente:");
for (int fila = 0; fila < lengthFilas; fila++)
{
    for(int columna = 0; columna < lengthColumnas; columna++)
    
    {
        Console.Write("{0} ", numeros[fila, columna]);
    }
    Console.WriteLine();
}
// Ciclo for para calculo de promedios por columna y muestra de valores promedios.

for (int columna = 0; columna < lengthColumnas; columna++)
{
    Console.WriteLine();
    Console.WriteLine("================================");
    Console.WriteLine();

    double suma = 0;
    for (int fila = 0; fila < lengthFilas; fila++)
    {
        suma = suma + numeros[fila, columna];
            
    }
valor = suma / lengthFilas;
promedios[columna] = valor;
Console.WriteLine($"El promedio de la columna ({columna + 1}/{lengthColumnas}) es {promedios[columna]}");


}

Console.ReadKey();
