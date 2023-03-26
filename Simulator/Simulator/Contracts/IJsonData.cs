using Simulator.Domain;

namespace Simulator.Contracts
{
    public interface IJsonData
    {
        List<Sensor> GetSensors();
        List<Receiver> GetReceivers();
    }
}