using Simulator.Domain;
using Simulator.Dto;
using Simulator.Mapper;

namespace Simulator.Implementations
{
    public class Mapper : IMapper
    {
        public List<Receiver> MapRecivers(ReceiversConfig receivers)
        {
            List<Receiver> result = new List<Receiver>();
            foreach (var receiver in receivers.Receivers)
            {
                new Receiver()
                {
                    Name = receiver.Name,
                    SensorIDs = receiver.SensorIDs,
                    IsActive = receiver.IsActive
                };
                result.Add(receiver);
            }
            return result;
        }

        public List<Sensor> MapSensors(SensorConfig sensors)
        {
            List<Sensor> result = new List<Sensor>();
            foreach (var sensor in sensors.Sensors)
            {
                new Sensor()
                {
                    ID = sensor.ID,
                    Type = sensor.Type,
                    MinValue = sensor.MinValue,
                    MaxValue = sensor.MaxValue,
                    EncoderType = sensor.EncoderType,
                    Frequency = sensor.Frequency
                };
                result.Add(sensor);
            }
            return result;
        }
    }
}
