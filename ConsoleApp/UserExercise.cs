using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises;

public class Exercise
{
    public static void RegistrationForm()
    {
        Console.WriteLine("/// Ficha de Registro");
        // Asking for data
        Console.Write("Ingrese su nombre: ");
        string input_name = Console.ReadLine();
        Console.Write("Ingrese sus apellidos: ");
        string input_last_name = Console.ReadLine();
        Console.Write("Ingrese su edad: ");
        int input_age = int.Parse(Console.ReadLine());
        Console.Write("Ingrese país de origen: ");
        string input_country = Console.ReadLine();

        // Printing
        Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||");
        Console.WriteLine("FICHA DE REGISTRO");
        Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||");
        Console.WriteLine($"Nombre completo: {input_name} {input_last_name}");
        Console.WriteLine($"Edad: {input_age} años");
        Console.WriteLine($"País: {input_country}");
        Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||");
    }
    public static void PerimeterAndArea()
    {
        Console.WriteLine("/// Calculadora de area y perímetro de un rectangulo!");
        Console.Write("Datos de Rectangulo:\nBase: ");
        double rectangleBase = double.Parse(Console.ReadLine());
        Console.Write("Altura: ");
        double rectangleHeight = double.Parse(Console.ReadLine());
        double rectangleArea = rectangleBase * rectangleHeight;
        double rectanglePerimeter = 2 * (rectangleBase + rectangleHeight); 
        Console.WriteLine($"- RESULTADOS -\nArea de Rectangulo: {rectangleArea}\nPerímetro: {rectanglePerimeter}");
    }
    public static void DiscountAndInvoice()
    {

    }
}
