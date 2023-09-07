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

namespace AnalyticsService
{
    public interface IDbClient
    {
        Task WriteToDatabase(string payload);
    }
    public class InfluxDbClient : IDbClient
    {
        public readonly InfluxDBClient _client;
        public InfluxDbClient()
        {
           _client = InfluxDBClientFactory.Create(url: "http://10.14.100.16:8086", "student", "student2023".ToCharArray());
        }
        public async Task WriteToDatabase(string payload)
        {
            try
            {
                var value = JsonSerializer.Deserialize<AirPiValue>(payload);
                DateTime timestamp = DateTime.UtcNow;

                var point = PointData
                    .Measurement("airpidata")
                    .Tag("timestamp", timestamp.ToString())
                    .Field("id", value.Id.ToString())
                    .Field("datetime", value.DateTime.ToString())
                    .Field("volume", value.Volume.ToString())
                    .Field("lightlevel", value.Light_Level.ToString())
                    .Field("temperatureDHT", value.Temperature_DHT.ToString())
                    .Field("pressure", value.Pressure.ToString())
                    .Field("temperatureBMP", value.Temperature_BMP.ToString())
                    .Field("relativehumidity", value.Relative_Humidity.ToString())
                    .Field("airquality", value.Air_Quality.ToString())
                    .Field("carbonmonoxide", value.Carbon_Monoxide.ToString())
                    .Field("nitrogendioxide", value.Nitrogen_Dioxide.ToString())
                    .Timestamp(DateTime.UtcNow, WritePrecision.Ns);

                Console.WriteLine("Write in db check!");
                await _client.GetWriteApiAsync().WritePointAsync(point, "IoT2", "AirPI");
                Console.WriteLine("Write in db done!");

            }
            catch (Exception ex)
            {

                Console.WriteLine($"Failed to write point:{ex.Message}");
            }
           
                

        }
    }

    public class AirPiValue
    {
        public string Id { get; set; }

        public DateTime DateTime { get; set; }

        public double Volume { get; set; }

        public double Light_Level { get; set; }

        public double Temperature_DHT { get; set; }

        public double Pressure { get; set; }

        public double Temperature_BMP { get; set; }

        public double Relative_Humidity { get; set; }

        public double Air_Quality { get; set; }

        public double Carbon_Monoxide { get; set; }

        public double Nitrogen_Dioxide { get; set; }
    }
}
