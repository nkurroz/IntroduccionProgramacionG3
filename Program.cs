//Leer un numero entero y mostrar todos sus antecesores elevados al cubo
using Math = System.Math;
Console.Clear();
int numero;

while (true)
{
    Console.Write("Ingrese un numero entero: ");
    if (int.TryParse(Console.ReadLine(), out numero))
    {
        break;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Entrada no valida. Por favor, ingrese un numero entero.");
        Console.ResetColor();
    }
}

Console.WriteLine($"Los antecesores de {numero} elevados al cubo son:");
int contador = 1;
while (contador < numero)
{
    double cubo = (int)Math.Pow(contador, 3);
    Console.WriteLine($"{contador}^3 = {cubo}");
    contador++;
}

