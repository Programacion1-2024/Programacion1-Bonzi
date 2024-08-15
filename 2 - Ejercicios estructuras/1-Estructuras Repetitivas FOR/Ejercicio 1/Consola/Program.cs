// See https://aka.ms/new-console-template for more information
// El usuario necesita ingresar 5 valores enteros, el sistema deberá informar la suma de los 5.
Console.WriteLine("Ingrese 5 números: ");

int suma = 0;
for (int i = 1; i <= 5; i++)
{
    Console.Write($"Valor {i}: ");
    if (int.TryParse(Console.ReadLine(), out int numero))
    {
        suma += numero;
    }
    else
    {
        Console.WriteLine("Entrada inválida. Por favor ingrese un número válido.");
        i--;
    }
}
Console.WriteLine($"La suma de los 5 números es: {suma}");
