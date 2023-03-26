using Simulator.Domain;

namespace Simulator
{
    public static class MessageClassifier
    {
        private static double alarmThresholdMin;
        private static double alarmThresholdMax;
        private static double warningThresholdMin;
        private static double warningThresholdMax;
        private static string Classify(double value)
        {
            if (value <= alarmThresholdMin || value >= alarmThresholdMax)
            {
                return "Alarm";
            }
            else if (value <= warningThresholdMin || value >= warningThresholdMax)
            {
                return "Warning";
            }
            else
            {
                return "Normal";
            }
        }
        public static string ClassifierMessage(this Sensor sensor, double value)
        {
            double sensorRange = Math.Abs(sensor.MinValue - sensor.MaxValue);

            alarmThresholdMin = sensor.MinValue + sensorRange * 0.1;
            alarmThresholdMax = sensor.MaxValue - sensorRange * 0.1;
            warningThresholdMin = sensor.MinValue + sensorRange * 0.15;
            warningThresholdMax = sensor.MaxValue - sensorRange * 0.15;

            return $"$FIX, {sensor.ID}, {sensor.Type}, {value.ToString("F3")}, {Classify(value)}*";
        }
    }
}
