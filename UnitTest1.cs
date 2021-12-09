using GrabacionTemperaturaLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProjectGrabacionTemperatura
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodToFahrenheit()
        {
            TemperatureScale objeto = new TemperatureScale();

            int number = 86;

            string key = "fahrenheit";

            string result = objeto.ToFahrenheit(number, key);

            Assert.AreEqual(86, 32, 305.15, result);

        }
        [TestMethod]
        public void TestMethodToCelsius()
        {
            TemperatureScale objeto = new TemperatureScale();

            int number = 32;

            string key = "celsius";

            string result = objeto.ToCelsius(number, key);

            Assert.AreEqual(86, 32, 305.15, result);
        }
        [TestMethod]
        public void TestMethodToKelvin()
        {
            TemperatureScale objeto = new TemperatureScale();

            int number = 300;

            string key = "kelvin";

            string result = objeto.ToKelvin(number, key);

            Assert.AreEqual(80.33, 26.85, 300, result);
        }
    }
}
