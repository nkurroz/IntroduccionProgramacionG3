int[] vector1 = new int[5];
int[] vector2 = new int[5];
int[] vectorSuma = new int[5];

Console.WriteLine("Ingrese los valores del primer vector:");
for (int i = 0; i < vector1.Length; i++)
{
    try
    {
        Console.Write($"Valor {i + 1}: ");
        vector1[i] = int.Parse(Console.ReadLine()!);
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
        i--; // Decrementar el índice para volver a solicitar el valor}
        Console.ResetColor();
    }
}

Console.WriteLine("Ingrese los valores del segundo vector:");
for (int i = 0; i < vector2.Length; i++)
{
    try
    {
        Console.Write($"Valor {i + 1}: ");
        vector2[i] = int.Parse(Console.ReadLine()!);
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
        i--;
        Console.ResetColor();
    }
}

for (int i = 0; i < vectorSuma.Length; i++)
{
    vectorSuma[i] = vector1[i] + vector2[i];
}

Console.WriteLine("La suma de los dos vectores es:");
for (int i = 0; i < vectorSuma.Length; i++)
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine($"Valor {i + 1}: {vectorSuma[i]}");
    Console.ResetColor();
}