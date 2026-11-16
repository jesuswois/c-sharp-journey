using System;
using Exercises;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Testing Syntax!");
        /*
        Exercise.GradeAnalyzer();
        Exercise.RegistrationForm();
        Exercise.GuessTheNumber();
        Exercise.PerimeterAndArea();
        */
        //// Loops
        /*
        Exercise.FilteredMultiplicationTable();
        Exercise.ATMPinLockout();
        */
        //// Methods
        /*
        Exercise.BillHelper();
        Exercise.TemperatureHelper();
        Exercise.MethodOverloading();
        */
        //// Arrays
        /*
        Exercise.ManualArrayOperations();
        Exercise.WeeklyTemperatureTracker();
        */
        // Lists
        /*
        Exercise.DynamicShoppingListing();
        */
        // Dictionaries
        /*
        Exercise.WordFrequencyCounter();
        */
        // HashSets
        /*
        Exercise.EventAttendanceTracker();
        */
        // OOP SECTION
        Product producto1 = new Product();
        producto1.Price = 1;
        Console.WriteLine($"Product1's price: {producto1.Price}");
        producto1.Price = -1;
        Console.WriteLine($"Product1's price: {producto1.Price}");
    }
}