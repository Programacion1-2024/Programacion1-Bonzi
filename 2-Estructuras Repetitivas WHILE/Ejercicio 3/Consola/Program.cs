// See https://aka.ms/new-console-template for more information
// El usuario ingresará una lista de nombre de persona, cuando se ingresé un nombre vacío, sin datos; el sistema informará cuántos nombres de han ingresado.


int contador = 0;

while (true)
{
    Console.Write("Ingrese el nombre de la persona: ");
    string nombre = Console.ReadLine();
    if (nombre != "")
    {
        contador++;
    }
    else
    {
        break;
    }
}
Console.Write($"Se han ingresado {contador} nombres");