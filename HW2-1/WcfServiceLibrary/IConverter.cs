using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
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
