using System.ServiceModel;

namespace ConverterHost
{
    [ServiceContract]
    public interface IConverter
    {
        [OperationContract]
        ConvertedUnits LinearMeasure(double meters);

        [OperationContract]
        ConvertedUnits CelsiusToFahrenheit(double c);

        [OperationContract]
        ConvertedUnits FahrenheitToCelsius(double f);
    }
}
