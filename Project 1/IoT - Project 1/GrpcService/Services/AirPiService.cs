using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using GrpcService.Protos;
using GrpcService.Repository;
using Microsoft.EntityFrameworkCore;

namespace GrpcService.Services
{
    public class AirPiService : AirPi.AirPiBase
    {
        private readonly AirPiDbContext _context;

        public AirPiService(AirPiDbContext context)
        {
            _context = context;
        }

        public override async Task<ValueMessage> GetAirPiValueById(AirPiValueId airPiValueId, ServerCallContext context)
        {
            var airPiValue = await _context.AirPiValues.FindAsync(airPiValueId.Id);

            if (airPiValue == null) 
            {
                return await Task.FromResult(new ValueMessage
                {
                    Message = $"There is no AirPi value with this id",
                    Id = airPiValueId.Id
                });
            }

            return await Task.FromResult(new ValueMessage
            {
                Airpivalue = new Protos.AirPiValue()
                    {
                    Id = airPiValue.Id,
                    Datetime = airPiValue.DateTime.ToString(),
                    Volume = airPiValue.Volume,
                    LightLevel = airPiValue.LightLevel,
                    TemperatureDht = airPiValue.TemperatureDHT,
                    Pressure = airPiValue.Pressure,
                    TemperatureBmp = airPiValue.TemperatureBMP,
                    RelativeHumidity = airPiValue.RelativeHumidity,
                    AirQuality = airPiValue.AirQuality,
                    CarbonMonoxide = airPiValue.CarbonMonoxide,
                    NitrogenDioxide = airPiValue.NitrogenDioxide
                }
               
            });
        }

        public override async Task<ValueMessage> AddValue(Protos.AirPiValue airPiValue, ServerCallContext context)
        {
            Repository.AirPiValue existValue = await _context.AirPiValues.Where(item => item.Id == airPiValue.Id).FirstOrDefaultAsync();

            if (existValue != null)
            {
                return await Task.FromResult(new ValueMessage
                {
                    Message = $"There is alerady AirPi value with this id! Id must be unic!",
                    Id = airPiValue.Id
                });
            }

            var newValue = new Repository.AirPiValue()
            {
                Id = airPiValue.Id,
                DateTime = DateTime.UtcNow,
                Volume = airPiValue.Volume,
                LightLevel = airPiValue.LightLevel,
                TemperatureDHT = airPiValue.TemperatureDht,
                Pressure = airPiValue.Pressure,
                TemperatureBMP = airPiValue.TemperatureBmp,
                RelativeHumidity = airPiValue.RelativeHumidity,
                AirQuality = airPiValue.AirQuality,
                CarbonMonoxide = airPiValue.CarbonMonoxide,
                NitrogenDioxide = airPiValue.NitrogenDioxide
            };
            _context.AirPiValues.Add(newValue);
            await _context.SaveChangesAsync();

            return await Task.FromResult(new ValueMessage
            {
                Message = "New value succesfully added!",
                Airpivalue = new Protos.AirPiValue
                {
                    Id = newValue.Id,
                    Datetime = newValue.DateTime.ToString(),
                    Volume = newValue.Volume,
                    LightLevel = newValue.LightLevel,
                    TemperatureDht = newValue.TemperatureDHT,
                    Pressure = newValue.Pressure,
                    TemperatureBmp = newValue.TemperatureBMP,
                    RelativeHumidity = newValue.RelativeHumidity,
                    AirQuality = newValue.AirQuality,
                    CarbonMonoxide = newValue.CarbonMonoxide,
                    NitrogenDioxide = newValue.NitrogenDioxide
                }

            });
        }

        public override async Task<ValueMessage> DeleteValue(AirPiValueId airPiValueId, ServerCallContext context)
        {
            Repository.AirPiValue existValue = await _context.AirPiValues.FindAsync(airPiValueId.Id);

            if (existValue == null) 
            {
                return await Task.FromResult(new ValueMessage
                {
                    Message = $"There is no AirPi value with this id",
                    Id = airPiValueId.Id
                });
            }

            _context.AirPiValues.Remove(existValue);
            _context.SaveChanges();
            return await Task.FromResult(new ValueMessage
            {
                Message = $"AirPi value is succesfully deleted : {DateTime.UtcNow}",
                Id = airPiValueId.Id 
            });
        }

        public override async Task<ValueMessage> UpdateValue(Protos.AirPiValue airPiValue, ServerCallContext context)
        {
            var existValue = await _context.AirPiValues.FindAsync(airPiValue.Id);

            if (existValue == null)
            {
                return await Task.FromResult(new ValueMessage
                {
                    Message = $"There is no AirPi value with this id",
                    Id = airPiValue.Id
                });
            }
            existValue.Id = airPiValue.Id;
            existValue.TemperatureBMP = airPiValue.TemperatureBmp;
            existValue.TemperatureDHT = airPiValue.TemperatureDht;
            existValue.Pressure = airPiValue.Pressure;
            existValue.AirQuality = airPiValue.AirQuality;
            existValue.Volume = airPiValue.Volume;
            existValue.RelativeHumidity = airPiValue.RelativeHumidity;
            existValue.DateTime = DateTime.UtcNow;
            existValue.CarbonMonoxide = airPiValue.CarbonMonoxide;
            existValue.NitrogenDioxide = airPiValue.NitrogenDioxide;

            _context.AirPiValues.Update(existValue);
            await _context.SaveChangesAsync();

            return await Task.FromResult(new ValueMessage
            {
                Message = "Value succesfully updated!",
                Airpivalue = new Protos.AirPiValue
                {
                    Id = existValue.Id,
                    Datetime = existValue.DateTime.ToString(),
                    Volume = existValue.Volume,
                    LightLevel = existValue.LightLevel,
                    TemperatureDht = existValue.TemperatureDHT,
                    Pressure = existValue.Pressure,
                    TemperatureBmp = existValue.TemperatureBMP,
                    RelativeHumidity = existValue.RelativeHumidity,
                    AirQuality = existValue.AirQuality,
                    CarbonMonoxide = existValue.CarbonMonoxide,
                    NitrogenDioxide = existValue.NitrogenDioxide
                }

            });
        }
    }
}
