using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibrary
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
