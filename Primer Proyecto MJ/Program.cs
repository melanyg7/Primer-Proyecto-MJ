using System;
public class Program
{
    static void Main(string[] args)
 {
    Console.WriteLine("Bienvenidos a nuestro primer sistema creado por github");

    Console.WriteLine("Ingrese su nombre para continuar");
    string Nombre = Console.ReadLine(); //Para recibir valores de caracter
    Console.WriteLine("Ingrese su edad");
    int Edad = Convert.ToInt32(Console.ReadLine());//Convertir a dato tipo double
    double EdadMeses = Edad * 12; //Calculos Matematicos
    Console.WriteLine(Nombre + "Tu edad en Meses es:" + EdadMeses + "Meses");//concatenacion
        if (Edad > 18)
        {
            Console.WriteLine(" Usted es Mayor de edad");
        }
        else
        {
            Console.WriteLine(" Usted es Menor de edad");
        }
    }
}
 
