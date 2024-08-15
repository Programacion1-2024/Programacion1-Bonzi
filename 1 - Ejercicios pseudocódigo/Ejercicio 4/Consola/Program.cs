// See https://aka.ms/new-console-template for more information
//Ejercicio 4: Calcular el promedio de tres números.
Console.Write("Ingrese el primer número a promediar: ");
double n1 = double.Parse(Console.ReadLine());
Console.Write("Ingrese el segundo número a promediar: ");
double n2 = double.Parse(Console.ReadLine());
Console.Write("Ingrese el tercer número a promediar: ");
double n3 = double.Parse(Console.ReadLine());

double promedio = (n1 + n2 + n3) / 3;
Console.Write("El promedio de los tres número es: " + promedio);