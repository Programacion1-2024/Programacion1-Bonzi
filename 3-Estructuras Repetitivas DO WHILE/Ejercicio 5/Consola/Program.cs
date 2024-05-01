// See https://aka.ms/new-console-template for more information
// Siguiendo con el ejercicio anterior, al ingresar uno mayor a 3 cifras se mostrará el promedio de los ingresados.

using System.Xml.Schema;

int numero = 0;
int suma = 0;
double promedio = 0;
int contador = 0;
do
{
    Console.Write("Ingrese un número (tres cifras para cortar): ");
    if (!int.TryParse(Console.ReadLine(), out numero))
    {
        Console.WriteLine("Error. Ingrese un número válido.");
    }
    if (numero <= 99)
    {
        contador ++;
        suma += numero;
    }
} while (numero <= 99);
promedio = suma / contador;
Console.WriteLine($"La suma de los números es: {suma}");
Console.WriteLine($"El promedio de los números es: {promedio}");
