// See https://aka.ms/new-console-template for more information

Console.WriteLine("Ingresar 5 números enteros.");

List<int> numeros = new List<int>();
int numero;

for (int i = 0; i < 5; i++)
{
    Console.Write($"Ingresar número {i+1}: ");
    if (!int.TryParse( Console.ReadLine(), out numero))
    {
        Console.WriteLine("Error. Ingrese un valor válido. Intente de nuevo.");
        i--;
    }
    else
    {
        numeros.Add(numero);
    }
}
foreach (int i in numeros)
{
    Console.WriteLine($"Número: {i}");
}
