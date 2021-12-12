namespace GrabacionTemperaturaLibrary
{
    public class TemperatureScale
    {
        public double fahrenheit, celsius, kelvin, number;
        public string key;
        public TemperatureScale()
        {
            fahrenheit = 0;
            celsius = 0;
            kelvin = 0;
            number = 0;
            key = " ";
        }
        public string ToFahrenheit(double number, string key)
        {
            TemperatureScale temperatures = new TemperatureScale();
            if (key == "fahrenheit")
            {
                temperatures.fahrenheit = number;
                temperatures.celsius = (double)(number - 32) * 5 / 9;
                temperatures.kelvin = (double)temperatures.celsius + 273.15;

                return "Fahrenheit: " + temperatures.fahrenheit + "\nCelsius: " + temperatures.celsius + "\nKelvin: " + temperatures.kelvin;
            }
            else
            {
                return "Bad Request";
            }
        }
        public string ToCelsius(double number, string key)
        {
            TemperatureScale temperatures = new TemperatureScale();
            if (key == "celsius")
            {
                temperatures.fahrenheit = (double)(number * 1.8) + 32;
                temperatures.celsius = number;
                temperatures.kelvin = (double)number + 273.15;

                return "Fahrenheit: " + temperatures.fahrenheit + "\nCelsius: " + temperatures.celsius + "\nKelvin: " + temperatures.kelvin;
            }
            else
            {
                return "Bad Request";
            }
        }
        public string ToKelvin(double number, string key)
        {
            TemperatureScale temperatures = new TemperatureScale();
            if (key == "kelvin")
            {
                temperatures.fahrenheit = (double)((number - 273.15) * 1.8) + 32;
                temperatures.celsius = (double)number - 273.15;
                temperatures.kelvin = number;

                return "Fahrenheit: " + temperatures.fahrenheit + "\nCelsius: " + temperatures.celsius + "\nKelvin: " + temperatures.kelvin;
            }
            else
            {
                return "Bad Request";
            }
        }
    }
}
