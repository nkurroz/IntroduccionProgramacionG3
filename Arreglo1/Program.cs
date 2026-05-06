//Almacenar 10 edades en un arreglo, luego calcular el promedio de las edades, el máximo y el mínimo.
//Crear arreglo
int [] edades = new int[10];
//Pedir edades
for (int i = 0; i < edades.Length; i++)
{
    try
    {
       Console.WriteLine("Digita la edad n° " + (i + 1) + ":");
       edades[i] = int.Parse(Console.ReadLine()!); 

       if (edades[i] < 0)
       {
           Console.ForegroundColor = ConsoleColor.Red;
           Console.WriteLine("Error: La edad no puede ser negativa :v");
           i--; // Decrementar el índice para volver a pedir la edad
           Console.ResetColor();
       }
       else if (edades[i] > 100)
       {
           Console.ForegroundColor = ConsoleColor.Red;
           Console.WriteLine("Sos inmortal o que :v");
           i--; // Decrementar el índice para volver a pedir la edad
           Console.ResetColor();
       }
    }
    catch
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Error: Por favor, ingresa un número válido :v");
        i--; // Decrementar el índice para volver a pedir la edad
        Console.ResetColor();
    }
}
//Calcular promedio
int suma = 0, maximo = edades[0], minimo = edades[0];

foreach (int edad in edades)
{
    suma += edad;
    if (edad > maximo)
    {
        maximo = edad;
    }
    if (edad < minimo)
    {
        minimo = edad;
    }
}
double promedio = (double)suma / edades.Length;

//Mostrar resultados
Console.WriteLine("El promedio de las edades es: " + promedio);
Console.WriteLine("La edad máxima es: " + maximo);
Console.WriteLine("La edad mínima es: " + minimo);