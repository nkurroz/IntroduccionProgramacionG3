//Crea un arreglo de 15 estudiantes, luego calcula el promedio de las notas, y los 3 primeros lugares, no se puede ingresar notas menores a 0 ni mayores a 100.
Console.BackgroundColor = ConsoleColor.Magenta;
Console.Clear();
Console.ForegroundColor = ConsoleColor.Black;

int[] notas = new int[15];
int suma = 0;
double promedio = 0;
int contError = 0;

for (int i = 0; i < notas.Length; i++)
{
    if (contError >= 3)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Te falla, no :v");
        Console.ResetColor();
        return; // Salir del programa
    }

    try
    {
        Console.WriteLine($"Ingrese la nota del estudiante {i + 1}:");
        int nota = int.Parse(Console.ReadLine()!);

        if (nota < 0 || nota > 100)
        {
            throw new ArgumentOutOfRangeException("La nota debe ser entre 0 y 100.");
        }
        notas[i] = nota;
    }
    catch (FormatException)
    {
        Console.WriteLine("Error:ingrese un número entero.");
        i--; // Volver a pedir la nota para el mismo estudiante
        contError++; // Incrementar el contador de errores
    }
    catch (ArgumentOutOfRangeException ex)
    {
        Console.WriteLine(ex.Message);
        i--; // Volver a pedir la nota para el mismo estudiante
        contError++; // Incrementar el contador de errores
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Ocurrió un error inesperado: {ex.Message}");
        i--; // Volver a pedir la nota para el mismo estudiante
        contError++; // Incrementar el contador de errores
    }
}

foreach (int nota in notas)
{
    suma += nota;
    Console.WriteLine($"Nota: {nota}");
    Console.WriteLine($"Cantidad de notas: {notas.Length}");
}
promedio = (double)suma / notas.Length;
Console.WriteLine($"El promedio de las notas es: {promedio:N2}");

Array.Sort(notas);
Array.Reverse(notas);
for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"Lugar {i + 1}: {notas[i]}");
}
