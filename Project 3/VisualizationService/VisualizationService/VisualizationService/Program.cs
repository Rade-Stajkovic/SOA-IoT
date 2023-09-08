
using System;
using System.Text;
using System.Threading.Tasks;
using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Adapter;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;
using VisualizationService;
using InfluxDB.Client;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

var serviceProvider = new ServiceCollection()
            .AddSingleton<IClient, Client>()
            .AddSingleton<IDbClient, InfluxDbClient>()// Register the EmqxClient as a singleton
            .BuildServiceProvider();

var emqxClient = serviceProvider.GetRequiredService<IClient>();
var dbClient = serviceProvider.GetRequiredService<IDbClient>();
string edgexTopic = "YOUR-UNIQUE-TOPIC";

var port = 1883;
var address = "broker.hivemq.com";

await emqxClient.ConnectAsync(address, "your_client_id");
await emqxClient.SubscribeAsync(new List<string> { edgexTopic });

emqxClient.ConfigureMessageHandler(MessageReceivedFunctionAsync);
Task MessageReceivedFunctionAsync(MqttApplicationMessageReceivedEventArgs args)
{
    string payload = Encoding.UTF8.GetString(args.ApplicationMessage.Payload);
    if (args.ApplicationMessage.Topic == edgexTopic)
    {
        
        var data = (JObject)JsonConvert.DeserializeObject(payload);
        var device = data.SelectToken("device").Value<String>();

        if (device != "SensorValueCluster2")
            return null;
        var reading = JArray.Parse(data.SelectToken("readings").ToString())[0];
        var nitrogendioxide = reading.SelectToken("value").Value<Int64>();
        dbClient.WriteToDatabase(nitrogendioxide);

        Console.WriteLine(payload);
       
        return Task.CompletedTask;
        
    }
   

    //dbClient.WriteToDatabase(payload);
    Console.WriteLine("Uspesno upiano pijani Rade"); //legenda
    return Task.CompletedTask;
}

while (true) ;


