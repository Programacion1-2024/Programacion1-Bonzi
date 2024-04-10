// See https://aka.ms/new-console-template for more information
//Ejercicio 6: Determinar si un número es positivo.
Console.Write("Ingrese un número: ");
int numero;

if (!Int32.TryParse(Console.ReadLine(), out numero))
{
    Console.Write("Error, debe ingresar un número correcto");
}
else
{
    if (numero > 0)
    {
        Console.Write("El número es positivo");
    }
    else
    {
        Console.Write("El número es negativo");
    }
}