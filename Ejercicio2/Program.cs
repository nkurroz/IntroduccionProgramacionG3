//Un robot industrial realiza movimientos en cinco direcciones diferentes dentro de una planta automatizada. El equipo de ingeniería necesita calcular la magnitud total del vector de movimiento para validar la trayectoria recorrida.

Console.Clear();
int[] vectores = new int[5];
double totalvector = 0;
double trayectoria = 0;

for (int i = 0; i < vectores.Length; i++)
{
    try
    {
        Console.Write($"Ingrese el valor del vector de movimento en la dirección {i + 1}: ");
        vectores[i] = int.Parse(Console.ReadLine()!);
        totalvector = Math.Sqrt(totalvector * totalvector + vectores[i] * vectores[i]);
        trayectoria += vectores[i];
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("ERROR: Formato no válido");
        i--;
        Console.ResetColor();
    }

}

Console.WriteLine($"La magnitud total del vector de movimiento es: {totalvector}");
Console.WriteLine($"La trayectoria recorrida es: {trayectoria}");

