using Simulator.Domain;
using Simulator.Dto;

namespace Simulator.Mapper
{
    public interface IMapper
    {
        List<Sensor> MapSensors(SensorConfig sensors);
        List<Receiver> MapRecivers(ReceiversConfig receivers);
    }
}
