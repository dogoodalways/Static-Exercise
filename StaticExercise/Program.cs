namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Fahrenheit -> Celsius: {TempConverter.FahrenheitToCelsius(32)} ");
            Console.WriteLine();

            Console.Write($"Celsius -> Fahrenheit; {TempConverter.CelsiusToFahrenheit(0)}");
            Console.WriteLine();
            

        }
    }
}
