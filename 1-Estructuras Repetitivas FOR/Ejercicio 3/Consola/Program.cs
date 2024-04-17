// See https://aka.ms/new-console-template for more information
//Para calcular el total de una factura, el usuario ingresará pares de datos Costo unitario y cantidad comprada; de unas 5 compras; Informar el total adeudado.

double total = 0;
for (int i = 1; i <= 5; i++)
{
    Console.Write($"Costo unitario {i}: ");
    if (!double.TryParse(Console.ReadLine(), out double costoUnitario))
    {
        Console.WriteLine("Error. Dato inválido, ingrese de nuevo.");
        i--; 
    }
    else
    {
        Console.Write($"Ingrese cantidad comprada {i}: ");
        if (!int.TryParse(Console.ReadLine(), out int cantidad))
        {
            Console.WriteLine("Error. Dato inválido, ingrese de nuevo.");
            i--; 
        }
        else
        {
            double costoTotal = costoUnitario * cantidad;
            total += costoTotal; 
        }
    }
}
Console.WriteLine($"El total adeudado es de: {total}");
