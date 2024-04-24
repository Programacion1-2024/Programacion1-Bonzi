// See https://aka.ms/new-console-template for more information
// Para calcular el consumo total de un cliente, el usuario primero ingresará cuántos productos compró; luego el sistema solicitará que ingrese el costo de cada uno de esos productos consumidos; al terminar informará el total adeudado por el cliente.

Console.Write("Ingrese la cantidad de productos comprados: ");
int cantidad = Int32.Parse(Console.ReadLine());

double totalcosto = 0;
while (cantidad != 0)
{
    Console.Write("Ingrese el costo: ");
    if (double.TryParse(Console.ReadLine(), out double costo))
    {
        cantidad--;
        totalcosto += costo;
    }
    else
    {
        Console.Write("Error. Ingrese un número válido.");
    }
}
Console.WriteLine($"El total adeudado es de {totalcosto}");