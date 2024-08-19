using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("Bienvenido al sistema de cálculo de promedios.");


        Console.Write("Por favor, ingrese su nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("Por favor, ingrese su grado: ");
        string grado = Console.ReadLine();


        Console.WriteLine($"\nHola {nombre}, del grado {grado}.\n");

        double[] notas = new double[4];


        for (int i = 0; i < notas.Length; i++)
        {
            Console.Write($"Ingrese la nota {i + 1}: ");
            notas[i] = Convert.ToDouble(Console.ReadLine());
        }


        double promedio = CalcularPromedio(notas);


        string observacion = DeterminarObservacion(promedio);


        Console.WriteLine($"\n{nombre}, tu promedio es: {promedio:F2}");
        Console.WriteLine($"Observación: {observacion}");
    }


    static double CalcularPromedio(double[] notas)
    {
        double suma = 0;
        for (int i = 0; i < notas.Length; i++)
        {
            suma += notas[i];
        }
        return suma / notas.Length;
    }


    static string DeterminarObservacion(double promedio)
    {
        if (promedio < 70)
        {
            return "Reprobado";
        }
        else if (promedio >= 70 && promedio <= 80)
        {
            return "Bueno";
        }
        else if (promedio >= 81 && promedio <= 90)
        {
            return "Muy Bueno";
        }
        else
        {
            return "Excelente";
        }
    }
}