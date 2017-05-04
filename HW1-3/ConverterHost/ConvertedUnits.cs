using System.Runtime.Serialization;

namespace ConverterHost
{
    [DataContract]
    public class ConvertedUnits
    {
        [DataMember]
        public double Inch { get; set; }
        [DataMember]
        public double Ft { get; set; }
        [DataMember]
        public double Yard { get; set; }
        [DataMember]
        public double Celsius { get; set; }
        [DataMember]
        public double Fahrenheit { get; set; }
    }
}
