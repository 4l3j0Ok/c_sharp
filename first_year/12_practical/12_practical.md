# Ejercicio 1

Código:
```csharp
﻿using System;

// 1 - Desarrollar un algoritmo que cargue una matriz de 4 x 4 con valores enteros aleatorios(random)
// comprendidos entre 1 y 6.Luego de cargadas la misma, el programa debe hacer lo siguiente:
// a - Imprimir la matriz en consola.
//  b - Recorrerla posición a posición, ir sumando el valor de cada celda y luego de terminar de
// recorrerla imprimir en consola, y debajo de la matriz ya impresa, el resultado de esa suma de
// todos los valores

namespace practical_1
{
    class Program1
    {
        static void Main(string[] args)
        {
            int total_rows = 4; int total_cols = 4; int start = 1; int limit = 7;
            int[,] random_matrix = GetRandomMatrix(total_rows, total_cols, start, limit);
            PrintAndSumMatrix(random_matrix);
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }

        static int[,] GetRandomMatrix(int total_rows, int total_cols, int start, int limit)
        {
            int[,] matrix = new int[total_rows, total_cols];
            for (int row = 0; row != total_rows; row += 1) {
                for (int col = 0; col != total_cols; col += 1) {
                    matrix[row, col] = new Random().Next(start, limit);
                }
            }
            return matrix;
        }

        static void PrintAndSumMatrix(int[,] matrix) {
            int total_rows = matrix.GetLength(0);
            int total_cols = matrix.GetLength(1);
            int sum = 0;
            Console.WriteLine("La matriz generada es la siguiente:\n");
            for (int row = 0; row != total_rows; row += 1) {
                Console.Write("\t");
                for (int col = 0; col != total_cols; col += 1) {
                    sum += matrix[row, col];
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nEl total de la suma entre todos los números de la matriz es: " + sum + "\n");
        }
    }
}

```

Salida:
```
La matriz generada es la siguiente:

	5 4 6 5 
	1 2 2 6 
	6 4 1 5 
	2 3 4 3 

El total de la suma entre todos los números de la matriz es: 59

Presione una tecla para continuar...

```

# Ejercicio 2

Código:
```csharp
﻿using System;

// Generar un algoritmo que cargue una matriz de 5 x 5 (con el formato y valores de la imagen que se muestra 
// a continuación mediante un algoritmo automático) y que al final de cada fila muestre la sumatoria de los 
// valores que forman las mismas.


namespace practical_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int total_rows = 5;
            int total_cols = 5;
            int start = 0;
            int[,] generated_matrix = GenerateMatrix(total_rows, total_cols, start);
            PrintMatrix(generated_matrix);
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }

        static int[,] GenerateMatrix(int total_rows, int total_cols, int start)
        {
            int value = start;
            int[,] matrix = new int[total_rows, total_cols];
            for (int row = 0; row != total_rows; row += 1)
            {
                for (int col = 0; col != total_cols; col += 1)
                {
                    matrix[row, col] = value;
                    value += 1;
                }
                start += 1;
                value = start;
            }
            return matrix;
        }

        static void PrintMatrix(int[,] matrix) {
            int total_rows = matrix.GetLength(0);
            int total_cols = matrix.GetLength(1);
            int sum = 0;
            Console.WriteLine();
            for (int row = 0; row != total_rows; row += 1)
            {
                Console.Write("\t");
                for (int col = 0; col != total_cols; col += 1)
                {
                    sum += matrix[row, col];
                    Console.Write(matrix[row, col] + " ");
                    if (col == total_cols - 1) {
                        Console.Write("= " + sum);
                        sum = 0;
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}

```

Salida:
```

	0 1 2 3 4 = 10
	1 2 3 4 5 = 15
	2 3 4 5 6 = 20
	3 4 5 6 7 = 25
	4 5 6 7 8 = 30

Presione una tecla para continuar...

```

# Ejercicio 3

Código:
```csharp
﻿using System;

// Elaborar un programa que lea o recorra una matriz, que ya debe estar cargadas con valores, y que imprima 
// por pantalla poniendo las filas como columnas y las columnas como filas (lo que se conoce como matriz 
// transpuesta)


namespace practical_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = {
                { 2, 5, 6, 7, 8 },
                { 8, 6, 3, 2, 1 },
                { 7, 4, 6, 1, 5 }
            };
            Console.WriteLine("Matrix original:");
            PrintMatrix(matrix);
            int[,] transposed_matrix = TransposeMatrix(matrix);
            Console.WriteLine("Matrix transpuesta:");
            PrintMatrix(transposed_matrix);
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }

        static int[,] TransposeMatrix(int[,] old_matrix) {
            int rows = old_matrix.GetLength(0);
            int cols = old_matrix.GetLength(1);
            int[,] new_matrix = new int[cols, rows];
            for (int row = 0; row != rows; row += 1) {
                for (int col = 0; col != cols; col += 1) {
                    new_matrix[col, row] = old_matrix[row, col];
                }
            }
            return new_matrix;
        }

        static void PrintMatrix(int[,] matrix)
        {
            int total_rows = matrix.GetLength(0);
            int total_cols = matrix.GetLength(1);
            Console.WriteLine();
            for (int row = 0; row != total_rows; row += 1)
            {
                Console.Write("\t");
                for (int col = 0; col != total_cols; col += 1)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}

```

