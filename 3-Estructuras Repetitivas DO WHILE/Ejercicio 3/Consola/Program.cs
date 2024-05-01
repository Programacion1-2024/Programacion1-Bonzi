// See https://aka.ms/new-console-template for more information
// Siguiendo con el ejercicio anterior, al ingresar el positivo se mostrará el promedio de los números negativos ingresados.

int numero;
int contador = 0;
double promedio;
double suma = 0;
do
{
    Console.Write("Ingrese un número: ");
    if (!int.TryParse(Console.ReadLine(), out numero) || numero <= 0)
    {
        Console.WriteLine("Error. Ingrese un número positivo.");
        if (numero < 0) 
        {
            contador++; 
            suma += numero;
        }
    }
} while (numero <= 0);

Console.WriteLine("Gracias por ingresar un número positivo");

if (contador > 0)
{
    promedio = suma / contador;
    Console.WriteLine($"El promedio de los números negativos es: {promedio}");
}
else
{
    Console.WriteLine("No se ingresaron números negativos.");
}
