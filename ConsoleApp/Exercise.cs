using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Text;

namespace Exercises
{
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
        // LOOPS
        public static void GuessTheNumber()
        {
            int secret_number = 7;
            int guessed_number = -1;
            int tries = 0;
            Console.WriteLine("Adivina el número entre 0 y 10!");
            while (guessed_number != secret_number)
            {
                tries++;
                guessed_number = int.Parse(Console.ReadLine());
                if (guessed_number == secret_number)
                {
                    Console.WriteLine($"Lo has adivinado! Te han tomado {tries} intentos");
                    continue;
                }
                else
                {
                    string hint = (guessed_number < secret_number) ? "mayor" : "menor";
                    Console.WriteLine($"Número incorrecto, intentalo de nuevo.\nPista: El número secreto es {hint}");
                }
            }
        }
        public static void GradeAnalyzer()
        {
            double[] initialGrades = [6.0, 9.6, 7.9, 8.5, 5.0, 10.0];

            ProcessGrades(initialGrades);
            void ProcessGrades(double[] grades)
            {
                double max = initialGrades[0];
                double min = initialGrades[0];
                double sum = 0;
                foreach (double grade in grades)
                {
                    if (grade > max) max = grade;
                    if (min > grade) min = grade;
                    sum += grade;
                }
                Console.WriteLine($"Calificacion mas alta: {max}");
                Console.WriteLine($"Calificacion mas baja: {min}");
                Console.WriteLine($"Calificacion promedio: {sum / grades.Length}");
            }
        }
        public static void FilteredMultiplicationTable()
        {
            int inputNumber = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 12; i++)
            {
                if ((inputNumber * i) % 4 == 0) continue;
                Console.WriteLine($"{inputNumber}x{i}={inputNumber * i}");
            }
        }
        public static void ATMPinLockout()
        {
            string pin = "1432";
            string guessedPin;
            int attempts = 3;
            Console.WriteLine("Guess the PIN. You have 3 attempts.");
            do
            {
                guessedPin = Console.ReadLine();
                if(guessedPin==pin) break;
                attempts++;
            }while(attempts<3 && guessedPin!=pin);
            if(guessedPin == pin)
            {
                Console.WriteLine("Access Granted");
            }
            else
            {
                Console.WriteLine("Account Locked");
            }
        }
        // METHODS
        public static void BillHelper()
        {
            Console.WriteLine($"Calling with subtotal of 50, and a tip of 15%: {CalculateTotalBill(50)}")
            double CalculateTotalBill(double subtotal, double tipPercentage = 15.0)
            {
                return subtotal + (subtotal*tipPercentage)/100;
            }
        }
        public static void TemperatureHelper()
        {
            const int celsius = 15;
            Console.WriteLine($"Converting {celsius} Celsius to Fahrenheit...");
            Console.WriteLine($"{celsius} celsius = {CelsiusToFahrenheit(celsius)} fahrenheit");
            double CelsiusToFahrenheit(double celsius)
            {
                return (celsius * 9 / 5 ) + 32;
            }
        }
        public static void MethodOverloading()
        {
            Console.WriteLine($"Area of a circle with 5 as radius: {CalculateArea(5.0)}");
            Console.WriteLine($"Area of a rectangle with 10 as width and 20 as height: {CalculateArea(10D,20D)}");
            Console.WriteLine($"Area of a triangle with 5 as base length and 25 as height: {CalculateArea(5D, 25D)}");
            double CalculateArea(double radius)
            {
                return Math.PI*(radius*radius);
            }
            double CalculateArea(double width, double height)
            {
                return width*height;
            }
            double CalculateArea(double baseLength, double height, bool isTriangle)
            {
                return (0.5 * baseLength * height);
            }
        }
        // Arrays
        
    }
}