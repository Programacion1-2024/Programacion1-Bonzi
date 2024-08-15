// See https://aka.ms/new-console-template for more information

// Ejercicio 2: Determinar si un número es par o impar.

Console.Write("Ingrese un número: ");
int numero = Int32.Parse(Console.ReadLine());
if (numero % 2 == 0)
{
    Console.Write("El número es par");
}
else
{
    Console.Write("El número es impar");
}

