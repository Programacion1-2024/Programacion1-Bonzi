// See https://aka.ms/new-console-template for more information

Console.WriteLine("Carga de productos. Finalizar con 0.");

int codigo = 1;
float precio;
int cantidad;
int mayor = 0;
int mayorCodigo = 0;
int cantidadVentas = 1;
int cantidadFinal = 0;
int total = 0;
string nombreProducto = "";

while (codigo != 0 && codigo <= 10)
{
    Console.Write("Ingresar el código del producto: ");
    if (!int.TryParse(Console.ReadLine(), out codigo) || codigo > 10 || codigo < 0)
    {
        Console.WriteLine("Error. Ingrese un valor válido.");
    }
    else if (codigo == 0)
    {
        break;
    }
    else
    {
        Console.Write("Ingrese el precio del producto: ");
        if (!float.TryParse(Console.ReadLine(), out precio) || precio <= 0)
        {
            Console.WriteLine("Error. Ingresar un valor válido.");
        }
        else
        {
            Console.Write("Ingrese la cantidad: ");
            if (!int.TryParse(Console.ReadLine(), out cantidad) || cantidad < 0)
            {
                Console.WriteLine("Error. Ingrece un valor válido.");
            }
            else
            {
                if (mayor < cantidad)
                {
                    mayor = cantidad;
                    mayorCodigo = codigo;
                }
                cantidadFinal = cantidad;

                while (cantidadVentas != 0)
                {
                    Console.Write("Ingrese la cantidad de ventas: ");
                    if (!int.TryParse(Console.ReadLine(), out cantidadVentas))
                    {
                        Console.WriteLine("Error. Ingrece un valor válido");
                    }
                    else
                    {
                        cantidadFinal -= cantidadVentas;
                        total += cantidadVentas;
                    }
                }
                if (cantidadFinal <= 0)
                {
                    Console.WriteLine("Tiene una cantidad menor o igual a 0");
                }
                Console.Write($"Ingrese el nombre del producto con código {codigo} ");
                nombreProducto =Console.ReadLine();

                if (total < 10)
                {
                    Console.WriteLine($"El producto {nombreProducto}, tuvo menos de 10 ventas");
                }
            }
        }
    }
}
Console.Write($"El código con mayor cantidad es: {mayorCodigo}");
