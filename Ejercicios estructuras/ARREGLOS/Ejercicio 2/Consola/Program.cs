// See https://aka.ms/new-console-template for more information
// Ejercicio 2: Calcular promedio de notas utilizando un arreglo. Consigna: El usuario debe ingresar 5 notas. El programa debe calcular el promedio de estas notas y mostrarlo en la consola. Utiliza un arreglo para almacenar las notas.

double suma = 0;
double promedio = 0;
double[] notas = new double[5];

for (int i = 0; i < notas.Length; i++)
{
    Console.Write("Ingrese la nota: ");
    if (double.TryParse(Console.ReadLine(), out double nota))
    {
        notas[i] = nota;
    }
}
for (int i = 0;i < notas.Length; i++)
{
    suma += notas[i];   
    promedio = suma / 5;
}
Console.Write($"El promedio de las notas es de: {promedio}");