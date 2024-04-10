// See https://aka.ms/new-console-template for more information
//Ejercicio 7: Mostrar el mayor de dos números.
Console.Write("Ingrese un número: ");
int n1, n2;
if (!Int32.TryParse(Console.ReadLine(), out n1))
{
    Console.Write("Error, debe ingresar un número correcto");
}   
else
{
    Console.Write("Ingrese otro número: ");
    if (!Int32.TryParse(Console.ReadLine(), out n2))
    {
        Console.Write("Error, debe ingresar un número correcto");
    }
    else
    {
        if (n1 > n2)
        {
            Console.Write(n1 + " es mayor");
        }
        else if (n1 == n2)
        {
            Console.Write("Son iguales");
        }
        else
        {
            Console.Write(n2 + " es mayor");
        }
    }
}


