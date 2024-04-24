// See https://aka.ms/new-console-template for more information
// Siguiendo el ejercicio anterior, calcular el promedio de los valores ingresados.

int numero = 1;
double suma = 0;
double promedio = 0;
int contador = 0;
while (numero != 0)
{
    Console.Write("Ingrese números positivos: ");
    if (int.TryParse(Console.ReadLine(), out numero))
    {
        if (numero >= 0)
        {
            suma += numero;
            if (numero != 0)
            {
                contador++;
            }
        }
        else
        {
            Console.WriteLine("Error. Ingrese un número positivo.");
        }
    }
    else
    {
        break;
    }
}

promedio = suma / contador;

Console.WriteLine($"La suma de los números es de: {suma}");
Console.WriteLine($"El promedio de los valores ingresado es de: {promedio}");