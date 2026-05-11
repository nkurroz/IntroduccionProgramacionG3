int[] ventas = new int[7];
int total = 0;
int menor = int.MaxValue;
int VentaMaxima = 0;

Console.Clear();

for (int i = 0; i < ventas.Length; i++)

    try
    {


        Console.Write($"Ingrese las ventas del día {i + 1}: ");
        ventas[i] = int.Parse(Console.ReadLine()!);

        total += ventas[i];

        if (ventas[i] > 150)
        {
            VentaMaxima++;
        }

        if (ventas[i] < menor)
        {
            menor = ventas[i];
        }

    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("ERROR: PARÁMETROS NO VÁLIDOS");
        i--;
        Console.ResetColor();
    }



Console.WriteLine("Ventas registradas:");

for (int i = 0; i < ventas.Length; i++)
{
    Console.WriteLine($"Día {i + 1}: {ventas[i]}");
}

Console.WriteLine($"Total vendido: {total}");
Console.WriteLine($"Días con ventas mayores a 150: {VentaMaxima}");
Console.WriteLine($"Venta más baja: {menor}");