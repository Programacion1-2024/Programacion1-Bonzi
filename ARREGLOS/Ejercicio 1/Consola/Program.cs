// See https://aka.ms/new-console-template for more information
//Ejercicio 1: Ingresar datos en un arreglo y mostrarlos. Consigna: El usuario debe ingresar 5 números enteros. El programa debe almacenar estos números en un arreglo y luego mostrarlos en la consola.

int[] numeros = new int[5];

for (int i = 0; i < numeros.Length; i++)
{
    Console.Write("Ingrese un número: ");
    if (!int.TryParse(Console.ReadLine(), out numeros[i]))
    {
        Console.WriteLine("Error. Ingrese un valor válido.");
    }
}
for (int i = 0;i < numeros.Length; i++)
{
    Console.WriteLine($"Elemento {i}: {numeros[i]}");
}

