// See https://aka.ms/new-console-template for more information
// El usuario ingresa un número entero positivo N y se deben mostrar todos los números enteros positivos pares desde 0 (incluido) hasta N

using static System.Runtime.InteropServices.JavaScript.JSType;

Console.Write("Ingrese un número positivo: ");
int numero;

if (!int.TryParse(Console.ReadLine(), out numero) || numero < 0)
{
    Console.Write("Error, debe ingresar un número correcto ");
}
else
{
    for (int i = 0; i <= numero; i++)
    {
        if (i % 2 == 0)
        {
            Console.WriteLine(i);
        }
    }
}