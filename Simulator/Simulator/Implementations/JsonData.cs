using Newtonsoft.Json;
using Simulator.Contracts;
using Simulator.Domain;
using Simulator.Dto;
using Simulator.Mapper;

namespace Simulator.Implementations
{
    public class JsonData : IJsonData
    {
        private readonly IMapper _mapper;
        public JsonData(IMapper mapper)
        {
            _mapper = mapper;
        }
        public List<Sensor> GetSensors()
        {
            var appFolderPath = Directory.GetCurrentDirectory();
            var parentFolderPath = Directory.GetParent(Directory.GetParent(appFolderPath).FullName).Parent.FullName;

            var json = File.ReadAllText(Path.Combine(parentFolderPath, "sensorConfig.json"));
            var sensorConfig = JsonConvert.DeserializeObject<SensorConfig>(json);

            var sensors = _mapper.MapSensors(sensorConfig);

            return sensors;
        }

        public List<Receiver> GetReceivers()
        {
            var appFolderPath = Directory.GetCurrentDirectory();
            var parentFolderPath = Directory.GetParent(Directory.GetParent(appFolderPath).FullName).Parent.FullName;

            var json = File.ReadAllText(Path.Combine(parentFolderPath, "receiverConfig.json"));
            var receiveConfig = JsonConvert.DeserializeObject<ReceiversConfig>(json);

            var receivers = _mapper.MapRecivers(receiveConfig);

            return receivers;
        }


    }
}