Salida:
```
Matrix original:

	2 5 6 7 8 
	8 6 3 2 1 
	7 4 6 1 5 

Matrix transpuesta:

	2 8 7 
	5 6 4 
	6 3 6 
	7 2 1 
	8 1 5 

Presione una tecla para continuar...

```

# Ejercicio 4

Código:
```csharp
﻿using System;

// Elabore un programa que cargue una matriz de 6 x 6 con números aleatorios entre 2 y 8. Imprima la misma 
// por pantalla. Al mismo tiempo que la imprime debe almacenar en un matrix de 6 posiciones los valores de 
// la diagonal de dicha matriz (diagonal de izquierda a derecha y de arriba hacia abajo) y luego se debe 
// imprimir dicho matrix.


namespace practical_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int total_rows = 6;
            int total_cols = 6;
            int start = 2;
            int limit = 9;
            int[,] random_matrix = GetRandommatrix(total_rows, total_cols, start, limit);
            int[] diagonal_values = GetDiagonalMatrixValues(random_matrix);
            Console.WriteLine("Matriz generada con valores aleatorios:");
            PrintMatrix(random_matrix);
            Console.WriteLine("Array generada con los valores de la diagonal:");
            PrintArray(diagonal_values);
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }

        static int[,] GetRandommatrix(int total_rows, int total_cols, int start, int limit)
        {
            int[,] matrix = new int[total_rows, total_cols];
            for (int row = 0; row != total_rows; row += 1)
            {
                for (int col = 0; col != total_cols; col += 1)
                {
                    matrix[row, col] = new Random().Next(start, limit);
                }
            }
            return matrix;
        }

        static void PrintMatrix(int[,] matrix)
        {
            int total_rows = matrix.GetLength(0);
            int total_cols = matrix.GetLength(1);
            Console.WriteLine();
            for (int row = 0; row != total_rows; row += 1)
            {
                Console.Write("\t");
                for (int col = 0; col != total_cols; col += 1)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static int[] GetDiagonalMatrixValues(int[,] matrix)
        {
            int total_rows = matrix.GetLength(0);
            int total_cols = matrix.GetLength(1);
            int[] array = new int[total_cols];
            int index = 0;
            for (int row = 0; row != total_rows; row += 1)
            {
                array[index] = matrix[row, index];
                index += 1;
            }
            return array;
        }

        static void PrintArray(int[] array)
        {
            int array_length = array.GetLength(0);
            Console.WriteLine();
            Console.Write("\t");
            for (int index = 0; index != array_length; index += 1) {
                Console.Write(array[index] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}

```

Salida:
```
Matriz generada con valores aleatorios:

	7 6 6 8 6 5 
	6 5 3 4 4 4 
	7 8 7 6 8 2 
	4 6 6 8 2 3 
	5 7 2 4 3 3 
	4 6 5 5 3 2 

Array generada con los valores de la diagonal:

	7 5 7 8 3 2 

Presione una tecla para continuar...

```

# Ejercicio 5

