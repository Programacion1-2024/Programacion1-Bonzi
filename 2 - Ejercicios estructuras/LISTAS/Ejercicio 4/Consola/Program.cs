// See https://aka.ms/new-console-template for more information

Console.WriteLine("Ingresar 5 notas.");

List<float> notas = new List<float>();
float nota;
float suma = 0;
float promedio = 0;

for (int i = 0; i < 5; i++)
{
    Console.Write($"Ingresar nota {i+1}: ");
    if (!float.TryParse(Console.ReadLine()?.Replace(",", "."), out nota))
    {
        Console.WriteLine("Error. Ingrese un valor válido. Intente de nuevo.");
        i--;
    }
    else
    {
        notas.Add(nota);
        suma += nota;
        promedio = suma / 5;
    }
}
Console.Write($"El promedio de las notas es de: {promedio}");
