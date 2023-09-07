
using System;
using System.Text;
using System.Threading.Tasks;
using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Adapter;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;
using AnalyticsService;

var serviceProvider = new ServiceCollection()
            .AddSingleton<IEmqxClient, EmqxClient>()
            .AddSingleton<IDbClient, InfluxDbClient>()// Register the EmqxClient as a singleton
            .BuildServiceProvider();

var emqxClient = serviceProvider.GetRequiredService<IEmqxClient>();
var dbClient = serviceProvider.GetRequiredService<IDbClient>();
string airPiTopic = "airpi_topic";
string eKuiperTopic = "eKuiper/AirQuality";


await emqxClient.ConnectAsync("172.26.176.1", "your_client_id");
await emqxClient.SubscribeAsync(new List<string> { airPiTopic, eKuiperTopic });

emqxClient.ConfigureMessageHandler(MessageReceivedFunctionAsync);

Task MessageReceivedFunctionAsync(MqttApplicationMessageReceivedEventArgs args)
{
    string payload = Encoding.UTF8.GetString(args.ApplicationMessage.Payload);
    if (args.ApplicationMessage.Topic == airPiTopic)
    {
        emqxClient.PublishMessageAsync("analytics/airpivalues", payload);
        return Task.CompletedTask;
    }
    Console.WriteLine(payload);
    
    dbClient.WriteToDatabase(payload);
    //Console.WriteLine("Uspesno upiano pijani Rade"); //legenda
    return Task.CompletedTask;
}

while (true) ;