Código:
```csharp
﻿using System;
using System.Diagnostics;


// 5 - Desarrolle un programa que:
//   a. Utilice dos arrays unidimensionales de 5 posiciones.
//   b. Los arrays deberán ser cargados con valores random de entre 1 y 9.
//   c. Luego deberá tomar cada valor del array1 e ir multiplicando por cada uno de los del array2 de la 
//   siguiente forma: 7 x 7 x 9 x 3 x 8 x 9 = 95256


namespace practical_5
{
    class Program
    {
        static void Main(string[] args)
        {
            const bool DEBUG = false;
            int array_length = 6;
            int rndm_start = 1;
            int rndm_limit = 10;
            int[] array_1 = GenerateRandomArray(array_length, rndm_start, rndm_limit);
            int[] array_2 = GenerateRandomArray(array_length, rndm_start, rndm_limit);
            int[] results = LMultiply(array_1, array_2, DEBUG);
            Console.WriteLine("Array 1:");
            PrintArray(array_1);
            Console.WriteLine("Array 2:");
            PrintArray(array_2);
            Console.WriteLine("Resultante:");
            PrintArray(results);
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }

        static int[] GenerateRandomArray(int array_length, int rndm_start, int rndm_limit)
        {
            int[] array = new int[array_length];
            for (int index = 0; index != array_length; index += 1)
            {
                array[index] = new Random().Next(rndm_start, rndm_limit);
            }
            return array;
        }

        static void PrintArray(int[] array)
        {
            int array_length = array.GetLength(0);
            Console.WriteLine();
            Console.Write("\t");
            for (int index = 0; index != array_length; index += 1)
            {
                Console.Write(array[index] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        static int[] LMultiply(int[] array_1, int[] array_2, bool debug = false) {
            int pos = 0;
            int[] results = new int[array_1.Length];
            for (int i = 0; i != array_1.Length; i += 1) {
                if (debug) Console.Write($"{array_1[i]} X {array_2[i]}");
                results[i] = array_1[i] * array_2[i];
                if (i != array_1.Length - 1) pos = i + 1;
                else pos = 0;
                while (true) {
                    if (pos == i) break;
                    if (debug) Console.Write($" X {array_2[pos]}");
                    results[i] *= array_2[pos];
                    if (pos == (array_2.Length - 1)) {
                        pos = 0;
                        continue;
                    }
                    pos++;
                }
                if (debug) Console.Write($" = {results[i]}");
                if (debug) Console.WriteLine();
            }
            if(debug) Console.WriteLine();
            return results;
        }
    }
}

```

Salida:
```
Array 1:

	1 3 3 5 1 4 

Array 2:

	9 5 8 3 6 5 

Resultante:

	32400 97200 97200 162000 32400 129600 

Presione una tecla para continuar...

```

# Ejercicio 6

Código:
```csharp
﻿using System;
using System.Diagnostics;


// Desarrollar un programa que utilice un array bidimensional que permita cargar Nombre, Apellido y Edad de 
// 5 personas (y en ese orden). Luego de que el mismo es cargado con la ayuda o interacción del usuario, el 
// programa deberá recorrer el array e imprimir por consola el contenido de este respetando el formato que 
// se muestra en la siguiente imagen ejemplo de ejecución


namespace practical_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int ammount = 5;
            string[,] matrix = CreateUserMatrix(ammount);
            PrintMatrix(matrix);
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }

        static string[,] CreateUserMatrix(int ammount)
        {
            string[,] matrix = new string[ammount, 3];
            for (int row = 0; row != ammount; row++) {
                Console.Write("Ingrese el nombre: ");
                matrix[row, 0] = Console.ReadLine();
                Console.Write("Ingrese el apellido: ");
                matrix[row, 1] = Console.ReadLine();
                Console.Write("Ingrese la edad: ");
                matrix[row, 2] = Console.ReadLine();
            }
            Console.WriteLine();
            return matrix;
        }

        static void PrintMatrix(string[,] matrix)
        {
            int total_rows = matrix.GetLength(0);
            int half;
            if (total_rows % 2 == 0) half = (total_rows + 1) / 2;
            else half = total_rows / 2;
            // Imprimo todo hasta la mitad, omitiendo el último índice.
            for (int row = total_rows -2; row >= half; row--)
            {
                Console.WriteLine($"{matrix[row, 1]}, {matrix[row, 0]} {matrix[row, 2]}");
            }
            // Imprimo el último índice.
            Console.WriteLine($"{matrix[total_rows - 1, 1]}, {matrix[total_rows - 1, 0]} {matrix[total_rows - 1, 2]}");
            // Imprimo desde la mitad hasta el índice 0.
            for (int row = half - 1; row >= 0; row--)
            {
                Console.WriteLine($"{matrix[row, 1]}, {matrix[row, 0]} {matrix[row, 2]}");
            }
            Console.WriteLine();
        }
    }
}

```

Salida:
```
Ingrese el nombre: Leandro
Ingrese el apellido: Pini
Ingrese la edad: 43
Ingrese el nombre: Alejo
Ingrese el apellido: Sarmiento
Ingrese la edad: 22
Ingrese el nombre: Juan
Ingrese el apellido: Perez
Ingrese la edad: 55
Ingrese el nombre: Maria
Ingrese el apellido: Suarez
Ingrese la edad: 43
Ingrese el nombre: Nicolas
Ingrese el apellido: Rolon
Ingrese la edad: 26
Suarez, Maria 43

Perez, Juan 55
Rolon, Nicolas 26
Sarmiento, Alejo 22
Pini, Leandro 43

Presione una tecla para continuar...
```

