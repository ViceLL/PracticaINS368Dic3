int temperatura;
double celsius_c,celsius_f, celsius_k;
double fahrenheit_c, fahrenheit_f, fahrenheit_k, kelvin_c, kelvin_f, kelvin_k;
Console.WriteLine("Ingrese la temperatura que desee (1.Celsius, 2.Fahrenheit o 3.Kelvin): ");
temperatura = int.Parse(Console.ReadLine()); 

if (temperatura == 1)
{
    celsius_c = int.Parse(Console.ReadLine());
    FahrenheitC();
    CelsiusC();
    KelvinC();
}

if (temperatura == 2)
{
    fahrenheit_f = int.Parse(Console.ReadLine());
    FahrenheitF();
    CelsiusF();
    KelvinF();

}

if (temperatura == 3)
{
    kelvin_k = int.Parse(Console.ReadLine());
    KelvinK();
    CelsiusK();
    FahrenheitK(); 

}

else
{
    Console.WriteLine("No ingreso una opcion valida. Ingrese el numero adecuado para calcular su temperatura correspondiente.");
}
  
void FahrenheitC()
{    
    fahrenheit_c = (celsius_c * 1.8) + 32;
    Console.WriteLine("Fahrenheit: " + fahrenheit_c);
}

void CelsiusC()
{
    Console.WriteLine("Celsius: " + celsius_c);
}

void KelvinC()
{   
    kelvin_c = celsius_c + 273.15;
    Console.WriteLine("Kelvin: " + kelvin_c);
}

void FahrenheitF()
{
    Console.WriteLine("Fahrenheit: " + fahrenheit_f);
}

void CelsiusF()
{
    celsius_f = (fahrenheit_f - 32) * (5 / 9);
    Console.WriteLine("Celsius: " + celsius_f);
}

void KelvinF()
{
    kelvin_f = celsius_f + 273.15;
    Console.WriteLine("Kelvin: " + kelvin_f);
}

void KelvinK()
{
    Console.WriteLine("Kelvin: " + kelvin_k);
}

void FahrenheitK()
{
     fahrenheit_k = (celsius_k * 5/9) + 273.15;
}

void CelsiusK()
{
    celsius_k = kelvin_k - 273.15;
    Console.WriteLine("Kelvin: " + kelvin_k);
}
