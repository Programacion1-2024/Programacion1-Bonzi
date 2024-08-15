// See https://aka.ms/new-console-template for more information
// Se necesita calcular el promedio de 8 números ingresados por el usuario.

using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Ingresar 8 números: ");

double suma = 0;
double promedio = 0;
for (int i = 1; i <=8; i++)
{
    Console.Write($"Número {i}: ");
    if (double.TryParse(Console.ReadLine(), out double numero))
    {
        suma += numero;
    }
    else
    {
        Console.WriteLine("Error. Ingrese un número válido: ");
        i--;
    }
}
promedio = suma / 8;
Console.WriteLine($" El promedio de los números ingresados es: {promedio}");