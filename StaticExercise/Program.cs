namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Try Fahrenheit to Celsius, enter a number");
            var userInput = Console.ReadLine();

            Console.WriteLine(TempConverter.FahrenheitToCelsius(double.Parse(userInput)));

            Console.WriteLine("Try Celsius to Fahrenheit, enter a number");
            var userInput2 = Console.ReadLine();

            Console.WriteLine(TempConverter.CelsiusToFahernheit(double.Parse(userInput2)));
        }
    }
}
