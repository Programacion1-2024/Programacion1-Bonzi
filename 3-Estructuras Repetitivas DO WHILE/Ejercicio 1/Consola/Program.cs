// See https://aka.ms/new-console-template for more information
// Para el ingreso a un sistema se necesita solicitar nombre de usuario y clave, repetir este ingreso hasta que el usuario ingrese la clave correcta: 667788.

string nombreUsuario;
int contraseña;
do
{
    Console.Write("Ingrese su usuario: ");
    nombreUsuario = Console.ReadLine();

    Console.Write("Ingrese su contraseña: ");
    contraseña = Convert.ToInt32(Console.ReadLine());

    if (contraseña != 667788)
    {
        Console.WriteLine("Error. Ingrese una contraseña válida");
    }
} while (contraseña != 667788);
Console.WriteLine("¡Bienvenido!");