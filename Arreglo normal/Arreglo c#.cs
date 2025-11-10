using System;

class Program
{
    static void Main()
    {
        // Declarar e inicializar un arreglo de enteros
        int[] numeros = { 10, 20, 30, 40, 50 };

        // Acceder a elementos
        Console.WriteLine("Primer elemento: " + numeros[0]); // 10
        Console.WriteLine("Tercer elemento: " + numeros[2]); // 30

        // Modificar un elemento
        numeros[1] = 25; // ahora {10, 25, 30, 40, 50}

        // Recorrer el arreglo
        Console.WriteLine("Contenido del arreglo:");
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write(numeros[i] + " ");
        }

        Console.WriteLine(); // salto de línea

        // Tamaño del arreglo
        Console.WriteLine("Tamaño del arreglo: " + numeros.Length);
    }
}