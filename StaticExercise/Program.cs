namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"The boiling point of water is 100 degrees celcius, but it is also {TempConverter.CelsiusToFahrenheit(100)} degrees fahrenheit");
            Console.WriteLine($"You can preheat the oven to 400 degrees fahrenheit, but you can also do it in {TempConverter.FahrenheitToCelsius(450)} degrees celcius");
        }
    }
}
