// See https://aka.ms/new-console-template for more information
//Ejercicio 8: Calcular el perímetro de un triángulo.
Console.Write("Ingrese la medida del lado 1: ");
double lado1 = double.Parse(Console.ReadLine());
Console.Write("Ingrese la medida del lado 2: ");
double lado2 = double.Parse(Console.ReadLine());
Console.Write("Ingrese la medida del lado 3: ");
double lado3 = double.Parse(Console.ReadLine());

double perimetro = lado1 + lado2 + lado3;
Console.Write("El perímetro del triángulo es: " + perimetro);

