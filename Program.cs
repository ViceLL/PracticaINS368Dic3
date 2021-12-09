using GrabacionTemperaturaLibrary;

string key, selection;
int temperature = 0;
Console.WriteLine("Escriba que escala de temperatura va a ingresar (fahrenheit, celsius o kelvin): ");
key = Console.ReadLine();

Console.WriteLine("Ingrese el numero de la temperatura: ");
temperature = int.Parse(Console.ReadLine());

TemperatureScale ob = new TemperatureScale();

if (key == "fahrenheit")
{
    selection = ob.ToFahrenheit(temperature, key);
    Console.WriteLine("\n Conversion de temperatura: \n");
    Console.WriteLine(selection);
}
else if(key == "celsius")
{
    selection = ob.ToCelsius(temperature, key);
    Console.WriteLine("\n Conversion de temperatura: \n");
    Console.WriteLine(selection);
}
else if (key == "kelvin")
{
    selection = ob.ToKelvin(temperature, key);
    Console.WriteLine("\n Conversion de temperatura: \n");
    Console.WriteLine(selection);
}