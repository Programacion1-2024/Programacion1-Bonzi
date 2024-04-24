// See https://aka.ms/new-console-template for more information
//Para calcular el total de una factura, el usuario ingresará pares de datos Costo unitario y cantidad comprada; cuando se ingrese costo 0 finaliza el ingreso de datos; informar el total adeudado.

double total = 0;
double costoUnitario;

while (true)
{
    Console.Write("Ingrese el costo unitario (0 para finalizar): ");
    if (!double.TryParse(Console.ReadLine(), out costoUnitario))
    {
        Console.WriteLine("Error. Ingrese un valor numérico correcto.");
    }

    if (costoUnitario == 0)
    {
        break; 
    }

    Console.Write("Ingrese la cantidad comprada: ");
    if (!int.TryParse(Console.ReadLine(), out int cantidad))
    {
        Console.WriteLine("Error. Ingrese un valor numérico correcto."); 
    }

    total += costoUnitario * cantidad; 
}

Console.WriteLine($"El total adeudado es de {total}");