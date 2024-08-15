// See https://aka.ms/new-console-template for more information
// 1 - Ordenar palabras alfabéticamente. El usuario ingresará una lista de palabras. El programa debe guardar, ordenar estas palabras alfabéticamente y mostrarlas en la consola.

List <string> nombres = new List<string>(); 

while (true)
{
    Console.Write("Ingresar la palabra: ");
    string? palabra = Console.ReadLine();
    if (palabra != " ")
    {
        nombres.Add(palabra);
    }
    else
    {
        break;
    }
}
nombres.Sort();
Console.WriteLine("Palabras ordenadas alfabeticamente: ");
foreach (string nombre in nombres)
{
    Console.WriteLine(nombre);
}