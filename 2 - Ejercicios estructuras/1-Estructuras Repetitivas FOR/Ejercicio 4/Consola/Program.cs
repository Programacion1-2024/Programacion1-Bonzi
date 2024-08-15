// See https://aka.ms/new-console-template for more information
// De una lista de 8 números indicar cual es el mayor.
using System;

Console.WriteLine("Ingrese 8 valores enteros:");

int max = 0;
for (int i = 1; i <= 8; i++)
{
    Console.Write($"Valor {i}: ");
    if (int.TryParse(Console.ReadLine(), out int numero))
    {
        if (numero > max)
        {
            max = numero;
        }
    }
    else
    {
        // Si la entrada no es válida, muestro error
        Console.WriteLine("Entrada inválida. Por favor ingrese un número válido.");
        i--;
    }
}
Console.WriteLine($"El mayor es: {max}");
