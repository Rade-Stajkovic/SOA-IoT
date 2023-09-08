using InfluxDB.Client;
using InfluxDB.Client.Api.Domain;
using InfluxDB.Client.Writes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace VisualizationService
{
    public interface IDbClient
    {
        Task WriteToDatabase(long payload);
    }
    public class InfluxDbClient : IDbClient
    {
        public readonly InfluxDBClient _client;
        public InfluxDbClient()
        {
            _client = InfluxDBClientFactory.Create(url: "http://172.26.176.1:8086", "student", "student2023".ToCharArray());
        }
        public async Task WriteToDatabase(long value)
        {
            try
            {
             
                DateTime timestamp = DateTime.UtcNow;

                var point = PointData
                    .Measurement("airpi")
                    .Tag("timestamp", timestamp.ToString())
                    .Field("nitrogendioxide", value.ToString())
                    .Timestamp(DateTime.UtcNow, WritePrecision.Ns);

                Console.WriteLine("Write in db check!");
                await _client.GetWriteApiAsync().WritePointAsync(point, "IoT3", "AirPI");
                Console.WriteLine("Write in db done!");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }

        }
    }

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
