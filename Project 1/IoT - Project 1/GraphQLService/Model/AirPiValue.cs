namespace GraphQLService.Model
{
    public class AirPiValue 
    {
        
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
