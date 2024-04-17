// See https://aka.ms/new-console-template for more information
// El usuario ingresa 5 pares de valores con el nombre del cliente y el total gastado indicar el cliente que gastó más.

string cliente = "";
double max = 0;
for (int i = 1; i <= 5; i++)
{
    Console.Write($"Nombre del cliente {i}: ");
    string nombreCliente = Console.ReadLine();

    Console.Write("Ingrese el total gastado del cliente: ");
    if (double.TryParse(Console.ReadLine(), out double totalGasto))
    {
        if (totalGasto > max)
        {
           max = totalGasto;
           cliente = nombreCliente;
        }
    }
    else
    {
        Console.WriteLine("Error, ingrese de nuevo");
        i--;
    }
}
Console.WriteLine($"El cliente que más gastó es: {cliente}");