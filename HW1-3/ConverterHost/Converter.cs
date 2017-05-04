namespace ConverterHost
{
    public class Converter : IConverter
    {
        public ConvertedUnits CelsiusToFahrenheit(double c)
        {
            ConvertedUnits fahrenheit= new ConvertedUnits();
            fahrenheit.Fahrenheit = ((9.0 / 5.0) * c) + 32;
            return fahrenheit;
        }

        public ConvertedUnits FahrenheitToCelsius(double f)
        {
            ConvertedUnits celsius = new ConvertedUnits();
            celsius.Celsius = (5.0 / 9.0) * (f - 32); ;
            return celsius;
        }

        public ConvertedUnits LinearMeasure(double meters)
        {
            ConvertedUnits converterMeters = new ConvertedUnits();
            converterMeters.Ft = meters * 3.281;
            converterMeters.Inch = meters * 0.3937 * 100;
            converterMeters.Yard = meters * 1.0936;
            return converterMeters;
        }
    }
}
