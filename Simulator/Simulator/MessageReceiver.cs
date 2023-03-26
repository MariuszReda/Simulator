using Simulator.Domain;

namespace Simulator
{
    public static class MessageReceiver
    {
        public static void ReceiveMessage(this Receiver receiver, string message)
        {
            var parts = message.Split(',').Select(p => p.Trim()).ToArray();

            var id = int.Parse(parts[1]);
            var type = parts[2];
            var value = double.Parse(parts[3]) + "," + double.Parse(parts[4]);
            var quality = parts[5].TrimEnd('*');

            if (receiver.SensorIDs.Contains(id) && receiver.IsActive)
            {
                Console.WriteLine($"Receiver '{receiver.Name}' received message from sensor id: {id} vaule: {value} ({quality})");
                if (quality == "Warning")
                {
                    Console.WriteLine("WARNING: Value is outside normal range.");
                }
                else if (quality == "Alarm")
                {
                    Console.WriteLine("ALARM: Value is outside acceptable range.");
                }
            }
        }
    }
}
