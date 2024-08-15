// See https://aka.ms/new-console-template for more information
//Se le solicitará ingresar números al usuario, se repetirá el pedido hasta que ingrese un número mayor a 3 cifras. Mostrar la suma total de todos los ingresados antes del corte.

int numero = 0;
int suma = 0;
do
{
    Console.Write("Ingrese un número: ");
    if (!int.TryParse(Console.ReadLine(), out numero))
    {
        Console.WriteLine("Error. Ingrese un número válido.");
    }
    if (numero <= 99)
    {
        suma += numero;
    }
} while (numero <= 99);
Console.WriteLine($"La suma de los números es: {suma}");