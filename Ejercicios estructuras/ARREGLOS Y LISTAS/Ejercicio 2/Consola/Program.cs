// See https://aka.ms/new-console-template for more information
// 2- Filtrar números pares en una lista. El usuario ingresará números enteros uno por uno. El programa debe solicitar al usuario que ingrese los números hasta que ingrese el número 0 para finalizar. Luego, debe mostrar los números ingresados de mayor a menor en la consola. Si se ingresa un valor no válido, se mostrará un mensaje de error.

Console.WriteLine("Ingresar números enteros. Finalizar con 0.");

List<int> numeros = new List<int>();

int numero = 1;

while(numero != 0)
{
    Console.Write("Ingresar un número: ");
    if (!int.TryParse(Console.ReadLine(), out numero))
    {
        Console.WriteLine("Error. Ingrese un valor válido.");
        numero = 1;
    }
    else if (numero != 0)
    {
        numeros.Add(numero);
    }
}
var numerosOrdenados = numeros.OrderBy(num => num).ToList();

Console.WriteLine("Números ordenados de mayor a menor:");
foreach (int i in numerosOrdenados)
{
    Console.WriteLine(i);
}

