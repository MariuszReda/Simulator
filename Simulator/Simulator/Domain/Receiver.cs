namespace Simulator.Domain
{
    public class Receiver
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<int> SensorIDs { get; set; }
        public bool IsActive { get; set; }
    }
}
