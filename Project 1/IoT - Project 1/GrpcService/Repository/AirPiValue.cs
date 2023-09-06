using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GrpcService.Repository
{
    public class AirPiValue
    {
        [Key]
        public string Id { get; set; }

        public DateTime DateTime { get; set; }

        public double Volume { get; set; }

        public double LightLevel { get; set; }

        public double TemperatureDHT { get; set; }

        public double Pressure { get; set; }

        public double TemperatureBMP { get; set; }

        public double RelativeHumidity { get; set; }

        public double AirQuality { get; set; }

        public double CarbonMonoxide { get; set; }

        public double NitrogenDioxide { get; set; }

    }
}
