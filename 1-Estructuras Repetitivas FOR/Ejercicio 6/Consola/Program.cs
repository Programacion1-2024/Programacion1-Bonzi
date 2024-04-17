// See https://aka.ms/new-console-template for more information
// El usuario ingresa un número N y se debe mostrar como resultado el factorial de dicho número.

int contador = 1;
Console.Write("Ingresar un número: ");
int numero;
if (int.TryParse(Console.ReadLine(), out numero))
{
    for (int i = 1; i <= numero; i++)
{
    contador *= i;
    }
    Console.WriteLine($"El factorial es: {contador}");
}
else
{
    Console.WriteLine("Error. Ingresar un número válido");
}

