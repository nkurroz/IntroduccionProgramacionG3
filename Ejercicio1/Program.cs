//Una estación meteorológica necesita registrar las temperaturas máximas de 7 días.
//El programa debe: Solicitar al usuario las 7 temperaturas. Guardar los datos en un arreglo unidimensional. Mostrar todas las temperaturas registradas. Calcular el promedio semanal. Indicar la temperatura más alta y la más baja.

int[] temperaturas = new int[7];
int suma = 0;
int max = int.MinValue;
int min = int.MaxValue;

Console.Clear();
for (int i = 0; i < temperaturas.Length; i++)
    try
    {
        Console.Write($"Ingrese la temperatura del día {i + 1} en grados Celsius: ");
        temperaturas[i] = int.Parse(Console.ReadLine()!);
        suma += temperaturas[i];

        if (temperaturas[i] > max)
        {
            max = temperaturas[i];
        }

        if (temperaturas[i] < min)
        {
            min = temperaturas[i];
        }
        
        Console.WriteLine("Temperaturas registradas:");
        Console.WriteLine($"Día {i + 1}: {temperaturas[i]}°C");
        double promedio = (double)suma / temperaturas.Length;
        Console.WriteLine($"Promedio semanal: {promedio:F2}°C");
        Console.WriteLine($"Temperatura más alta: {max}°C");
        Console.WriteLine($"Temperatura más baja: {min}°C");
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("ERROR: PARÁMETROS NO VÁLIDOS");
        i--;
        Console.ResetColor();
    }

