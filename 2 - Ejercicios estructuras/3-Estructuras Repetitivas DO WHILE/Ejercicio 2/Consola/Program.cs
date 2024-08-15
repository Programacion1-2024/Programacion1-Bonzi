// See https://aka.ms/new-console-template for more information
// Se le solicitará ingresar un número al usuario, se repetirá el pedido hasta que ingrese un positivo.

int numero;  
do
{
    Console.Write("Ingrese un número: ");
    if (!int.TryParse(Console.ReadLine(), out numero) || numero <= 0)
    {
        Console.WriteLine("Error. Ingrese un número positivo.");
    }
} while (numero <= 0); 

Console.WriteLine("Gracias por ingresar un número positivo");



