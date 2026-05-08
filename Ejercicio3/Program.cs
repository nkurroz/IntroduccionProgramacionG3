//Un sistema físico analiza dos conjuntos de fuerzas aplicadas sobre una estructura metálica. Cada fuerza está representada mediante un vector de tamaño 5. El objetivo es calcular el producto escalar entre ambos vectores para analiz=ar su comportamiento.

Console.Clear();

int[] vector1 = new int[5];
int[] vector2 = new int[5];

for (int i = 0; i < 5; i++)
{
    try
    {
        Console.Write($"Ingrese el conjunto {i + 1} del primer vector: ");
        vector1[i] = int.Parse(Console.ReadLine()!);
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("ERROR: Caracter no válido");
        i--;
        Console.ResetColor();
    }
}

for (int i = 0; i < 5; i++)
{
    try
    {
        Console.Write($"Ingrese el conjunto {i + 1} del segundo vector: ");
        vector2[i] = int.Parse(Console.ReadLine()!);
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("ERROR: Caracter no válido");
        i--;
        Console.ResetColor();
    }

}

int ProductoEscalar = 0;
ProductoEscalar = vector1[0] * vector2[0] + vector1[1] * vector2[1] + vector1[2] * vector2[2] + vector1[3] * vector2[3] + vector1[4] * vector2[4];
Console.WriteLine($"El producto escalar entre ambos vectores es: {ProductoEscalar}");