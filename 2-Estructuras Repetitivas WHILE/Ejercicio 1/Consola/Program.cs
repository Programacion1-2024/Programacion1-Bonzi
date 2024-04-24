// See https://aka.ms/new-console-template for more information
// El usuario ingresará valores positivos, cuando no tenga más valores ingresará 0 (cero).El sistema deberá informar la suma de los ingresados.

int numero = 1;
int suma = 0;
while (numero != 0)
{
    Console.Write("Ingrese números positivos: ");
    numero++;
    if (int.TryParse(Console.ReadLine(), out numero))
    {
        if (numero >= 0)
        {
            suma += numero;
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
Console.WriteLine($"La suma de los números es de: {suma}");