using Autofac;
using Simulator;
using Simulator.Contracts;


var servideProvider = ServiceProvider.Configure();
var service = servideProvider.Resolve<IJsonData>();

var sensors = service.GetSensors();
var receivers = service.GetReceivers();


foreach (var sensor in sensors)
{
    Random random = new Random();
    var vaule = 10;//random.NextDouble() * 10000 - 5000;
    var message = sensor.ClassifierMessage(vaule);
    foreach(var receiver in receivers)
    {
        receiver.ReceiveMessage(message);
    }   
}

Console.ReadLine();
