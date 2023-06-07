// See https://aka.ms/new-console-template for more information
int numero1, numero2;

Console.Write("Ingrese el valor del primer número: ");
numero1 = int.Parse(Console.ReadLine());

Console.Write("Ingrese el valor del segundo número: ");
numero2 = int.Parse(Console.ReadLine());

Console.WriteLine($"La suma de {numero1} + {numero2} es de {numero1 + numero2}");